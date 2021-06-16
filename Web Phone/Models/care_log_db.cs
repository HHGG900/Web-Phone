using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Web_Phone.Models
{
	public class care_log_db
	{
		private readonly string ConnStr = "Data Source=webphone20201109.database.windows.net;Initial Catalog=webphone1109;Persist Security Info=True;User ID=oa123;Password=OOaa12345;MultipleActiveResultSets=True;Application Name=EntityFramework";

		public void care_log_insert(care_log care_log)
		{
			SqlConnection sqlConnection = new SqlConnection(ConnStr);
			SqlCommand sqlCommand = new SqlCommand(
				@"INSERT into care_log_db (usr_name,tim,worker_name,pic_place,BA01,BA02,BA03,BA04,BA05,BA06,BA07,BA08,BA09,BA10)
				VALUES(@usr_name,@tim,@worker_name,@pic_place,@BA01,@BA02,@BA03,@BA04,@BA05,@BA06,@BA07,@BA08,@BA09,@BA10)");
			sqlCommand.Connection = sqlConnection;
			sqlCommand.Parameters.Add(new SqlParameter("@usr_name", care_log.usr_name));
			sqlCommand.Parameters.Add(new SqlParameter("@tim", care_log.tim));
			sqlCommand.Parameters.Add(new SqlParameter("@worker_name", care_log.worker_name));
			sqlCommand.Parameters.Add(new SqlParameter("@pic_place", care_log.pic_place));
			sqlCommand.Parameters.Add(new SqlParameter("@BA01", care_log.BA01));
			if (care_log.BA02 == null)
				sqlCommand.Parameters.Add(new SqlParameter("@BA02", DBNull.Value));
			else
				sqlCommand.Parameters.Add(new SqlParameter("@BA02", care_log.BA02));
			if (care_log.BA03 == null)
				sqlCommand.Parameters.Add(new SqlParameter("@BA03", DBNull.Value));
			else
				sqlCommand.Parameters.Add(new SqlParameter("@BA03", care_log.BA03));
			if (care_log.BA04 == null)
				sqlCommand.Parameters.Add(new SqlParameter("@BA04", DBNull.Value));
			else
				sqlCommand.Parameters.Add(new SqlParameter("@BA04", care_log.BA04));
			if (care_log.BA05 == null)
				sqlCommand.Parameters.Add(new SqlParameter("@BA05", DBNull.Value));
			else
				sqlCommand.Parameters.Add(new SqlParameter("@BA05", care_log.BA05));
			if (care_log.BA06 == null)
				sqlCommand.Parameters.Add(new SqlParameter("@BA06", DBNull.Value));
			else
				sqlCommand.Parameters.Add(new SqlParameter("@BA06", care_log.BA06));
			if (care_log.BA07 == null)
				sqlCommand.Parameters.Add(new SqlParameter("@BA07", DBNull.Value));
			else
				sqlCommand.Parameters.Add(new SqlParameter("@BA07", care_log.BA07));
			if (care_log.BA08 == null)
				sqlCommand.Parameters.Add(new SqlParameter("@BA08", DBNull.Value));
			else
				sqlCommand.Parameters.Add(new SqlParameter("@BA08", care_log.BA08));
			if (care_log.BA09 == null)
				sqlCommand.Parameters.Add(new SqlParameter("@BA09", DBNull.Value));
			else
				sqlCommand.Parameters.Add(new SqlParameter("@BA09", care_log.BA09));
			sqlConnection.Open();
			sqlCommand.ExecuteNonQuery();
			sqlConnection.Close();
		}

		public care_log sign_in_db_select(string UserId)
		{
			care_log care_log = new care_log();
			SqlConnection sqlConnection = new SqlConnection(ConnStr);
			SqlCommand sqlCommand = new SqlCommand("SELECT * FROM sign_in_db WHERE usr_index = @usr_index");
			sqlCommand.Connection = sqlConnection;
			sqlCommand.Parameters.Add(new SqlParameter("@usr_index", UserId));
			sqlConnection.Open();

			SqlDataReader reader = sqlCommand.ExecuteReader();
			if (reader.HasRows)
			{
				while (reader.Read())
				{
					care_log = new care_log
					{
						usr_name = reader.GetString(reader.GetOrdinal("@usr_name")),
						tim = reader.GetString(reader.GetOrdinal("@tim")),
						worker_name = reader.GetString(reader.GetOrdinal("@worker_name")),
						pic_place = reader.GetString(reader.GetOrdinal("@pic_place")),
						BA01 = reader.GetString(reader.GetOrdinal("@BA01")),
						BA02 = reader.GetString(reader.GetOrdinal("@BA02")),
						BA03 = reader.GetString(reader.GetOrdinal("@BA03")),
						BA04 = reader.GetString(reader.GetOrdinal("@AB04")),
						BA05 = reader.GetString(reader.GetOrdinal("@BA05")),
						BA06 = reader.GetString(reader.GetOrdinal("@BA06")),
						BA07 = reader.GetString(reader.GetOrdinal("@BA07")),
						BA08 = reader.GetString(reader.GetOrdinal("@BA08")),
						BA09 = reader.GetString(reader.GetOrdinal("@BA09")),
						BA10 = reader.GetString(reader.GetOrdinal("@BA10")),

					};
				}
			}
			sqlConnection.Close();
			return care_log;
		}
	}
}