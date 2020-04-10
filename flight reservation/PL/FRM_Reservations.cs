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
	public partial class FRM_Reservations : Form
	{
		public FRM_Reservations()
		{
			InitializeComponent();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Hide();
			FRM_Home f = new FRM_Home();
			f.Show();
		}

		private void FRM_Reservations_Load(object sender, EventArgs e)
		{
			try
			{
				OracleDataAdapter da_Fligths = new OracleDataAdapter("" +
				"select p.FLIGHT_NUM \"Flight ID\" , fm.airport_name \"From\", t.airport_name \"To\",f.from_time \"From Time\",f.to_time \"To Time\",p.PRICE \"Price\" from passenger_flight p,flight f INNER JOIN airport fm ON fm.airport_code = f.from_code INNER JOIN airport t ON t.airport_code = f.to_code where p.passenger_id=:u_id", DAL.Data.cn);
				da_Fligths.SelectCommand.Parameters.Add("u_id", FRM_Home.U_ID);
				DataTable dt_Fligths = new DataTable();
				da_Fligths.Fill(dt_Fligths);
				dataGridView1.DataSource = dt_Fligths;
			}
			catch (Exception dddd)
			{
				MessageBox.Show("There Are Some Problems In App", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
