using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Web_Phone.Models
{
	public class family_attend_db
	{
		private readonly string ConnStr = "Data Source=webphone20201109.database.windows.net;Initial Catalog=webphone1109;Persist Security Info=True;User ID=oa123;Password=OOaa12345;MultipleActiveResultSets=True;Application Name=EntityFramework";

		public void family_attend_insert(family_attend family_attend)
		{
			SqlConnection sqlConnection = new SqlConnection(ConnStr);
			SqlCommand sqlCommand = new SqlCommand(
				@"INSERT INTO family_attend_db (caser_name,tim,eat,drink_medicine,sleep,depression,doctor,doctor_tell,family_tell)
				VALUES(@caser_name,@tim,@eat,@drink_medicine,@sleep,@depression,@doctor,@doctor_tell,@family_tell)");
			sqlCommand.Connection = sqlConnection;
			sqlCommand.Parameters.Add(new SqlParameter("@caser_name", family_attend.caser_name));
			sqlCommand.Parameters.Add(new SqlParameter("@tim", family_attend.tim));
			sqlCommand.Parameters.Add(new SqlParameter("@eat", family_attend.eat));
			sqlCommand.Parameters.Add(new SqlParameter("@drink_medicine", family_attend.drink_medicine));
			sqlCommand.Parameters.Add(new SqlParameter("@sleep", family_attend.sleep));
			sqlCommand.Parameters.Add(new SqlParameter("@depression", family_attend.depression));
			sqlCommand.Parameters.Add(new SqlParameter("@doctor", family_attend.doctor));
			sqlCommand.Parameters.Add(new SqlParameter("@doctor_tell", family_attend.doctor_tell));
			sqlCommand.Parameters.Add(new SqlParameter("@family_tell", family_attend.family_tell));
			sqlConnection.Open();
			sqlCommand.ExecuteNonQuery();
			sqlConnection.Close();
		}

		public family_attend family_attend_select(string UserId)
		{
			family_attend family_attend1 = new family_attend();
			SqlConnection sqlConnection = new SqlConnection(ConnStr);
			SqlCommand sqlCommand = new SqlCommand("SELECT * FROM family_attend_db WHERE caser_name = @caser_name");
			sqlCommand.Connection = sqlConnection;
			sqlCommand.Parameters.Add(new SqlParameter("@caser_name", UserId));
			sqlConnection.Open();

			SqlDataReader reader = sqlCommand.ExecuteReader();
			if (reader.HasRows)
			{
				while (reader.Read())
				{
					family_attend1 = new family_attend
					{
						caser_name = reader.GetString(reader.GetOrdinal("@caser_name")),
						tim = reader.GetString(reader.GetOrdinal("@tim")),
						eat= reader.GetString(reader.GetOrdinal("@eat")),
						drink_medicine = reader.GetString(reader.GetOrdinal("@drink_medicine")),
						sleep = reader.GetString(reader.GetOrdinal("@sleep")),
						depression = reader.GetString(reader.GetOrdinal("@depression")),
						doctor = reader.GetString(reader.GetOrdinal("@doctor")),
						doctor_tell = reader.GetString(reader.GetOrdinal("@doctor_tell")),
						family_tell = reader.GetString(reader.GetOrdinal("@family_tell")),

					};
				}
			}
			sqlConnection.Close();
			return family_attend1;
		}
	}
}