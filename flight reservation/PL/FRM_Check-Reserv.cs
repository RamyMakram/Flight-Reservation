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
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			DateTimePicker dynamicDTP = new DateTimePicker();
			dynamicDTP.Name = "DyanmicDateTimePicker";
			dynamicDTP.Location = new System.Drawing.Point(12, 12);
			dynamicDTP.Size = new System.Drawing.Size(200, 25);
			dynamicDTP.Width = 200;
			dynamicDTP.Height = 25;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Hide();
			FRM_Home f = new FRM_Home();
			f.Show();
		}

		private void BTN_Search_Click(object sender, EventArgs e)
		{
			try
			{
				if (CB_From.SelectedValue != CB_To.SelectedValue)
				{
					OracleDataAdapter da_Fligths = new OracleDataAdapter("" +
					"select e.FLIGHT_NUM,e.AIRPLAN_ID, e.FROM_TIME \"From Time\", e.TO_TIME \"To Time\" , e.PRICE \"Price\" , e.STATUE \"Class\" ,FN_GetSets(e.FLIGHT_NUM,e.AIRPLAN_ID) \"Availbe Sets\" from FLIGHT e " +
					"where FROM_CODE=:from_ and TO_CODE=:to_ and STATUE=:class_ and FROM_TIME>:date_ and FN_GetSets(e.FLIGHT_NUM,e.AIRPLAN_ID) >0", DAL.Data.cn);
					da_Fligths.SelectCommand.Parameters.Add("from_", CB_From.SelectedValue);
					da_Fligths.SelectCommand.Parameters.Add("to_", CB_To.SelectedValue);
					da_Fligths.SelectCommand.Parameters.Add("class_", CB_Class.Text);
					da_Fligths.SelectCommand.Parameters.Add("date_", DateTime.Now);
					DataTable dt_Fligths = new DataTable();
					da_Fligths.Fill(dt_Fligths);
					if (dt_Fligths.Rows.Count > 0)
					{
						PL.CheckOut checkout = new PL.CheckOut();
						checkout.DGV_Flights.DataSource = dt_Fligths;
						checkout.DGV_Flights.Columns[0].Visible = false;
						checkout.DGV_Flights.Columns[1].Visible = false;
						checkout.Size = new Size(937, 349);
						checkout.ShowDialog();
					}
					else
						MessageBox.Show("Sorry!! \nNo Avalible Fligths 😢😢");
				}
			}
			catch (Exception dddd)
			{
				MessageBox.Show("There Are Some Problems In App", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Form3_Load(object sender, EventArgs e)
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
	}
}
