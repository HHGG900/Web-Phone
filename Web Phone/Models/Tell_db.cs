using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Web_Phone.Models
{
	public class Tell_db
	{
		private readonly string ConnStr = "Data Source=webphone20201109.database.windows.net;Initial Catalog=webphone20101109_db;Persist Security Info=True;User ID=oa123 ;Password=OOaa12345;MultipleActiveResultSets=True;Application Name=EntityFramework";

		public void Tell_insert(Tell tell)
		{
			SqlConnection sqlConnection = new SqlConnection(ConnStr);
			SqlCommand sqlCommand = new SqlCommand(
				@"INSERT INTO tell (caser_name,user_status,origin,phone,tim,cause)
				VALUES(@caser_name, @user_status, @origin, @phone, @tim, @cause)");
			sqlCommand.Connection = sqlConnection;
			sqlCommand.Parameters.Add(new SqlParameter("@caser_name", tell.caser_name));
			sqlCommand.Parameters.Add(new SqlParameter("@user_status", tell.user_status));
			sqlCommand.Parameters.Add(new SqlParameter("@origin", tell.origin));
			sqlCommand.Parameters.Add(new SqlParameter("@phone", tell.phone));
			sqlCommand.Parameters.Add(new SqlParameter("@tim", tell.tim));
			sqlCommand.Parameters.Add(new SqlParameter("@cause", tell.cause));
			sqlConnection.Open();
			sqlCommand.ExecuteNonQuery();
			sqlConnection.Close();
		}

		public Tell Tell_select(string caser_name)
		{
			Tell tell = new Tell();
			SqlConnection sqlConnection = new SqlConnection(ConnStr);
			SqlCommand sqlCommand = new SqlCommand("SELECT * FROM tell WHERE caser_name = @caser_name");
			sqlCommand.Connection = sqlConnection;
			sqlCommand.Parameters.Add(new SqlParameter("@caser_name", caser_name));
			sqlConnection.Open();

			SqlDataReader reader = sqlCommand.ExecuteReader();
			if (reader.HasRows)
			{
				while (reader.Read())
				{
					tell = new Tell
					{
						caser_name = reader.GetString(reader.GetOrdinal("caser_name")),
						user_status = reader.GetString(reader.GetOrdinal("user_status")),
						origin = reader.GetString(reader.GetOrdinal("origin")),
						phone = reader.GetString(reader.GetOrdinal("phone")),
						tim = reader.GetDateTime(reader.GetOrdinal("tim")),
						cause = reader.GetString(reader.GetOrdinal("cause"))
					};
				}
			}
			sqlConnection.Close();
			return tell;
		}
	}
}