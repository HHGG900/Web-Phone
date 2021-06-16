using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Web_Phone.Models
{
	public class pressure_db
	{
		private readonly string ConnStr = "Data Source=webphone20201109.database.windows.net;Initial Catalog=webphone1109;Persist Security Info=True;User ID=oa123;Password=OOaa12345;MultipleActiveResultSets=True;Application Name=EntityFramework";
		/*
				public void pressure_insert(Pressure pressure)
				{
					SqlConnection sqlConnection = new SqlConnection(ConnStr);
					SqlCommand sqlCommand = new SqlCommand(
						@"INSERT INTO pressure_db (caser_name,tim,one,twe,there,four,five,six,seven,eight,nine,ten,eleven,twelve,thirteen)
						VALUES(@caser_name,@tim,@one,@twe,@there,@four,@five,@six,@seven,@eight,@nine,@ten,@eleven,@twelve,@thirteen)");
					sqlCommand.Connection = sqlConnection;
					sqlCommand.Parameters.Add(new SqlParameter("@caser_name", pressure.caser_name));
					sqlCommand.Parameters.Add(new SqlParameter("@tim", pressure.tim));
					sqlCommand.Parameters.Add(new SqlParameter("@one", pressure.one));
					sqlCommand.Parameters.Add(new SqlParameter("@twe", pressure.twe));
					sqlCommand.Parameters.Add(new SqlParameter("@there", pressure.there));
					sqlCommand.Parameters.Add(new SqlParameter("@four", pressure.four));
					sqlCommand.Parameters.Add(new SqlParameter("@five", pressure.five));
					sqlCommand.Parameters.Add(new SqlParameter("@six", pressure.six));
					sqlCommand.Parameters.Add(new SqlParameter("@seven", pressure.seven));
					sqlCommand.Parameters.Add(new SqlParameter("@eight", pressure.eight));
					sqlCommand.Parameters.Add(new SqlParameter("@nine", pressure.nine));
					sqlCommand.Parameters.Add(new SqlParameter("@ten", pressure.ten));
					sqlCommand.Parameters.Add(new SqlParameter("@eleven", pressure.eleven));
					sqlCommand.Parameters.Add(new SqlParameter("@twelve", pressure.twelve));
					sqlCommand.Parameters.Add(new SqlParameter("@thirteen", pressure.thirteen));
					sqlConnection.Open();
					sqlCommand.ExecuteNonQuery();
					sqlConnection.Close();
				}

				public Pressure pressure_select(string UserId)
				{
					Pressure pressure = new Pressure();
					SqlConnection sqlConnection = new SqlConnection(ConnStr);
					SqlCommand sqlCommand = new SqlCommand("SELECT * FROM pressure_db WHERE caser_name = @caser_name");
					sqlCommand.Connection = sqlConnection;
					sqlCommand.Parameters.Add(new SqlParameter("@caser_name", UserId));
					sqlConnection.Open();

					SqlDataReader reader = sqlCommand.ExecuteReader();
					if (reader.HasRows)
					{
						while (reader.Read())
						{
							pressure = new Pressure
							{
								caser_name = reader.GetString(reader.GetOrdinal("caser_name")),
								tim  = reader.GetInt32(reader.GetOrdinal("tim")),
								one = reader.GetInt32(reader.GetOrdinal("one")),
								twe  = reader.GetInt32(reader.GetOrdinal("twe")),
								there = reader.GetInt32(reader.GetOrdinal("there")),
								four = reader.GetInt32(reader.GetOrdinal("four")),
								five = reader.GetInt32(reader.GetOrdinal("five")),
								six = reader.GetInt32(reader.GetOrdinal("six")),
								seven = reader.GetInt32(reader.GetOrdinal("seven")),
								eight = reader.GetInt32(reader.GetOrdinal("eight")),
								nine = reader.GetInt32(reader.GetOrdinal("nine")),
								ten = reader.GetInt32(reader.GetOrdinal("ten")),
								eleven = reader.GetInt32(reader.GetOrdinal("eleven")),
								twelve = reader.GetInt32(reader.GetOrdinal("twelve")),
								thirteen = reader.GetInt32(reader.GetOrdinal("thirteen")),

							};
						}
					}
					sqlConnection.Close();
					return pressure;
				}*/
	}
}