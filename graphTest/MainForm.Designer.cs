namespace graphTest
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonStartFast = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.checkBoxPOWER = new System.Windows.Forms.CheckBox();
            this.checkBoxMARKER = new System.Windows.Forms.CheckBox();
            this.checkBoxCH1 = new System.Windows.Forms.CheckBox();
            this.checkBoxCH2 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.buttonOpenPort = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxSerialPort = new System.Windows.Forms.ComboBox();
            this.saveToFileButton = new System.Windows.Forms.Button();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.saveToMESbutton = new System.Windows.Forms.Button();
            this.openFileButton = new System.Windows.Forms.Button();
            this.openMESbutton = new System.Windows.Forms.Button();
            this.WaveLenghtLabel = new System.Windows.Forms.Label();
            this.WMserialPort = new System.IO.Ports.SerialPort(this.components);
            this.WLInforLabel = new System.Windows.Forms.Label();
            this.MnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.startStopButton = new System.Windows.Forms.Button();
            this.nextStepButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.DarkSlateGray;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.BlanchedAlmond;
            chartArea1.AxisX.LineColor = System.Drawing.Color.BlanchedAlmond;
            chartArea1.AxisX.MajorGrid.LineWidth = 0;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Linen;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.Linen;
            chartArea1.AxisX2.MajorGrid.LineWidth = 0;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.BlanchedAlmond;
            chartArea1.AxisY.LineColor = System.Drawing.Color.BlanchedAlmond;
            chartArea1.AxisY.MajorGrid.LineWidth = 0;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.Linen;
            chartArea1.AxisY2.MajorGrid.LineWidth = 0;
            chartArea1.BackColor = System.Drawing.Color.DarkSlateGray;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            this.chart1.Size = new System.Drawing.Size(822, 403);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // buttonStartFast
            // 
            this.buttonStartFast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStartFast.Location = new System.Drawing.Point(1004, 510);
            this.buttonStartFast.Name = "buttonStartFast";
            this.buttonStartFast.Size = new System.Drawing.Size(96, 66);
            this.buttonStartFast.TabIndex = 1;
            this.buttonStartFast.Text = "Start szybki";
            this.buttonStartFast.UseVisualStyleBackColor = true;
            this.buttonStartFast.Click += new System.EventHandler(this.buttonStartFast_Click);
            // 
            // chart2
            // 
            this.chart2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart2.BackColor = System.Drawing.Color.DarkSlateGray;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.BlanchedAlmond;
            chartArea2.AxisX.LineColor = System.Drawing.Color.Linen;
            chartArea2.AxisX.MajorGrid.LineWidth = 0;
            chartArea2.AxisX2.MajorGrid.LineWidth = 0;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.BlanchedAlmond;
            chartArea2.AxisY.LineColor = System.Drawing.Color.BlanchedAlmond;
            chartArea2.AxisY.MajorGrid.LineWidth = 0;
            chartArea2.AxisY2.MajorGrid.LineWidth = 0;
            chartArea2.BackColor = System.Drawing.Color.DarkSlateGray;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Location = new System.Drawing.Point(3, 412);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            this.chart2.Size = new System.Drawing.Size(822, 162);
            this.chart2.TabIndex = 2;
            this.chart2.Text = "chart2";
            // 
            // buttonSettings
            // 
            this.buttonSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSettings.Location = new System.Drawing.Point(852, 12);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(89, 23);
            this.buttonSettings.TabIndex = 3;
            this.buttonSettings.Text = "Ustawienia";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // checkBoxPOWER
            // 
            this.checkBoxPOWER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxPOWER.Checked = true;
            this.checkBoxPOWER.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPOWER.Location = new System.Drawing.Point(842, 455);
            this.checkBoxPOWER.Name = "checkBoxPOWER";
            this.checkBoxPOWER.Size = new System.Drawing.Size(117, 26);
            this.checkBoxPOWER.TabIndex = 4;
            this.checkBoxPOWER.Text = "Pokaz moc";
            this.checkBoxPOWER.UseVisualStyleBackColor = true;
            this.checkBoxPOWER.CheckedChanged += new System.EventHandler(this.checkBoxChart_CheckStateChanged);
            // 
            // checkBoxMARKER
            // 
            this.checkBoxMARKER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxMARKER.Checked = true;
            this.checkBoxMARKER.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMARKER.Location = new System.Drawing.Point(842, 428);
            this.checkBoxMARKER.Name = "checkBoxMARKER";
            this.checkBoxMARKER.Size = new System.Drawing.Size(117, 21);
            this.checkBoxMARKER.TabIndex = 5;
            this.checkBoxMARKER.Text = "Pokaż marker";
            this.checkBoxMARKER.UseVisualStyleBackColor = true;
            this.checkBoxMARKER.CheckedChanged += new System.EventHandler(this.checkBoxChart_CheckStateChanged);
            // 
            // checkBoxCH1
            // 
            this.checkBoxCH1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxCH1.AutoSize = true;
            this.checkBoxCH1.Checked = true;
            this.checkBoxCH1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCH1.Location = new System.Drawing.Point(842, 68);
            this.checkBoxCH1.Name = "checkBoxCH1";
            this.checkBoxCH1.Size = new System.Drawing.Size(57, 21);
            this.checkBoxCH1.TabIndex = 6;
            this.checkBoxCH1.Text = "CH1";
            this.checkBoxCH1.UseVisualStyleBackColor = true;
            this.checkBoxCH1.CheckedChanged += new System.EventHandler(this.checkBoxChart_CheckStateChanged);
            // 
            // checkBoxCH2
            // 
            this.checkBoxCH2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxCH2.AutoSize = true;
            this.checkBoxCH2.Checked = true;
            this.checkBoxCH2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCH2.Location = new System.Drawing.Point(842, 95);
            this.checkBoxCH2.Name = "checkBoxCH2";
            this.checkBoxCH2.Size = new System.Drawing.Size(57, 21);
            this.checkBoxCH2.TabIndex = 7;
            this.checkBoxCH2.Text = "CH2";
            this.checkBoxCH2.UseVisualStyleBackColor = true;
            this.checkBoxCH2.CheckedChanged += new System.EventHandler(this.checkBoxChart_CheckStateChanged);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(1004, 428);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 66);
            this.button3.TabIndex = 10;
            this.button3.Text = "Start sredni";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonStartMedium_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(1004, 345);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 63);
            this.button4.TabIndex = 11;
            this.button4.Text = "Start wolny";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonStartSlow_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 256000;
            this.serialPort1.PortName = "COM5";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fileNameTextBox.Location = new System.Drawing.Point(979, 115);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(121, 22);
            this.fileNameTextBox.TabIndex = 12;
            this.fileNameTextBox.TextChanged += new System.EventHandler(this.textBoxDelay_TextChanged);
            // 
            // buttonOpenPort
            // 
            this.buttonOpenPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenPort.Location = new System.Drawing.Point(979, 12);
            this.buttonOpenPort.Name = "buttonOpenPort";
            this.buttonOpenPort.Size = new System.Drawing.Size(121, 23);
            this.buttonOpenPort.TabIndex = 13;
            this.buttonOpenPort.Text = "Otwórz port";
            this.buttonOpenPort.UseVisualStyleBackColor = true;
            this.buttonOpenPort.Click += new System.EventHandler(this.buttonOpenPort_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.chart1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chart2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.05719F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.94281F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(828, 577);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // comboBoxSerialPort
            // 
            this.comboBoxSerialPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSerialPort.FormattingEnabled = true;
            this.comboBoxSerialPort.Location = new System.Drawing.Point(979, 41);
            this.comboBoxSerialPort.Name = "comboBoxSerialPort";
            this.comboBoxSerialPort.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSerialPort.TabIndex = 18;
            // 
            // saveToFileButton
            // 
            this.saveToFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveToFileButton.Location = new System.Drawing.Point(979, 143);
            this.saveToFileButton.Name = "saveToFileButton";
            this.saveToFileButton.Size = new System.Drawing.Size(121, 23);
            this.saveToFileButton.TabIndex = 19;
            this.saveToFileButton.Text = "Zapisz do pliku";
            this.saveToFileButton.UseVisualStyleBackColor = true;
            this.saveToFileButton.Click += new System.EventHandler(this.saveToFileButton_Click);
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(976, 95);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(84, 17);
            this.fileNameLabel.TabIndex = 20;
            this.fileNameLabel.Text = "Nazwa Pliku";
            // 
            // stopButton
            // 
            this.stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stopButton.Location = new System.Drawing.Point(1004, 269);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(96, 41);
            this.stopButton.TabIndex = 21;
            this.stopButton.Text = "Anuluj pomiar";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveToMESbutton
            // 
            this.saveToMESbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveToMESbutton.Location = new System.Drawing.Point(979, 173);
            this.saveToMESbutton.Name = "saveToMESbutton";
            this.saveToMESbutton.Size = new System.Drawing.Size(121, 23);
            this.saveToMESbutton.TabIndex = 22;
            this.saveToMESbutton.Text = "Zapisz do MES";
            this.saveToMESbutton.UseVisualStyleBackColor = true;
            this.saveToMESbutton.Click += new System.EventHandler(this.saveToMesFileButton_Click);
            // 
            // openFileButton
            // 
            this.openFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openFileButton.Location = new System.Drawing.Point(852, 143);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(121, 23);
            this.openFileButton.TabIndex = 23;
            this.openFileButton.Text = "Otwórz plik";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // openMESbutton
            // 
            this.openMESbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openMESbutton.Location = new System.Drawing.Point(852, 173);
            this.openMESbutton.Name = "openMESbutton";
            this.openMESbutton.Size = new System.Drawing.Size(121, 23);
            this.openMESbutton.TabIndex = 24;
            this.openMESbutton.Text = "Otwórz MES";
            this.openMESbutton.UseVisualStyleBackColor = true;
            this.openMESbutton.Click += new System.EventHandler(this.openMesFileButton_Click);
            // 
            // WaveLenghtLabel
            // 
            this.WaveLenghtLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.WaveLenghtLabel.AutoSize = true;
            this.WaveLenghtLabel.Location = new System.Drawing.Point(839, 358);
            this.WaveLenghtLabel.Name = "WaveLenghtLabel";
            this.WaveLenghtLabel.Size = new System.Drawing.Size(16, 17);
            this.WaveLenghtLabel.TabIndex = 25;
            this.WaveLenghtLabel.Text = "0";
            // 
            // WMserialPort
            // 
            this.WMserialPort.BaudRate = 19200;
            this.WMserialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.WMserialPort_DataReceived);
            // 
            // WLInforLabel
            // 
            this.WLInforLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.WLInforLabel.AutoSize = true;
            this.WLInforLabel.Location = new System.Drawing.Point(839, 345);
            this.WLInforLabel.Name = "WLInforLabel";
            this.WLInforLabel.Size = new System.Drawing.Size(81, 17);
            this.WLInforLabel.TabIndex = 26;
            this.WLInforLabel.Text = "Długość fali";
            // 
            // MnumericUpDown
            // 
            this.MnumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MnumericUpDown.Location = new System.Drawing.Point(979, 212);
            this.MnumericUpDown.Name = "MnumericUpDown";
            this.MnumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.MnumericUpDown.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(852, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Numer pomiaru";
            // 
            // startStopButton
            // 
            this.startStopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startStopButton.Location = new System.Drawing.Point(855, 269);
            this.startStopButton.Name = "startStopButton";
            this.startStopButton.Size = new System.Drawing.Size(86, 41);
            this.startStopButton.TabIndex = 29;
            this.startStopButton.Text = "START / STOP";
            this.startStopButton.UseVisualStyleBackColor = true;
            this.startStopButton.Click += new System.EventHandler(this.startStopButton_Click);
            // 
            // nextStepButton
            // 
            this.nextStepButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextStepButton.Location = new System.Drawing.Point(948, 269);
            this.nextStepButton.Name = "nextStepButton";
            this.nextStepButton.Size = new System.Drawing.Size(31, 41);
            this.nextStepButton.TabIndex = 30;
            this.nextStepButton.Text = "+1";
            this.nextStepButton.UseVisualStyleBackColor = true;
            this.nextStepButton.Click += new System.EventHandler(this.nextStepButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1112, 591);
            this.Controls.Add(this.nextStepButton);
            this.Controls.Add(this.startStopButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MnumericUpDown);
            this.Controls.Add(this.WLInforLabel);
            this.Controls.Add(this.WaveLenghtLabel);
            this.Controls.Add(this.openMESbutton);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.saveToMESbutton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.saveToFileButton);
            this.Controls.Add(this.comboBoxSerialPort);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonOpenPort);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.checkBoxCH2);
            this.Controls.Add(this.checkBoxCH1);
            this.Controls.Add(this.checkBoxMARKER);
            this.Controls.Add(this.checkBoxPOWER);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonStartFast);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Pomiarowiec";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonStartFast;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.CheckBox checkBoxPOWER;
        private System.Windows.Forms.CheckBox checkBoxMARKER;
        private System.Windows.Forms.CheckBox checkBoxCH1;
        private System.Windows.Forms.CheckBox checkBoxCH2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Button buttonOpenPort;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBoxSerialPort;
        private System.Windows.Forms.Button saveToFileButton;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button saveToMESbutton;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Button openMESbutton;
        private System.Windows.Forms.Label WaveLenghtLabel;
        private System.IO.Ports.SerialPort WMserialPort;
        private System.Windows.Forms.Label WLInforLabel;
        private System.Windows.Forms.NumericUpDown MnumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startStopButton;
        private System.Windows.Forms.Button nextStepButton;
    }
}

