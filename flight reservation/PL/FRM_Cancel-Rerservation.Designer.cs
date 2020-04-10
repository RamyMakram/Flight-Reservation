namespace flight_reservation
{
    partial class cancel
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cancel));
			this.button3 = new System.Windows.Forms.Button();
			this.BTN_Cancel = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.TXT_FlightNum = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.TXT_FlightNum)).BeginInit();
			this.SuspendLayout();
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.OrangeRed;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button3.Location = new System.Drawing.Point(657, 403);
			this.button3.Margin = new System.Windows.Forms.Padding(2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(112, 36);
			this.button3.TabIndex = 15;
			this.button3.Text = "Back";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// BTN_Cancel
			// 
			this.BTN_Cancel.BackColor = System.Drawing.Color.OrangeRed;
			this.BTN_Cancel.FlatAppearance.BorderSize = 0;
			this.BTN_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BTN_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BTN_Cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.BTN_Cancel.Location = new System.Drawing.Point(102, 339);
			this.BTN_Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.BTN_Cancel.Name = "BTN_Cancel";
			this.BTN_Cancel.Size = new System.Drawing.Size(221, 44);
			this.BTN_Cancel.TabIndex = 41;
			this.BTN_Cancel.Text = "Cancel Reservation";
			this.BTN_Cancel.UseVisualStyleBackColor = false;
			this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.LightSeaGreen;
			this.label12.Location = new System.Drawing.Point(160, 214);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(102, 19);
			this.label12.TabIndex = 38;
			this.label12.Text = "Flight Num";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.OrangeRed;
			this.label2.Location = new System.Drawing.Point(52, 133);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(309, 35);
			this.label2.TabIndex = 36;
			this.label2.Text = "Cancel Reservation";
			// 
			// TXT_FlightNum
			// 
			this.TXT_FlightNum.Location = new System.Drawing.Point(58, 262);
			this.TXT_FlightNum.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.TXT_FlightNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.TXT_FlightNum.Name = "TXT_FlightNum";
			this.TXT_FlightNum.Size = new System.Drawing.Size(308, 24);
			this.TXT_FlightNum.TabIndex = 42;
			this.TXT_FlightNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// cancel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(780, 450);
			this.Controls.Add(this.TXT_FlightNum);
			this.Controls.Add(this.BTN_Cancel);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "cancel";
			this.Text = "cancel";
			((System.ComponentModel.ISupportInitialize)(this.TXT_FlightNum)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown TXT_FlightNum;
	}
}