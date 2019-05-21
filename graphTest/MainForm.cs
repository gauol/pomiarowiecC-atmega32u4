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

        int valueCounter = 0;
        int[] values = new int[1024];
        Series series = new Series("Dane1");
        SerialPort serial;

        public MainForm()
        {
            InitializeComponent();
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            ArrayList dataTabl = new ArrayList();
            chart1.Series.Add(series);

            loadSettings();

            serial = serialPort1;
            var ports = SerialPort.GetPortNames();
            comboBoxSerialPort.DataSource = ports;
            comboBoxSerialPort.SelectedIndex = comboBoxSerialPort.FindString(Properties.Settings.Default.ComPort.ToString());
        }

        private void buttonStartFast_Click(object sender, EventArgs e)
        {
            series.Points.Clear();
            valueCounter = 0;
            Thread thread1 = new Thread(DoWork);
            thread1.Start();
        }

        public void DoWork()
        {
            //foreach (int index in Enumerable.Range(1, 1000))
            //{
            //    Thread.Sleep(10);
            //    serial.Write("B");
            //}
            serial.Write("OOMS");

        }

        private void sendTask(UInt32 deadTime, UInt32 resolution, UInt32 accumulate)
        {

        }

        private void buttonOpenPort_Click(object sender, EventArgs e)
        {
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
            //liczba probek na jeden odczyt-- akumulacja
            //czas pomiedzy punktami -- czas martwy/oczekiwania przestoju
            //
            // ustawienie rozdzielczosci skoku co 1 /2 / /4 /8 /16
            SettingsForm settingsForm = new SettingsForm(this);
            settingsForm.Show();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            textBoxDelay.Invoke(new Action(delegate ()
            {
                String data = serialPort1.ReadExisting();
                data = data.Substring(0, 5);
                textBoxDelay.Text = data;
                values[valueCounter] = Int32.Parse(data);
                valueCounter++;
                series.Points.Clear();
                foreach (int val in values)
                {
                    series.Points.Add(val);
                }
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

        private void comboBoxSerialPort_SelectedValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ComPort = comboBoxSerialPort.SelectedValue.ToString();
        }
    }
}
