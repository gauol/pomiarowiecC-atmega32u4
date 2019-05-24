using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            this.mainForm = mainForm;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.FastAcumulate   = (UInt16)numericUpDownFastAcumulate.Value;
            Properties.Settings.Default.MediumAcumulate = (UInt16)numericUpDownMediumAcumulate.Value;
            Properties.Settings.Default.SlowAcumulate   = (UInt16)numericUpDownSlowAcumulate.Value;

            Properties.Settings.Default.FastDeadTime = (UInt16)numericUpDownFastDeadTime.Value;
            Properties.Settings.Default.MediumDeadTime = (UInt16)numericUpDownMediumDeadTime.Value;
            Properties.Settings.Default.SlowDeadTime = (UInt16)numericUpDownSlowDeadTime.Value;

            Properties.Settings.Default.FastResolution = Convert.ToUInt16(comboBoxFastResolution.SelectedItem.ToString());
            Properties.Settings.Default.MediumResolution = Convert.ToUInt16(comboBoxMediumResolution.SelectedItem.ToString());
            Properties.Settings.Default.SlowResolution = Convert.ToUInt16(comboBoxSlowResolution.SelectedItem);

            Properties.Settings.Default.Save();
            MessageBox.Show("Pomyślnie zapisano!");
            mainForm.loadSettings();
            this.Close();

        }
    }
}
