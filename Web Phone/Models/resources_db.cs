using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Web_Phone.Models
{
	public class resources_db
	{
		private readonly string ConnStr = "Data Source=webphone20201109.database.windows.net;Initial Catalog=webphone1109;Persist Security Info=True;User ID=oa123;Password=OOaa12345;MultipleActiveResultSets=True;Application Name=EntityFramework";
		/*
		public void resources_insert(resources resources)
		{
			SqlConnection sqlConnection = new SqlConnection(ConnStr);
			SqlCommand sqlCommand = new SqlCommand(
				@"INSERT INTO resources_db (caser_name,tim,one,twe,there,four,five,six,seven,eight,nine,ten)
				VALUES(@caser_name,@tim,@one,@twe,@there,@four,@five,@six,@seven,@eight,@nine,@ten)");
			sqlCommand.Connection = sqlConnection;
			sqlCommand.Parameters.Add(new SqlParameter("@caser_name", resources.caser_name));
			sqlCommand.Parameters.Add(new SqlParameter("@tim", resources.tim));
			sqlCommand.Parameters.Add(new SqlParameter("@one", resources.one));
			sqlCommand.Parameters.Add(new SqlParameter("@twe", resources.twe));
			sqlCommand.Parameters.Add(new SqlParameter("@there", resources.there));
			sqlCommand.Parameters.Add(new SqlParameter("@four", resources.four));
			sqlCommand.Parameters.Add(new SqlParameter("@five", resources.five));
			sqlCommand.Parameters.Add(new SqlParameter("@six", resources.six));
			sqlCommand.Parameters.Add(new SqlParameter("@seven", resources.seven));
			sqlCommand.Parameters.Add(new SqlParameter("@eight", resources.eight));
			sqlCommand.Parameters.Add(new SqlParameter("@nine", resources.nine));
			sqlCommand.Parameters.Add(new SqlParameter("@ten", resources.ten));
			sqlConnection.Open();
			sqlCommand.ExecuteNonQuery();
			sqlConnection.Close();
		}

		public resources resources_select(string UserId)
		{
			resources resources = new resources();
			SqlConnection sqlConnection = new SqlConnection(ConnStr);
			SqlCommand sqlCommand = new SqlCommand("SELECT * FROM resources_db WHERE caser_name = @caser_name");
			sqlCommand.Connection = sqlConnection;
			sqlCommand.Parameters.Add(new SqlParameter("@caser_name", UserId));
			sqlConnection.Open();

			SqlDataReader reader = sqlCommand.ExecuteReader();
			if (reader.HasRows)
			{
				while (reader.Read())
				{
					resources = new resources
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
					};
				}
			}
			sqlConnection.Close();
			return resources;
		}*/
	}
}