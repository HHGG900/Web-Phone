using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Web_Phone.Models
{
	public class home_write_db
	{
		private readonly string ConnStr = "Data Source=webphone20201109.database.windows.net;Initial Catalog=webphone1109;Persist Security Info=True;User ID=oa123;Password=OOaa12345;MultipleActiveResultSets=True;Application Name=EntityFramework";

		public void home_write_insert(home_write home_write)
		{
			SqlConnection sqlConnection = new SqlConnection(ConnStr);
			SqlCommand sqlCommand = new SqlCommand(
				@"INSERT INTO home_write_db (caser_name,daily_record,record,question,reply,attend_area,attend_record)
				VALUES(@caser_name,@daily_record,@record,@question,@reply,@attend_area,@attend_record)");
			sqlCommand.Connection = sqlConnection;
			sqlCommand.Parameters.Add(new SqlParameter("@caser_name", home_write.caser_name));
			sqlCommand.Parameters.Add(new SqlParameter("@daily_record", home_write.daily_record));
			sqlCommand.Parameters.Add(new SqlParameter("@record", home_write.record));
			sqlCommand.Parameters.Add(new SqlParameter("@question", home_write.question));
			sqlCommand.Parameters.Add(new SqlParameter("@reply", home_write.reply));
			sqlCommand.Parameters.Add(new SqlParameter("@attend_area", home_write.attend_area));
			sqlCommand.Parameters.Add(new SqlParameter("@attend_record", home_write.attend_record));
			sqlConnection.Open();
			sqlCommand.ExecuteNonQuery();
			sqlConnection.Close();
		}

		public home_write home_write_select(string UserId)
		{
			home_write home_write = new home_write();
			SqlConnection sqlConnection = new SqlConnection(ConnStr);
			SqlCommand sqlCommand = new SqlCommand("SELECT * FROM home_write_db WHERE caser_name = @caser_name");
			sqlCommand.Connection = sqlConnection;
			sqlCommand.Parameters.Add(new SqlParameter("@caser_name", UserId));
			sqlConnection.Open();

			SqlDataReader reader = sqlCommand.ExecuteReader();
			if (reader.HasRows)
			{
				while (reader.Read())
				{
					home_write = new home_write
					{
						caser_name = reader.GetString(reader.GetOrdinal("@caser_name")),
						daily_record = reader.GetString(reader.GetOrdinal("@daily_record")),
						record = reader.GetString(reader.GetOrdinal("@record")),
						question = reader.GetString(reader.GetOrdinal("@question")),
						reply = reader.GetString(reader.GetOrdinal("@reply")),
						attend_area = reader.GetString(reader.GetOrdinal("@attend_area")),
						attend_record = reader.GetString(reader.GetOrdinal("@attend_record"))
					};
				}
			}
			sqlConnection.Close();
			return home_write;
		}
	}
}