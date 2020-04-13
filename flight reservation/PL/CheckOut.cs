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

namespace flight_reservation.PL
{
	public partial class CheckOut : Form
	{
		int current = 0;
		public CheckOut()
		{
			InitializeComponent();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void DGV_Flights_SelectionChanged(object sender, EventArgs e)
		{
			//if (DGV_Flights.CurrentRow != null)
			//{
			//	int income =  int.Parse(DGV_Flights.CurrentRow.Cells[0].Value.ToString());
			//	if (current != income)
			//	{
			//		current = income;
			//		MessageBox.Show(DGV_Flights.CurrentRow.Cells[0].Value.ToString());
			//	}
			//}
		}

		private void BTN_ConfirmTime_Click(object sender, EventArgs e)
		{
			try
			{
				//get_number_of_sets
				OracleCommand cmd = new OracleCommand("get_number_of_sets", DAL.Data.cn);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.Add("fligthId", int.Parse(DGV_Flights.CurrentRow.Cells[0].Value.ToString()));
				cmd.Parameters.Add("planid", int.Parse(DGV_Flights.CurrentRow.Cells[1].Value.ToString()));
				cmd.Parameters.Add("n", OracleDbType.Int16, ParameterDirection.Output);
				var x = cmd.ExecuteNonQuery();
				int le = int.Parse(cmd.Parameters[2].Value.ToString());
				if (le <= 0)
				{
					MessageBox.Show("Sorry!! No Avalibe Sets", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				DGV_Flights.Enabled = false;
				BTN_ConfirmTime.Visible = false;
				BTN_Book.Visible = true;
				panel1.Visible = true;
				BTN_ChangeFligth.Visible = true;
				CB_Sets.Items.Clear();
				for (int i = 1; i <= le; i++)
				{
					CB_Sets.Items.Add(i);
				}
				CB_Sets.SelectedIndex = 0;
			}
			catch
			{
				MessageBox.Show("There Are Some Problems In App", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void BTN_ChangeFligth_Click(object sender, EventArgs e)
		{
			DGV_Flights.Enabled = true;
			BTN_ConfirmTime.Visible = true;
			BTN_ChangeFligth.Visible = false;
			BTN_Book.Visible = false;
			panel1.Visible = false;
		}

		private void BTN_Book_Click(object sender, EventArgs e)
		{
			try
			{
				//get_number_of_sets
				OracleCommand cmd = new OracleCommand("reserve_", DAL.Data.cn);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.Add("fligthId", int.Parse(DGV_Flights.CurrentRow.Cells[0].Value.ToString()));
				cmd.Parameters.Add("userid", FRM_Home.U_ID);
				cmd.Parameters.Add("nsets", int.Parse(CB_Sets.Text));
				cmd.Parameters.Add("price", int.Parse(DGV_Flights.CurrentRow.Cells[4].Value.ToString()));
				cmd.ExecuteNonQuery();
				MessageBox.Show("Congratulation 😎😎");
				this.Close();
			}
			catch (Exception eeee)
			{
				MessageBox.Show("There Are Some Problems In App", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
