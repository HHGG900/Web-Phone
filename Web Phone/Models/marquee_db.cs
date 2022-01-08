using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Web_Phone.Models
{
	public class marquee_db
	{
		private readonly string ConnStr = "Data Source=WIN-6M12QM5R44F;Initial Catalog=webphone;Persist Security Info=True;User ID=sa;Password=1qaz!QAZ;MultipleActiveResultSets=True;Application Name=EntityFramework";

		public void marquee_insert(marquee marquee, string classname)
		{
			SqlConnection sqlConnection = new SqlConnection(ConnStr);
			SqlCommand sqlCommand = new SqlCommand(
				@"INSERT into marquee(marquee1 , tim ,class)
				VALUES (@marquee1 , @tim,(select class from organization_account where name = @classname))");
			sqlCommand.Connection = sqlConnection;
			sqlCommand.Parameters.Add(new SqlParameter("@marquee1", marquee.marquee1));
			sqlCommand.Parameters.Add(new SqlParameter("@tim", marquee.tim));
			sqlCommand.Parameters.Add(new SqlParameter("@classname", classname));
			sqlConnection.Open();
			sqlCommand.ExecuteNonQuery();
			sqlConnection.Close();
		}

		public marquee marquee_db_select(string UserId)
		{
			marquee marquee = new marquee();
			SqlConnection sqlConnection = new SqlConnection(ConnStr);
			SqlCommand sqlCommand = new SqlCommand("SELECT * FROM marquee WHERE tim = (select MAX(tim)from marquee where class = (select class from organization_account where name = @caser_name))");
			sqlCommand.Connection = sqlConnection;
			sqlCommand.Parameters.Add(new SqlParameter("@caser_name", UserId));
			sqlConnection.Open();

			SqlDataReader reader = sqlCommand.ExecuteReader();
			try {if (reader.HasRows)
			{
				while (reader.Read())
				{
					marquee = new marquee
					{
						marquee1 = reader.GetString(reader.GetOrdinal("marquee1")),
					};
				}
			} 
			}
			catch
			{
				marquee = new marquee
				{
					marquee1 = "µL"
				};
			}
			
			sqlConnection.Close();
			return marquee;
		}
	}
}