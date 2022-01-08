using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Web_Phone.Models
{
	public class worker_arrive_db
	{
		private readonly string ConnStr = "Data Source=WIN-6M12QM5R44F;Initial Catalog=webphone;Persist Security Info=True;User ID=sa;Password=1qaz!QAZ;MultipleActiveResultSets=True;Application Name=EntityFramework";

		public void worker_arrive_insert(string name)
		{
			string date = string.Format(DateTime.Now.ToString("yyyy-MM-dd"));
			string time = string.Format(DateTime.Now.ToString("yyyy-MM-dd H:mm:ss"));
			SqlConnection sqlConnection = new SqlConnection(ConnStr);
			SqlCommand sqlCommand = new SqlCommand(
				@"INSERT into worker_arrive(worker_name, arrive_time, tim)
				VALUES (@worker_name,'" + time + "', '" + date + "')");
			sqlCommand.Connection = sqlConnection;
			sqlCommand.Parameters.Add(new SqlParameter("@worker_name", name));
			sqlConnection.Open();
			sqlCommand.ExecuteNonQuery();
			sqlConnection.Close();
		}

		public void worker_arrive_update(string worker)
		{
			string date = string.Format(DateTime.Now.ToString("yyyy-MM-dd"));
			string time = string.Format(DateTime.Now.ToString("yyyy-MM-dd H:mm:ss"));
			SqlConnection sqlConnection = new SqlConnection(ConnStr);
			SqlCommand sqlCommand = new SqlCommand(
				@"UPDATE worker_arrive SET leave_time = '"+ time + "' WHERE (tim = '"+ date+ "' AND arrive_time = (select max(arrive_time) from worker_arrive where worker_name = @worker_name))");
			sqlCommand.Connection = sqlConnection;
			sqlCommand.Parameters.Add(new SqlParameter("@worker_name", worker));
			sqlConnection.Open();
			sqlCommand.ExecuteNonQuery();
			sqlConnection.Close();
		}

		public worker_arrive worker_arrive_select(string UserId)
		{
			worker_arrive worker_arrive = new worker_arrive();
			SqlConnection sqlConnection = new SqlConnection(ConnStr);
			SqlCommand sqlCommand = new SqlCommand("SELECT * FROM worker_arrive_db WHERE worker_name = @worker_name");
			sqlCommand.Connection = sqlConnection;
			sqlCommand.Parameters.Add(new SqlParameter("@worker_name", UserId));
			sqlConnection.Open();

			SqlDataReader reader = sqlCommand.ExecuteReader();
			if (reader.HasRows)
			{
				while (reader.Read())
				{
					worker_arrive = new worker_arrive
					{
						worker_name = reader.GetString(reader.GetOrdinal("worker_name")),
						arrive_time = reader.GetString(reader.GetOrdinal("arrive_time")),
						leave_time = reader.GetString(reader.GetOrdinal("leave_time")),
						tim = reader.GetString(reader.GetOrdinal("tim"))
					};
				}
			}
			sqlConnection.Close();
			return worker_arrive;
		}
	}
}