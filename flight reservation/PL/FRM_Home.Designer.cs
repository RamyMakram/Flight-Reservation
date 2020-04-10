namespace flight_reservation
{
    partial class FRM_Home
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Home));
			this.BTN_Login = new System.Windows.Forms.Button();
			this.BTN_Book = new System.Windows.Forms.Button();
			this.BTN_Fligth = new System.Windows.Forms.Button();
			this.BTN_CancelRes = new System.Windows.Forms.Button();
			this.BTN_ViewRes = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.BTN_Contact = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.LBL_Name = new System.Windows.Forms.Label();
			this.BTN_LogOut = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// BTN_Login
			// 
			this.BTN_Login.BackColor = System.Drawing.Color.OrangeRed;
			this.BTN_Login.FlatAppearance.BorderSize = 0;
			this.BTN_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BTN_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BTN_Login.ForeColor = System.Drawing.Color.White;
			this.BTN_Login.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Login.Image")));
			this.BTN_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.BTN_Login.Location = new System.Drawing.Point(846, 3);
			this.BTN_Login.Margin = new System.Windows.Forms.Padding(2);
			this.BTN_Login.Name = "BTN_Login";
			this.BTN_Login.Size = new System.Drawing.Size(112, 36);
			this.BTN_Login.TabIndex = 3;
			this.BTN_Login.Text = "Log in";
			this.BTN_Login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.BTN_Login.UseVisualStyleBackColor = false;
			this.BTN_Login.Click += new System.EventHandler(this.button9_Click);
			// 
			// BTN_Book
			// 
			this.BTN_Book.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BTN_Book.Enabled = false;
			this.BTN_Book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BTN_Book.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BTN_Book.ForeColor = System.Drawing.Color.Turquoise;
			this.BTN_Book.Location = new System.Drawing.Point(611, 298);
			this.BTN_Book.Margin = new System.Windows.Forms.Padding(2);
			this.BTN_Book.Name = "BTN_Book";
			this.BTN_Book.Size = new System.Drawing.Size(351, 47);
			this.BTN_Book.TabIndex = 1;
			this.BTN_Book.Text = "Booking";
			this.BTN_Book.UseVisualStyleBackColor = false;
			this.BTN_Book.Click += new System.EventHandler(this.button7_Click);
			// 
			// BTN_Fligth
			// 
			this.BTN_Fligth.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BTN_Fligth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BTN_Fligth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BTN_Fligth.ForeColor = System.Drawing.Color.Turquoise;
			this.BTN_Fligth.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Fligth.Image")));
			this.BTN_Fligth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.BTN_Fligth.Location = new System.Drawing.Point(611, 117);
			this.BTN_Fligth.Margin = new System.Windows.Forms.Padding(2);
			this.BTN_Fligth.Name = "BTN_Fligth";
			this.BTN_Fligth.Size = new System.Drawing.Size(351, 44);
			this.BTN_Fligth.TabIndex = 1;
			this.BTN_Fligth.Text = "Flights";
			this.BTN_Fligth.UseVisualStyleBackColor = false;
			this.BTN_Fligth.Click += new System.EventHandler(this.button2_Click);
			// 
			// BTN_CancelRes
			// 
			this.BTN_CancelRes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BTN_CancelRes.Enabled = false;
			this.BTN_CancelRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BTN_CancelRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BTN_CancelRes.ForeColor = System.Drawing.Color.Turquoise;
			this.BTN_CancelRes.Image = ((System.Drawing.Image)(resources.GetObject("BTN_CancelRes.Image")));
			this.BTN_CancelRes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.BTN_CancelRes.Location = new System.Drawing.Point(611, 389);
			this.BTN_CancelRes.Margin = new System.Windows.Forms.Padding(2);
			this.BTN_CancelRes.Name = "BTN_CancelRes";
			this.BTN_CancelRes.Size = new System.Drawing.Size(351, 46);
			this.BTN_CancelRes.TabIndex = 7;
			this.BTN_CancelRes.Text = "cancel reservation";
			this.BTN_CancelRes.UseVisualStyleBackColor = false;
			this.BTN_CancelRes.Click += new System.EventHandler(this.button5_Click);
			// 
			// BTN_ViewRes
			// 
			this.BTN_ViewRes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BTN_ViewRes.Enabled = false;
			this.BTN_ViewRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BTN_ViewRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BTN_ViewRes.ForeColor = System.Drawing.Color.Turquoise;
			this.BTN_ViewRes.Image = ((System.Drawing.Image)(resources.GetObject("BTN_ViewRes.Image")));
			this.BTN_ViewRes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.BTN_ViewRes.Location = new System.Drawing.Point(611, 206);
			this.BTN_ViewRes.Margin = new System.Windows.Forms.Padding(2);
			this.BTN_ViewRes.Name = "BTN_ViewRes";
			this.BTN_ViewRes.Size = new System.Drawing.Size(351, 46);
			this.BTN_ViewRes.TabIndex = 6;
			this.BTN_ViewRes.Text = "Review Reservation";
			this.BTN_ViewRes.UseVisualStyleBackColor = false;
			this.BTN_ViewRes.Click += new System.EventHandler(this.button4_Click_1);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new System.Drawing.Point(250, 139);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(199, 45);
			this.label2.TabIndex = 9;
			this.label2.Text = "Come on";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(271, 206);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(143, 45);
			this.label1.TabIndex = 10;
			this.label1.Text = "Check";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label3.Location = new System.Drawing.Point(282, 272);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(117, 45);
			this.label3.TabIndex = 11;
			this.label3.Text = "Your";
			// 
			// BTN_Contact
			// 
			this.BTN_Contact.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BTN_Contact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BTN_Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BTN_Contact.ForeColor = System.Drawing.Color.Turquoise;
			this.BTN_Contact.Location = new System.Drawing.Point(611, 482);
			this.BTN_Contact.Margin = new System.Windows.Forms.Padding(2);
			this.BTN_Contact.Name = "BTN_Contact";
			this.BTN_Contact.Size = new System.Drawing.Size(351, 47);
			this.BTN_Contact.TabIndex = 12;
			this.BTN_Contact.Text = "Contact Us";
			this.BTN_Contact.UseVisualStyleBackColor = false;
			this.BTN_Contact.Click += new System.EventHandler(this.button1_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label4.Location = new System.Drawing.Point(239, 334);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(188, 45);
			this.label4.TabIndex = 13;
			this.label4.Text = "Services";
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.OrangeRed;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Location = new System.Drawing.Point(611, 0);
			this.button3.Margin = new System.Windows.Forms.Padding(2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(56, 42);
			this.button3.TabIndex = 14;
			this.button3.Text = "🏠";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// LBL_Name
			// 
			this.LBL_Name.BackColor = System.Drawing.Color.Transparent;
			this.LBL_Name.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LBL_Name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.LBL_Name.Location = new System.Drawing.Point(717, 9);
			this.LBL_Name.Name = "LBL_Name";
			this.LBL_Name.Size = new System.Drawing.Size(204, 23);
			this.LBL_Name.TabIndex = 15;
			this.LBL_Name.Text = "Welcome ";
			this.LBL_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.LBL_Name.Visible = false;
			// 
			// BTN_LogOut
			// 
			this.BTN_LogOut.BackColor = System.Drawing.Color.OrangeRed;
			this.BTN_LogOut.FlatAppearance.BorderSize = 0;
			this.BTN_LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BTN_LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BTN_LogOut.ForeColor = System.Drawing.Color.White;
			this.BTN_LogOut.Location = new System.Drawing.Point(926, 3);
			this.BTN_LogOut.Margin = new System.Windows.Forms.Padding(2);
			this.BTN_LogOut.Name = "BTN_LogOut";
			this.BTN_LogOut.Size = new System.Drawing.Size(32, 36);
			this.BTN_LogOut.TabIndex = 14;
			this.BTN_LogOut.Text = "🔄";
			this.BTN_LogOut.UseVisualStyleBackColor = false;
			this.BTN_LogOut.Visible = false;
			this.BTN_LogOut.Click += new System.EventHandler(this.BTN_LogOut_Click);
			// 
			// FRM_Home
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(961, 529);
			this.Controls.Add(this.BTN_Login);
			this.Controls.Add(this.LBL_Name);
			this.Controls.Add(this.BTN_LogOut);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.BTN_Contact);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.BTN_CancelRes);
			this.Controls.Add(this.BTN_ViewRes);
			this.Controls.Add(this.BTN_Fligth);
			this.Controls.Add(this.BTN_Book);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.HelpButton = true;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FRM_Home";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTN_Fligth;
        private System.Windows.Forms.Button BTN_Login;
        private System.Windows.Forms.Button BTN_Book;
        private System.Windows.Forms.Button BTN_CancelRes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_Contact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label LBL_Name;
		private System.Windows.Forms.Button BTN_ViewRes;
		private System.Windows.Forms.Button BTN_LogOut;
	}
}

