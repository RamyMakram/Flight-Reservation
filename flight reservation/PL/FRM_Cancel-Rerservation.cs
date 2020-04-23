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
		int toalsets = 0;
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
				OracleCommand cmd = new OracleCommand("GET_NUMBER_OF_FLIGTHS_OF_PASSS", DAL.Data.cn);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.Add("num", CB_FlightNum.Text);
				cmd.Parameters.Add("u_id", FRM_Home.U_ID);
				cmd.Parameters.Add("n", OracleDbType.Int16, ParameterDirection.Output);
				var x = cmd.ExecuteNonQuery();
				toalsets = int.Parse(cmd.Parameters[2].Value.ToString());
				if (toalsets == 1)
				{
					CB_SetsNum.Items.Add(1);
					CB_SetsNum.SelectedIndex = 0;
					BTN_Confirm_Click(null, null);
				}
				else
				{
					BTN_Cancel.Visible = label12.Visible = CB_FlightNum.Visible = false;
					BTN_Confirm.Visible = label1.Visible = CB_SetsNum.Visible = true;
					CB_SetsNum.Items.Clear();
					for (int i = 1; i <= toalsets; i++)
						CB_SetsNum.Items.Add(i);
					CB_SetsNum.SelectedIndex = 0;
				}
			}
			catch (Exception dddd)
			{
				MessageBox.Show("There Are Some Problems In App", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void BTN_Confirm_Click(object sender, EventArgs e)
		{
			try
			{
				if (MessageBox.Show("Are you sure to cancel this flight?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
				{
					OracleCommand cmd = new OracleCommand("CANCEL_RESERV", DAL.Data.cn);
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.Add("num", CB_FlightNum.Text);
					cmd.Parameters.Add("u_id", FRM_Home.U_ID);
					cmd.Parameters.Add("n", CB_SetsNum.Text);
					cmd.Parameters.Add("totalSets", toalsets);
					var x = cmd.ExecuteNonQuery();
					MessageBox.Show("Ok");
					button3_Click(null, null);
				}
			}
			catch (Exception dddd)
			{
				MessageBox.Show("There Are Some Problems In App", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void cancel_Load(object sender, EventArgs e)
		{
			try
			{
				OracleCommand cmd = new OracleCommand("select DISTINCT p.flight_num from passenger_flight p, flight e where e.from_time > sysdate and PASSENGER_ID=:u_id", DAL.Data.cn);
				cmd.Parameters.Add("u_id", FRM_Home.U_ID);
				var x = cmd.ExecuteReader();
				while (x.Read())
					CB_FlightNum.Items.Add(x.GetValue(0));
				if (CB_FlightNum.Items.Count > 0)
					CB_FlightNum.SelectedIndex = 0;
				else
				{
					MessageBox.Show("Theres No Flights Yet!");
					new FRM_Home().Show();
					this.Close();
				}
			}
			catch (Exception dddd)
			{
				MessageBox.Show("There Are Some Problems In App", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
