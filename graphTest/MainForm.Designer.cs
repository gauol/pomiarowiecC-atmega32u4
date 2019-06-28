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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
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
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(822, 403);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // buttonStartFast
            // 
            this.buttonStartFast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStartFast.Location = new System.Drawing.Point(1004, 553);
            this.buttonStartFast.Name = "buttonStartFast";
            this.buttonStartFast.Size = new System.Drawing.Size(96, 23);
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
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(3, 412);
            this.chart2.Name = "chart2";
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
            this.checkBoxCH1.Location = new System.Drawing.Point(842, 86);
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
            this.checkBoxCH2.Location = new System.Drawing.Point(842, 113);
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
            this.button3.Location = new System.Drawing.Point(1004, 524);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Start sredni";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonStartMedium_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(1004, 495);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 23);
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
            this.timer1.Interval = 1;
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
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1112, 591);
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
    }
}

