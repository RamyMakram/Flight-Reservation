using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flight_reservation
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			try
			{
				DAL.Data.cn = new Oracle.DataAccess.Client.OracleConnection("Data source=orcl;User Id=hr;Password = hr;");
				DAL.Data.cn.Open();
				Application.Run(new PL.Reports());
				//Application.Run(new FRM_Book());
			}
			catch (Exception e)
			{
				MessageBox.Show("Faild To Open DataBase\nThe Application Will Be Exist","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
	}
}
