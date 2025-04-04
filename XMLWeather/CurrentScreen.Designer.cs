namespace XMLWeather
{
    partial class CurrentScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cityOutput = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.currentOutput = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.windspeedLabel = new System.Windows.Forms.Label();
            this.windOutput = new System.Windows.Forms.Label();
            this.wsLabel = new System.Windows.Forms.Label();
            this.wdLabel = new System.Windows.Forms.Label();
            this.wdOutput = new System.Windows.Forms.Label();
            this.precipLabel = new System.Windows.Forms.Label();
            this.precipOutput = new System.Windows.Forms.Label();
            this.visibilityOutput = new System.Windows.Forms.Label();
            this.visOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.ForeColor = System.Drawing.Color.White;
            this.cityOutput.Location = new System.Drawing.Point(28, 105);
            this.cityOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(94, 28);
            this.cityOutput.TabIndex = 22;
            this.cityOutput.Text = "City";
            // 
            // maxOutput
            // 
            this.maxOutput.BackColor = System.Drawing.Color.White;
            this.maxOutput.Location = new System.Drawing.Point(156, 222);
            this.maxOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(151, 16);
            this.maxOutput.TabIndex = 32;
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.ForeColor = System.Drawing.Color.White;
            this.maxLabel.Location = new System.Drawing.Point(28, 222);
            this.maxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(32, 16);
            this.maxLabel.TabIndex = 31;
            this.maxLabel.Text = "max";
            // 
            // minOutput
            // 
            this.minOutput.BackColor = System.Drawing.Color.White;
            this.minOutput.Location = new System.Drawing.Point(156, 194);
            this.minOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(151, 16);
            this.minOutput.TabIndex = 30;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.ForeColor = System.Drawing.Color.White;
            this.minLabel.Location = new System.Drawing.Point(28, 194);
            this.minLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(28, 16);
            this.minLabel.TabIndex = 29;
            this.minLabel.Text = "min";
            // 
            // currentOutput
            // 
            this.currentOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentOutput.ForeColor = System.Drawing.Color.White;
            this.currentOutput.Location = new System.Drawing.Point(174, 167);
            this.currentOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentOutput.Name = "currentOutput";
            this.currentOutput.Size = new System.Drawing.Size(29, 16);
            this.currentOutput.TabIndex = 28;
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.ForeColor = System.Drawing.Color.White;
            this.tempLabel.Location = new System.Drawing.Point(28, 167);
            this.tempLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(130, 16);
            this.tempLabel.TabIndex = 26;
            this.tempLabel.Text = "Current Temperature";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 34);
            this.label3.TabIndex = 40;
            this.label3.Text = "Today";
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(188, 18);
            this.forecastLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(110, 34);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "7 Day";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(26, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 33);
            this.label5.TabIndex = 42;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // windspeedLabel
            // 
            this.windspeedLabel.Location = new System.Drawing.Point(0, 0);
            this.windspeedLabel.Name = "windspeedLabel";
            this.windspeedLabel.Size = new System.Drawing.Size(100, 23);
            this.windspeedLabel.TabIndex = 45;
            // 
            // windOutput
            // 
            this.windOutput.BackColor = System.Drawing.Color.White;
            this.windOutput.Location = new System.Drawing.Point(156, 259);
            this.windOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.windOutput.Name = "windOutput";
            this.windOutput.Size = new System.Drawing.Size(151, 16);
            this.windOutput.TabIndex = 44;
            // 
            // wsLabel
            // 
            this.wsLabel.AutoSize = true;
            this.wsLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.wsLabel.Location = new System.Drawing.Point(28, 259);
            this.wsLabel.Name = "wsLabel";
            this.wsLabel.Size = new System.Drawing.Size(80, 16);
            this.wsLabel.TabIndex = 46;
            this.wsLabel.Text = "Wind speed";
            // 
            // wdLabel
            // 
            this.wdLabel.AutoSize = true;
            this.wdLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.wdLabel.Location = new System.Drawing.Point(28, 288);
            this.wdLabel.Name = "wdLabel";
            this.wdLabel.Size = new System.Drawing.Size(92, 16);
            this.wdLabel.TabIndex = 47;
            this.wdLabel.Text = "Wind direction";
            // 
            // wdOutput
            // 
            this.wdOutput.BackColor = System.Drawing.Color.White;
            this.wdOutput.Location = new System.Drawing.Point(156, 288);
            this.wdOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wdOutput.Name = "wdOutput";
            this.wdOutput.Size = new System.Drawing.Size(151, 16);
            this.wdOutput.TabIndex = 48;
            // 
            // precipLabel
            // 
            this.precipLabel.AutoSize = true;
            this.precipLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.precipLabel.Location = new System.Drawing.Point(28, 318);
            this.precipLabel.Name = "precipLabel";
            this.precipLabel.Size = new System.Drawing.Size(81, 16);
            this.precipLabel.TabIndex = 49;
            this.precipLabel.Text = "Precipitation";
            // 
            // precipOutput
            // 
            this.precipOutput.BackColor = System.Drawing.Color.White;
            this.precipOutput.Location = new System.Drawing.Point(156, 319);
            this.precipOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.precipOutput.Name = "precipOutput";
            this.precipOutput.Size = new System.Drawing.Size(151, 15);
            this.precipOutput.TabIndex = 50;
            // 
            // visibilityOutput
            // 
            this.visibilityOutput.AutoSize = true;
            this.visibilityOutput.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.visibilityOutput.Location = new System.Drawing.Point(31, 357);
            this.visibilityOutput.Name = "visibilityOutput";
            this.visibilityOutput.Size = new System.Drawing.Size(56, 16);
            this.visibilityOutput.TabIndex = 51;
            this.visibilityOutput.Text = "Visibility";
            // 
            // visOutput
            // 
            this.visOutput.BackColor = System.Drawing.Color.White;
            this.visOutput.Location = new System.Drawing.Point(156, 353);
            this.visOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.visOutput.Name = "visOutput";
            this.visOutput.Size = new System.Drawing.Size(151, 20);
            this.visOutput.TabIndex = 52;
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.visOutput);
            this.Controls.Add(this.visibilityOutput);
            this.Controls.Add(this.precipOutput);
            this.Controls.Add(this.precipLabel);
            this.Controls.Add(this.wdOutput);
            this.Controls.Add(this.wdLabel);
            this.Controls.Add(this.wsLabel);
            this.Controls.Add(this.windOutput);
            this.Controls.Add(this.windspeedLabel);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.currentOutput);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(333, 492);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label currentOutput;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label windspeedLabel;
        private System.Windows.Forms.Label windOutput;
        private System.Windows.Forms.Label wsLabel;
        private System.Windows.Forms.Label wdLabel;
        private System.Windows.Forms.Label wdOutput;
        private System.Windows.Forms.Label precipLabel;
        private System.Windows.Forms.Label precipOutput;
        private System.Windows.Forms.Label visibilityOutput;
        private System.Windows.Forms.Label visOutput;
    }
}
