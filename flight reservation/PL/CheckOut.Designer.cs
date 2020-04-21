namespace flight_reservation.PL
{
	partial class CheckOut
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.DGV_Flights = new System.Windows.Forms.DataGridView();
			this.button3 = new System.Windows.Forms.Button();
			this.BTN_Book = new System.Windows.Forms.Button();
			this.BTN_ConfirmTime = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.CB_Sets = new System.Windows.Forms.ComboBox();
			this.BTN_ChangeFligth = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.LBL_Price = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.DGV_Flights)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// DGV_Flights
			// 
			this.DGV_Flights.AllowUserToAddRows = false;
			this.DGV_Flights.AllowUserToDeleteRows = false;
			this.DGV_Flights.AllowUserToOrderColumns = true;
			this.DGV_Flights.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DGV_Flights.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.DGV_Flights.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumTurquoise;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightCyan;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DGV_Flights.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.DGV_Flights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.LightSeaGreen;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkCyan;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DGV_Flights.DefaultCellStyle = dataGridViewCellStyle4;
			this.DGV_Flights.GridColor = System.Drawing.Color.Turquoise;
			this.DGV_Flights.Location = new System.Drawing.Point(57, 38);
			this.DGV_Flights.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.DGV_Flights.MultiSelect = false;
			this.DGV_Flights.Name = "DGV_Flights";
			this.DGV_Flights.ReadOnly = true;
			this.DGV_Flights.RowHeadersWidth = 51;
			this.DGV_Flights.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DGV_Flights.ShowCellErrors = false;
			this.DGV_Flights.ShowEditingIcon = false;
			this.DGV_Flights.ShowRowErrors = false;
			this.DGV_Flights.Size = new System.Drawing.Size(768, 295);
			this.DGV_Flights.TabIndex = 2;
			this.DGV_Flights.SelectionChanged += new System.EventHandler(this.DGV_Flights_SelectionChanged);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.OrangeRed;
			this.button3.Dock = System.Windows.Forms.DockStyle.Right;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button3.Location = new System.Drawing.Point(849, 0);
			this.button3.Margin = new System.Windows.Forms.Padding(2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(88, 527);
			this.button3.TabIndex = 40;
			this.button3.Text = "⬅";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// BTN_Book
			// 
			this.BTN_Book.BackColor = System.Drawing.Color.OrangeRed;
			this.BTN_Book.FlatAppearance.BorderSize = 0;
			this.BTN_Book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BTN_Book.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BTN_Book.ForeColor = System.Drawing.Color.White;
			this.BTN_Book.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.BTN_Book.Location = new System.Drawing.Point(470, 476);
			this.BTN_Book.Margin = new System.Windows.Forms.Padding(2);
			this.BTN_Book.Name = "BTN_Book";
			this.BTN_Book.Size = new System.Drawing.Size(189, 36);
			this.BTN_Book.TabIndex = 41;
			this.BTN_Book.Text = "Book";
			this.BTN_Book.UseVisualStyleBackColor = false;
			this.BTN_Book.Visible = false;
			this.BTN_Book.Click += new System.EventHandler(this.BTN_Book_Click);
			// 
			// BTN_ConfirmTime
			// 
			this.BTN_ConfirmTime.BackColor = System.Drawing.Color.OrangeRed;
			this.BTN_ConfirmTime.FlatAppearance.BorderSize = 0;
			this.BTN_ConfirmTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BTN_ConfirmTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BTN_ConfirmTime.ForeColor = System.Drawing.Color.White;
			this.BTN_ConfirmTime.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.BTN_ConfirmTime.Location = new System.Drawing.Point(372, 349);
			this.BTN_ConfirmTime.Margin = new System.Windows.Forms.Padding(2);
			this.BTN_ConfirmTime.Name = "BTN_ConfirmTime";
			this.BTN_ConfirmTime.Size = new System.Drawing.Size(189, 36);
			this.BTN_ConfirmTime.TabIndex = 41;
			this.BTN_ConfirmTime.Text = "Confirm Time";
			this.BTN_ConfirmTime.UseVisualStyleBackColor = false;
			this.BTN_ConfirmTime.Click += new System.EventHandler(this.BTN_ConfirmTime_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.LBL_Price);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.CB_Sets);
			this.panel1.Location = new System.Drawing.Point(367, 357);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 107);
			this.panel1.TabIndex = 42;
			this.panel1.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(45, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 17);
			this.label1.TabIndex = 45;
			this.label1.Text = "Number Of Sets";
			// 
			// CB_Sets
			// 
			this.CB_Sets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CB_Sets.FormattingEnabled = true;
			this.CB_Sets.Location = new System.Drawing.Point(35, 52);
			this.CB_Sets.Name = "CB_Sets";
			this.CB_Sets.Size = new System.Drawing.Size(140, 24);
			this.CB_Sets.TabIndex = 44;
			this.CB_Sets.SelectedIndexChanged += new System.EventHandler(this.CB_Sets_SelectedIndexChanged);
			// 
			// BTN_ChangeFligth
			// 
			this.BTN_ChangeFligth.BackColor = System.Drawing.Color.OrangeRed;
			this.BTN_ChangeFligth.FlatAppearance.BorderSize = 0;
			this.BTN_ChangeFligth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BTN_ChangeFligth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BTN_ChangeFligth.ForeColor = System.Drawing.Color.White;
			this.BTN_ChangeFligth.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.BTN_ChangeFligth.Location = new System.Drawing.Point(271, 476);
			this.BTN_ChangeFligth.Margin = new System.Windows.Forms.Padding(2);
			this.BTN_ChangeFligth.Name = "BTN_ChangeFligth";
			this.BTN_ChangeFligth.Size = new System.Drawing.Size(175, 36);
			this.BTN_ChangeFligth.TabIndex = 40;
			this.BTN_ChangeFligth.Text = "Change Fligth";
			this.BTN_ChangeFligth.UseVisualStyleBackColor = false;
			this.BTN_ChangeFligth.Visible = false;
			this.BTN_ChangeFligth.Click += new System.EventHandler(this.BTN_ChangeFligth_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(38, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 17);
			this.label2.TabIndex = 46;
			this.label2.Text = "You Will Pay";
			// 
			// LBL_Price
			// 
			this.LBL_Price.AutoSize = true;
			this.LBL_Price.Location = new System.Drawing.Point(121, 82);
			this.LBL_Price.Name = "LBL_Price";
			this.LBL_Price.Size = new System.Drawing.Size(0, 17);
			this.LBL_Price.TabIndex = 47;
			// 
			// CheckOut
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(937, 527);
			this.Controls.Add(this.BTN_ConfirmTime);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.BTN_ChangeFligth);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.BTN_Book);
			this.Controls.Add(this.DGV_Flights);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "CheckOut";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CheckOut";
			((System.ComponentModel.ISupportInitialize)(this.DGV_Flights)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		public System.Windows.Forms.DataGridView DGV_Flights;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button BTN_Book;
		private System.Windows.Forms.Button BTN_ConfirmTime;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox CB_Sets;
		private System.Windows.Forms.Button BTN_ChangeFligth;
		private System.Windows.Forms.Label LBL_Price;
		private System.Windows.Forms.Label label2;
	}
}