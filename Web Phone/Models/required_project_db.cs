using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Web_Phone.Models
{
	public class required_project_db
	{
		private readonly string ConnStr = "Data Source=webphone20201109.database.windows.net;Initial Catalog=webphone1109;Persist Security Info=True;User ID=oa123;Password=OOaa12345;MultipleActiveResultSets=True;Application Name=EntityFramework";

		public void sign_in_db_insert(required_project required_project)
		{
			SqlConnection sqlConnection = new SqlConnection(ConnStr);
			SqlCommand sqlCommand = new SqlCommand(
				@"INSERT into required_project_db (caser_name,health,sport,service_record)
				VALUES(@caser_name,@health,@sport,@service_record)");
			sqlCommand.Connection = sqlConnection;
			sqlCommand.Parameters.Add(new SqlParameter("@caser_name", required_project.caser_name));
			sqlCommand.Parameters.Add(new SqlParameter("@health", required_project.health));
			sqlCommand.Parameters.Add(new SqlParameter("@sport", required_project.sport));
			sqlCommand.Parameters.Add(new SqlParameter("@service_record", required_project.service_record));
			sqlConnection.Open();
			sqlCommand.ExecuteNonQuery();
			sqlConnection.Close();
		}

		public required_project required_project_db_select(string UserId)
		{
			required_project required_project = new required_project();
			SqlConnection sqlConnection = new SqlConnection(ConnStr);
			SqlCommand sqlCommand = new SqlCommand("SELECT * FROM required_project_db WHERE caser_name = @caser_name");
			sqlCommand.Connection = sqlConnection;
			sqlCommand.Parameters.Add(new SqlParameter("@caser_name", UserId));
			sqlConnection.Open();

			SqlDataReader reader = sqlCommand.ExecuteReader();
			if (reader.HasRows)
			{
				while (reader.Read())
				{
					required_project = new required_project
					{
						caser_name = reader.GetString(reader.GetOrdinal("caser_name")),
						health = reader.GetString(reader.GetOrdinal("health")),
						sport = reader.GetString(reader.GetOrdinal("sport")),
						service_record = reader.GetString(reader.GetOrdinal("service_record"))
					};
				}
			}
			sqlConnection.Close();
			return required_project;
		}
	}
}