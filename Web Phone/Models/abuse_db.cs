using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Web_Phone.Models
{
	public class abuse_db
	{
		private readonly string ConnStr = "Data Source=WIN-6M12QM5R44F;Initial Catalog=webphone;Persist Security Info=True;User ID=sa;Password=1qaz!QAZ;MultipleActiveResultSets=True;Application Name=EntityFramework";
		/*
				public void abuse_db_insert(abuse abuse)
				{
					SqlConnection sqlConnection = new SqlConnection(ConnStr);
					SqlCommand sqlCommand = new SqlCommand(
						@"INSERT INTO abuse_db (caser_name,tim,one,twe,there,four,five,six,seven,eight,nine,ten,eleven)
						VALUES(@caser_name,@tim,@one,@twe,@there,@four,@five,@six,@seven,@eight,@nine,@ten,@eleven)");
					sqlCommand.Connection = sqlConnection;
					sqlCommand.Parameters.Add(new SqlParameter("@caser_name", abuse.caser_name));
					sqlCommand.Parameters.Add(new SqlParameter("@tim", abuse.tim));
					sqlCommand.Parameters.Add(new SqlParameter("@one", abuse.one));
					sqlCommand.Parameters.Add(new SqlParameter("@twe", abuse.twe));
					sqlCommand.Parameters.Add(new SqlParameter("@there", abuse.there));
					sqlCommand.Parameters.Add(new SqlParameter("@four", abuse.four));
					sqlCommand.Parameters.Add(new SqlParameter("@five", abuse.five));
					sqlCommand.Parameters.Add(new SqlParameter("@six", abuse.six));
					sqlCommand.Parameters.Add(new SqlParameter("@seven", abuse.seven));
					sqlCommand.Parameters.Add(new SqlParameter("@eight", abuse.eight));
					sqlCommand.Parameters.Add(new SqlParameter("@nine", abuse.nine));
					sqlCommand.Parameters.Add(new SqlParameter("@ten", abuse.ten));
					sqlCommand.Parameters.Add(new SqlParameter("@eleven", abuse.eleven));
					sqlConnection.Open();
					sqlCommand.ExecuteNonQuery();
					sqlConnection.Close();
				}

				public abuse sign_in_db_select(string UserId)
				{
					abuse abuse = new abuse();
					SqlConnection sqlConnection = new SqlConnection(ConnStr);
					SqlCommand sqlCommand = new SqlCommand("SELECT * FROM abuse_db WHERE caser_name = @caser_name");
					sqlCommand.Connection = sqlConnection;
					sqlCommand.Parameters.Add(new SqlParameter("@caser_name", UserId));
					sqlConnection.Open();

					SqlDataReader reader = sqlCommand.ExecuteReader();
					if (reader.HasRows)
					{
						while (reader.Read())
						{
							abuse = new abuse
							{
								caser_name = reader.GetString(reader.GetOrdinal("caser_name")),
								tim = reader.GetString(reader.GetOrdinal("tim")),
								one = reader.GetInt32(reader.GetOrdinal("one")),
								twe = reader.GetInt32(reader.GetOrdinal("twe")),
								there = reader.GetInt32(reader.GetOrdinal("there")),
								four = reader.GetInt32(reader.GetOrdinal("four")),
								five = reader.GetInt32(reader.GetOrdinal("five")),
								six = reader.GetInt32(reader.GetOrdinal("six")),
								seven = reader.GetInt32(reader.GetOrdinal("seven")),
								eight = reader.GetInt32(reader.GetOrdinal("eight")),
								nine = reader.GetInt32(reader.GetOrdinal("nine")),
								ten = reader.GetInt32(reader.GetOrdinal("ten")),
								eleven = reader.GetInt32(reader.GetOrdinal("eleven")),
							};
						}
					}
					sqlConnection.Close();
					return abuse;
				}*/
	}
}