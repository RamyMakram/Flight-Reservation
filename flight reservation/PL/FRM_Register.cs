using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flight_reservation
{
	public partial class FRM_Register : Form
	{
		public FRM_Register()
		{
			InitializeComponent();
		}


		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			new FRM_Login().Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				OracleCommand cmd = new OracleCommand(@"insert into PASSENGER (PASSENGER_ID,PASSENGER_FNAME,PASSENGER_LNAME,PASSENGER_EMAIL,PASSENGER_PASSWORD,PASSENGER_PHONE) values 
(:id,:fname,:lname,:email,:pass,:phone)", DAL.Data.cn);
				cmd.Parameters.Add("id", DAL.Data.Get_Identity());
				cmd.Parameters.Add("fname", TXT_Fname.Text);
				cmd.Parameters.Add("lname", TXT_Lname.Text);
				cmd.Parameters.Add("email", TXT_Mail.Text);
				cmd.Parameters.Add("pass", TXT_pass.Text);
				cmd.Parameters.Add("phone", TXT_Phone.Text);
				var x = cmd.ExecuteNonQuery();
				if (x > 0)
				{
					MessageBox.Show("Congratulation You Now One Of Flight Reservation System Army 😊😊", "Success");
					this.Hide();
					new FRM_Login().Show();
				}
				else
				{
					MessageBox.Show("Faild!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

			}
			catch (Exception dddd)
			{
				MessageBox.Show("There Are Some Problems In App", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
