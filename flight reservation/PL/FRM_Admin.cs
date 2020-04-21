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
		OracleDataAdapter da_Admin;
		OracleCommandBuilder cb_Admin;
		DataTable dt_Admin;
		public FRM_Admin()
		{
			InitializeComponent();
		}
		private void FRM_Admin_Load(object sender, EventArgs e)
		{
			try
			{
				OracleCommand cmd = new OracleCommand("select PASSENGER_ID,PASSENGER_FNAME,PASSENGER_LNAME,PASSENGER_EMAIL,PASSENGER_PHONE from PASSENGER", DAL.Data.cn);
				var x = cmd.ExecuteReader();
				while (x.Read())
					DGV_Pass.Rows.Add(x.GetValue(0), x.GetValue(1), x.GetValue(2), x.GetValue(3), x.GetValue(4));
			}
			catch (Exception dddd)
			{
				MessageBox.Show("There Are Some Problems In App", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			try
			{
				OracleCommand cmd = new OracleCommand("get_airports", DAL.Data.cn);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.Add("airports", OracleDbType.RefCursor, ParameterDirection.Output);
				var x = cmd.ExecuteReader();
				DataTable dt = new DataTable();
				dt.Load(x);
				DGV_AirPort.Columns.Clear();
				DGV_AirPort.DataSource = dt;
				CB_From.DataSource = dt.Copy();
				CB_From.ValueMember = "ID";
				CB_From.DisplayMember = "Name";
				CB_To.DataSource = dt.Copy();
				CB_To.ValueMember = "ID";
				CB_To.DisplayMember = "Name";
				CB_From.SelectedIndex = CB_Sate.SelectedIndex = 0;
				CB_To.SelectedIndex = 1;
			}
			catch (Exception dddd)
			{
				MessageBox.Show("There Are Some Problems In App", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			try
			{
				OracleCommand cmd = new OracleCommand("get_Planes", DAL.Data.cn);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.Add("planes", OracleDbType.RefCursor, ParameterDirection.Output);
				DataTable dt = new DataTable();
				(new OracleDataAdapter(cmd)).Fill(dt);
				int length = dt.Rows.Count;
				for (int i = 0; i < length; i++)
				{
					CB_FligthPNum.Items.Add(dt.Rows[i][0].ToString());
					DGV_Planes.Rows.Add(dt.Rows[i][0].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][0].ToString());
				}
				CB_FligthPNum.SelectedIndex = 0;
			}
			catch (Exception dddd)
			{
				MessageBox.Show("There Are Some Problems In App", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			try
			{
				DGV_Flights.Columns.Clear();
				OracleDataAdapter da_Fligths = new OracleDataAdapter("select e.FLIGHT_NUM \"Fligth Number\",f.airport_name \"From\", e.FROM_TIME \"From Time\", t.airport_name \"To\", e.TO_TIME \"To Time\" , e.PRICE \"Price\" , e.STATUE \"Class\",e.AIRPLAN_ID \"Plane Number\" from FLIGHT e inner join airport f on f.airport_code = e.FROM_CODE inner join airport t on t.airport_code = e.TO_CODE order by e.FLIGHT_NUM", DAL.Data.cn);
				DataTable dt_Fligths = new DataTable();
				da_Fligths.Fill(dt_Fligths);
				DGV_Flights.DataSource = dt_Fligths;
				DGV_Flights.Columns.Add(new DataGridViewButtonColumn() { HeaderText = "Del", Text = "❌", UseColumnTextForButtonValue = true });
				DGV_Flights.Columns.Add(new DataGridViewButtonColumn() { HeaderText = "Edit", Text = "✏", UseColumnTextForButtonValue = true });
			}
			catch (Exception dddd)
			{
				MessageBox.Show("There Are Some Problems In App", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			try
			{
				DGV_Admin.Columns.Clear();
				da_Admin = new OracleDataAdapter("select * from ADMINISTRATOR", DAL.Data.cn);
				cb_Admin = new OracleCommandBuilder(da_Admin);
				dt_Admin = new DataTable();
				da_Admin.Fill(dt_Admin);
				DGV_Admin.DataSource = dt_Admin;
				DGV_Admin.Columns[0].Visible = false;
			}
			catch (Exception dddd)
			{
				MessageBox.Show("There Are Some Problems In App", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
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
					DGV_Pass.Rows.Add(ID, TXT_FName.Text, TXT_LName.Text, TXT_Mail.Text, TXT_Phone.Text);
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


		private void DGV_Pass_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				if (e.ColumnIndex == 5)//Delete
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
				else if (e.ColumnIndex == 6)//View Password
				{
					try
					{
						OracleCommand cmd = new OracleCommand("select PASSENGER_PASSWORD from PASSENGER where PASSENGER_ID=:id", DAL.Data.cn);
						cmd.Parameters.Add("id", DGV_Pass.Rows[e.RowIndex].Cells[0].Value);
						var x = cmd.ExecuteReader();
						x.Read();
						MessageBox.Show($"Password Is: '{x.GetString(0)}'");
					}
					catch (Exception dddd)
					{
						MessageBox.Show("There Are Some Problems In App", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
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
							//OracleCommand cmd = new OracleCommand(@"
							//begin
							//	remove_Plane(:Plane_ID,:Row_count);
							//end;
							//", DAL.Data.cn);
							OracleCommand cmd = new OracleCommand("remove_Plane", DAL.Data.cn);
							cmd.CommandType = CommandType.StoredProcedure;
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
					TXT_PlaneID.Text = DGV_Planes.Rows[e.RowIndex].Cells[0].Value.ToString();
					TXT_PlaneName.Text = DGV_Planes.Rows[e.RowIndex].Cells[1].Value.ToString();
					TXT_PlaneSets.Value = int.Parse(DGV_Planes.Rows[e.RowIndex].Cells[2].Value.ToString());
					BTN_AddPlane.Visible = false;
					BTN_SavePlane.Visible = true;
				}
				else if (e.ColumnIndex == 5)
				{
					try
					{
						OracleCommand cmd = new OracleCommand(@"
						select from_time from flight where flight_num=(
							select MAX(flight_num) from flight where AIRPLAN_ID=:a_id
						) ", DAL.Data.cn);
						cmd.Parameters.Add("a_id", int.Parse(DGV_Planes.Rows[e.RowIndex].Cells[0].Value.ToString()));
						var x = cmd.ExecuteReader();
						x.Read();
						MessageBox.Show(x.GetValue(0).ToString(), "Last Launch");
					}
					catch (Exception dddd)
					{
						MessageBox.Show("No Launch", "Last Launch");
					}
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
				if (D_FlightFrom.Value.ToString("dd-MM-yyyy HH:mm") != D_FlightTo.Value.ToString("dd-MM-yyyy HH:mm") && D_FlightFrom.Value < D_FlightTo.Value)
				{
					OracleCommand cmd = new OracleCommand(@"
					insert into FLIGHT (FLIGHT_NUM,FROM_CODE,FROM_TIME,TO_TIME,TO_CODE,PRICE,STATUE,AIRPLAN_ID) values 
					(:id_val,:from_,:fromtime_,:totime_,:to_,:price_,:st_,:p_ID)", DAL.Data.cn);
					int ID = DAL.Data.Get_Identity();
					cmd.Parameters.Add("id_val", ID);
					cmd.Parameters.Add("from_", CB_From.SelectedValue);
					cmd.Parameters.Add("fromtime_", D_FlightFrom.Value);
					cmd.Parameters.Add("totime_", D_FlightTo.Value);
					cmd.Parameters.Add("to_", CB_To.SelectedValue);
					cmd.Parameters.Add("price_", TXT_FlightPrice.Value);
					cmd.Parameters.Add("st_", CB_Sate.Text);
					cmd.Parameters.Add("p_ID", int.Parse(CB_FligthPNum.Text));
					var x = cmd.ExecuteNonQuery();
					if (x > 0)
					{
						MessageBox.Show("Added", "Success");
						DataTable dt = (DataTable)DGV_Flights.DataSource;
						dt.Rows.Add(ID, CB_From.Text, D_FlightFrom.Value, CB_To.Text, D_FlightTo.Value, TXT_FlightPrice.Value, CB_Sate.Text, CB_FligthPNum.Text);
						dt.AcceptChanges();
						DGV_Flights.DataSource = dt;
					}
					else
					{
						MessageBox.Show("Faild!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				else
				{
					MessageBox.Show("Time Not Valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
			catch (Exception dddd)
			{
				MessageBox.Show("There Are Some Problems In App", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void DGV_Flights_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				if (e.ColumnIndex == 8)//Delete
				{
					if (MessageBox.Show("Are You Want to Remove this AirPort And His History?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						try
						{
							OracleCommand cmd = new OracleCommand(@"
							delete from FLIGHT where FLIGHT_NUM=:f_ID
							", DAL.Data.cn);
							cmd.Parameters.Add("f_ID", DGV_Flights.Rows[e.RowIndex].Cells[0].Value);
							cmd.ExecuteNonQuery();
							MessageBox.Show("Deleted");
							DGV_Flights.Rows.RemoveAt(e.RowIndex);
						}
						catch (Exception dddd)
						{
							MessageBox.Show("There Are Some Problems In App", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
				else if (e.ColumnIndex == 9)//Edit
				{
					DateTime from = Convert.ToDateTime(DGV_Flights.Rows[e.RowIndex].Cells[2].Value.ToString());
					if (from >= DateTime.Now)
					{
						CB_From.SelectedIndex = CB_From.FindStringExact(DGV_Flights.Rows[e.RowIndex].Cells[1].Value.ToString());
						CB_To.SelectedIndex = CB_To.FindStringExact(DGV_Flights.Rows[e.RowIndex].Cells[3].Value.ToString());
						CB_Sate.Text = DGV_Flights.Rows[e.RowIndex].Cells[6].Value.ToString();
						CB_FligthPNum.Text = DGV_Flights.Rows[e.RowIndex].Cells[7].Value.ToString();
						TXT_FligthID.Text = DGV_Flights.Rows[e.RowIndex].Cells[0].Value.ToString();
						TXT_FlightPrice.Value = int.Parse(DGV_Flights.Rows[e.RowIndex].Cells[5].Value.ToString());
						D_FlightFrom.Value = from;
						D_FlightTo.Value = Convert.ToDateTime(DGV_Flights.Rows[e.RowIndex].Cells[4].Value.ToString());
						BTN_AddFligth.Visible = false;
						BTN_SaveFlight.Visible = true;
					}
					else
					{
						MessageBox.Show("Can't Edit this Flight Because The Fligth Is In Progress", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void BTN_SavePlane_Click(object sender, EventArgs e)
		{
			try
			{
				OracleCommand command = new OracleCommand(@"
				declare
					Plane_row AIRPLANE_INFO%rowtype;
				begin
					Plane_row.AIRPLANETYPE_NAME:=:name;
					Plane_row.AIRPLANE_NUMSEATS:=:num;
					Plane_row.airplane_id:=:a_id;
					update_Plane(Plane_row);
				end;"
				, DAL.Data.cn);
				command.Parameters.Add(":name", TXT_PlaneName.Text);
				command.Parameters.Add(":num", TXT_PlaneSets.Value);
				command.Parameters.Add(":a_id", int.Parse(TXT_PlaneID.Text));
				var x = command.ExecuteNonQuery();
				MessageBox.Show("Updated", "Success");
				try
				{
					foreach (DataGridViewRow i in DGV_Planes.Rows)
						if (i.Cells[0].Value.ToString() == TXT_PlaneID.Text)
						{
							i.Cells[1].Value = TXT_PlaneName.Text;
							i.Cells[2].Value = TXT_PlaneSets.Value;
						}
				}
				catch (Exception)
				{
				}
				BTN_AddPlane.Visible = true;
				BTN_SavePlane.Visible = false;
				TXT_AirID.Text = TXT_PlaneName.Text = "";
				TXT_PlaneSets.Value = 15;
			}
			catch (Exception dddd)
			{
				MessageBox.Show("There Are Some Problems In App", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void SaveTemp_Click(object sender, EventArgs e)
		{
			try
			{
				//dt_Admin.Columns[0].Unique = true;
				//dt_Admin.PrimaryKey = new DataColumn[] { dt_Admin.Columns[0] };
				da_Admin.Update(dt_Admin);
			}
			catch (Exception ffff)
			{
			}
		}

		private void BTN_SaveFlight_Click(object sender, EventArgs e)
		{
			try
			{

				OracleCommand cmd = new OracleCommand(@"
				update FLIGHT set FROM_CODE=:from_,FROM_TIME=:fromtime_,TO_CODE=:to_,TO_TIME=:totime_,PRICE=:price_,STATUE=:st_,AIRPLAN_ID=:a_ID where FLIGHT_NUM=:id_
				", DAL.Data.cn);

				cmd.Parameters.Add("from_", CB_From.SelectedValue);
				cmd.Parameters.Add("fromtime_", D_FlightFrom.Value);
				cmd.Parameters.Add("to_", CB_To.SelectedValue);
				cmd.Parameters.Add("totime_", D_FlightTo.Value);
				cmd.Parameters.Add("price_", TXT_FlightPrice.Value);
				cmd.Parameters.Add("st_", CB_Sate.Text);
				cmd.Parameters.Add("a_ID", int.Parse(CB_FligthPNum.Text));
				cmd.Parameters.Add("id_", int.Parse(TXT_FligthID.Text));
				var x = cmd.ExecuteNonQuery();
				MessageBox.Show("Updated", "Success");
				try
				{
					foreach (DataGridViewRow i in DGV_Flights.Rows)
						if (i.Cells[0].Value.ToString() == TXT_FligthID.Text)
						{
							i.Cells[1].Value = CB_From.Text;
							i.Cells[2].Value = D_FlightFrom.Value.ToString();
							i.Cells[3].Value = CB_To.Text;
							i.Cells[4].Value = D_FlightTo.Value.ToString();
							i.Cells[5].Value = TXT_FlightPrice.Text;
							i.Cells[6].Value = CB_Sate.Text;
							i.Cells[7].Value = CB_FligthPNum.Text;
						}
				}
				catch (Exception)
				{
				}
				BTN_AddFligth.Visible = true;
				BTN_SaveFlight.Visible = false;
			}
			catch (Exception dddd)
			{
				MessageBox.Show("There Are Some Problems In App", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void DGV_Admin_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
		}

		private void DGV_Admin_UserAddedRow(object sender, DataGridViewRowEventArgs e)
		{
			try
			{
				int ID = DAL.Data.Get_Identity();
				DGV_Admin.Rows[e.Row.Index - 1].Cells[0].Value = ID;
			}
			catch (Exception ffff)
			{
			}
		}
	}
}
