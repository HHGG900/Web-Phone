using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Web_Phone.Models
{
	public class care_place_db
	{
		private readonly string ConnStr = "Data Source=webphone20201109.database.windows.net;Initial Catalog=webphone1109;Persist Security Info=True;User ID=oa123;Password=OOaa12345;MultipleActiveResultSets=True;Application Name=EntityFramework";

		public void Care_place_insert(Care_place care_place)
		{


			SqlConnection sqlConnection = new SqlConnection(ConnStr);
			SqlCommand sqlCommand = new SqlCommand(
				@"INSERT into Care_place_db (usr_name,tim,pic_place,BA01,BA02,BA03,BA04,BA05,BA06,BA07,BA08,BA09,BA010,BA01_tem,BA02_tem,BA03_tem,BA04_tem,BA05_tem,BA06_tem,BA07_tem,BA08_tem,BA09_tem,BA010_tem)
							VALUES(@usr_name,@tim,@pic_place,@BA01,@BA02,@BA03,@BA04,@BA05,@BA06,@BA07,@BA08,@BA09,@BA10,@BA01_tem,@BA02_tem,@BA03_tem,@BA04_tem,@BA05_tem,@BA06_tem,@BA07_tem,@BA08_tem,@BA09_tem,@BA010_tem)");
			sqlCommand.Connection = sqlConnection;
			sqlCommand.Parameters.Add(new SqlParameter("@usr_name", care_place.usr_name));
			sqlCommand.Parameters.Add(new SqlParameter("@tim", care_place.tim));
			sqlCommand.Parameters.Add(new SqlParameter("@worker_name", care_place.worker_name));
			sqlCommand.Parameters.Add(new SqlParameter("@pic_place", care_place.pic_place));
			sqlCommand.Parameters.Add(new SqlParameter("@BA01", care_place.BA01));
			if (care_place.BA02 == null)
				sqlCommand.Parameters.Add(new SqlParameter("@BA02", DBNull.Value));
			else
				sqlCommand.Parameters.Add(new SqlParameter("@BA02", care_place.BA02));
			if (care_place.BA03 == null)
				sqlCommand.Parameters.Add(new SqlParameter("@BA03", DBNull.Value));
			else
				sqlCommand.Parameters.Add(new SqlParameter("@BA03", care_place.BA03));
			if (care_place.BA04 == null)
				sqlCommand.Parameters.Add(new SqlParameter("@BA04", DBNull.Value));
			else
				sqlCommand.Parameters.Add(new SqlParameter("@BA04", care_place.BA04));
			if (care_place.BA05 == null)
				sqlCommand.Parameters.Add(new SqlParameter("@BA05", DBNull.Value));
			else
				sqlCommand.Parameters.Add(new SqlParameter("@BA05", care_place.BA05));
			if (care_place.BA06 == null)
				sqlCommand.Parameters.Add(new SqlParameter("@BA06", DBNull.Value));
			else
				sqlCommand.Parameters.Add(new SqlParameter("@BA06", care_place.BA06));
			if (care_place.BA07 == null)
				sqlCommand.Parameters.Add(new SqlParameter("@BA07", DBNull.Value));
			else
				sqlCommand.Parameters.Add(new SqlParameter("@BA07", care_place.BA07));
			if (care_place.BA08 == null)
				sqlCommand.Parameters.Add(new SqlParameter("@BA08", DBNull.Value));
			else
				sqlCommand.Parameters.Add(new SqlParameter("@BA08", care_place.BA08));
			if (care_place.BA09 == null)
				sqlCommand.Parameters.Add(new SqlParameter("@BA09", DBNull.Value));
			else
				sqlCommand.Parameters.Add(new SqlParameter("@BA09", care_place.BA09));

			sqlCommand.Parameters.Add(new SqlParameter("@BA01_tem", care_place.BA01_tem));
			if (care_place.BA02 == null)
				sqlCommand.Parameters.Add(new SqlParameter("@BA02_tem", DBNull.Value));
			else
				sqlCommand.Parameters.Add(new SqlParameter("@BA02_tem", care_place.BA02_tem));
			if (care_place.BA03 == null)
				sqlCommand.Parameters.Add(new SqlParameter("@BA03_tem", DBNull.Value));
			else
				sqlCommand.Parameters.Add(new SqlParameter("@BA03_tem", care_place.BA03_tem));
			if (care_place.BA04 == null)
				sqlCommand.Parameters.Add(new SqlParameter("@BA04_tem", DBNull.Value));
			else
				sqlCommand.Parameters.Add(new SqlParameter("@BA04_tem", care_place.BA04_tem));
			if (care_place.BA05 == null)
				sqlCommand.Parameters.Add(new SqlParameter("@BA05_tem", DBNull.Value));
			else
				sqlCommand.Parameters.Add(new SqlParameter("@BA05_tem", care_place.BA05_tem));
			if (care_place.BA06 == null)
				sqlCommand.Parameters.Add(new SqlParameter("@BA06_tem", DBNull.Value));
			else
				sqlCommand.Parameters.Add(new SqlParameter("@BA06_tem", care_place.BA06_tem));
			if (care_place.BA07 == null)
				sqlCommand.Parameters.Add(new SqlParameter("@BA07_tem", DBNull.Value));
			else
				sqlCommand.Parameters.Add(new SqlParameter("@BA07_tem", care_place.BA07_tem));
			if (care_place.BA08 == null)
				sqlCommand.Parameters.Add(new SqlParameter("@BA08_tem", DBNull.Value));
			else
				sqlCommand.Parameters.Add(new SqlParameter("@BA08_tem", care_place.BA08_tem));
			if (care_place.BA09 == null)
				sqlCommand.Parameters.Add(new SqlParameter("@BA09_tem", DBNull.Value));
			else
				sqlCommand.Parameters.Add(new SqlParameter("@BA09_tem", care_place.BA09_tem));

			sqlConnection.Open();
			sqlCommand.ExecuteNonQuery();
			sqlConnection.Close();

		}
		public List<Care_place> Care_place_select(string UserId)
		{
			List<Care_place> care_place = new List<Care_place>();
			SqlConnection sqlConnection = new SqlConnection(ConnStr);
			SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Care_place_db WHERE usr_name = @usr_name " +
													"and tim = SELECT MAX(tim) FROM Care_place_db ");
			sqlCommand.Connection = sqlConnection;
			sqlCommand.Parameters.Add(new SqlParameter("@usr_name", UserId));
			sqlConnection.Open();

			SqlDataReader reader = sqlCommand.ExecuteReader();
			if (reader.HasRows)
			{
				while (reader.Read())
				{
					Care_place care = new Care_place
					{
						usr_name = reader.GetString(reader.GetOrdinal("usr_name")),
						tim = reader.GetDateTime(reader.GetOrdinal("tim")),
						worker_name = reader.GetString(reader.GetOrdinal("worker_name")),
						pic_place = reader.GetString(reader.GetOrdinal("pic_place")),
						BA01 = reader.GetString(reader.GetOrdinal("BA01")),
						BA02 = reader.GetString(reader.GetOrdinal("BA02")),
						BA03 = reader.GetString(reader.GetOrdinal("BA03")),
						BA04 = reader.GetString(reader.GetOrdinal("BA04")),
						BA05 = reader.GetString(reader.GetOrdinal("BA05")),
						BA06 = reader.GetString(reader.GetOrdinal("BA06")),
						BA07 = reader.GetString(reader.GetOrdinal("BA07")),
						BA08 = reader.GetString(reader.GetOrdinal("BA08")),
						BA09 = reader.GetString(reader.GetOrdinal("BA09")),
						BA10 = reader.GetString(reader.GetOrdinal("BA10")),
						BA01_tem = reader.GetInt16(reader.GetOrdinal("BA01_tem")),
						BA02_tem = reader.GetInt16(reader.GetOrdinal("BA02_tem")),
						BA03_tem = reader.GetInt16(reader.GetOrdinal("BA03_tem")),
						BA04_tem = reader.GetInt16(reader.GetOrdinal("BA04_tem")),
						BA05_tem = reader.GetInt16(reader.GetOrdinal("BA05_tem")),
						BA06_tem = reader.GetInt16(reader.GetOrdinal("BA06_tem")),
						BA07_tem = reader.GetInt16(reader.GetOrdinal("BA07_tem")),
						BA08_tem = reader.GetInt16(reader.GetOrdinal("BA08_tem")),
						BA09_tem = reader.GetInt16(reader.GetOrdinal("BA09_tem"))
					};
					care_place.Add(care);
				}
			}
			sqlConnection.Close();
			return care_place;
		}

		public void Care_place_update(Care_place care_place, DateTime tim)
		{
			SqlConnection sqlConnection = new SqlConnection(ConnStr);
			SqlCommand sqlCommand = new SqlCommand(
				@"UPDATE Care_place_db SET(pic_place, BA01, BA02, BA03, BA04, BA05, BA06, BA07, BA08, BA09, BA010, BA01_tem, BA02_tem, BA03_tem, BA04_tem, BA05_tem, BA06_tem, BA07_tem, BA08_tem, BA09_tem, BA010_tem)
							VALUES( @pic_place, @BA01, @BA02, @BA03, @BA04, @BA05, @BA06, @BA07, @BA08, @BA09, @BA10, @BA01_tem, @BA02_tem, @BA03_tem, @BA04_tem, @BA05_tem, @BA06_tem, @BA07_tem, @BA08_tem, @BA09_tem, @BA010_tem)
							WHERE usr_name = @usr_name and tim = @tim");
			sqlCommand.Connection = sqlConnection;

			sqlCommand.Parameters.Add(new SqlParameter("@usr_name", care_place.usr_name));
			sqlCommand.Parameters.Add(new SqlParameter("@tim", care_place.tim));
			sqlCommand.Parameters.Add(new SqlParameter("@worker_name", care_place.worker_name));
			sqlCommand.Parameters.Add(new SqlParameter("@pic_place", care_place.pic_place));
			sqlCommand.Parameters.Add(new SqlParameter("@BA01", care_place.BA01));
			if (care_place.BA02 == null)
				sqlCommand.Parameters.Add(new SqlParameter("@BA02", DBNull.Value));
			else
				sqlCommand.Parameters.Add(new SqlParameter("@BA02", care_place.BA02));
			if (care_place.BA03 == null)
				sqlCommand.Parameters.Add(new SqlParameter("@BA03", DBNull.Value));
			else
				sqlCommand.Parameters.Add(new SqlParameter("@BA03", care_place.BA03));
			if (care_place.BA04 == null)
				sqlCommand.Parameters.Add(new SqlParameter("@BA04", DBNull.Value));
			else
				sqlCommand.Parameters.Add(new SqlParameter("@BA04", care_place.BA04));
			if (care_place.BA05 == null)
				sqlCommand.Parameters.Add(new SqlParameter("@BA05", DBNull.Value));
			else
				sqlCommand.Parameters.Add(new SqlParameter("@BA05", care_place.BA05));
			if (care_place.BA06 == null)
				sqlCommand.Parameters.Add(new SqlParameter("@BA06", DBNull.Value));
			else
				sqlCommand.Parameters.Add(new SqlParameter("@BA06", care_place.BA06));
			if (care_place.BA07 == null)
				sqlCommand.Parameters.Add(new SqlParameter("@BA07", DBNull.Value));
			else
				sqlCommand.Parameters.Add(new SqlParameter("@BA07", care_place.BA07));
			if (care_place.BA08 == null)
				sqlCommand.Parameters.Add(new SqlParameter("@BA08", DBNull.Value));
			else
				sqlCommand.Parameters.Add(new SqlParameter("@BA08", care_place.BA08));
			if (care_place.BA09 == null)
				sqlCommand.Parameters.Add(new SqlParameter("@BA09", DBNull.Value));
			else
				sqlCommand.Parameters.Add(new SqlParameter("@BA09", care_place.BA09));

			sqlCommand.Parameters.Add(new SqlParameter("@BA01_tem", care_place.BA01_tem));
			sqlCommand.Parameters.Add(new SqlParameter("@BA02_tem", care_place.BA02_tem));
			sqlCommand.Parameters.Add(new SqlParameter("@BA03_tem", care_place.BA03_tem));
			sqlCommand.Parameters.Add(new SqlParameter("@BA04_tem", care_place.BA04_tem));
			sqlCommand.Parameters.Add(new SqlParameter("@BA05_tem", care_place.BA05_tem));
			sqlCommand.Parameters.Add(new SqlParameter("@BA06_tem", care_place.BA06_tem));
			sqlCommand.Parameters.Add(new SqlParameter("@BA07_tem", care_place.BA07_tem));
			sqlCommand.Parameters.Add(new SqlParameter("@BA08_tem", care_place.BA08_tem));
			sqlCommand.Parameters.Add(new SqlParameter("@BA09_tem", care_place.BA09_tem));

			sqlCommand.ExecuteNonQuery();
			sqlConnection.Close();
		}
	}
}