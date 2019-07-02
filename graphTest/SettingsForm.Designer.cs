namespace graphTest
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.buttonSave = new System.Windows.Forms.Button();
            this.numericUpDownFastAcumulate = new System.Windows.Forms.NumericUpDown();
            this.labelFastAcumulate = new System.Windows.Forms.Label();
            this.groupBoxFast = new System.Windows.Forms.GroupBox();
            this.fastTimeLabel = new System.Windows.Forms.Label();
            this.comboBoxFastResolution = new System.Windows.Forms.ComboBox();
            this.numericUpDownFastDeadTime = new System.Windows.Forms.NumericUpDown();
            this.labelDeadTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mediumTimeLabel = new System.Windows.Forms.Label();
            this.comboBoxMediumResolution = new System.Windows.Forms.ComboBox();
            this.numericUpDownMediumDeadTime = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMediumAcumulate = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.slowTimeLabel = new System.Windows.Forms.Label();
            this.comboBoxSlowResolution = new System.Windows.Forms.ComboBox();
            this.numericUpDownSlowDeadTime = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSlowAcumulate = new System.Windows.Forms.NumericUpDown();
            this.waveMeterTextBoxLabel = new System.Windows.Forms.Label();
            this.waveMeterCOMportTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.autoConnectWaveMetercheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFastAcumulate)).BeginInit();
            this.groupBoxFast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFastDeadTime)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMediumDeadTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMediumAcumulate)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSlowDeadTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSlowAcumulate)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(569, 474);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 28);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // numericUpDownFastAcumulate
            // 
            this.numericUpDownFastAcumulate.Location = new System.Drawing.Point(8, 23);
            this.numericUpDownFastAcumulate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownFastAcumulate.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownFastAcumulate.Name = "numericUpDownFastAcumulate";
            this.numericUpDownFastAcumulate.Size = new System.Drawing.Size(160, 22);
            this.numericUpDownFastAcumulate.TabIndex = 1;
            // 
            // labelFastAcumulate
            // 
            this.labelFastAcumulate.AutoSize = true;
            this.labelFastAcumulate.Location = new System.Drawing.Point(101, 11);
            this.labelFastAcumulate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFastAcumulate.Name = "labelFastAcumulate";
            this.labelFastAcumulate.Size = new System.Drawing.Size(80, 17);
            this.labelFastAcumulate.TabIndex = 2;
            this.labelFastAcumulate.Text = "Akumulacja";
            // 
            // groupBoxFast
            // 
            this.groupBoxFast.Controls.Add(this.fastTimeLabel);
            this.groupBoxFast.Controls.Add(this.comboBoxFastResolution);
            this.groupBoxFast.Controls.Add(this.numericUpDownFastDeadTime);
            this.groupBoxFast.Controls.Add(this.numericUpDownFastAcumulate);
            this.groupBoxFast.Location = new System.Drawing.Point(16, 84);
            this.groupBoxFast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxFast.Name = "groupBoxFast";
            this.groupBoxFast.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxFast.Size = new System.Drawing.Size(831, 68);
            this.groupBoxFast.TabIndex = 3;
            this.groupBoxFast.TabStop = false;
            this.groupBoxFast.Text = "Szybki";
            // 
            // fastTimeLabel
            // 
            this.fastTimeLabel.AutoSize = true;
            this.fastTimeLabel.Location = new System.Drawing.Point(600, 33);
            this.fastTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fastTimeLabel.Name = "fastTimeLabel";
            this.fastTimeLabel.Size = new System.Drawing.Size(30, 17);
            this.fastTimeLabel.TabIndex = 7;
            this.fastTimeLabel.Text = "Klik";
            this.fastTimeLabel.Click += new System.EventHandler(this.updateTimes);
            // 
            // comboBoxFastResolution
            // 
            this.comboBoxFastResolution.FormattingEnabled = true;
            this.comboBoxFastResolution.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "8",
            "16",
            "32",
            "64",
            "128"});
            this.comboBoxFastResolution.Location = new System.Drawing.Point(344, 23);
            this.comboBoxFastResolution.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxFastResolution.Name = "comboBoxFastResolution";
            this.comboBoxFastResolution.Size = new System.Drawing.Size(160, 24);
            this.comboBoxFastResolution.TabIndex = 6;
            // 
            // numericUpDownFastDeadTime
            // 
            this.numericUpDownFastDeadTime.Location = new System.Drawing.Point(176, 23);
            this.numericUpDownFastDeadTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownFastDeadTime.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownFastDeadTime.Name = "numericUpDownFastDeadTime";
            this.numericUpDownFastDeadTime.Size = new System.Drawing.Size(160, 22);
            this.numericUpDownFastDeadTime.TabIndex = 3;
            // 
            // labelDeadTime
            // 
            this.labelDeadTime.AutoSize = true;
            this.labelDeadTime.Location = new System.Drawing.Point(252, 11);
            this.labelDeadTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDeadTime.Name = "labelDeadTime";
            this.labelDeadTime.Size = new System.Drawing.Size(101, 17);
            this.labelDeadTime.TabIndex = 4;
            this.labelDeadTime.Text = "Czas przestoju";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Roździelczość skoku";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mediumTimeLabel);
            this.groupBox1.Controls.Add(this.comboBoxMediumResolution);
            this.groupBox1.Controls.Add(this.numericUpDownMediumDeadTime);
            this.groupBox1.Controls.Add(this.numericUpDownMediumAcumulate);
            this.groupBox1.Location = new System.Drawing.Point(16, 159);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(831, 68);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sredni";
            // 
            // mediumTimeLabel
            // 
            this.mediumTimeLabel.AutoSize = true;
            this.mediumTimeLabel.Location = new System.Drawing.Point(600, 33);
            this.mediumTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mediumTimeLabel.Name = "mediumTimeLabel";
            this.mediumTimeLabel.Size = new System.Drawing.Size(30, 17);
            this.mediumTimeLabel.TabIndex = 8;
            this.mediumTimeLabel.Text = "Klik";
            this.mediumTimeLabel.Click += new System.EventHandler(this.updateTimes);
            // 
            // comboBoxMediumResolution
            // 
            this.comboBoxMediumResolution.FormattingEnabled = true;
            this.comboBoxMediumResolution.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "8",
            "16",
            "32"});
            this.comboBoxMediumResolution.Location = new System.Drawing.Point(344, 23);
            this.comboBoxMediumResolution.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxMediumResolution.Name = "comboBoxMediumResolution";
            this.comboBoxMediumResolution.Size = new System.Drawing.Size(160, 24);
            this.comboBoxMediumResolution.TabIndex = 6;
            // 
            // numericUpDownMediumDeadTime
            // 
            this.numericUpDownMediumDeadTime.Location = new System.Drawing.Point(176, 23);
            this.numericUpDownMediumDeadTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownMediumDeadTime.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMediumDeadTime.Name = "numericUpDownMediumDeadTime";
            this.numericUpDownMediumDeadTime.Size = new System.Drawing.Size(160, 22);
            this.numericUpDownMediumDeadTime.TabIndex = 3;
            // 
            // numericUpDownMediumAcumulate
            // 
            this.numericUpDownMediumAcumulate.Location = new System.Drawing.Point(8, 23);
            this.numericUpDownMediumAcumulate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownMediumAcumulate.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMediumAcumulate.Name = "numericUpDownMediumAcumulate";
            this.numericUpDownMediumAcumulate.Size = new System.Drawing.Size(160, 22);
            this.numericUpDownMediumAcumulate.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.slowTimeLabel);
            this.groupBox2.Controls.Add(this.comboBoxSlowResolution);
            this.groupBox2.Controls.Add(this.numericUpDownSlowDeadTime);
            this.groupBox2.Controls.Add(this.numericUpDownSlowAcumulate);
            this.groupBox2.Location = new System.Drawing.Point(16, 234);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(831, 68);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wolny";
            // 
            // slowTimeLabel
            // 
            this.slowTimeLabel.AutoSize = true;
            this.slowTimeLabel.Location = new System.Drawing.Point(600, 33);
            this.slowTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.slowTimeLabel.Name = "slowTimeLabel";
            this.slowTimeLabel.Size = new System.Drawing.Size(30, 17);
            this.slowTimeLabel.TabIndex = 8;
            this.slowTimeLabel.Text = "Klik";
            this.slowTimeLabel.Click += new System.EventHandler(this.updateTimes);
            // 
            // comboBoxSlowResolution
            // 
            this.comboBoxSlowResolution.FormattingEnabled = true;
            this.comboBoxSlowResolution.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "8",
            "16",
            "32"});
            this.comboBoxSlowResolution.Location = new System.Drawing.Point(344, 23);
            this.comboBoxSlowResolution.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxSlowResolution.Name = "comboBoxSlowResolution";
            this.comboBoxSlowResolution.Size = new System.Drawing.Size(160, 24);
            this.comboBoxSlowResolution.TabIndex = 6;
            // 
            // numericUpDownSlowDeadTime
            // 
            this.numericUpDownSlowDeadTime.Location = new System.Drawing.Point(176, 23);
            this.numericUpDownSlowDeadTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownSlowDeadTime.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownSlowDeadTime.Name = "numericUpDownSlowDeadTime";
            this.numericUpDownSlowDeadTime.Size = new System.Drawing.Size(160, 22);
            this.numericUpDownSlowDeadTime.TabIndex = 3;
            // 
            // numericUpDownSlowAcumulate
            // 
            this.numericUpDownSlowAcumulate.Location = new System.Drawing.Point(8, 23);
            this.numericUpDownSlowAcumulate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownSlowAcumulate.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownSlowAcumulate.Name = "numericUpDownSlowAcumulate";
            this.numericUpDownSlowAcumulate.Size = new System.Drawing.Size(160, 22);
            this.numericUpDownSlowAcumulate.TabIndex = 1;
            // 
            // waveMeterTextBoxLabel
            // 
            this.waveMeterTextBoxLabel.AutoSize = true;
            this.waveMeterTextBoxLabel.Location = new System.Drawing.Point(24, 329);
            this.waveMeterTextBoxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.waveMeterTextBoxLabel.Name = "waveMeterTextBoxLabel";
            this.waveMeterTextBoxLabel.Size = new System.Drawing.Size(204, 17);
            this.waveMeterTextBoxLabel.TabIndex = 8;
            this.waveMeterTextBoxLabel.Text = "Port COM miernika długości fali";
            // 
            // waveMeterCOMportTextBox
            // 
            this.waveMeterCOMportTextBox.Location = new System.Drawing.Point(239, 325);
            this.waveMeterCOMportTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.waveMeterCOMportTextBox.Name = "waveMeterCOMportTextBox";
            this.waveMeterCOMportTextBox.Size = new System.Drawing.Size(132, 22);
            this.waveMeterCOMportTextBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(616, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Oriętacyjny czas pomiaru (ms)";
            // 
            // autoConnectWaveMetercheckBox
            // 
            this.autoConnectWaveMetercheckBox.AutoSize = true;
            this.autoConnectWaveMetercheckBox.Location = new System.Drawing.Point(27, 361);
            this.autoConnectWaveMetercheckBox.Name = "autoConnectWaveMetercheckBox";
            this.autoConnectWaveMetercheckBox.Size = new System.Drawing.Size(327, 21);
            this.autoConnectWaveMetercheckBox.TabIndex = 11;
            this.autoConnectWaveMetercheckBox.Text = "Automatycznie połącz z miernikiem dlugości fali";
            this.autoConnectWaveMetercheckBox.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(948, 517);
            this.Controls.Add(this.autoConnectWaveMetercheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.waveMeterCOMportTextBox);
            this.Controls.Add(this.waveMeterTextBoxLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxFast);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelFastAcumulate);
            this.Controls.Add(this.labelDeadTime);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SettingsForm";
            this.Text = "Ustawienia";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFastAcumulate)).EndInit();
            this.groupBoxFast.ResumeLayout(false);
            this.groupBoxFast.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFastDeadTime)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMediumDeadTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMediumAcumulate)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSlowDeadTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSlowAcumulate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.NumericUpDown numericUpDownFastAcumulate;
        private System.Windows.Forms.Label labelFastAcumulate;
        private System.Windows.Forms.GroupBox groupBoxFast;
        private System.Windows.Forms.NumericUpDown numericUpDownFastDeadTime;
        private System.Windows.Forms.Label labelDeadTime;
        private System.Windows.Forms.ComboBox comboBoxFastResolution;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxMediumResolution;
        private System.Windows.Forms.NumericUpDown numericUpDownMediumDeadTime;
        private System.Windows.Forms.NumericUpDown numericUpDownMediumAcumulate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxSlowResolution;
        private System.Windows.Forms.NumericUpDown numericUpDownSlowDeadTime;
        private System.Windows.Forms.NumericUpDown numericUpDownSlowAcumulate;
        private System.Windows.Forms.Label waveMeterTextBoxLabel;
        private System.Windows.Forms.TextBox waveMeterCOMportTextBox;
        private System.Windows.Forms.Label fastTimeLabel;
        private System.Windows.Forms.Label mediumTimeLabel;
        private System.Windows.Forms.Label slowTimeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox autoConnectWaveMetercheckBox;
    }
}