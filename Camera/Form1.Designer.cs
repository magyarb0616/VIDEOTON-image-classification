namespace Camera
{
    partial class Form1
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.Satart_button = new System.Windows.Forms.Button();
			this.Snapshot_button = new System.Windows.Forms.Button();
			this.CameraList_comboBox = new System.Windows.Forms.ComboBox();
			this.Capture_pictureBox = new System.Windows.Forms.PictureBox();
			this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
			this.Result_Label = new System.Windows.Forms.Label();
			this.gbValidationPanel = new System.Windows.Forms.GroupBox();
			this.btnCorrect = new System.Windows.Forms.Button();
			this.btnPPN = new System.Windows.Forms.Button();
			this.btnPNP = new System.Windows.Forms.Button();
			this.btnPNN = new System.Windows.Forms.Button();
			this.btnPPP = new System.Windows.Forms.Button();
			this.btnNPP = new System.Windows.Forms.Button();
			this.btnNPN = new System.Windows.Forms.Button();
			this.btnNNP = new System.Windows.Forms.Button();
			this.btnNNN = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.pbVideoton = new System.Windows.Forms.PictureBox();
			this.pbInstagrid = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.Capture_pictureBox)).BeginInit();
			this.gbValidationPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbVideoton)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbInstagrid)).BeginInit();
			this.SuspendLayout();
			// 
			// Satart_button
			// 
			this.Satart_button.Location = new System.Drawing.Point(512, 50);
			this.Satart_button.Margin = new System.Windows.Forms.Padding(0);
			this.Satart_button.Name = "Satart_button";
			this.Satart_button.Size = new System.Drawing.Size(180, 45);
			this.Satart_button.TabIndex = 1;
			this.Satart_button.Text = "Start";
			this.Satart_button.UseVisualStyleBackColor = true;
			this.Satart_button.Click += new System.EventHandler(this.Satart_button_Click);
			// 
			// Snapshot_button
			// 
			this.Snapshot_button.BackColor = System.Drawing.SystemColors.Control;
			this.Snapshot_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Snapshot_button.Location = new System.Drawing.Point(1604, 192);
			this.Snapshot_button.Margin = new System.Windows.Forms.Padding(6);
			this.Snapshot_button.Name = "Snapshot_button";
			this.Snapshot_button.Size = new System.Drawing.Size(627, 195);
			this.Snapshot_button.TabIndex = 2;
			this.Snapshot_button.Text = "Snapshot";
			this.Snapshot_button.UseVisualStyleBackColor = false;
			this.Snapshot_button.Click += new System.EventHandler(this.Snapshot_button_Click);
			// 
			// CameraList_comboBox
			// 
			this.CameraList_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.CameraList_comboBox.FormattingEnabled = true;
			this.CameraList_comboBox.Location = new System.Drawing.Point(37, 50);
			this.CameraList_comboBox.Margin = new System.Windows.Forms.Padding(6);
			this.CameraList_comboBox.Name = "CameraList_comboBox";
			this.CameraList_comboBox.Size = new System.Drawing.Size(469, 45);
			this.CameraList_comboBox.TabIndex = 3;
			// 
			// Capture_pictureBox
			// 
			this.Capture_pictureBox.Location = new System.Drawing.Point(812, 192);
			this.Capture_pictureBox.Margin = new System.Windows.Forms.Padding(6);
			this.Capture_pictureBox.Name = "Capture_pictureBox";
			this.Capture_pictureBox.Size = new System.Drawing.Size(728, 546);
			this.Capture_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Capture_pictureBox.TabIndex = 4;
			this.Capture_pictureBox.TabStop = false;
			// 
			// videoSourcePlayer1
			// 
			this.videoSourcePlayer1.Location = new System.Drawing.Point(37, 192);
			this.videoSourcePlayer1.Margin = new System.Windows.Forms.Padding(6);
			this.videoSourcePlayer1.Name = "videoSourcePlayer1";
			this.videoSourcePlayer1.Size = new System.Drawing.Size(728, 546);
			this.videoSourcePlayer1.TabIndex = 5;
			this.videoSourcePlayer1.Text = "videoSourcePlayer1";
			this.videoSourcePlayer1.VideoSource = null;
			this.videoSourcePlayer1.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.videoSourcePlayer1_NewFrame);
			// 
			// Result_Label
			// 
			this.Result_Label.AutoSize = true;
			this.Result_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Result_Label.Location = new System.Drawing.Point(1007, 123);
			this.Result_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.Result_Label.Name = "Result_Label";
			this.Result_Label.Size = new System.Drawing.Size(310, 63);
			this.Result_Label.TabIndex = 6;
			this.Result_Label.Text = "Prediction: ";
			// 
			// gbValidationPanel
			// 
			this.gbValidationPanel.Controls.Add(this.btnCorrect);
			this.gbValidationPanel.Controls.Add(this.btnPPN);
			this.gbValidationPanel.Controls.Add(this.btnPNP);
			this.gbValidationPanel.Controls.Add(this.btnPNN);
			this.gbValidationPanel.Controls.Add(this.btnPPP);
			this.gbValidationPanel.Controls.Add(this.btnNPP);
			this.gbValidationPanel.Controls.Add(this.btnNPN);
			this.gbValidationPanel.Controls.Add(this.btnNNP);
			this.gbValidationPanel.Controls.Add(this.btnNNN);
			this.gbValidationPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.gbValidationPanel.Location = new System.Drawing.Point(1604, 439);
			this.gbValidationPanel.Name = "gbValidationPanel";
			this.gbValidationPanel.Size = new System.Drawing.Size(643, 299);
			this.gbValidationPanel.TabIndex = 7;
			this.gbValidationPanel.TabStop = false;
			this.gbValidationPanel.Text = "Prediction Validation";
			// 
			// btnCorrect
			// 
			this.btnCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnCorrect.ForeColor = System.Drawing.Color.LimeGreen;
			this.btnCorrect.Location = new System.Drawing.Point(404, 41);
			this.btnCorrect.Name = "btnCorrect";
			this.btnCorrect.Size = new System.Drawing.Size(217, 242);
			this.btnCorrect.TabIndex = 8;
			this.btnCorrect.Text = "CORRECT!";
			this.btnCorrect.UseVisualStyleBackColor = true;
			this.btnCorrect.Click += new System.EventHandler(this.btnCorrect_Click);
			// 
			// btnPPN
			// 
			this.btnPPN.ForeColor = System.Drawing.Color.Red;
			this.btnPPN.Location = new System.Drawing.Point(215, 227);
			this.btnPPN.Name = "btnPPN";
			this.btnPPN.Size = new System.Drawing.Size(183, 56);
			this.btnPPN.TabIndex = 7;
			this.btnPPN.Text = "PPN";
			this.btnPPN.UseVisualStyleBackColor = true;
			this.btnPPN.Click += new System.EventHandler(this.btnPPN_Click);
			// 
			// btnPNP
			// 
			this.btnPNP.ForeColor = System.Drawing.Color.Red;
			this.btnPNP.Location = new System.Drawing.Point(215, 165);
			this.btnPNP.Name = "btnPNP";
			this.btnPNP.Size = new System.Drawing.Size(183, 56);
			this.btnPNP.TabIndex = 6;
			this.btnPNP.Text = "PNP";
			this.btnPNP.UseVisualStyleBackColor = true;
			this.btnPNP.Click += new System.EventHandler(this.btnPNP_Click);
			// 
			// btnPNN
			// 
			this.btnPNN.ForeColor = System.Drawing.Color.Red;
			this.btnPNN.Location = new System.Drawing.Point(215, 103);
			this.btnPNN.Name = "btnPNN";
			this.btnPNN.Size = new System.Drawing.Size(183, 56);
			this.btnPNN.TabIndex = 5;
			this.btnPNN.Text = "PNN";
			this.btnPNN.UseVisualStyleBackColor = true;
			this.btnPNN.Click += new System.EventHandler(this.btnPNN_Click);
			// 
			// btnPPP
			// 
			this.btnPPP.ForeColor = System.Drawing.Color.Red;
			this.btnPPP.Location = new System.Drawing.Point(215, 41);
			this.btnPPP.Name = "btnPPP";
			this.btnPPP.Size = new System.Drawing.Size(183, 56);
			this.btnPPP.TabIndex = 4;
			this.btnPPP.Text = "PPP";
			this.btnPPP.UseVisualStyleBackColor = true;
			this.btnPPP.Click += new System.EventHandler(this.btnPPP_Click);
			// 
			// btnNPP
			// 
			this.btnNPP.ForeColor = System.Drawing.Color.Red;
			this.btnNPP.Location = new System.Drawing.Point(26, 227);
			this.btnNPP.Name = "btnNPP";
			this.btnNPP.Size = new System.Drawing.Size(183, 56);
			this.btnNPP.TabIndex = 3;
			this.btnNPP.Text = "NPP";
			this.btnNPP.UseVisualStyleBackColor = true;
			this.btnNPP.Click += new System.EventHandler(this.btnNPP_Click);
			// 
			// btnNPN
			// 
			this.btnNPN.ForeColor = System.Drawing.Color.Red;
			this.btnNPN.Location = new System.Drawing.Point(26, 165);
			this.btnNPN.Name = "btnNPN";
			this.btnNPN.Size = new System.Drawing.Size(183, 56);
			this.btnNPN.TabIndex = 2;
			this.btnNPN.Text = "NPN";
			this.btnNPN.UseVisualStyleBackColor = true;
			this.btnNPN.Click += new System.EventHandler(this.btnNPN_Click);
			// 
			// btnNNP
			// 
			this.btnNNP.ForeColor = System.Drawing.Color.Red;
			this.btnNNP.Location = new System.Drawing.Point(26, 103);
			this.btnNNP.Name = "btnNNP";
			this.btnNNP.Size = new System.Drawing.Size(183, 56);
			this.btnNNP.TabIndex = 1;
			this.btnNNP.Text = "NNP";
			this.btnNNP.UseVisualStyleBackColor = true;
			this.btnNNP.Click += new System.EventHandler(this.btnNNP_Click);
			// 
			// btnNNN
			// 
			this.btnNNN.ForeColor = System.Drawing.Color.Red;
			this.btnNNN.Location = new System.Drawing.Point(26, 41);
			this.btnNNN.Name = "btnNNN";
			this.btnNNN.Size = new System.Drawing.Size(183, 56);
			this.btnNNN.TabIndex = 0;
			this.btnNNN.Text = "NNN";
			this.btnNNN.UseVisualStyleBackColor = true;
			this.btnNNN.Click += new System.EventHandler(this.btnNNN_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(209, 123);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(356, 63);
			this.label1.TabIndex = 8;
			this.label1.Text = "Live preview:";
			// 
			// chart
			// 
			chartArea1.Name = "ChartArea1";
			this.chart.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart.Legends.Add(legend1);
			this.chart.Location = new System.Drawing.Point(812, 771);
			this.chart.Name = "chart";
			this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
			series1.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			series1.Legend = "Legend1";
			series1.Name = "s1";
			this.chart.Series.Add(series1);
			this.chart.Size = new System.Drawing.Size(821, 546);
			this.chart.TabIndex = 11;
			this.chart.Text = "chart";
			// 
			// pbVideoton
			// 
			this.pbVideoton.Image = ((System.Drawing.Image)(resources.GetObject("pbVideoton.Image")));
			this.pbVideoton.Location = new System.Drawing.Point(37, 855);
			this.pbVideoton.Name = "pbVideoton";
			this.pbVideoton.Size = new System.Drawing.Size(728, 187);
			this.pbVideoton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbVideoton.TabIndex = 12;
			this.pbVideoton.TabStop = false;
			// 
			// pbInstagrid
			// 
			this.pbInstagrid.Image = ((System.Drawing.Image)(resources.GetObject("pbInstagrid.Image")));
			this.pbInstagrid.Location = new System.Drawing.Point(37, 1048);
			this.pbInstagrid.Name = "pbInstagrid";
			this.pbInstagrid.Size = new System.Drawing.Size(728, 189);
			this.pbInstagrid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbInstagrid.TabIndex = 13;
			this.pbInstagrid.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(2286, 1396);
			this.Controls.Add(this.pbInstagrid);
			this.Controls.Add(this.pbVideoton);
			this.Controls.Add(this.chart);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.gbValidationPanel);
			this.Controls.Add(this.Result_Label);
			this.Controls.Add(this.videoSourcePlayer1);
			this.Controls.Add(this.Capture_pictureBox);
			this.Controls.Add(this.CameraList_comboBox);
			this.Controls.Add(this.Snapshot_button);
			this.Controls.Add(this.Satart_button);
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "Form1";
			this.Text = "Battery Cell Orientation Checker - Machine Learning";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.Capture_pictureBox)).EndInit();
			this.gbValidationPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbVideoton)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbInstagrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Satart_button;
        private System.Windows.Forms.Button Snapshot_button;
        private System.Windows.Forms.ComboBox CameraList_comboBox;
        private System.Windows.Forms.PictureBox Capture_pictureBox;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.Label Result_Label;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox gbValidationPanel;
		private System.Windows.Forms.Button btnCorrect;
		private System.Windows.Forms.Button btnPPN;
		private System.Windows.Forms.Button btnPNP;
		private System.Windows.Forms.Button btnPNN;
		private System.Windows.Forms.Button btnPPP;
		private System.Windows.Forms.Button btnNPP;
		private System.Windows.Forms.Button btnNPN;
		private System.Windows.Forms.Button btnNNP;
		private System.Windows.Forms.Button btnNNN;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart;
		private System.Windows.Forms.PictureBox pbVideoton;
		private System.Windows.Forms.PictureBox pbInstagrid;
	}
}

