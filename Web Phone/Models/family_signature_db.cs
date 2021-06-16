using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Web_Phone.Models
{
	public class family_signature_db
	{
		private readonly string ConnStr = "Data Source=webphone20201109.database.windows.net;Initial Catalog=webphone1109;Persist Security Info=True;User ID=oa123;Password=OOaa12345;MultipleActiveResultSets=True;Application Name=EntityFramework";
		/*
				public void family_signature_insert(Family_signature family_signature)
				{
					SqlConnection sqlConnection = new SqlConnection(ConnStr);
					SqlCommand sqlCommand = new SqlCommand(
						@"INSERT into family_signature_db (caser_name, signature_time, seal_place_one, seal_place_twe)
						VALUES (@caser_name, @signature_time, @seal_place_one, @seal_place_twe)");
					sqlCommand.Connection = sqlConnection;
					sqlCommand.Parameters.Add(new SqlParameter("@caser_name", family_signature.caser_name));
					sqlCommand.Parameters.Add(new SqlParameter("@signature_time", family_signature.signature_time));
					if (family_signature.seal_place_one == null)
						sqlCommand.Parameters.Add(new SqlParameter("@seal_place_one", DBNull.Value));
					else
						sqlCommand.Parameters.Add(new SqlParameter("@seal_place_one", family_signature.seal_place_one));
					if (family_signature.seal_place_twe == null)
						sqlCommand.Parameters.Add(new SqlParameter("@seal_place_twe", DBNull.Value));
					else
						sqlCommand.Parameters.Add(new SqlParameter("@seal_place_twe", family_signature.seal_place_twe));
					sqlConnection.Open();
					sqlCommand.ExecuteNonQuery();
					sqlConnection.Close();
				}

				public Family_signature family_signature_select(string UserId)
				{
					Family_signature family_signature = new Family_signature();
					SqlConnection sqlConnection = new SqlConnection(ConnStr);
					SqlCommand sqlCommand = new SqlCommand("SELECT * FROM family_signature_db WHERE caser_name = @caser_name");
					sqlCommand.Connection = sqlConnection;
					sqlCommand.Parameters.Add(new SqlParameter("@caser_name", UserId));
					sqlConnection.Open();

					SqlDataReader reader = sqlCommand.ExecuteReader();
					if (reader.HasRows)
					{
						while (reader.Read())
						{
							family_signature = new Family_signature
							{
								caser_name = reader.GetString(reader.GetOrdinal("caser_name")),
								signature_time = reader.GetString(reader.GetOrdinal("signature_time")),
								seal_place_one = reader.GetString(reader.GetOrdinal("seal_place_one")),
								seal_place_twe = reader.GetString(reader.GetOrdinal("seal_place_twe"))
							};
						}
					}
					sqlConnection.Close();
					return family_signature;
				}*/
	}
}