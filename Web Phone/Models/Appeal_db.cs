using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace Web_Phone.Models
{
	public class Appeal_db
	{
		private readonly string ConnStr = "Data Source=WIN-6M12QM5R44F;Initial Catalog=webphone;Persist Security Info=True;User ID=sa;Password=1qaz!QAZ;MultipleActiveResultSets=True;Application Name=EntityFramework";

		public void appeal_insert(Appeal appeal)
		{
			SqlConnection sqlConnection = new SqlConnection(ConnStr);
			SqlCommand sqlCommand = new SqlCommand(
				@"INSERT INTO appeal (US_name,user_status,phone,fall_class,conten,pic_one,tim)
				VALUES(@US_name,@user_status,@phone,@fall_class,@conten,@pic_one,@tim)");
			sqlCommand.Connection = sqlConnection;
			sqlCommand.Parameters.Add(new SqlParameter("@US_name", appeal.US_name));
			sqlCommand.Parameters.Add(new SqlParameter("@user_status", appeal.user_status));
			sqlCommand.Parameters.Add(new SqlParameter("@phone", appeal.phone));
			sqlCommand.Parameters.Add(new SqlParameter("@fall_class", appeal.fall_class));
			sqlCommand.Parameters.Add(new SqlParameter("@conten", appeal.conten));
			sqlCommand.Parameters.Add(new SqlParameter("@tim", appeal.tim));
			if (appeal.pic_one == null)
				sqlCommand.Parameters.Add(new SqlParameter("@pic_pne", DBNull.Value));
			else
				sqlCommand.Parameters.Add(new SqlParameter("@pic_one", appeal.pic_one));

			sqlConnection.Open();
			sqlCommand.ExecuteNonQuery();
			sqlConnection.Close();
		}

		public Appeal appeal_select(string US_name)
		{
			Appeal appeal = new Appeal();
			SqlConnection sqlConnection = new SqlConnection(ConnStr);
			SqlCommand sqlCommand = new SqlCommand("SELECT * FROM appeal WHERE US_name = @US_name");
			sqlCommand.Connection = sqlConnection;
			sqlCommand.Parameters.Add(new SqlParameter("@US_name", US_name));
			sqlConnection.Open();

			SqlDataReader reader = sqlCommand.ExecuteReader();
			if (reader.HasRows)
			{
				while (reader.Read())
				{
					appeal = new Appeal
					{
						US_name = reader.GetString(reader.GetOrdinal("US_name")),
						user_status = reader.GetString(reader.GetOrdinal("user_status")),
						phone = reader.GetInt32(reader.GetOrdinal("phone")),
						fall_class = reader.GetString(reader.GetOrdinal("fall_class")),
						conten = reader.GetString(reader.GetOrdinal("conten")),
						pic_one = reader.GetString(reader.GetOrdinal("pic_one")),
						tim = reader.GetDateTime(reader.GetOrdinal("tim"))

					};
				}
			}
			sqlConnection.Close();
			return appeal;
		}
	}
}