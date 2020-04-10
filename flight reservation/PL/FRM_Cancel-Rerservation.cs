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
	public partial class cancel : Form
	{
		public cancel()
		{
			InitializeComponent();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Hide();
			new FRM_Home().Show();
		}

		private void BTN_Cancel_Click(object sender, EventArgs e)
		{
			try
			{
				OracleCommand cmd = new OracleCommand("delete from PASSENGER_FLIGHT where FLIGHT_NUM=:num and PASSENGER_ID=:u_id", DAL.Data.cn);
				cmd.Parameters.Add("num", TXT_FlightNum.Value);
				cmd.Parameters.Add("u_id", FRM_Home.U_ID);
				var x = cmd.ExecuteNonQuery();
				MessageBox.Show("Ok");
				button3_Click(null, null);
			}
			catch (Exception dddd)
			{
				MessageBox.Show("There Are Some Problems In App", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
