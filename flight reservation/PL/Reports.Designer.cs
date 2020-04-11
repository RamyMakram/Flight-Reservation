namespace flight_reservation.PL
{
	partial class Reports
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
			this.BTN_AirPort = new System.Windows.Forms.Button();
			this.BTN_Client = new System.Windows.Forms.Button();
			this.TXT_ClientID = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.CB_From = new System.Windows.Forms.ComboBox();
			this.CB_To = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.BTN_FligthsReport = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.TXT_ClientID)).BeginInit();
			this.SuspendLayout();
			// 
			// BTN_AirPort
			// 
			this.BTN_AirPort.Location = new System.Drawing.Point(42, 94);
			this.BTN_AirPort.Name = "BTN_AirPort";
			this.BTN_AirPort.Size = new System.Drawing.Size(146, 40);
			this.BTN_AirPort.TabIndex = 0;
			this.BTN_AirPort.Text = "AirPorts Report";
			this.BTN_AirPort.UseVisualStyleBackColor = true;
			this.BTN_AirPort.Click += new System.EventHandler(this.BTN_AirPort_Click);
			// 
			// BTN_Client
			// 
			this.BTN_Client.Location = new System.Drawing.Point(257, 94);
			this.BTN_Client.Name = "BTN_Client";
			this.BTN_Client.Size = new System.Drawing.Size(146, 40);
			this.BTN_Client.TabIndex = 0;
			this.BTN_Client.Text = "Client Report";
			this.BTN_Client.UseVisualStyleBackColor = true;
			this.BTN_Client.Click += new System.EventHandler(this.BTN_Client_Click);
			// 
			// TXT_ClientID
			// 
			this.TXT_ClientID.Location = new System.Drawing.Point(257, 51);
			this.TXT_ClientID.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.TXT_ClientID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.TXT_ClientID.Name = "TXT_ClientID";
			this.TXT_ClientID.Size = new System.Drawing.Size(146, 24);
			this.TXT_ClientID.TabIndex = 1;
			this.TXT_ClientID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(304, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Client ID";
			// 
			// CB_From
			// 
			this.CB_From.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CB_From.FormattingEnabled = true;
			this.CB_From.Location = new System.Drawing.Point(502, 48);
			this.CB_From.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.CB_From.Name = "CB_From";
			this.CB_From.Size = new System.Drawing.Size(129, 24);
			this.CB_From.TabIndex = 67;
			// 
			// CB_To
			// 
			this.CB_To.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CB_To.FormattingEnabled = true;
			this.CB_To.Location = new System.Drawing.Point(652, 48);
			this.CB_To.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.CB_To.Name = "CB_To";
			this.CB_To.Size = new System.Drawing.Size(129, 24);
			this.CB_To.TabIndex = 66;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label8.Location = new System.Drawing.Point(693, 16);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(31, 19);
			this.label8.TabIndex = 65;
			this.label8.Text = "To";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label7.Location = new System.Drawing.Point(542, 16);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(52, 19);
			this.label7.TabIndex = 64;
			this.label7.Text = "From";
			// 
			// BTN_FligthsReport
			// 
			this.BTN_FligthsReport.Location = new System.Drawing.Point(578, 94);
			this.BTN_FligthsReport.Name = "BTN_FligthsReport";
			this.BTN_FligthsReport.Size = new System.Drawing.Size(146, 40);
			this.BTN_FligthsReport.TabIndex = 0;
			this.BTN_FligthsReport.Text = "Fligths Report";
			this.BTN_FligthsReport.UseVisualStyleBackColor = true;
			this.BTN_FligthsReport.Click += new System.EventHandler(this.BTN_FligthsReport_Click);
			// 
			// Reports
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.CB_From);
			this.Controls.Add(this.CB_To);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TXT_ClientID);
			this.Controls.Add(this.BTN_FligthsReport);
			this.Controls.Add(this.BTN_Client);
			this.Controls.Add(this.BTN_AirPort);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Reports";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Reports";
			this.Load += new System.EventHandler(this.Reports_Load);
			((System.ComponentModel.ISupportInitialize)(this.TXT_ClientID)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BTN_AirPort;
		private System.Windows.Forms.Button BTN_Client;
		private System.Windows.Forms.NumericUpDown TXT_ClientID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox CB_From;
		private System.Windows.Forms.ComboBox CB_To;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button BTN_FligthsReport;
	}
}