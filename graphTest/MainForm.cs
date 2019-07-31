using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace graphTest
{
    public partial class MainForm : Form
    {
        Double waveLenght;
        Double waveLenghtToFile;
        String wls = ""; // zmienna przechowujaca dane odbierane z miernika długości fali

        // Parametry skanów
        UInt32 FastAcumulate;  
        UInt32 MediumAcumulate;
        UInt32 SlowAcumulate;

        UInt32 FastDeadTime;
        UInt32 MediumDeadTime;
        UInt32 SlowDeadTime;

        UInt32 FastResolution;
        UInt32 MediumResolution;
        UInt32 SlowResolution;
        // Parametry skanów

        string frame; // zmienna przechowująca dane odbierane z urządzenia pomiarowego

        int valueCounter = 0; // licznik który pomiar został odebrany

        // odebrane wartości pomiarów
        Int32[] valuesCH0 = new Int32[65536];
        Int32[] valuesCH1 = new Int32[65536];
        Int32[] valuesCH2 = new Int32[65536];
        Int32[] valuesCH3 = new Int32[65536];
        // odebrane wartości pomiarów

        // zmienne wykresu z danymi
        Series seriesCH0 = new Series("DaneCH0");
        Series seriesCH1 = new Series("DaneCH1");
        Series seriesCH2 = new Series("Marker CH2");
        Series seriesCH3 = new Series("Moc CH3");
        // zmienne wykresu z danymi

        public MainForm()
        {
            InitializeComponent();

            seriesCH0.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            seriesCH1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            seriesCH2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            seriesCH3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            ArrayList dataTabl = new ArrayList();
            chart1.Series.Add(seriesCH0);
            chart1.Series.Add(seriesCH1);
            chart2.Series.Add(seriesCH2);
            chart2.Series.Add(seriesCH3);

            chart1.ChartAreas[0].AxisY.Maximum = 4096;
            chart1.ChartAreas[0].AxisY.Minimum = 0;

            chart2.ChartAreas[0].AxisY.Maximum = 4096;
            chart2.ChartAreas[0].AxisY.Minimum = 0;

            loadSettings();
            openWMport();

            var ports = SerialPort.GetPortNames();
            comboBoxSerialPort.DataSource = ports;

            comboBoxSerialPort.SelectedIndex = comboBoxSerialPort.FindString(Properties.Settings.Default.ComPort);
        }

        private void buttonStartFast_Click(object sender, EventArgs e)
        {
            sendTask(FastDeadTime, FastResolution, FastAcumulate);
        }

        private void buttonStartMedium_Click(object sender, EventArgs e)
        {
            sendTask(MediumDeadTime, MediumResolution, MediumAcumulate);
        }

        private void buttonStartSlow_Click(object sender, EventArgs e)
        {
            sendTask(SlowDeadTime, SlowResolution, SlowAcumulate);
        }

        private void clearSeries()
        {
            seriesCH0.Points.Clear();
            seriesCH1.Points.Clear();
            seriesCH2.Points.Clear();
            seriesCH3.Points.Clear();
        }

        private void clearData()
        {
            Array.Clear(valuesCH0, 0, valuesCH0.Length);
            Array.Clear(valuesCH1, 0, valuesCH1.Length);
            Array.Clear(valuesCH2, 0, valuesCH2.Length);
            Array.Clear(valuesCH3, 0, valuesCH3.Length);
        }

        private void setXrange(UInt32 resolution)
        {
            chart1.ChartAreas[0].AxisX.Maximum =  resolution;
            chart1.ChartAreas[0].AxisX.Minimum = 0;

            chart2.ChartAreas[0].AxisX.Maximum = resolution;
            chart2.ChartAreas[0].AxisX.Minimum = 0;
        }

        private void sendTask(UInt32 deadTime, UInt32 resolution, UInt32 accumulate)
        {
            setXrange(65536 / resolution);

            clearSeries();

            valueCounter = 0;
            frame = "";

            try
            {//A000100640001B   - ramka testujaca
                waveLenghtToFile = waveLenght;
                serialPort1.Write("CA" + deadTime.ToString("0000") + resolution.ToString("0000") + accumulate.ToString("0000") + "B");
                //serialPort1.Write("B");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void buttonOpenPort_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ComPort != comboBoxSerialPort.SelectedValue.ToString())
            {
                Properties.Settings.Default.ComPort = comboBoxSerialPort.SelectedValue.ToString();
                Properties.Settings.Default.Save();
            }
            try
            {
                serialPort1.PortName = comboBoxSerialPort.SelectedItem.ToString();
                serialPort1.Open();
            }
            catch
            {
                MessageBox.Show("Wystąpił błąd połączenia (czy wybrano poprawny port?");
            }
        }

        private void openWMport()
        {
            if (Properties.Settings.Default.autoConnectWaveMeter)
            {
                try
                {
                    WMserialPort.PortName = Properties.Settings.Default.WaveMeterComPort;
                    WMserialPort.Open();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(this);
            settingsForm.Show();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            this.Invoke(new Action(delegate ()
            {
                //valueCounter = 0;
                frame += serialPort1.ReadExisting();
                if (frame.Length > 0 && frame[0] == 'X')
                    frame = frame.Substring(1, frame.Length - 1);
                string[] datas = frame.Split('X');

                seriesCH0.Points.SuspendUpdates();
                seriesCH1.Points.SuspendUpdates();
                seriesCH2.Points.SuspendUpdates();
                seriesCH3.Points.SuspendUpdates();

                foreach (string data in datas)
                {
                    if (data.Length == 24 && data[0] =='Y')
                    {
                        frame = frame.Substring(24, frame.Length - 24);
                        if(frame.Length > 0  && frame[0] == 'X')
                            frame = frame.Substring(1, frame.Length - 1);

                        //MessageBox.Show(frame);
                        string ch0val = data.Substring(1, 5);
                        string ch1val = data.Substring(7, 5);
                        string ch2val = data.Substring(13, 5);
                        string ch3val = data.Substring(19, 5);

                        // 15 / 4095
                        valuesCH0[valueCounter] = Int32.Parse(ch0val);// * 0.0036630036630037;
                        valuesCH1[valueCounter] = Int32.Parse(ch1val);// * 0.0036630036630037;
                        valuesCH2[valueCounter] = Int32.Parse(ch2val);// * 0.0036630036630037;
                        valuesCH3[valueCounter] = Int32.Parse(ch3val);// * 0.0036630036630037;

                        if (checkBoxCH1.Checked)
                            seriesCH0.Points.Add(valuesCH0[valueCounter]);
                        if (checkBoxCH2.Checked)
                            seriesCH1.Points.Add(valuesCH1[valueCounter]);
                        if (checkBoxMARKER.Checked)
                            seriesCH2.Points.Add(valuesCH2[valueCounter]);
                        if (checkBoxPOWER.Checked)
                            seriesCH3.Points.Add(valuesCH3[valueCounter]);

                        //chart1.Invalidate();
                        //chart2.Update();
                        //this.Refresh();
                        valueCounter++;
                    }
                    else
                    {
                        //frame.Substring(data.Length, frame.Length - data.Length);
                        break;
                    }
                }
                seriesCH0.Points.ResumeUpdates();
                seriesCH1.Points.ResumeUpdates();
                seriesCH2.Points.ResumeUpdates();
                seriesCH3.Points.ResumeUpdates();

                chart1.Update();
                chart2.Update();

                //redrawCharts();

            }));
        }

        public void loadSettings()
        {
            FastAcumulate   = Properties.Settings.Default.FastAcumulate;
            MediumAcumulate = Properties.Settings.Default.MediumAcumulate;
            SlowAcumulate   = Properties.Settings.Default.SlowAcumulate;

            FastDeadTime    = Properties.Settings.Default.FastDeadTime;
            MediumDeadTime  = Properties.Settings.Default.MediumDeadTime;
            SlowDeadTime    = Properties.Settings.Default.SlowDeadTime;

            FastResolution      = Properties.Settings.Default.FastResolution;
            MediumResolution    = Properties.Settings.Default.MediumResolution;
            SlowResolution      = Properties.Settings.Default.SlowResolution;
        }
        
        private void redrawCharts()
        {
            clearSeries();
            foreach (int val in Enumerable.Range(0, valueCounter))
            {
                if (checkBoxCH1.Checked)
                    seriesCH0.Points.Add(valuesCH0[val]);
                if (checkBoxCH2.Checked)
                    seriesCH1.Points.Add(valuesCH1[val]);
                if (checkBoxMARKER.Checked)
                    seriesCH2.Points.Add(valuesCH2[val]);
                if (checkBoxPOWER.Checked)
                    seriesCH3.Points.Add(valuesCH3[val]);
            }
        }

        private void checkBoxChart_CheckStateChanged(object sender, EventArgs e)
        {
            redrawCharts();
        }

        private void textBoxDelay_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ComPort = fileNameTextBox.Text;
            Properties.Settings.Default.Save();
        }

        private void saveToFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Pomiary" + fileNameTextBox.Text;
                if (!Directory.Exists(docPath))
                {
                    Directory.CreateDirectory(docPath);
                }
                string date = DateTime.Now.ToString("HH.mm.ss - d/M/yyyy");

                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, fileNameTextBox.Text + " " + date + waveLenght + ".txt")))
                {
                    outputFile.WriteLine("#" + waveLenght);
                    outputFile.WriteLine("#liczba falowa");
                    foreach (int val in Enumerable.Range(0, valueCounter))
                    {
                        outputFile.WriteLine
                            (valuesCH0[val].ToString("0.00", System.Globalization.CultureInfo.InvariantCulture)
                            + ";" + valuesCH1[val].ToString("0.0000", System.Globalization.CultureInfo.InvariantCulture)
                            + ";" + valuesCH2[val].ToString("0.0000", System.Globalization.CultureInfo.InvariantCulture)
                            + ";" + valuesCH3[val].ToString("0.0000", System.Globalization.CultureInfo.InvariantCulture)
                            );
                    }
                    outputFile.Close();
                }
                MessageBox.Show("Zapis pomyślny");
                MnumericUpDown.Value++;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void saveToMesFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Pomiary/" + fileNameTextBox.Text;
                if (!Directory.Exists(docPath))
                {
                    Directory.CreateDirectory(docPath);
                }
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, fileNameTextBox.Text +"-"+ MnumericUpDown.Value + ".MES")))
                {
                    outputFile.WriteLine("#" + waveLenghtToFile.ToString("0.0000", System.Globalization.CultureInfo.InvariantCulture));
                    outputFile.WriteLine("#");
                    foreach (int val in Enumerable.Range(0, valueCounter))
                    {
                        outputFile.WriteLine(valuesCH0[val].ToString("0.0000", System.Globalization.CultureInfo.InvariantCulture));
                    }
                    foreach (int val in Enumerable.Range(0, valueCounter))
                    {
                        outputFile.WriteLine(valuesCH2[val].ToString("0.0000", System.Globalization.CultureInfo.InvariantCulture));
                    }
                    outputFile.Close();
                }
                MessageBox.Show("Zapis pomyślny");
                MnumericUpDown.Value++;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            valueCounter = 0;
            try
            {
                var dlg = new OpenFileDialog();
                if (dlg.ShowDialog() != DialogResult.OK)
                    return;
                clearSeries();
                clearData();
                string[] lines = System.IO.File.ReadAllLines(dlg.FileName);

                foreach (string line in lines.Skip(2))
                {
                    string[] datas = line.Split(';');
                    valuesCH0[valueCounter] = (Int32)Double.Parse(datas[0], CultureInfo.InvariantCulture);
                    valuesCH1[valueCounter] = (Int32)Double.Parse(datas[1], CultureInfo.InvariantCulture);
                    valuesCH2[valueCounter] = (Int32)Double.Parse(datas[2], CultureInfo.InvariantCulture);
                    valuesCH3[valueCounter] = (Int32)Double.Parse(datas[3], CultureInfo.InvariantCulture);

                    valueCounter++;
                }
                redrawCharts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + " - Czy wybrano poprawny plik?");
            }
        }

        private void openMesFileButton_Click(object sender, EventArgs e)
        {
            valueCounter = 0;
            try
            { 
                var dlg = new OpenFileDialog();
                if (dlg.ShowDialog() != DialogResult.OK)
                    return;
                clearSeries();
                clearData();
                string[] lines = System.IO.File.ReadAllLines(dlg.FileName);

                int values = (lines.Length - 2) / 2;

                foreach (string line in lines.Skip(values + 2))
                {
                    valuesCH2[valueCounter] = (Int32) Double.Parse(line, CultureInfo.InvariantCulture);
                    valueCounter++;
                }
                valueCounter = 0;

                foreach (string line in lines.Skip(2).Take(values))
                {
                    valuesCH0[valueCounter] = (Int32) Double.Parse(line, CultureInfo.InvariantCulture);
                    valueCounter++;
                }

                setXrange((uint)values);

                redrawCharts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + " - Czy wybrano poprawny plik?");
            }
        }

        private void WMserialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                this.Invoke(new Action(delegate ()
                {
                wls += WMserialPort.ReadExisting();
                    string[] datas = wls.Split(new string[] { "\r\n" }, StringSplitOptions.None);
                    foreach (string line in datas)
                    {
                        if (line.Length >= 21)
                        {
                            var sbstr = line.Substring(1, 10);
                            waveLenght = Double.Parse(sbstr, CultureInfo.InvariantCulture);
                            WaveLenghtLabel.Text = waveLenght.ToString();
                            wls = "";
                        }
    
                    }
                }));
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message.ToString());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
            //MnumericUpDown.Value++;
        }

        private void startStopButton_Click(object sender, EventArgs e)
        {
            serialPort1.Write("S");
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            serialPort1.Write("C");
        }

        private void nextStepButton_Click(object sender, EventArgs e)
        {
            serialPort1.Write("N");
        }

        //public void callThread()
        //{
        //series.Points.Clear();
        //valueCounter = 0;
        //Thread thread1 = new Thread(DoWork);
        //thread1.Start();
        //}

        //public void DoWork()
        //{
        //    foreach (int index in Enumerable.Range(1, 1000))
        //    {
        //        Thread.Sleep(10);
        //        serial.Write("B");
        //    }
        //}
    }
}
