using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Web_Phone.Models
{
	public class Guarding_records_every_moon_db
	{
		private readonly string ConnStr = "Data Source=WIN-6M12QM5R44F;Initial Catalog=webphone;Persist Security Info=True;User ID=sa;Password=1qaz!QAZ;MultipleActiveResultSets=True;Application Name=EntityFramework";

		public void Guarding_records_every_moon_insert(Guarding_records_every_moon Guarding_records_every_moon)
		{
			Guarding_records_every_moon.time_m = DateTime.Now.AddHours(6).ToString("yyyy/MM/dd HH.mm");
			SqlConnection sqlConnection = new SqlConnection(ConnStr);
			SqlCommand sqlCommand = new SqlCommand(
				@"INSERT INTO Guarding_records_every_moon (caser_name,worker_name,signatur,time_m,pressure_all,resources_all,sight,listen,languag,understand,assistive,muscle_status,abuse,safet)
				VALUES(@caser_name,@worker_name,@signatur,@time_m,@pressure_all,@resources_all,@sight,@listen,@languag,@understand,@assistive,@muscle_status,@abuse,@safet)");
			sqlCommand.Connection = sqlConnection;
			sqlCommand.Parameters.Add(new SqlParameter("@caser_name", Guarding_records_every_moon.caser_name));
			sqlCommand.Parameters.Add(new SqlParameter("@worker_name", Guarding_records_every_moon.worker_name));
			if(Guarding_records_every_moon.signatur == null)
				sqlCommand.Parameters.Add(new SqlParameter("@signatur",DBNull.Value));
			else
				sqlCommand.Parameters.Add(new SqlParameter("@signatur", Guarding_records_every_moon.signatur));
			sqlCommand.Parameters.Add(new SqlParameter("@time_m", Guarding_records_every_moon.time_m));
			sqlCommand.Parameters.Add(new SqlParameter("@pressure_all", Guarding_records_every_moon.pressure_all));
			sqlCommand.Parameters.Add(new SqlParameter("@resources_all", Guarding_records_every_moon.resources_all));
			sqlCommand.Parameters.Add(new SqlParameter("@sight", Guarding_records_every_moon.sight));
			sqlCommand.Parameters.Add(new SqlParameter("@listen", Guarding_records_every_moon.listen));
			sqlCommand.Parameters.Add(new SqlParameter("@languag", Guarding_records_every_moon.languag));
			sqlCommand.Parameters.Add(new SqlParameter("@understand", Guarding_records_every_moon.understand));
			sqlCommand.Parameters.Add(new SqlParameter("@assistive", Guarding_records_every_moon.assistive));
			sqlCommand.Parameters.Add(new SqlParameter("@muscle_status", Guarding_records_every_moon.muscle_status));
			sqlCommand.Parameters.Add(new SqlParameter("@abuse", Guarding_records_every_moon.abuse));
			sqlCommand.Parameters.Add(new SqlParameter("@safet", Guarding_records_every_moon.safet));
			sqlConnection.Open();
			sqlCommand.ExecuteNonQuery();
			sqlConnection.Close();
		}

		public Guarding_records_every_moon Guarding_records_every_moon_select(string UserId)
		{
			Guarding_records_every_moon guarding_records_every_moon = new Guarding_records_every_moon();
			SqlConnection sqlConnection = new SqlConnection(ConnStr);
			SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Guarding_records_every_moon WHERE caser_name = @caser_name");
			sqlCommand.Connection = sqlConnection;
			sqlCommand.Parameters.Add(new SqlParameter("@caser_name", UserId));
			sqlConnection.Open();

			SqlDataReader reader = sqlCommand.ExecuteReader();
			if (reader.HasRows)
			{
				while (reader.Read())
				{
					guarding_records_every_moon = new Guarding_records_every_moon
					{
						caser_name = reader.GetString(reader.GetOrdinal("caser_name")),
						worker_name = reader.GetString(reader.GetOrdinal("worker_name")),
						signatur = reader.GetString(reader.GetOrdinal("signatur")),
						time_m = reader.GetString(reader.GetOrdinal("time_m")),
						pressure_all = reader.GetString(reader.GetOrdinal("pressure_all")),
						resources_all = reader.GetString(reader.GetOrdinal("resources_all")),
						sight = reader.GetString(reader.GetOrdinal("sight")),
						listen = reader.GetString(reader.GetOrdinal("listen")),
						languag = reader.GetString(reader.GetOrdinal("languag")),
						understand = reader.GetString(reader.GetOrdinal("understand")),
						assistive = reader.GetString(reader.GetOrdinal("assistive")),
						muscle_status = reader.GetString(reader.GetOrdinal("muscle_status")),
						abuse = reader.GetString(reader.GetOrdinal("abuse")),
						safet = reader.GetString(reader.GetOrdinal("safet")),
						ten_key = reader.GetString(reader.GetOrdinal("ten_key"))
					};
				}
			}
			sqlConnection.Close();
			return guarding_records_every_moon;
		}
	}
}