using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphTest
{
    public partial class SettingsForm : Form
    {
        MainForm mainForm;

        public SettingsForm(MainForm mainForm)
        {
            InitializeComponent();
            numericUpDownFastAcumulate.Value = Properties.Settings.Default.FastAcumulate;
            numericUpDownMediumAcumulate.Value = Properties.Settings.Default.MediumAcumulate;
            numericUpDownSlowAcumulate.Value = Properties.Settings.Default.SlowAcumulate;

            numericUpDownFastDeadTime.Value = Properties.Settings.Default.FastDeadTime;
            numericUpDownMediumDeadTime.Value = Properties.Settings.Default.MediumDeadTime;
            numericUpDownSlowDeadTime.Value = Properties.Settings.Default.SlowDeadTime;

            comboBoxFastResolution.SelectedIndex = comboBoxFastResolution.FindString(Properties.Settings.Default.FastResolution.ToString());
            comboBoxMediumResolution.SelectedIndex = comboBoxMediumResolution.FindString(Properties.Settings.Default.MediumResolution.ToString());
            comboBoxSlowResolution.SelectedIndex = comboBoxSlowResolution.FindString(Properties.Settings.Default.SlowResolution.ToString());

            waveMeterCOMportTextBox.Text = Properties.Settings.Default.WaveMeterComPort;
            autoConnectWaveMetercheckBox.Checked = Properties.Settings.Default.autoConnectWaveMeter;

            this.mainForm = mainForm;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.FastResolution = Convert.ToUInt16(comboBoxFastResolution.SelectedItem.ToString());
            Properties.Settings.Default.MediumResolution = Convert.ToUInt16(comboBoxMediumResolution.SelectedItem.ToString());
            Properties.Settings.Default.SlowResolution = Convert.ToUInt16(comboBoxSlowResolution.SelectedItem);

            Properties.Settings.Default.FastAcumulate   = (UInt16)numericUpDownFastAcumulate.Value;
            Properties.Settings.Default.MediumAcumulate = (UInt16)numericUpDownMediumAcumulate.Value;
            Properties.Settings.Default.SlowAcumulate   = (UInt16)numericUpDownSlowAcumulate.Value;

            Properties.Settings.Default.FastDeadTime = (UInt16)numericUpDownFastDeadTime.Value;
            Properties.Settings.Default.MediumDeadTime = (UInt16)numericUpDownMediumDeadTime.Value;
            Properties.Settings.Default.SlowDeadTime = (UInt16)numericUpDownSlowDeadTime.Value;

            Properties.Settings.Default.WaveMeterComPort = waveMeterCOMportTextBox.Text;
            Properties.Settings.Default.autoConnectWaveMeter = autoConnectWaveMetercheckBox.Checked;

            Properties.Settings.Default.Save();
            MessageBox.Show("Pomyślnie zapisano!");
            mainForm.loadSettings();
            this.Close();
        }

        private void updateTimes(object sender, EventArgs e)
        {
            decimal fastTime = ((65536 / Convert.ToInt16(comboBoxFastResolution.SelectedItem.ToString())) *(numericUpDownFastAcumulate.Value + 1 + numericUpDownFastDeadTime.Value));
            fastTimeLabel.Text = fastTime.ToString("# ### ### ### ###") + " (" + (fastTime /1000 / 60).ToString("0.##") + "min)";

            decimal mediumTime = (65536 / Convert.ToInt16(comboBoxMediumResolution.SelectedItem.ToString())) * (numericUpDownMediumAcumulate.Value + numericUpDownMediumDeadTime.Value);

            mediumTimeLabel.Text = (mediumTime).ToString("# ### ### ### ###") + " (" + (mediumTime / 1000 / 60).ToString("0.##") + "min)";
            decimal slowTime = ((65536 / Convert.ToInt16(comboBoxSlowResolution.SelectedItem.ToString())) * (numericUpDownSlowAcumulate.Value + numericUpDownSlowDeadTime.Value));
            slowTimeLabel.Text = slowTime.ToString("# ### ### ### ###") + " (" + (slowTime / 1000 / 60).ToString("0.##") + "min)";

        }
    }
}
