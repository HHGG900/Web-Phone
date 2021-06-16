using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Web_Phone.Models
{
	public class Exception_notification_db
	{
		private readonly string ConnStr = "Data Source=WIN-6M12QM5R44F;Initial Catalog=webphone;Persist Security Info=True;User ID=sa;Password=1qaz!QAZ;MultipleActiveResultSets=True;Application Name=EntityFramework";

		public List<Exception_notification> GetException_notification()
		{
			List<Exception_notification> exception_notifications = new List<Exception_notification>();
			SqlConnection sqlConnection = new SqlConnection(ConnStr);
			SqlCommand sqlCommand = new SqlCommand("SELECT * FROM exception_notification");
			sqlCommand.Connection = sqlConnection;
			sqlConnection.Open();

			SqlDataReader reader = sqlCommand.ExecuteReader();
			if (reader.HasRows)
			{
				while (reader.Read())
				{
					Exception_notification exception_notificationrd = new Exception_notification
					{
						working_name = reader.GetString(reader.GetOrdinal("working_name")),
						event_description = reader.GetString(reader.GetOrdinal("event_description")),
						exception_class = reader.GetString(reader.GetOrdinal("exception_class")),
						ten_index = reader.GetString(reader.GetOrdinal("ten_index")),
						tim = reader.GetDateTime(reader.GetOrdinal("tim"))
					
				};
					exception_notifications.Add(exception_notificationrd);
				}
			}
			else
			{
				Console.WriteLine("資料庫為空！");
			}
			sqlConnection.Close();
			return exception_notifications;
		}
		public void sign_in_db_insert(Exception_notification exception_notification)
				{
					SqlConnection sqlConnection = new SqlConnection(ConnStr);
					SqlCommand sqlCommand = new SqlCommand(
						@"INSERT INTO exception_notification (working_name,event_description,exception_class,ten_index,tim)
						VALUES(@working_name,@event_description,@exception_class,@ten_index,@tim)");
					sqlCommand.Connection = sqlConnection;
					sqlCommand.Parameters.Add(new SqlParameter("@working_name", exception_notification.working_name));
					sqlCommand.Parameters.Add(new SqlParameter("@event_description", exception_notification.event_description));
					sqlCommand.Parameters.Add(new SqlParameter("@exception_class", exception_notification.exception_class));
					sqlCommand.Parameters.Add(new SqlParameter("@ten_index", exception_notification.ten_index));
					sqlCommand.Parameters.Add(new SqlParameter("@tim", exception_notification.tim));
					sqlConnection.Open();
					sqlCommand.ExecuteNonQuery();
					sqlConnection.Close();
				}

				public Exception_notification exception_notification_select(string working_name)
				{
					Exception_notification exception_notification = new Exception_notification();
					SqlConnection sqlConnection = new SqlConnection(ConnStr);
					SqlCommand sqlCommand = new SqlCommand("SELECT * FROM exception_notification WHERE working_name = @working_name");
					sqlCommand.Connection = sqlConnection;
					sqlCommand.Parameters.Add(new SqlParameter("@working_name", working_name));
					sqlConnection.Open();

					SqlDataReader reader = sqlCommand.ExecuteReader();
					if (reader.HasRows)
					{
						while (reader.Read())
						{
							exception_notification = new Exception_notification
							{
								working_name = reader.GetString(reader.GetOrdinal("working_name")),
								event_description = reader.GetString(reader.GetOrdinal("event_description")),
								exception_class = reader.GetString(reader.GetOrdinal("exception_class")),
								ten_index = reader.GetString(reader.GetOrdinal("ten_index")),
								tim = reader.GetDateTime(reader.GetOrdinal("tim"))
							};
						}
					}
					sqlConnection.Close();
					return exception_notification;
				}
	}
}