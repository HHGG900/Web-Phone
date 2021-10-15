using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Web_Phone.Models
{
	public class Guarding_records_every_db
	{
		private readonly string ConnStr = "Data Source=WIN-6M12QM5R44F;Initial Catalog=webphone;Persist Security Info=True;User ID=sa;Password=1qaz!QAZ;MultipleActiveResultSets=True;Application Name=EntityFramework";

		public void Guarding_records_every_insert(Guarding_records_every guarding_records_every)
		{
			SqlConnection sqlConnection = new SqlConnection(ConnStr);
			SqlCommand sqlCommand = new SqlCommand(
				@"INSERT INTO guarding_records_every (caser_name,worker_name,signatur,time_m,temperature,pulse_low,pulse_high,skin_assess,odd_place_yes_no,odd_place,odd_status,odd_range,odd_pic,pain_assess,feel_assess_one,feel_assess_twe,medicine_one,medicine_twe,Precautions)
				VALUES(@caser_name,@worker_name,@signatur,@time_m,@temperature,@pulse_low,@pulse_high,@skin_assess,@odd_place_yes_no,@odd_place,@odd_status,@odd_range,@odd_pic,@pain_assess,@feel_assess_one,@feel_assess_twe,@medicine_one,@medicine_twe,@Precautions)");
			sqlCommand.Connection = sqlConnection;
			sqlCommand.Parameters.Add(new SqlParameter("@caser_name", guarding_records_every.caser_name));
			sqlCommand.Parameters.Add(new SqlParameter("@worker_name", guarding_records_every.worker_name));
			if(guarding_records_every.signatur != null)
				sqlCommand.Parameters.Add(new SqlParameter("@signatur", guarding_records_every.signatur));
			else
				sqlCommand.Parameters.Add(new SqlParameter("@signatur", DBNull.Value));
			sqlCommand.Parameters.Add(new SqlParameter("@time_m",DateTime.Now.AddHours(8)));
			sqlCommand.Parameters.Add(new SqlParameter("@temperature", guarding_records_every.temperature));
			sqlCommand.Parameters.Add(new SqlParameter("@pulse_low", guarding_records_every.pulse_low));
			sqlCommand.Parameters.Add(new SqlParameter("@pulse_high", guarding_records_every.pulse_high));
			if (guarding_records_every.skin_assess != null)
				sqlCommand.Parameters.Add(new SqlParameter("@skin_assess", guarding_records_every.skin_assess));
			else
				sqlCommand.Parameters.Add(new SqlParameter("@skin_assess", DBNull.Value));
			sqlCommand.Parameters.Add(new SqlParameter("@odd_place_yes_no", guarding_records_every.odd_place_yes_no));
			if (guarding_records_every.odd_place != null)
				sqlCommand.Parameters.Add(new SqlParameter("@odd_place", guarding_records_every.odd_pic));
			else
				sqlCommand.Parameters.Add(new SqlParameter("@odd_place", DBNull.Value));
			if (guarding_records_every.odd_status != null)
				sqlCommand.Parameters.Add(new SqlParameter("@odd_status", guarding_records_every.odd_status));
			else
				sqlCommand.Parameters.Add(new SqlParameter("@odd_status", DBNull.Value));
			sqlCommand.Parameters.Add(new SqlParameter("@odd_range", guarding_records_every.odd_range));
			if (guarding_records_every.odd_pic != null)
				sqlCommand.Parameters.Add(new SqlParameter("@odd_pic", guarding_records_every.odd_pic));
			else
				sqlCommand.Parameters.Add(new SqlParameter("@odd_pic", DBNull.Value));
			sqlCommand.Parameters.Add(new SqlParameter("@pain_assess", guarding_records_every.pain_assess));
			sqlCommand.Parameters.Add(new SqlParameter("@feel_assess_one", guarding_records_every.feel_assess_one));
			sqlCommand.Parameters.Add(new SqlParameter("@feel_assess_twe", guarding_records_every.feel_assess_twe));
			sqlCommand.Parameters.Add(new SqlParameter("@medicine_one", guarding_records_every.medicine_one));
			sqlCommand.Parameters.Add(new SqlParameter("@medicine_twe", guarding_records_every.medicine_twe));
			sqlCommand.Parameters.Add(new SqlParameter("@Precautions", guarding_records_every.Precautions));
			sqlConnection.Open();
			sqlCommand.ExecuteNonQuery();
			sqlConnection.Close();
		}

		public Guarding_records_every Guarding_records_every_select(string caser_name)
		{
			Guarding_records_every guarding_records_every = new Guarding_records_every();
			SqlConnection sqlConnection = new SqlConnection(ConnStr);
			SqlCommand sqlCommand = new SqlCommand("SELECT * FROM guarding_records_every WHERE caser_name = @caser_name");
			sqlCommand.Connection = sqlConnection;
			sqlCommand.Parameters.Add(new SqlParameter("@caser_name", caser_name));
			sqlConnection.Open();

			SqlDataReader reader = sqlCommand.ExecuteReader();
			if (reader.HasRows)
			{
				while (reader.Read())
				{
					guarding_records_every = new Guarding_records_every
					{
						caser_name = reader.GetString(reader.GetOrdinal("caser_name" )),
						worker_name = reader.GetString(reader.GetOrdinal("worker_name" )),
						signatur = reader.GetString(reader.GetOrdinal("signatur" )),
						time_m = reader.GetDateTime(reader.GetOrdinal("time_m" )),
						temperature = reader.GetFloat(reader.GetOrdinal("temperature" )),
						pulse_low = reader.GetInt16(reader.GetOrdinal("pulse_low" )),
						pulse_high = reader.GetInt16(reader.GetOrdinal("pulse_high" )),
						skin_assess = reader.GetString(reader.GetOrdinal("skin_assess" )),
						odd_place_yes_no = reader.GetString(reader.GetOrdinal("odd_place_yes_no" )),
						odd_place = reader.GetString(reader.GetOrdinal("odd_place" )),
						odd_status = reader.GetString(reader.GetOrdinal("odd_status" )),
						odd_range = reader.GetString(reader.GetOrdinal("odd_range" )),
						odd_pic = reader.GetString(reader.GetOrdinal("odd_pic" )),
						pain_assess = reader.GetString(reader.GetOrdinal("pain_assess" )),
						feel_assess_one = reader.GetString(reader.GetOrdinal("feel_assess_one" )),
						feel_assess_twe = reader.GetString(reader.GetOrdinal("feel_assess_twe" )),
						medicine_one = reader.GetString(reader.GetOrdinal("medicine_one" )),
						medicine_twe = reader.GetString(reader.GetOrdinal("medicine_twe" )),
						Precautions = reader.GetString(reader.GetOrdinal("Precautions" ))
					};
				}
			}
			sqlConnection.Close();
			return guarding_records_every;
		}
	}
}