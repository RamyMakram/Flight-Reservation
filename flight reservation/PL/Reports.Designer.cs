using System.Windows.Forms;

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
			Application.Exit();
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.D_FlightFrom = new System.Windows.Forms.DateTimePicker();
			this.D_FlightTo = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.BTN_From_To = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.TXT_ClientID)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// BTN_AirPort
			// 
			this.BTN_AirPort.Location = new System.Drawing.Point(26, 39);
			this.BTN_AirPort.Name = "BTN_AirPort";
			this.BTN_AirPort.Size = new System.Drawing.Size(146, 40);
			this.BTN_AirPort.TabIndex = 0;
			this.BTN_AirPort.Text = "AirPorts Report";
			this.BTN_AirPort.UseVisualStyleBackColor = true;
			this.BTN_AirPort.Click += new System.EventHandler(this.BTN_AirPort_Click);
			// 
			// BTN_Client
			// 
			this.BTN_Client.Location = new System.Drawing.Point(47, 95);
			this.BTN_Client.Name = "BTN_Client";
			this.BTN_Client.Size = new System.Drawing.Size(146, 40);
			this.BTN_Client.TabIndex = 0;
			this.BTN_Client.Text = "Client Report";
			this.BTN_Client.UseVisualStyleBackColor = true;
			this.BTN_Client.Click += new System.EventHandler(this.BTN_Client_Click);
			// 
			// TXT_ClientID
			// 
			this.TXT_ClientID.Location = new System.Drawing.Point(64, 55);
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
			this.TXT_ClientID.Size = new System.Drawing.Size(108, 24);
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
			this.label1.Location = new System.Drawing.Point(81, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Client ID";
			// 
			// CB_From
			// 
			this.CB_From.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CB_From.FormattingEnabled = true;
			this.CB_From.Location = new System.Drawing.Point(9, 73);
			this.CB_From.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.CB_From.Name = "CB_From";
			this.CB_From.Size = new System.Drawing.Size(129, 24);
			this.CB_From.TabIndex = 67;
			// 
			// CB_To
			// 
			this.CB_To.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CB_To.FormattingEnabled = true;
			this.CB_To.Location = new System.Drawing.Point(159, 73);
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
			this.label8.Location = new System.Drawing.Point(200, 41);
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
			this.label7.Location = new System.Drawing.Point(49, 41);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(52, 19);
			this.label7.TabIndex = 64;
			this.label7.Text = "From";
			// 
			// BTN_FligthsReport
			// 
			this.BTN_FligthsReport.Location = new System.Drawing.Point(85, 119);
			this.BTN_FligthsReport.Name = "BTN_FligthsReport";
			this.BTN_FligthsReport.Size = new System.Drawing.Size(146, 40);
			this.BTN_FligthsReport.TabIndex = 0;
			this.BTN_FligthsReport.Text = "Fligths Report";
			this.BTN_FligthsReport.UseVisualStyleBackColor = true;
			this.BTN_FligthsReport.Click += new System.EventHandler(this.BTN_FligthsReport_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.BTN_AirPort);
			this.groupBox1.Location = new System.Drawing.Point(12, 64);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(210, 113);
			this.groupBox1.TabIndex = 72;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "AirPort";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.BTN_Client);
			this.groupBox2.Controls.Add(this.TXT_ClientID);
			this.groupBox2.Location = new System.Drawing.Point(238, 42);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(238, 147);
			this.groupBox2.TabIndex = 73;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Client";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.BTN_FligthsReport);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.CB_To);
			this.groupBox3.Controls.Add(this.CB_From);
			this.groupBox3.Location = new System.Drawing.Point(495, 25);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(295, 181);
			this.groupBox3.TabIndex = 74;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Flights";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.D_FlightFrom);
			this.groupBox4.Controls.Add(this.D_FlightTo);
			this.groupBox4.Controls.Add(this.label2);
			this.groupBox4.Controls.Add(this.label11);
			this.groupBox4.Controls.Add(this.BTN_From_To);
			this.groupBox4.Location = new System.Drawing.Point(102, 237);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(595, 191);
			this.groupBox4.TabIndex = 75;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Flights";
			// 
			// D_FlightFrom
			// 
			this.D_FlightFrom.Location = new System.Drawing.Point(29, 66);
			this.D_FlightFrom.Name = "D_FlightFrom";
			this.D_FlightFrom.Size = new System.Drawing.Size(237, 24);
			this.D_FlightFrom.TabIndex = 75;
			// 
			// D_FlightTo
			// 
			this.D_FlightTo.Location = new System.Drawing.Point(309, 66);
			this.D_FlightTo.Name = "D_FlightTo";
			this.D_FlightTo.Size = new System.Drawing.Size(243, 24);
			this.D_FlightTo.TabIndex = 76;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(385, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 17);
			this.label2.TabIndex = 73;
			this.label2.Text = "To Date";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(99, 31);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(73, 17);
			this.label11.TabIndex = 74;
			this.label11.Text = "From Date";
			// 
			// BTN_From_To
			// 
			this.BTN_From_To.Location = new System.Drawing.Point(209, 119);
			this.BTN_From_To.Name = "BTN_From_To";
			this.BTN_From_To.Size = new System.Drawing.Size(146, 40);
			this.BTN_From_To.TabIndex = 72;
			this.BTN_From_To.Text = "Fligths Report";
			this.BTN_From_To.UseVisualStyleBackColor = true;
			this.BTN_From_To.Click += new System.EventHandler(this.BTN_From_To_Click_1);
			// 
			// Reports
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Reports";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Reports";
			this.Load += new System.EventHandler(this.Reports_Load);
			((System.ComponentModel.ISupportInitialize)(this.TXT_ClientID)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);

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
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.DateTimePicker D_FlightFrom;
		private System.Windows.Forms.DateTimePicker D_FlightTo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button BTN_From_To;
	}
}