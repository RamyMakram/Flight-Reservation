using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace flight_reservation.DAL
{
	static class Data
	{
		public static OracleConnection cn;
		public static int Get_Identity()
		{
			OracleCommand command = new OracleCommand(@"begin
            :sal := get_sq_val();
          end;", DAL.Data.cn);
			command.Parameters.Add(":sal", OracleDbType.Int16, ParameterDirection.Output);
			command.ExecuteNonQuery();
			return int.Parse(command.Parameters[0].Value.ToString());
		}
	}
}