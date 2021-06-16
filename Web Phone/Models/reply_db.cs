using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Web_Phone.Models
{
	public class reply_db
	{
		private readonly string ConnStr = "Data Source=webphone20201109.database.windows.net;Initial Catalog=webphone1109;Persist Security Info=True;User ID=oa123;Password=OOaa12345;MultipleActiveResultSets=True;Application Name=EntityFramework";

		public void reply_insert(reply reply)
		{
			SqlConnection sqlConnection = new SqlConnection(ConnStr);
			SqlCommand sqlCommand = new SqlCommand(
				@"INSERT into reply_db (caser_name,reply,satisfaction,tim)
				VALUES(@caser_name,@reply,@satisfaction,@tim)");
			sqlCommand.Connection = sqlConnection;
			sqlCommand.Parameters.Add(new SqlParameter("@caser_name", reply.caser_name));
			sqlCommand.Parameters.Add(new SqlParameter("@reply", reply.reply1));
			sqlCommand.Parameters.Add(new SqlParameter("@satisfaction", reply.satisfaction));
			sqlCommand.Parameters.Add(new SqlParameter("@tim", reply.tim));
			sqlConnection.Open();
			sqlCommand.ExecuteNonQuery();
			sqlConnection.Close();
		}

		public reply reply_select(string UserId)
		{
			reply reply = new reply();
			SqlConnection sqlConnection = new SqlConnection(ConnStr);
			SqlCommand sqlCommand = new SqlCommand("SELECT * FROM reply_db WHERE caser_name = @caser_name");
			sqlCommand.Connection = sqlConnection;
			sqlCommand.Parameters.Add(new SqlParameter("@caser_name", UserId));
			sqlConnection.Open();

			SqlDataReader reader = sqlCommand.ExecuteReader();
			if (reader.HasRows)
			{
				while (reader.Read())
				{
					reply = new reply
					{
						caser_name = reader.GetString(reader.GetOrdinal("caser_name")),
						reply1 = reader.GetString(reader.GetOrdinal("reply1")),
						satisfaction = reader.GetString(reader.GetOrdinal("satisfaction")),
						tim = reader.GetString(reader.GetOrdinal("tim"))
					};
				}
			}
			sqlConnection.Close();
			return reply;
		}
	}
}