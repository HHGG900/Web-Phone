using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Web_Phone.Models
{
	public class fall_down_db
	{
		private readonly string ConnStr = "Data Source=webphone20201109.database.windows.net;Initial Catalog=webphone1109;Persist Security Info=True;User ID=oa123;Password=OOaa12345;MultipleActiveResultSets=True;Application Name=EntityFramework";

		public void fall_down_insert(fall_down fall_down)
		{
			SqlConnection sqlConnection = new SqlConnection(ConnStr);
			SqlCommand sqlCommand = new SqlCommand(
				@"INSㄊERT INTO fall_down_db (caser_name,tim,one,twe,there,four,five,six,seven,eight,nine,ten,eleven,twelve,thirteen)
				VALUES(@caser_name,@tim,@one,@twe,@there,@four,@five,@six,@seven,@eight,@nine,@ten,@eleven)");
			sqlCommand.Connection = sqlConnection;
			sqlCommand.Parameters.Add(new SqlParameter("@caser_name", fall_down.caser_name));
			sqlCommand.Parameters.Add(new SqlParameter("@tim", fall_down.tim));
			sqlCommand.Parameters.Add(new SqlParameter("@one", fall_down.one));
			sqlCommand.Parameters.Add(new SqlParameter("@twe", fall_down.twe));
			sqlCommand.Parameters.Add(new SqlParameter("@there", fall_down.there));
			sqlCommand.Parameters.Add(new SqlParameter("@four", fall_down.four));
			sqlCommand.Parameters.Add(new SqlParameter("@five", fall_down.five));
			sqlCommand.Parameters.Add(new SqlParameter("@six", fall_down.six));
			sqlCommand.Parameters.Add(new SqlParameter("@seven", fall_down.seven));
			sqlCommand.Parameters.Add(new SqlParameter("@eight", fall_down.eight));
			sqlCommand.Parameters.Add(new SqlParameter("@nine", fall_down.nine));
			sqlCommand.Parameters.Add(new SqlParameter("@ten", fall_down.ten));
			sqlCommand.Parameters.Add(new SqlParameter("@eleven", fall_down.eleven));
			sqlConnection.Open();
			sqlCommand.ExecuteNonQuery();
			sqlConnection.Close();
		}

		public fall_down fall_down_select(string UserId)
		{
			fall_down fall_down = new fall_down();
			SqlConnection sqlConnection = new SqlConnection(ConnStr);
			SqlCommand sqlCommand = new SqlCommand("SELECT * FROM fall_down_db WHERE caser_name = @caser_name");
			sqlCommand.Connection = sqlConnection;
			sqlCommand.Parameters.Add(new SqlParameter("@caser_name", UserId));
			sqlConnection.Open();

			SqlDataReader reader = sqlCommand.ExecuteReader();
			if (reader.HasRows)
			{
				while (reader.Read())
				{
					fall_down = new fall_down
					{
						caser_name = reader.GetString(reader.GetOrdinal("caser_name")),
						tim = reader.GetString(reader.GetOrdinal("tim")),
						one = reader.GetString(reader.GetOrdinal("one")),
						twe = reader.GetString(reader.GetOrdinal("twe")),
						there = reader.GetString(reader.GetOrdinal("there")),
						four = reader.GetString(reader.GetOrdinal("four")),
						five = reader.GetString(reader.GetOrdinal("five")),
						six = reader.GetString(reader.GetOrdinal("six")),
						seven = reader.GetString(reader.GetOrdinal("seven")),
						eight = reader.GetString(reader.GetOrdinal("eight")),
						nine = reader.GetString(reader.GetOrdinal("nine")),
						ten = reader.GetString(reader.GetOrdinal("ten")),
						eleven = reader.GetString(reader.GetOrdinal("eleven"))

					};
				}
			}
			sqlConnection.Close();
			return fall_down;
		}
	}
}