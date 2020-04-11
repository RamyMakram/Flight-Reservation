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
	public partial class FRM_Book : Form
	{
		PL.CheckOut checkout;
		public FRM_Book()
		{
			InitializeComponent();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Hide();
			FRM_Home f = new FRM_Home();
			f.Show();
		}

		private void FRM_Book_Load(object sender, EventArgs e)
		{
			try
			{
				OracleCommand cmd = new OracleCommand("get_airports", DAL.Data.cn);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.Add("airports", OracleDbType.RefCursor, ParameterDirection.Output);
				var x = cmd.ExecuteReader();
				DataTable dt = new DataTable();
				dt.Columns.Add("ID", typeof(int));
				dt.Columns.Add("Name");
				while (x.Read())
					dt.Rows.Add(int.Parse(x.GetValue(0).ToString()), x.GetValue(1).ToString());
				CB_From.DataSource = dt;
				CB_From.DisplayMember = "Name";
				CB_From.ValueMember = "ID";
				CB_To.DataSource = dt.Copy();
				CB_To.DisplayMember = "Name";
				CB_To.ValueMember = "ID";
				CB_From.SelectedIndex = CB_Class.SelectedIndex = 0;
				CB_To.SelectedIndex = 1;
			}
			catch (Exception dddd)
			{
				MessageBox.Show("There Are Some Problems In App", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				if (CB_From.SelectedValue != CB_To.SelectedValue)
				{
					OracleDataAdapter da_Fligths = new OracleDataAdapter("" +
					"select e.FLIGHT_NUM,e.AIRPLAN_ID, e.FROM_TIME \"From Time\", e.TO_TIME \"To Time\" , e.PRICE \"Price\" , e.STATUE \"Class\" from FLIGHT e " +
					"where FROM_CODE=:from_ and TO_CODE=:to_ and STATUE=:class_ and FROM_TIME>:date_", DAL.Data.cn);
					da_Fligths.SelectCommand.Parameters.Add("from_", CB_From.SelectedValue);
					da_Fligths.SelectCommand.Parameters.Add("to_", CB_To.SelectedValue);
					da_Fligths.SelectCommand.Parameters.Add("class_", CB_Class.Text);
					da_Fligths.SelectCommand.Parameters.Add("date_", DateTime.Now);
					DataTable dt_Fligths = new DataTable();
					da_Fligths.Fill(dt_Fligths);
					checkout = new PL.CheckOut();
					checkout.DGV_Flights.DataSource = dt_Fligths;
					checkout.DGV_Flights.Columns[0].Visible = false;
					checkout.DGV_Flights.Columns[1].Visible = false;
					//checkout.DGV_Flights.SelectionChanged += DGV_Flights_SelectionChanged;
					checkout.ShowDialog();
				}
			}
			catch (Exception dddd)
			{
				MessageBox.Show("There Are Some Problems In App", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void DGV_Flights_SelectionChanged(object sender, EventArgs e)
		{
			MessageBox.Show(checkout.DGV_Flights.CurrentRow.Cells[0].Value.ToString());
		}
	}
}
