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
	public partial class Reports : Form
	{
		RPT.rpt_view frm;
		public Reports()
		{
			InitializeComponent();
		}

		private void BTN_AirPort_Click(object sender, EventArgs e)
		{
			frm = new RPT.rpt_view();
			OracleCommand cmd = new OracleCommand("get_airports", DAL.Data.cn);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add("pass", OracleDbType.RefCursor, ParameterDirection.Output);
			DataTable dt = new DataTable();
			new OracleDataAdapter(cmd).Fill(dt);


			RPT.AirportDetail report = new RPT.AirportDetail();
			report.SetDataSource(dt);



			frm.crystalReportViewer1.ReportSource = report;
			frm.Show();
		}

		private void BTN_Client_Click(object sender, EventArgs e)
		{
			frm = new RPT.rpt_view();
			RPT.PassDetails report = new RPT.PassDetails();
			OracleCommand cmd = new OracleCommand("passanger_print", DAL.Data.cn);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add("id", TXT_ClientID.Value);
			cmd.Parameters.Add("pass", OracleDbType.RefCursor, ParameterDirection.Output);
			DataTable dt = new DataTable();
			new OracleDataAdapter(cmd).Fill(dt);
			report.SetDataSource(dt);
			frm.crystalReportViewer1.ReportSource = report;
			frm.Show();
		}

		private void BTN_FligthsReport_Click(object sender, EventArgs e)
		{
			frm = new RPT.rpt_view();
			RPT.FlightsDetails report = new RPT.FlightsDetails();
			OracleCommand cmd = new OracleCommand("fligths_print", DAL.Data.cn);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add("from_", CB_From.SelectedValue);
			cmd.Parameters.Add("to_", CB_To.SelectedValue);
			cmd.Parameters.Add("fligths", OracleDbType.RefCursor, ParameterDirection.Output);
			DataTable dt = new DataTable();
			new OracleDataAdapter(cmd).Fill(dt);
			report.SetDataSource(dt);
			frm.crystalReportViewer1.ReportSource = report;
			frm.Show();
		}

		private void Reports_Load(object sender, EventArgs e)
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
				CB_From.SelectedIndex = 0;
				CB_To.SelectedIndex = 1;
			}
			catch (Exception dddd)
			{
				MessageBox.Show("There Are Some Problems In App", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			D_FlightFrom.MinDate = DateTime.Now;
			D_FlightTo.MinDate = DateTime.Now;
		}

		private void BTN_From_To_Click(object sender, EventArgs e)
		{
			frm = new RPT.rpt_view();
			RPT.FlightsDetails report = new RPT.FlightsDetails();
			OracleCommand cmd = new OracleCommand("fligths_print", DAL.Data.cn);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add("from_", CB_From.SelectedValue);
			cmd.Parameters.Add("to_", CB_To.SelectedValue);
			cmd.Parameters.Add("fligths", OracleDbType.RefCursor, ParameterDirection.Output);
			DataTable dt = new DataTable();
			new OracleDataAdapter(cmd).Fill(dt);
			report.SetDataSource(dt);
			frm.crystalReportViewer1.ReportSource = report;
			frm.Show();
		}

		private void BTN_From_To_Click_1(object sender, EventArgs e)
		{
			frm = new RPT.rpt_view();
			RPT.FlightsFromTo report = new RPT.FlightsFromTo();
			OracleCommand cmd = new OracleCommand("fligth_FromTo_print", DAL.Data.cn);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add("from_", D_FlightFrom.Value);
			cmd.Parameters.Add("to_", D_FlightTo.Value);
			cmd.Parameters.Add("fligths", OracleDbType.RefCursor, ParameterDirection.Output);
			DataTable dt = new DataTable();
			new OracleDataAdapter(cmd).Fill(dt);
			report.SetDataSource(dt);
			frm.crystalReportViewer1.ReportSource = report;
			frm.Show();
		}
	}
}
