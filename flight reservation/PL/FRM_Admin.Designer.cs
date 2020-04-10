namespace flight_reservation.PL
{
	partial class FRM_Admin
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
			if (System.Windows.Forms.MessageBox.Show("Are You Want To Close Program?😢😢", "Confirm", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
			{
				if (disposing && (components != null))
				{
					components.Dispose();
				}
				base.Dispose(disposing);
			}
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.BTN_AddPass = new System.Windows.Forms.Button();
			this.TXT_Phone = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.TXT_Pass = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.TXT_Mail = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.TXT_LName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.TXT_FName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.BTN_SavePass = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.DGV_Pass = new System.Windows.Forms.DataGridView();
			this.PASSENGER_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PASSENGER_FNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PASSENGER_LNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PASSENGER_EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PASSENGER_PASSWORD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PASSENGER_PHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
			this.View = new System.Windows.Forms.DataGridViewButtonColumn();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.BTN_AddAir = new System.Windows.Forms.Button();
			this.TXT_AirCity = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.TXT_AirID = new System.Windows.Forms.TextBox();
			this.TXT_AirName = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.BTN_SaveAir = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.DGV_AirPort = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
			this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.TXT_PlaneSets = new System.Windows.Forms.NumericUpDown();
			this.BTN_AddPlane = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.TXT_PlaneID = new System.Windows.Forms.TextBox();
			this.TXT_PlaneName = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.BTN_SavePlane = new System.Windows.Forms.Button();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.DGV_Planes = new System.Windows.Forms.DataGridView();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.DGV_Flights = new System.Windows.Forms.DataGridView();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.TXT_FlightPrice = new System.Windows.Forms.NumericUpDown();
			this.CB_From = new System.Windows.Forms.ComboBox();
			this.CB_Sate = new System.Windows.Forms.ComboBox();
			this.CB_To = new System.Windows.Forms.ComboBox();
			this.TXT_FligthID = new System.Windows.Forms.TextBox();
			this.D_FlightFrom = new System.Windows.Forms.DateTimePicker();
			this.D_FlightTo = new System.Windows.Forms.DateTimePicker();
			this.BTN_AddFligth = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.BTN_SaveFlight = new System.Windows.Forms.Button();
			this.Save_Admin = new System.Windows.Forms.Button();
			this.groupBox9 = new System.Windows.Forms.GroupBox();
			this.DGV_Admin = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewButtonColumn6 = new System.Windows.Forms.DataGridViewButtonColumn();
			this.dataGridViewButtonColumn7 = new System.Windows.Forms.DataGridViewButtonColumn();
			this.label16 = new System.Windows.Forms.Label();
			this.CB_FligthPNum = new System.Windows.Forms.ComboBox();
			this.F_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FROM_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FROM_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TO_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TO_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.STATUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PlaneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewButtonColumn4 = new System.Windows.Forms.DataGridViewButtonColumn();
			this.dataGridViewButtonColumn5 = new System.Windows.Forms.DataGridViewButtonColumn();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewButtonColumn3 = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
			this.View_Fligths = new System.Windows.Forms.DataGridViewButtonColumn();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DGV_Pass)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DGV_AirPort)).BeginInit();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TXT_PlaneSets)).BeginInit();
			this.groupBox6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DGV_Planes)).BeginInit();
			this.groupBox7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DGV_Flights)).BeginInit();
			this.groupBox8.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TXT_FlightPrice)).BeginInit();
			this.groupBox9.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DGV_Admin)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.BTN_AddPass);
			this.groupBox1.Controls.Add(this.TXT_Phone);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.TXT_Pass);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.TXT_Mail);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.TXT_LName);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.TXT_FName);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.BTN_SavePass);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(774, 158);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Passengers";
			// 
			// BTN_AddPass
			// 
			this.BTN_AddPass.Location = new System.Drawing.Point(354, 117);
			this.BTN_AddPass.Name = "BTN_AddPass";
			this.BTN_AddPass.Size = new System.Drawing.Size(75, 23);
			this.BTN_AddPass.TabIndex = 2;
			this.BTN_AddPass.Text = "Add";
			this.BTN_AddPass.UseVisualStyleBackColor = true;
			this.BTN_AddPass.Click += new System.EventHandler(this.BTN_AddPass_Click);
			// 
			// TXT_Phone
			// 
			this.TXT_Phone.Location = new System.Drawing.Point(459, 70);
			this.TXT_Phone.Name = "TXT_Phone";
			this.TXT_Phone.Size = new System.Drawing.Size(156, 24);
			this.TXT_Phone.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(411, 74);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(47, 17);
			this.label6.TabIndex = 0;
			this.label6.Text = "Phone";
			// 
			// TXT_Pass
			// 
			this.TXT_Pass.Location = new System.Drawing.Point(225, 70);
			this.TXT_Pass.Name = "TXT_Pass";
			this.TXT_Pass.Size = new System.Drawing.Size(156, 24);
			this.TXT_Pass.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(177, 74);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 17);
			this.label5.TabIndex = 0;
			this.label5.Text = "Pass";
			// 
			// TXT_Mail
			// 
			this.TXT_Mail.Location = new System.Drawing.Point(566, 32);
			this.TXT_Mail.Name = "TXT_Mail";
			this.TXT_Mail.Size = new System.Drawing.Size(156, 24);
			this.TXT_Mail.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(518, 36);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 17);
			this.label4.TabIndex = 0;
			this.label4.Text = "Mail";
			// 
			// TXT_LName
			// 
			this.TXT_LName.Location = new System.Drawing.Point(329, 32);
			this.TXT_LName.Name = "TXT_LName";
			this.TXT_LName.Size = new System.Drawing.Size(156, 24);
			this.TXT_LName.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(274, 36);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 17);
			this.label3.TabIndex = 0;
			this.label3.Text = "L Name";
			// 
			// TXT_FName
			// 
			this.TXT_FName.Location = new System.Drawing.Point(103, 32);
			this.TXT_FName.Name = "TXT_FName";
			this.TXT_FName.Size = new System.Drawing.Size(156, 24);
			this.TXT_FName.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(40, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "F Name";
			// 
			// BTN_SavePass
			// 
			this.BTN_SavePass.Location = new System.Drawing.Point(354, 117);
			this.BTN_SavePass.Name = "BTN_SavePass";
			this.BTN_SavePass.Size = new System.Drawing.Size(75, 23);
			this.BTN_SavePass.TabIndex = 2;
			this.BTN_SavePass.Text = "Save";
			this.BTN_SavePass.UseVisualStyleBackColor = true;
			this.BTN_SavePass.Visible = false;
			this.BTN_SavePass.Click += new System.EventHandler(this.BTN_SavePass_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.DGV_Pass);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox2.Location = new System.Drawing.Point(0, 158);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(774, 232);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Passengers";
			// 
			// DGV_Pass
			// 
			this.DGV_Pass.AllowUserToDeleteRows = false;
			this.DGV_Pass.AllowUserToOrderColumns = true;
			this.DGV_Pass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DGV_Pass.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumTurquoise;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightCyan;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DGV_Pass.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.DGV_Pass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGV_Pass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PASSENGER_ID,
            this.PASSENGER_FNAME,
            this.PASSENGER_LNAME,
            this.PASSENGER_EMAIL,
            this.PASSENGER_PASSWORD,
            this.PASSENGER_PHONE,
            this.Delete,
            this.View});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightSeaGreen;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkCyan;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DGV_Pass.DefaultCellStyle = dataGridViewCellStyle2;
			this.DGV_Pass.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DGV_Pass.GridColor = System.Drawing.Color.Turquoise;
			this.DGV_Pass.Location = new System.Drawing.Point(3, 20);
			this.DGV_Pass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.DGV_Pass.Name = "DGV_Pass";
			this.DGV_Pass.ReadOnly = true;
			this.DGV_Pass.RowHeadersWidth = 51;
			this.DGV_Pass.Size = new System.Drawing.Size(768, 209);
			this.DGV_Pass.TabIndex = 1;
			this.DGV_Pass.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Pass_CellClick);
			// 
			// PASSENGER_ID
			// 
			this.PASSENGER_ID.HeaderText = "Passanger ID";
			this.PASSENGER_ID.MinimumWidth = 6;
			this.PASSENGER_ID.Name = "PASSENGER_ID";
			this.PASSENGER_ID.ReadOnly = true;
			this.PASSENGER_ID.Visible = false;
			// 
			// PASSENGER_FNAME
			// 
			this.PASSENGER_FNAME.FillWeight = 122.5225F;
			this.PASSENGER_FNAME.HeaderText = "First Name";
			this.PASSENGER_FNAME.MinimumWidth = 6;
			this.PASSENGER_FNAME.Name = "PASSENGER_FNAME";
			this.PASSENGER_FNAME.ReadOnly = true;
			// 
			// PASSENGER_LNAME
			// 
			this.PASSENGER_LNAME.FillWeight = 122.5225F;
			this.PASSENGER_LNAME.HeaderText = "Last Name";
			this.PASSENGER_LNAME.MinimumWidth = 6;
			this.PASSENGER_LNAME.Name = "PASSENGER_LNAME";
			this.PASSENGER_LNAME.ReadOnly = true;
			// 
			// PASSENGER_EMAIL
			// 
			this.PASSENGER_EMAIL.FillWeight = 122.5225F;
			this.PASSENGER_EMAIL.HeaderText = "Email";
			this.PASSENGER_EMAIL.MinimumWidth = 6;
			this.PASSENGER_EMAIL.Name = "PASSENGER_EMAIL";
			this.PASSENGER_EMAIL.ReadOnly = true;
			// 
			// PASSENGER_PASSWORD
			// 
			this.PASSENGER_PASSWORD.FillWeight = 122.5225F;
			this.PASSENGER_PASSWORD.HeaderText = "Password";
			this.PASSENGER_PASSWORD.MinimumWidth = 6;
			this.PASSENGER_PASSWORD.Name = "PASSENGER_PASSWORD";
			this.PASSENGER_PASSWORD.ReadOnly = true;
			// 
			// PASSENGER_PHONE
			// 
			this.PASSENGER_PHONE.FillWeight = 122.5225F;
			this.PASSENGER_PHONE.HeaderText = "Phone";
			this.PASSENGER_PHONE.MinimumWidth = 6;
			this.PASSENGER_PHONE.Name = "PASSENGER_PHONE";
			this.PASSENGER_PHONE.ReadOnly = true;
			// 
			// Delete
			// 
			this.Delete.FillWeight = 42.46774F;
			this.Delete.HeaderText = "❌";
			this.Delete.MinimumWidth = 12;
			this.Delete.Name = "Delete";
			this.Delete.ReadOnly = true;
			this.Delete.Text = "❌";
			this.Delete.ToolTipText = "Delete";
			this.Delete.UseColumnTextForButtonValue = true;
			// 
			// View
			// 
			this.View.FillWeight = 44.91978F;
			this.View.HeaderText = "👁‍🗨";
			this.View.MinimumWidth = 12;
			this.View.Name = "View";
			this.View.ReadOnly = true;
			this.View.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.View.Text = "👁‍🗨";
			this.View.ToolTipText = "View Fligths";
			this.View.UseColumnTextForButtonValue = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.BTN_AddAir);
			this.groupBox3.Controls.Add(this.TXT_AirCity);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.TXT_AirID);
			this.groupBox3.Controls.Add(this.TXT_AirName);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Controls.Add(this.BTN_SaveAir);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox3.Location = new System.Drawing.Point(0, 390);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(774, 137);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Airport";
			// 
			// BTN_AddAir
			// 
			this.BTN_AddAir.Location = new System.Drawing.Point(362, 95);
			this.BTN_AddAir.Name = "BTN_AddAir";
			this.BTN_AddAir.Size = new System.Drawing.Size(75, 23);
			this.BTN_AddAir.TabIndex = 2;
			this.BTN_AddAir.Text = "Add";
			this.BTN_AddAir.UseVisualStyleBackColor = true;
			this.BTN_AddAir.Click += new System.EventHandler(this.BTN_AddAir_Click);
			// 
			// TXT_AirCity
			// 
			this.TXT_AirCity.Location = new System.Drawing.Point(451, 46);
			this.TXT_AirCity.Name = "TXT_AirCity";
			this.TXT_AirCity.Size = new System.Drawing.Size(156, 24);
			this.TXT_AirCity.TabIndex = 1;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(416, 50);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(32, 17);
			this.label9.TabIndex = 0;
			this.label9.Text = "City";
			// 
			// TXT_AirID
			// 
			this.TXT_AirID.Location = new System.Drawing.Point(58, 78);
			this.TXT_AirID.Name = "TXT_AirID";
			this.TXT_AirID.Size = new System.Drawing.Size(15, 24);
			this.TXT_AirID.TabIndex = 1;
			this.TXT_AirID.Visible = false;
			// 
			// TXT_AirName
			// 
			this.TXT_AirName.Location = new System.Drawing.Point(225, 46);
			this.TXT_AirName.Name = "TXT_AirName";
			this.TXT_AirName.Size = new System.Drawing.Size(156, 24);
			this.TXT_AirName.TabIndex = 1;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(162, 50);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(43, 17);
			this.label10.TabIndex = 0;
			this.label10.Text = "Name";
			// 
			// BTN_SaveAir
			// 
			this.BTN_SaveAir.Location = new System.Drawing.Point(362, 95);
			this.BTN_SaveAir.Name = "BTN_SaveAir";
			this.BTN_SaveAir.Size = new System.Drawing.Size(75, 23);
			this.BTN_SaveAir.TabIndex = 2;
			this.BTN_SaveAir.Text = "Save";
			this.BTN_SaveAir.UseVisualStyleBackColor = true;
			this.BTN_SaveAir.Visible = false;
			this.BTN_SaveAir.Click += new System.EventHandler(this.BTN_SaveAir_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.DGV_AirPort);
			this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox4.Location = new System.Drawing.Point(0, 527);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(774, 232);
			this.groupBox4.TabIndex = 4;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "AirPorts";
			// 
			// DGV_AirPort
			// 
			this.DGV_AirPort.AllowUserToDeleteRows = false;
			this.DGV_AirPort.AllowUserToOrderColumns = true;
			this.DGV_AirPort.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DGV_AirPort.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumTurquoise;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightCyan;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DGV_AirPort.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.DGV_AirPort.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGV_AirPort.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewButtonColumn1,
            this.dataGridViewButtonColumn2});
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.LightSeaGreen;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkCyan;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DGV_AirPort.DefaultCellStyle = dataGridViewCellStyle4;
			this.DGV_AirPort.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DGV_AirPort.GridColor = System.Drawing.Color.Turquoise;
			this.DGV_AirPort.Location = new System.Drawing.Point(3, 20);
			this.DGV_AirPort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.DGV_AirPort.Name = "DGV_AirPort";
			this.DGV_AirPort.ReadOnly = true;
			this.DGV_AirPort.RowHeadersWidth = 51;
			this.DGV_AirPort.Size = new System.Drawing.Size(768, 209);
			this.DGV_AirPort.TabIndex = 1;
			this.DGV_AirPort.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_AirPort_CellClick);
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.MinimumWidth = 6;
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.FillWeight = 122.5225F;
			this.dataGridViewTextBoxColumn2.HeaderText = "Name";
			this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.FillWeight = 122.5225F;
			this.dataGridViewTextBoxColumn3.HeaderText = "CityName";
			this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewButtonColumn1
			// 
			this.dataGridViewButtonColumn1.FillWeight = 42.46774F;
			this.dataGridViewButtonColumn1.HeaderText = "❌";
			this.dataGridViewButtonColumn1.MinimumWidth = 12;
			this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
			this.dataGridViewButtonColumn1.ReadOnly = true;
			this.dataGridViewButtonColumn1.Text = "❌";
			this.dataGridViewButtonColumn1.ToolTipText = "Delete";
			this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
			// 
			// dataGridViewButtonColumn2
			// 
			this.dataGridViewButtonColumn2.FillWeight = 44.91978F;
			this.dataGridViewButtonColumn2.HeaderText = "✏";
			this.dataGridViewButtonColumn2.MinimumWidth = 12;
			this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
			this.dataGridViewButtonColumn2.ReadOnly = true;
			this.dataGridViewButtonColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewButtonColumn2.Text = "✏";
			this.dataGridViewButtonColumn2.ToolTipText = "Edit";
			this.dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.TXT_PlaneSets);
			this.groupBox5.Controls.Add(this.BTN_AddPlane);
			this.groupBox5.Controls.Add(this.label2);
			this.groupBox5.Controls.Add(this.TXT_PlaneID);
			this.groupBox5.Controls.Add(this.TXT_PlaneName);
			this.groupBox5.Controls.Add(this.label7);
			this.groupBox5.Controls.Add(this.BTN_SavePlane);
			this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox5.Location = new System.Drawing.Point(0, 759);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(774, 137);
			this.groupBox5.TabIndex = 5;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "AirPlane";
			// 
			// TXT_PlaneSets
			// 
			this.TXT_PlaneSets.Location = new System.Drawing.Point(487, 48);
			this.TXT_PlaneSets.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
			this.TXT_PlaneSets.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
			this.TXT_PlaneSets.Name = "TXT_PlaneSets";
			this.TXT_PlaneSets.Size = new System.Drawing.Size(120, 24);
			this.TXT_PlaneSets.TabIndex = 3;
			this.TXT_PlaneSets.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
			// 
			// BTN_AddPlane
			// 
			this.BTN_AddPlane.Location = new System.Drawing.Point(324, 96);
			this.BTN_AddPlane.Name = "BTN_AddPlane";
			this.BTN_AddPlane.Size = new System.Drawing.Size(75, 23);
			this.BTN_AddPlane.TabIndex = 2;
			this.BTN_AddPlane.Text = "Add";
			this.BTN_AddPlane.UseVisualStyleBackColor = true;
			this.BTN_AddPlane.Click += new System.EventHandler(this.BTN_AddPlane_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(378, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(107, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Number Os Sets";
			// 
			// TXT_PlaneID
			// 
			this.TXT_PlaneID.Location = new System.Drawing.Point(138, 96);
			this.TXT_PlaneID.Name = "TXT_PlaneID";
			this.TXT_PlaneID.Size = new System.Drawing.Size(13, 24);
			this.TXT_PlaneID.TabIndex = 1;
			this.TXT_PlaneID.Visible = false;
			// 
			// TXT_PlaneName
			// 
			this.TXT_PlaneName.Location = new System.Drawing.Point(187, 48);
			this.TXT_PlaneName.Name = "TXT_PlaneName";
			this.TXT_PlaneName.Size = new System.Drawing.Size(156, 24);
			this.TXT_PlaneName.TabIndex = 1;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(124, 52);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(43, 17);
			this.label7.TabIndex = 0;
			this.label7.Text = "Name";
			// 
			// BTN_SavePlane
			// 
			this.BTN_SavePlane.Location = new System.Drawing.Point(324, 97);
			this.BTN_SavePlane.Name = "BTN_SavePlane";
			this.BTN_SavePlane.Size = new System.Drawing.Size(75, 23);
			this.BTN_SavePlane.TabIndex = 2;
			this.BTN_SavePlane.Text = "Save";
			this.BTN_SavePlane.UseVisualStyleBackColor = true;
			this.BTN_SavePlane.Visible = false;
			this.BTN_SavePlane.Click += new System.EventHandler(this.BTN_SavePlane_Click);
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.DGV_Planes);
			this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox6.Location = new System.Drawing.Point(0, 896);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(774, 232);
			this.groupBox6.TabIndex = 6;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Planes";
			// 
			// DGV_Planes
			// 
			this.DGV_Planes.AllowUserToDeleteRows = false;
			this.DGV_Planes.AllowUserToOrderColumns = true;
			this.DGV_Planes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DGV_Planes.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.MediumTurquoise;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightCyan;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DGV_Planes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.DGV_Planes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGV_Planes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewButtonColumn3,
            this.Edit,
            this.View_Fligths});
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.LightSeaGreen;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkCyan;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DGV_Planes.DefaultCellStyle = dataGridViewCellStyle6;
			this.DGV_Planes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DGV_Planes.GridColor = System.Drawing.Color.Turquoise;
			this.DGV_Planes.Location = new System.Drawing.Point(3, 20);
			this.DGV_Planes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.DGV_Planes.Name = "DGV_Planes";
			this.DGV_Planes.ReadOnly = true;
			this.DGV_Planes.RowHeadersWidth = 51;
			this.DGV_Planes.Size = new System.Drawing.Size(768, 209);
			this.DGV_Planes.TabIndex = 1;
			this.DGV_Planes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Planes_CellClick);
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.DGV_Flights);
			this.groupBox7.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox7.Location = new System.Drawing.Point(0, 1349);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(774, 232);
			this.groupBox7.TabIndex = 8;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Flights";
			// 
			// DGV_Flights
			// 
			this.DGV_Flights.AllowUserToDeleteRows = false;
			this.DGV_Flights.AllowUserToOrderColumns = true;
			this.DGV_Flights.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DGV_Flights.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.MediumTurquoise;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightCyan;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DGV_Flights.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.DGV_Flights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGV_Flights.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.F_ID,
            this.FROM_CODE,
            this.FROM_TIME,
            this.TO_CODE,
            this.TO_TIME,
            this.PRICE,
            this.STATUE,
            this.PlaneNumber,
            this.dataGridViewButtonColumn4,
            this.dataGridViewButtonColumn5});
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.LightSeaGreen;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkCyan;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DGV_Flights.DefaultCellStyle = dataGridViewCellStyle8;
			this.DGV_Flights.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DGV_Flights.GridColor = System.Drawing.Color.Turquoise;
			this.DGV_Flights.Location = new System.Drawing.Point(3, 20);
			this.DGV_Flights.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.DGV_Flights.Name = "DGV_Flights";
			this.DGV_Flights.RowHeadersWidth = 51;
			this.DGV_Flights.Size = new System.Drawing.Size(768, 209);
			this.DGV_Flights.TabIndex = 1;
			this.DGV_Flights.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Flights_CellClick);
			// 
			// groupBox8
			// 
			this.groupBox8.Controls.Add(this.TXT_FlightPrice);
			this.groupBox8.Controls.Add(this.CB_From);
			this.groupBox8.Controls.Add(this.CB_FligthPNum);
			this.groupBox8.Controls.Add(this.CB_Sate);
			this.groupBox8.Controls.Add(this.CB_To);
			this.groupBox8.Controls.Add(this.TXT_FligthID);
			this.groupBox8.Controls.Add(this.D_FlightFrom);
			this.groupBox8.Controls.Add(this.D_FlightTo);
			this.groupBox8.Controls.Add(this.BTN_AddFligth);
			this.groupBox8.Controls.Add(this.label8);
			this.groupBox8.Controls.Add(this.label15);
			this.groupBox8.Controls.Add(this.label11);
			this.groupBox8.Controls.Add(this.label16);
			this.groupBox8.Controls.Add(this.label12);
			this.groupBox8.Controls.Add(this.label13);
			this.groupBox8.Controls.Add(this.label14);
			this.groupBox8.Controls.Add(this.BTN_SaveFlight);
			this.groupBox8.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox8.Location = new System.Drawing.Point(0, 1128);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size(774, 221);
			this.groupBox8.TabIndex = 7;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = "Flight";
			// 
			// TXT_FlightPrice
			// 
			this.TXT_FlightPrice.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.TXT_FlightPrice.Location = new System.Drawing.Point(476, 86);
			this.TXT_FlightPrice.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.TXT_FlightPrice.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.TXT_FlightPrice.Name = "TXT_FlightPrice";
			this.TXT_FlightPrice.Size = new System.Drawing.Size(120, 24);
			this.TXT_FlightPrice.TabIndex = 6;
			this.TXT_FlightPrice.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// CB_From
			// 
			this.CB_From.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.CB_From.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.CB_From.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CB_From.FormattingEnabled = true;
			this.CB_From.Location = new System.Drawing.Point(175, 37);
			this.CB_From.Name = "CB_From";
			this.CB_From.Size = new System.Drawing.Size(121, 24);
			this.CB_From.Sorted = true;
			this.CB_From.TabIndex = 5;
			// 
			// CB_Sate
			// 
			this.CB_Sate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.CB_Sate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.CB_Sate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CB_Sate.FormattingEnabled = true;
			this.CB_Sate.Items.AddRange(new object[] {
            "Class A",
            "Class B",
            "Economy",
            "High",
            "VIP"});
			this.CB_Sate.Location = new System.Drawing.Point(577, 37);
			this.CB_Sate.Name = "CB_Sate";
			this.CB_Sate.Size = new System.Drawing.Size(121, 24);
			this.CB_Sate.Sorted = true;
			this.CB_Sate.TabIndex = 5;
			// 
			// CB_To
			// 
			this.CB_To.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.CB_To.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.CB_To.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CB_To.FormattingEnabled = true;
			this.CB_To.Location = new System.Drawing.Point(364, 37);
			this.CB_To.Name = "CB_To";
			this.CB_To.Size = new System.Drawing.Size(121, 24);
			this.CB_To.Sorted = true;
			this.CB_To.TabIndex = 5;
			// 
			// TXT_FligthID
			// 
			this.TXT_FligthID.Location = new System.Drawing.Point(91, 178);
			this.TXT_FligthID.Name = "TXT_FligthID";
			this.TXT_FligthID.Size = new System.Drawing.Size(17, 24);
			this.TXT_FligthID.TabIndex = 1;
			this.TXT_FligthID.Visible = false;
			// 
			// D_FlightFrom
			// 
			this.D_FlightFrom.Location = new System.Drawing.Point(156, 132);
			this.D_FlightFrom.Name = "D_FlightFrom";
			this.D_FlightFrom.Size = new System.Drawing.Size(237, 24);
			this.D_FlightFrom.TabIndex = 3;
			// 
			// D_FlightTo
			// 
			this.D_FlightTo.Location = new System.Drawing.Point(490, 132);
			this.D_FlightTo.Name = "D_FlightTo";
			this.D_FlightTo.Size = new System.Drawing.Size(243, 24);
			this.D_FlightTo.TabIndex = 3;
			// 
			// BTN_AddFligth
			// 
			this.BTN_AddFligth.Location = new System.Drawing.Point(333, 179);
			this.BTN_AddFligth.Name = "BTN_AddFligth";
			this.BTN_AddFligth.Size = new System.Drawing.Size(75, 23);
			this.BTN_AddFligth.TabIndex = 2;
			this.BTN_AddFligth.Text = "Add";
			this.BTN_AddFligth.UseVisualStyleBackColor = true;
			this.BTN_AddFligth.Click += new System.EventHandler(this.BTN_AddFligth_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(422, 136);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(57, 17);
			this.label8.TabIndex = 0;
			this.label8.Text = "To Date";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(416, 90);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(37, 17);
			this.label15.TabIndex = 0;
			this.label15.Text = "Price";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(72, 136);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(73, 17);
			this.label11.TabIndex = 0;
			this.label11.Text = "From Date";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(507, 41);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(48, 17);
			this.label12.TabIndex = 0;
			this.label12.Text = "Statue";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(318, 41);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(24, 17);
			this.label13.TabIndex = 0;
			this.label13.Text = "To";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(113, 41);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(40, 17);
			this.label14.TabIndex = 0;
			this.label14.Text = "From";
			// 
			// BTN_SaveFlight
			// 
			this.BTN_SaveFlight.Location = new System.Drawing.Point(333, 179);
			this.BTN_SaveFlight.Name = "BTN_SaveFlight";
			this.BTN_SaveFlight.Size = new System.Drawing.Size(75, 23);
			this.BTN_SaveFlight.TabIndex = 2;
			this.BTN_SaveFlight.Text = "Save";
			this.BTN_SaveFlight.UseVisualStyleBackColor = true;
			this.BTN_SaveFlight.Visible = false;
			this.BTN_SaveFlight.Click += new System.EventHandler(this.BTN_SaveFlight_Click);
			// 
			// Save_Admin
			// 
			this.Save_Admin.Location = new System.Drawing.Point(273, 23);
			this.Save_Admin.Name = "Save_Admin";
			this.Save_Admin.Size = new System.Drawing.Size(212, 23);
			this.Save_Admin.TabIndex = 2;
			this.Save_Admin.Text = "Save";
			this.Save_Admin.UseVisualStyleBackColor = true;
			this.Save_Admin.Click += new System.EventHandler(this.SaveTemp_Click);
			// 
			// groupBox9
			// 
			this.groupBox9.Controls.Add(this.DGV_Admin);
			this.groupBox9.Controls.Add(this.Save_Admin);
			this.groupBox9.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox9.Location = new System.Drawing.Point(0, 1581);
			this.groupBox9.Name = "groupBox9";
			this.groupBox9.Size = new System.Drawing.Size(774, 318);
			this.groupBox9.TabIndex = 9;
			this.groupBox9.TabStop = false;
			this.groupBox9.Text = "Admin";
			// 
			// DGV_Admin
			// 
			this.DGV_Admin.AllowUserToOrderColumns = true;
			this.DGV_Admin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DGV_Admin.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.MediumTurquoise;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightCyan;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DGV_Admin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.DGV_Admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGV_Admin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewButtonColumn6,
            this.dataGridViewButtonColumn7});
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle10.ForeColor = System.Drawing.Color.LightSeaGreen;
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DarkCyan;
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DGV_Admin.DefaultCellStyle = dataGridViewCellStyle10;
			this.DGV_Admin.GridColor = System.Drawing.Color.Turquoise;
			this.DGV_Admin.Location = new System.Drawing.Point(3, 64);
			this.DGV_Admin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.DGV_Admin.Name = "DGV_Admin";
			this.DGV_Admin.RowHeadersWidth = 51;
			this.DGV_Admin.Size = new System.Drawing.Size(758, 247);
			this.DGV_Admin.TabIndex = 1;
			this.DGV_Admin.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DGV_Admin_RowsAdded);
			this.DGV_Admin.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.DGV_Admin_UserAddedRow);
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.HeaderText = "ID";
			this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.Visible = false;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.HeaderText = "From";
			this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.HeaderText = "From Time";
			this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.HeaderText = "To";
			this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.HeaderText = "To Time";
			this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			// 
			// dataGridViewTextBoxColumn11
			// 
			this.dataGridViewTextBoxColumn11.HeaderText = "Price";
			this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
			// 
			// dataGridViewTextBoxColumn12
			// 
			this.dataGridViewTextBoxColumn12.HeaderText = "Class";
			this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
			// 
			// dataGridViewButtonColumn6
			// 
			this.dataGridViewButtonColumn6.FillWeight = 42.46774F;
			this.dataGridViewButtonColumn6.HeaderText = "❌";
			this.dataGridViewButtonColumn6.MinimumWidth = 12;
			this.dataGridViewButtonColumn6.Name = "dataGridViewButtonColumn6";
			this.dataGridViewButtonColumn6.Text = "❌";
			this.dataGridViewButtonColumn6.ToolTipText = "Delete";
			this.dataGridViewButtonColumn6.UseColumnTextForButtonValue = true;
			// 
			// dataGridViewButtonColumn7
			// 
			this.dataGridViewButtonColumn7.FillWeight = 44.91978F;
			this.dataGridViewButtonColumn7.HeaderText = "✏";
			this.dataGridViewButtonColumn7.MinimumWidth = 12;
			this.dataGridViewButtonColumn7.Name = "dataGridViewButtonColumn7";
			this.dataGridViewButtonColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewButtonColumn7.Text = "✏";
			this.dataGridViewButtonColumn7.ToolTipText = "Edit";
			this.dataGridViewButtonColumn7.UseColumnTextForButtonValue = true;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(166, 90);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(93, 17);
			this.label16.TabIndex = 0;
			this.label16.Text = "Plane Number";
			// 
			// CB_FligthPNum
			// 
			this.CB_FligthPNum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.CB_FligthPNum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.CB_FligthPNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CB_FligthPNum.FormattingEnabled = true;
			this.CB_FligthPNum.Location = new System.Drawing.Point(272, 86);
			this.CB_FligthPNum.Name = "CB_FligthPNum";
			this.CB_FligthPNum.Size = new System.Drawing.Size(121, 24);
			this.CB_FligthPNum.Sorted = true;
			this.CB_FligthPNum.TabIndex = 5;
			// 
			// F_ID
			// 
			this.F_ID.HeaderText = "ID";
			this.F_ID.MinimumWidth = 6;
			this.F_ID.Name = "F_ID";
			this.F_ID.Visible = false;
			// 
			// FROM_CODE
			// 
			this.FROM_CODE.HeaderText = "From";
			this.FROM_CODE.MinimumWidth = 6;
			this.FROM_CODE.Name = "FROM_CODE";
			// 
			// FROM_TIME
			// 
			this.FROM_TIME.HeaderText = "From Time";
			this.FROM_TIME.MinimumWidth = 6;
			this.FROM_TIME.Name = "FROM_TIME";
			// 
			// TO_CODE
			// 
			this.TO_CODE.HeaderText = "To";
			this.TO_CODE.MinimumWidth = 6;
			this.TO_CODE.Name = "TO_CODE";
			// 
			// TO_TIME
			// 
			this.TO_TIME.HeaderText = "To Time";
			this.TO_TIME.MinimumWidth = 6;
			this.TO_TIME.Name = "TO_TIME";
			// 
			// PRICE
			// 
			this.PRICE.HeaderText = "Price";
			this.PRICE.MinimumWidth = 6;
			this.PRICE.Name = "PRICE";
			// 
			// STATUE
			// 
			this.STATUE.HeaderText = "Class";
			this.STATUE.MinimumWidth = 6;
			this.STATUE.Name = "STATUE";
			// 
			// PlaneNumber
			// 
			this.PlaneNumber.HeaderText = "Plane Number";
			this.PlaneNumber.MinimumWidth = 6;
			this.PlaneNumber.Name = "PlaneNumber";
			// 
			// dataGridViewButtonColumn4
			// 
			this.dataGridViewButtonColumn4.FillWeight = 42.46774F;
			this.dataGridViewButtonColumn4.HeaderText = "❌";
			this.dataGridViewButtonColumn4.MinimumWidth = 12;
			this.dataGridViewButtonColumn4.Name = "dataGridViewButtonColumn4";
			this.dataGridViewButtonColumn4.Text = "❌";
			this.dataGridViewButtonColumn4.ToolTipText = "Delete";
			this.dataGridViewButtonColumn4.UseColumnTextForButtonValue = true;
			// 
			// dataGridViewButtonColumn5
			// 
			this.dataGridViewButtonColumn5.FillWeight = 44.91978F;
			this.dataGridViewButtonColumn5.HeaderText = "✏";
			this.dataGridViewButtonColumn5.MinimumWidth = 12;
			this.dataGridViewButtonColumn5.Name = "dataGridViewButtonColumn5";
			this.dataGridViewButtonColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewButtonColumn5.Text = "✏";
			this.dataGridViewButtonColumn5.ToolTipText = "Edit";
			this.dataGridViewButtonColumn5.UseColumnTextForButtonValue = true;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "ID";
			this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.FillWeight = 93.36237F;
			this.dataGridViewTextBoxColumn4.HeaderText = "Name";
			this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.FillWeight = 93.36237F;
			this.dataGridViewTextBoxColumn5.HeaderText = "Number Of Sets";
			this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// dataGridViewButtonColumn3
			// 
			this.dataGridViewButtonColumn3.FillWeight = 32.3605F;
			this.dataGridViewButtonColumn3.HeaderText = "❌";
			this.dataGridViewButtonColumn3.MinimumWidth = 12;
			this.dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
			this.dataGridViewButtonColumn3.ReadOnly = true;
			this.dataGridViewButtonColumn3.Text = "❌";
			this.dataGridViewButtonColumn3.ToolTipText = "Delete";
			this.dataGridViewButtonColumn3.UseColumnTextForButtonValue = true;
			// 
			// Edit
			// 
			this.Edit.FillWeight = 32.3605F;
			this.Edit.HeaderText = "✏";
			this.Edit.MinimumWidth = 12;
			this.Edit.Name = "Edit";
			this.Edit.ReadOnly = true;
			this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Edit.Text = "✏";
			this.Edit.ToolTipText = "Edit";
			this.Edit.UseColumnTextForButtonValue = true;
			// 
			// View_Fligths
			// 
			this.View_Fligths.FillWeight = 32.3605F;
			this.View_Fligths.HeaderText = "👁‍🗨";
			this.View_Fligths.MinimumWidth = 6;
			this.View_Fligths.Name = "View_Fligths";
			this.View_Fligths.ReadOnly = true;
			this.View_Fligths.Text = "👁‍🗨";
			this.View_Fligths.ToolTipText = "View Last Flight Time";
			this.View_Fligths.UseColumnTextForButtonValue = true;
			// 
			// FRM_Admin
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(795, 785);
			this.Controls.Add(this.groupBox9);
			this.Controls.Add(this.groupBox7);
			this.Controls.Add(this.groupBox8);
			this.Controls.Add(this.groupBox6);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FRM_Admin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Admin";
			this.Load += new System.EventHandler(this.FRM_Admin_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DGV_Pass)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DGV_AirPort)).EndInit();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.TXT_PlaneSets)).EndInit();
			this.groupBox6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DGV_Planes)).EndInit();
			this.groupBox7.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DGV_Flights)).EndInit();
			this.groupBox8.ResumeLayout(false);
			this.groupBox8.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.TXT_FlightPrice)).EndInit();
			this.groupBox9.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DGV_Admin)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox TXT_Phone;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox TXT_Pass;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox TXT_Mail;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox TXT_LName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox TXT_FName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button BTN_SavePass;
		private System.Windows.Forms.Button BTN_AddPass;
		private System.Windows.Forms.DataGridView DGV_Pass;
		private System.Windows.Forms.DataGridViewTextBoxColumn PASSENGER_ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn PASSENGER_FNAME;
		private System.Windows.Forms.DataGridViewTextBoxColumn PASSENGER_LNAME;
		private System.Windows.Forms.DataGridViewTextBoxColumn PASSENGER_EMAIL;
		private System.Windows.Forms.DataGridViewTextBoxColumn PASSENGER_PASSWORD;
		private System.Windows.Forms.DataGridViewTextBoxColumn PASSENGER_PHONE;
		private System.Windows.Forms.DataGridViewButtonColumn Delete;
		private System.Windows.Forms.DataGridViewButtonColumn View;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button BTN_AddAir;
		private System.Windows.Forms.TextBox TXT_AirCity;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox TXT_AirName;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button BTN_SaveAir;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.DataGridView DGV_AirPort;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
		private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
		private System.Windows.Forms.TextBox TXT_AirID;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.NumericUpDown TXT_PlaneSets;
		private System.Windows.Forms.Button BTN_AddPlane;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TXT_PlaneName;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button BTN_SavePlane;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.DataGridView DGV_Planes;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.DataGridView DGV_Flights;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.Button BTN_AddFligth;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.ComboBox CB_From;
		private System.Windows.Forms.ComboBox CB_Sate;
		private System.Windows.Forms.ComboBox CB_To;
		private System.Windows.Forms.DateTimePicker D_FlightFrom;
		private System.Windows.Forms.DateTimePicker D_FlightTo;
		private System.Windows.Forms.NumericUpDown TXT_FlightPrice;
		private System.Windows.Forms.TextBox TXT_PlaneID;
		private System.Windows.Forms.Button BTN_SaveFlight;
		private System.Windows.Forms.TextBox TXT_FligthID;
		private System.Windows.Forms.GroupBox groupBox9;
		private System.Windows.Forms.DataGridView DGV_Admin;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
		private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn6;
		private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn7;
		private System.Windows.Forms.Button Save_Admin;
		private System.Windows.Forms.ComboBox CB_FligthPNum;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.DataGridViewTextBoxColumn F_ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn FROM_CODE;
		private System.Windows.Forms.DataGridViewTextBoxColumn FROM_TIME;
		private System.Windows.Forms.DataGridViewTextBoxColumn TO_CODE;
		private System.Windows.Forms.DataGridViewTextBoxColumn TO_TIME;
		private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
		private System.Windows.Forms.DataGridViewTextBoxColumn STATUE;
		private System.Windows.Forms.DataGridViewTextBoxColumn PlaneNumber;
		private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn4;
		private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn3;
		private System.Windows.Forms.DataGridViewButtonColumn Edit;
		private System.Windows.Forms.DataGridViewButtonColumn View_Fligths;
	}
}