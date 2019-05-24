using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        UInt32 FastAcumulate;
        UInt32 MediumAcumulate;
        UInt32 SlowAcumulate;

        UInt32 FastDeadTime;
        UInt32 MediumDeadTime;
        UInt32 SlowDeadTime;

        UInt32 FastResolution;
        UInt32 MediumResolution;
        UInt32 SlowResolution;

        string frame;

        int valueCounter = 0;
        double[] valuesCH0 = new double[65536];
        double[] valuesCH1 = new double[65536];
        double[] valuesCH2 = new double[65536];
        double[] valuesCH3 = new double[65536];

        Series seriesCH0 = new Series("DaneCH0");
        Series seriesCH1 = new Series("DaneCH1");
        Series seriesCH2 = new Series("DaneCH2");
        Series seriesCH3 = new Series("DaneCH3");

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

            loadSettings();


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

        private void sendTask(UInt32 deadTime, UInt32 resolution, UInt32 accumulate)
        {
            clearSeries();

            valueCounter = 0;
            frame = "";

            try
            {
                serialPort1.Write("A" + deadTime.ToString("0000") + resolution.ToString("0000") + accumulate.ToString("0000") + "B");
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

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(this);
            settingsForm.Show();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            this.Invoke(new Action(delegate ()
            {
                valueCounter = 0;
                frame += serialPort1.ReadExisting();
                string[] datas = frame.Split('X');
                foreach(string data in datas)
                {
                    if (data.Length == 24 && data[0] =='Y')
                    {
                        string ch0val = data.Substring(1, 5);
                        string ch1val = data.Substring(7, 5);
                        string ch2val = data.Substring(13, 5);
                        string ch3val = data.Substring(19, 5);
                        // 15 / 4095
                        valuesCH0[valueCounter] = Double.Parse(ch0val) * 0.0036630036630037;
                        valuesCH1[valueCounter] = Double.Parse(ch1val) * 0.0036630036630037;
                        valuesCH2[valueCounter] = Double.Parse(ch2val) * 0.0036630036630037;
                        valuesCH3[valueCounter] = Double.Parse(ch3val) * 0.0036630036630037;

                        valueCounter++;
                    }
                }
                redrawCharts();
                
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
            Properties.Settings.Default.ComPort = textBoxDelay.Text;
            Properties.Settings.Default.Save();
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
