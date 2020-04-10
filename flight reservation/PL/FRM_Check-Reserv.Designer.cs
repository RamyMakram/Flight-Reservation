namespace flight_reservation
{
    partial class Form3
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
			this.button3 = new System.Windows.Forms.Button();
			this.BTN_Search = new System.Windows.Forms.Button();
			this.CB_Class = new System.Windows.Forms.ComboBox();
			this.CB_From = new System.Windows.Forms.ComboBox();
			this.CB_To = new System.Windows.Forms.ComboBox();
			this.label18 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
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
			this.button3.Location = new System.Drawing.Point(729, 229);
			this.button3.Margin = new System.Windows.Forms.Padding(2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(112, 36);
			this.button3.TabIndex = 19;
			this.button3.Text = "Back";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// BTN_Search
			// 
			this.BTN_Search.BackColor = System.Drawing.Color.OrangeRed;
			this.BTN_Search.FlatAppearance.BorderSize = 0;
			this.BTN_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BTN_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BTN_Search.ForeColor = System.Drawing.Color.White;
			this.BTN_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.BTN_Search.Location = new System.Drawing.Point(382, 174);
			this.BTN_Search.Margin = new System.Windows.Forms.Padding(2);
			this.BTN_Search.Name = "BTN_Search";
			this.BTN_Search.Size = new System.Drawing.Size(112, 36);
			this.BTN_Search.TabIndex = 20;
			this.BTN_Search.Text = "Search";
			this.BTN_Search.UseVisualStyleBackColor = false;
			this.BTN_Search.Click += new System.EventHandler(this.BTN_Search_Click);
			// 
			// CB_Class
			// 
			this.CB_Class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CB_Class.FormattingEnabled = true;
			this.CB_Class.Items.AddRange(new object[] {
            "Class A",
            "Class B",
            "Economy",
            "High",
            "VIP"});
			this.CB_Class.Location = new System.Drawing.Point(574, 108);
			this.CB_Class.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.CB_Class.Name = "CB_Class";
			this.CB_Class.Size = new System.Drawing.Size(205, 24);
			this.CB_Class.TabIndex = 70;
			// 
			// CB_From
			// 
			this.CB_From.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CB_From.FormattingEnabled = true;
			this.CB_From.Location = new System.Drawing.Point(68, 108);
			this.CB_From.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.CB_From.Name = "CB_From";
			this.CB_From.Size = new System.Drawing.Size(205, 24);
			this.CB_From.TabIndex = 69;
			// 
			// CB_To
			// 
			this.CB_To.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CB_To.FormattingEnabled = true;
			this.CB_To.Location = new System.Drawing.Point(321, 108);
			this.CB_To.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.CB_To.Name = "CB_To";
			this.CB_To.Size = new System.Drawing.Size(205, 24);
			this.CB_To.TabIndex = 68;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.BackColor = System.Drawing.Color.Transparent;
			this.label18.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.ForeColor = System.Drawing.Color.OrangeRed;
			this.label18.Location = new System.Drawing.Point(570, 76);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(55, 19);
			this.label18.TabIndex = 66;
			this.label18.Text = "Class";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.OrangeRed;
			this.label8.Location = new System.Drawing.Point(320, 76);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(31, 19);
			this.label8.TabIndex = 67;
			this.label8.Text = "To";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.OrangeRed;
			this.label7.Location = new System.Drawing.Point(66, 76);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(52, 19);
			this.label7.TabIndex = 65;
			this.label7.Text = "From";
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(853, 285);
			this.Controls.Add(this.CB_Class);
			this.Controls.Add(this.CB_From);
			this.Controls.Add(this.CB_To);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.BTN_Search);
			this.Controls.Add(this.button3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form3";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Flights";
			this.Load += new System.EventHandler(this.Form3_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BTN_Search;
		private System.Windows.Forms.ComboBox CB_Class;
		private System.Windows.Forms.ComboBox CB_From;
		private System.Windows.Forms.ComboBox CB_To;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
	}
}