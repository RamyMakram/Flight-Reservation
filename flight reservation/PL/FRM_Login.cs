using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;
using System.Windows.Forms;
using System.IO;

namespace flight_reservation
{
	public partial class FRM_Login : Form
	{
		public FRM_Login()
		{
			InitializeComponent();
		}


		private void button3_Click(object sender, EventArgs e)
		{
			this.Hide();
			FRM_Register f = new FRM_Register();
			f.Show();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			this.Hide();
			FRM_Home f = new FRM_Home();
			f.Show();
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			try
			{
				OracleCommand cmd = new OracleCommand("select * from PASSENGER where PASSENGER_EMAIL=:un and PASSENGER_PASSWORD=:pw", DAL.Data.cn);
				cmd.Parameters.Add("un", TXT_UN.Text);
				cmd.Parameters.Add("pw", TXT_PW.Text);
				var x = cmd.ExecuteReader();
				bool i = x.Read();
				if (i)
				{
					if (CB_REm.Checked)
					{
						StreamWriter wr = new StreamWriter(new FileStream("log.txt", FileMode.Create, FileAccess.ReadWrite));
						wr.WriteLine(x.GetValue(0));
						wr.WriteLine(x.GetValue(1));
						wr.Close();
					}
					else
					{
						FRM_Home.U_Name = x.GetValue(1).ToString();
						FRM_Home.U_ID = int.Parse(x.GetValue(0).ToString());
					}
					this.Hide();
					FRM_Home f = new FRM_Home();
					f.Show();

				}
				else
				{
					OracleCommand cmd_ = new OracleCommand("select * from ADMINISTRATOR where ADMINISTRATOR_USER=:un and ADMINISTRATOR_PASSWORD=:pw", DAL.Data.cn);
					cmd_.Parameters.Add("un", TXT_UN.Text);
					cmd_.Parameters.Add("pw", TXT_PW.Text);
					var x_ = cmd_.ExecuteReader();
					bool i_ = x_.Read();
					if (i_)
					{
						this.Hide();
						new PL.FRM_Admin().Show();
					}
					else
						MessageBox.Show("Please Enter Valid Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception eddd)
			{
				MessageBox.Show("There Are Some Problems In App", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
