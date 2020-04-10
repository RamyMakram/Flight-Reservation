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
	public partial class FRM_Admin : Form
	{
		public FRM_Admin()
		{
			InitializeComponent();
		}

		private void BTN_AddPass_Click(object sender, EventArgs e)
		{
			try
			{
				OracleCommand cmd = new OracleCommand(@"insert into PASSENGER (PASSENGER_ID,PASSENGER_FNAME,PASSENGER_LNAME,PASSENGER_EMAIL,PASSENGER_PASSWORD,PASSENGER_PHONE) values 
				(:id,:fname,:lname,:email,:pass,:phone)", DAL.Data.cn);
				int ID = DAL.Data.Get_Identity();
				cmd.Parameters.Add("id", ID);
				cmd.Parameters.Add("fname", TXT_FName.Text);
				cmd.Parameters.Add("lname", TXT_LName.Text);
				cmd.Parameters.Add("email", TXT_Mail.Text);
				cmd.Parameters.Add("pass", TXT_Pass.Text);
				cmd.Parameters.Add("phone", TXT_Phone.Text);
				var x = cmd.ExecuteNonQuery();
				if (x > 0)
				{
					MessageBox.Show("Added", "Success");
					DGV_Pass.Rows.Add(ID, TXT_FName.Text, TXT_LName.Text, TXT_Mail.Text, TXT_Pass.Text, TXT_Phone.Text);
					TXT_FName.Text = TXT_LName.Text = TXT_Mail.Text = TXT_Pass.Text = TXT_Phone.Text = "";
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

		private void FRM_Admin_Load(object sender, EventArgs e)
		{
			try
			{
				OracleCommand cmd = new OracleCommand("select * from PASSENGER", DAL.Data.cn);
				var x = cmd.ExecuteReader();
				while (x.Read())
					DGV_Pass.Rows.Add(x.GetValue(0), x.GetValue(1), x.GetValue(2), x.GetValue(3), x.GetValue(4), x.GetValue(5));
			}
			catch (Exception dddd)
			{
				MessageBox.Show("There Are Some Problems In App", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			try
			{
				OracleCommand cmd = new OracleCommand("select * from AIRPORT", DAL.Data.cn);
				var x = cmd.ExecuteReader();
				DataTable dt = new DataTable();
				dt.Columns.Add("ID", typeof(int));
				dt.Columns.Add("Name");
				while (x.Read())
				{
					DGV_AirPort.Rows.Add(x.GetValue(0), x.GetValue(1), x.GetValue(2));
					dt.Rows.Add(int.Parse(x.GetValue(0).ToString()), x.GetValue(1).ToString());
				}
				CB_From.DataSource = dt;
				CB_From.ValueMember = "ID";
				CB_From.DisplayMember = "Name";
				CB_To.DataSource = dt.Copy();
				CB_To.ValueMember = "ID";
				CB_To.DisplayMember = "Name";
				CB_Test.DataSource = dt.Copy();
				CB_Test.ValueMember = "ID";
				CB_Test.DisplayMember = "Name";
				CB_From.SelectedIndex = CB_Sate.SelectedIndex = 0; CB_To.SelectedIndex = 1;
			}
			catch (Exception dddd)
			{
				MessageBox.Show("There Are Some Problems In App", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			try
			{
				OracleCommand cmd = new OracleCommand("select * from AIRPLANE_INFO", DAL.Data.cn);
				DataTable dt = new DataTable();
				(new OracleDataAdapter(cmd)).Fill(dt);
				int length = dt.Rows.Count;
				for (int i = 0; i < length; i++)
				{
					DGV_Planes.Rows.Add(dt.Rows[i][0].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][0].ToString());
				};
			}
			catch (Exception dddd)
			{
				MessageBox.Show("There Are Some Problems In App", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			try
			{
				OracleCommand cmd = new OracleCommand("select * from Flight", DAL.Data.cn);
				DataTable dt = new DataTable();
				(new OracleDataAdapter(cmd)).Fill(dt);
				int length = dt.Rows.Count;
				for (int i = 0; i < length; i++)
				{
					CB_Test.SelectedValue = dt.Rows[i][1];
					string fr = CB_Test.Text;
					CB_Test.SelectedValue = dt.Rows[i][4];
					string to = CB_Test.Text;
					DGV_Flights.Rows.Add(dt.Rows[i][0].ToString(), fr, dt.Rows[i][2].ToString(), to, dt.Rows[i][3].ToString(), dt.Rows[i][5].ToString(), dt.Rows[i][6].ToString());
				};
			}
			catch (Exception dddd)
			{
				MessageBox.Show("There Are Some Problems In App", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void DGV_Pass_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				if (e.ColumnIndex == 6)//Delete
				{
					if (MessageBox.Show("Are You Want to Remove this Passanger And His History?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						try
						{
							OracleCommand cmd = new OracleCommand("delete from PASSENGER where PASSENGER_ID=:id", DAL.Data.cn);
							cmd.Parameters.Add("id", DGV_Pass.Rows[e.RowIndex].Cells[0].Value);
							if (cmd.ExecuteNonQuery() > 0)
							{
								MessageBox.Show("Deleted");
								DGV_Pass.Rows.RemoveAt(e.RowIndex);
							}
						}
						catch (Exception dddd)
						{
							MessageBox.Show("There Are Some Problems In App", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
				else if (e.ColumnIndex == 7)//View Flights
				{

				}
			}
		}

		private void BTN_SavePass_Click(object sender, EventArgs e)
		{

		}

		private void BTN_AddAir_Click(object sender, EventArgs e)
		{
			try
			{
				OracleCommand cmd = new OracleCommand(@"insert into AIRPORT (AIRPORT_CODE,AIRPORT_NAME,AIRPORT_CITY) values 
				(:id,:name,:city)", DAL.Data.cn);
				int ID = DAL.Data.Get_Identity();
				cmd.Parameters.Add("id", ID);
				cmd.Parameters.Add("name", TXT_AirName.Text);
				cmd.Parameters.Add("city", TXT_AirCity.Text);
				var x = cmd.ExecuteNonQuery();
				if (x > 0)
				{
					MessageBox.Show("Added", "Success");
					DGV_AirPort.Rows.Add(ID, TXT_AirName.Text, TXT_AirCity.Text);
					TXT_AirName.Text = TXT_AirCity.Text = "";
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

		private void DGV_AirPort_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				if (e.ColumnIndex == 3)//Delete
				{
					if (MessageBox.Show("Are You Want to Remove this AirPort And His History?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						try
						{
							OracleCommand cmd = new OracleCommand("delete from AIRPORT where AIRPORT_CODE=:id", DAL.Data.cn);
							cmd.Parameters.Add("id", DGV_AirPort.Rows[e.RowIndex].Cells[0].Value);
							if (cmd.ExecuteNonQuery() > 0)
							{
								MessageBox.Show("Deleted");
								DGV_AirPort.Rows.RemoveAt(e.RowIndex);
							}
						}
						catch (Exception dddd)
						{
							MessageBox.Show("There Are Some Problems In App", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
				else if (e.ColumnIndex == 4)//Edit
				{
					TXT_AirID.Text = DGV_AirPort.Rows[e.RowIndex].Cells[0].Value.ToString();
					TXT_AirName.Text = DGV_AirPort.Rows[e.RowIndex].Cells[1].Value.ToString();
					TXT_AirCity.Text = DGV_AirPort.Rows[e.RowIndex].Cells[2].Value.ToString();
					BTN_AddAir.Visible = false;
					BTN_SaveAir.Visible = true;
				}
			}
		}

		private void BTN_SaveAir_Click(object sender, EventArgs e)
		{
			try
			{
				OracleCommand cmd = new OracleCommand(@"update AIRPORT set AIRPORT_NAME=:name,AIRPORT_CITY=:city where AIRPORT_CODE=:id", DAL.Data.cn);
				cmd.Parameters.Add(":name", TXT_AirName.Text);
				cmd.Parameters.Add(":city", TXT_AirCity.Text);
				cmd.Parameters.Add(":id", OracleDbType.Int16).Value = int.Parse(TXT_AirID.Text);
				var x = cmd.ExecuteNonQuery();
				MessageBox.Show("Updated", "Success");
				try
				{
					foreach (DataGridViewRow i in DGV_AirPort.Rows)
						if (i.Cells[0].Value.ToString() == TXT_AirID.Text)
						{
							i.Cells[1].Value = TXT_AirName.Text;
							i.Cells[2].Value = TXT_AirCity.Text;
						}
				}
				catch (Exception)
				{
				}
				TXT_AirName.Text = TXT_AirCity.Text = "";
				BTN_AddAir.Visible = true;
				BTN_SaveAir.Visible = false;
			}
			catch (Exception dddd)
			{
				MessageBox.Show("There Are Some Problems In App", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void BTN_AddPlane_Click(object sender, EventArgs e)
		{
			try
			{
				OracleCommand command = new OracleCommand(@"
				declare
					Plane_row AIRPLANE_INFO%rowtype;
				begin
					Plane_row.AIRPLANETYPE_NAME:=:name;
					Plane_row.AIRPLANE_NUMSEATS:=:num;
					Add_Plane(Plane_row,:ID);
				end;"
				, DAL.Data.cn);
				command.Parameters.Add(":name", TXT_PlaneName.Text);
				command.Parameters.Add(":num", TXT_PlaneSets.Value);
				command.Parameters.Add(":ID", OracleDbType.Int16, ParameterDirection.Output);
				var x = command.ExecuteNonQuery();
				MessageBox.Show("Added", "Success");
				DGV_Planes.Rows.Add(command.Parameters[2].Value.ToString(), TXT_PlaneName.Text, TXT_PlaneSets.Value);
				TXT_PlaneName.Text = "";
				TXT_PlaneSets.Value = 15;
			}
			catch (Exception dddd)
			{
				MessageBox.Show("There Are Some Problems In App", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void DGV_Planes_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				if (e.ColumnIndex == 3)//Delete
				{
					if (MessageBox.Show("Are You Want to Remove this AirPort And His History?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						try
						{
							OracleCommand cmd = new OracleCommand(@"
							begin
								remove_Plane(:Plane_ID,:Row_count);
							end;
							", DAL.Data.cn);
							cmd.Parameters.Add("Plane_ID", DGV_Planes.Rows[e.RowIndex].Cells[0].Value);
							cmd.Parameters.Add("Row_count", OracleDbType.Int16, ParameterDirection.Output);
							cmd.ExecuteNonQuery();
							if (cmd.Parameters[1].Value.ToString() != "0")
							{
								MessageBox.Show("Deleted");
								DGV_Planes.Rows.RemoveAt(e.RowIndex);
							}
						}
						catch (Exception dddd)
						{
							MessageBox.Show("There Are Some Problems In App", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
				else if (e.ColumnIndex == 4)//Edit
				{
					TXT_AirID.Text = DGV_AirPort.Rows[e.RowIndex].Cells[0].Value.ToString();
					TXT_AirName.Text = DGV_AirPort.Rows[e.RowIndex].Cells[1].Value.ToString();
					TXT_AirCity.Text = DGV_AirPort.Rows[e.RowIndex].Cells[2].Value.ToString();
					BTN_AddAir.Visible = false;
					BTN_SaveAir.Visible = true;
				}
			}
		}

		private void BTN_AddFligth_Click(object sender, EventArgs e)
		{
			try
			{
				if (CB_To.SelectedValue == CB_From.SelectedValue)
				{
					MessageBox.Show("Not Allowed To Make Distniation Is The Sourcse", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				OracleCommand cmd = new OracleCommand(@"insert into FLIGHT (FLIGHT_NUM,FROM_CODE,FROM_TIME,TO_TIME,TO_CODE,PRICE,STATUE) values 
				(:id_val,:from_,:fromtime_,:totime_,:to_,:price_,:st_)", DAL.Data.cn);
				int ID = DAL.Data.Get_Identity();
				cmd.Parameters.Add("id_val", ID);
				cmd.Parameters.Add("from_", CB_From.SelectedValue);
				cmd.Parameters.Add("fromtime_", D_FlightFrom.Value);
				cmd.Parameters.Add("totime_", D_FlightTo.Value);
				cmd.Parameters.Add("to_", CB_To.SelectedValue);
				cmd.Parameters.Add("price_", TXT_FlightPrice.Value);
				cmd.Parameters.Add("st_", CB_Sate.Text);
				var x = cmd.ExecuteNonQuery();
				if (x > 0)
				{
					MessageBox.Show("Added", "Success");
					DGV_Flights.Rows.Add(ID, CB_From.Text, D_FlightFrom.Value, CB_To.Text, D_FlightTo.Value, TXT_FlightPrice.Value, CB_Sate.Text);
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

		private void DGV_Flights_CellClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
