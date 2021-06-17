using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Web_Phone.Models
{
	public class Roster_db
	{
		private readonly string ConnStr = "Data Source=WIN-6M12QM5R44F;Initial Catalog=webphone;Persist Security Info=True;User ID=sa;Password=1qaz!QAZ;MultipleActiveResultSets=True;Application Name=EntityFramework";

		public void Roster_insert(Roster Roster)
		{
			SqlConnection sqlConnection = new SqlConnection(ConnStr);
			SqlCommand sqlCommand = new SqlCommand(
				@"INSERT into Roster_db (worker_name,one_one,one_two,one_three,one_four,one_five,one_six,one_seven,one_eight,two_one,two_two,two_three,two_four,two_five,two_six,two_seven,two_eight,three_one,three_two,three_three,three_four,three_five,three_six,three_seven,three_eight,four_one,four_two,four_three,four_four,four_five,four_six,four_seven,four_eight,five_one,five_two,five_three,five_four,five_five,five_six,five_seven,five_eight,six_one,six_two,six_three,six_four,six_five,six_six,six_seven,six_eight,seven_one,seven_two,seven_three,seven_four,seven_five,seven_six,seven_seven,seven_eight)
				VALUES(@worker_name,@one_one,@one_two,@one_three,@one_four,@one_five,@one_six,@one_seven,@one_eight,@two_one,@two_two,@two_three,@two_four,@two_five,@two_six,@two_seven,@two_eight,@three_one,@three_two,@three_three,@three_four,@three_five,@three_six,@three_seven,@three_eight,@four_one,@four_two,@four_three,@four_four,@four_five,@four_six,@four_seven,@four_eight,@five_one,@five_two,@five_three,@five_four,@five_five,@five_six,@five_seven,@five_eight,@six_one,@six_two,@six_three,@six_four,@six_five,@six_six,@six_seven,@six_eight,@seven_one,@seven_two,@seven_three,@seven_four,@seven_five,@seven_six,@seven_seven,@seven_eight))
");
			sqlCommand.Connection = sqlConnection;
			sqlCommand.Parameters.Add(new SqlParameter("@worker_name", Roster.worker_name));
			sqlCommand.Parameters.Add(new SqlParameter("@one_one", Roster.one_one));
			sqlCommand.Parameters.Add(new SqlParameter("@one_two", Roster.one_two));
			sqlCommand.Parameters.Add(new SqlParameter("@one_three", Roster.one_three));
			sqlCommand.Parameters.Add(new SqlParameter("@one_four", Roster.one_four));
			sqlCommand.Parameters.Add(new SqlParameter("@one_five", Roster.one_five));
			sqlCommand.Parameters.Add(new SqlParameter("@one_six", Roster.one_six));
			sqlCommand.Parameters.Add(new SqlParameter("@one_seven", Roster.one_seven));
			sqlCommand.Parameters.Add(new SqlParameter("@one_eight", Roster.one_eight));
			sqlCommand.Parameters.Add(new SqlParameter("@two_one", Roster.two_one));
			sqlCommand.Parameters.Add(new SqlParameter("@two_two", Roster.two_two));
			sqlCommand.Parameters.Add(new SqlParameter("@two_three", Roster.two_three));
			sqlCommand.Parameters.Add(new SqlParameter("@two_four", Roster.two_four));
			sqlCommand.Parameters.Add(new SqlParameter("@two_five", Roster.two_five));
			sqlCommand.Parameters.Add(new SqlParameter("@two_six", Roster.two_six));
			sqlCommand.Parameters.Add(new SqlParameter("@two_seven", Roster.two_seven));
			sqlCommand.Parameters.Add(new SqlParameter("@two_eight", Roster.two_eight));
			sqlCommand.Parameters.Add(new SqlParameter("@three_one", Roster.three_one));
			sqlCommand.Parameters.Add(new SqlParameter("@three_two", Roster.three_two));
			sqlCommand.Parameters.Add(new SqlParameter("@three_three", Roster.three_three));
			sqlCommand.Parameters.Add(new SqlParameter("@three_four", Roster.three_four));
			sqlCommand.Parameters.Add(new SqlParameter("@three_five", Roster.three_five));
			sqlCommand.Parameters.Add(new SqlParameter("@three_six", Roster.three_six));
			sqlCommand.Parameters.Add(new SqlParameter("@three_seven", Roster.three_seven));
			sqlCommand.Parameters.Add(new SqlParameter("@three_eight", Roster.three_eight));
			sqlCommand.Parameters.Add(new SqlParameter("@four_one", Roster.four_one));
			sqlCommand.Parameters.Add(new SqlParameter("@four_two", Roster.four_two));
			sqlCommand.Parameters.Add(new SqlParameter("@four_three", Roster.four_three));
			sqlCommand.Parameters.Add(new SqlParameter("@four_four", Roster.four_four));
			sqlCommand.Parameters.Add(new SqlParameter("@four_five", Roster.four_five));
			sqlCommand.Parameters.Add(new SqlParameter("@four_six", Roster.four_six));
			sqlCommand.Parameters.Add(new SqlParameter("@four_seven", Roster.four_seven));
			sqlCommand.Parameters.Add(new SqlParameter("@four_eight", Roster.four_eight));
			sqlCommand.Parameters.Add(new SqlParameter("@five_one", Roster.five_one));
			sqlCommand.Parameters.Add(new SqlParameter("@five_two", Roster.five_two));
			sqlCommand.Parameters.Add(new SqlParameter("@five_three", Roster.five_three));
			sqlCommand.Parameters.Add(new SqlParameter("@five_four", Roster.five_four));
			sqlCommand.Parameters.Add(new SqlParameter("@five_five", Roster.five_five));
			sqlCommand.Parameters.Add(new SqlParameter("@five_six", Roster.five_six));
			sqlCommand.Parameters.Add(new SqlParameter("@five_seven", Roster.five_seven));
			sqlCommand.Parameters.Add(new SqlParameter("@five_eight", Roster.five_eight));
			sqlCommand.Parameters.Add(new SqlParameter("@six_one", Roster.six_one));
			sqlCommand.Parameters.Add(new SqlParameter("@six_two", Roster.six_two));
			sqlCommand.Parameters.Add(new SqlParameter("@six_three", Roster.six_three));
			sqlCommand.Parameters.Add(new SqlParameter("@six_four", Roster.six_four));
			sqlCommand.Parameters.Add(new SqlParameter("@six_five", Roster.six_five));
			sqlCommand.Parameters.Add(new SqlParameter("@six_six", Roster.six_six));
			sqlCommand.Parameters.Add(new SqlParameter("@six_seven", Roster.six_seven));
			sqlCommand.Parameters.Add(new SqlParameter("@six_eight", Roster.six_eight));
			sqlCommand.Parameters.Add(new SqlParameter("@seven_one", Roster.seven_one));
			sqlCommand.Parameters.Add(new SqlParameter("@seven_two", Roster.seven_two));
			sqlCommand.Parameters.Add(new SqlParameter("@seven_three", Roster.seven_three));
			sqlCommand.Parameters.Add(new SqlParameter("@seven_four", Roster.seven_four));
			sqlCommand.Parameters.Add(new SqlParameter("@seven_five", Roster.seven_five));
			sqlCommand.Parameters.Add(new SqlParameter("@seven_six", Roster.seven_six));
			sqlCommand.Parameters.Add(new SqlParameter("@seven_seven", Roster.seven_seven));
			sqlCommand.Parameters.Add(new SqlParameter("@seven_eight", Roster.seven_eight));


			sqlConnection.Open();
			sqlCommand.ExecuteNonQuery();
			sqlConnection.Close();
		}

		public List<Roster> Roster_select(string UserId)
		{
			List<Roster> Roster = new List<Roster>();
			SqlConnection sqlConnection = new SqlConnection(ConnStr);
			SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Roster WHERE worker_name = @worker_name");
			sqlCommand.Connection = sqlConnection;
			sqlCommand.Parameters.Add(new SqlParameter("@worker_name", UserId));
			sqlConnection.Open();

			SqlDataReader reader = sqlCommand.ExecuteReader();
			if (reader.HasRows)
			{
				while (reader.Read())
				{
					Roster roster = new Roster
					{
						worker_name = reader.GetString(reader.GetOrdinal("worker_name")),
						one_one = iii(reader, "one_one"),
						one_two = iii(reader, "one_two"),
						one_three = iii(reader, "one_three"),
						one_four = iii(reader, "one_four"),
						one_five = iii(reader, "one_five"),
						one_six = iii(reader, "one_six"),
						one_seven = iii(reader, "one_seven"),
						one_eight = iii(reader, "one_eight"),
						two_one = iii(reader, "two_one"),
						two_two = iii(reader, "two_two"),
						two_three = iii(reader, "two_three"),
						two_four = iii(reader, "two_four"),
						two_five = iii(reader, "two_five"),
						two_six = iii(reader, "two_six"),
						two_seven = iii(reader, "two_seven"),
						two_eight = iii(reader, "two_eight"),
						three_one = iii(reader, "three_one"),
						three_two = iii(reader, "three_two"),
						three_three = iii(reader, "three_three"),
						three_four = iii(reader, "three_four"),
						three_five = iii(reader, "three_five"),
						three_six = iii(reader, "three_six"),
						three_seven = iii(reader, "three_seven"),
						three_eight = iii(reader, "three_eight"),
						four_one = iii(reader, "four_one"),
						four_two = iii(reader, "four_two"),
						four_three = iii(reader, "four_three"),
						four_four = iii(reader, "four_four"),
						four_five = iii(reader, "four_five"),
						four_six = iii(reader, "four_six"),
						four_seven = iii(reader, "four_seven"),
						four_eight = iii(reader, "four_eight"),
						five_one = iii(reader, "five_one"),
						five_two = iii(reader, "five_two"),
						five_three = iii(reader, "five_three"),
						five_four = iii(reader, "five_four"),
						five_five = iii(reader, "five_five"),
						five_six = iii(reader, "five_six"),
						five_seven = iii(reader, "five_seven"),
						five_eight = iii(reader, "five_eight"),
						six_one = iii(reader, "six_one"),
						six_two = iii(reader, "six_two"),
						six_three = iii(reader, "six_three"),
						six_four = iii(reader, "six_four"),
						six_five = iii(reader, "six_five"),
						six_six = iii(reader, "six_six"),
						six_seven = iii(reader, "six_seven"),
						six_eight = iii(reader, "six_eight"),
						seven_one = iii(reader, "seven_one"),
						seven_two = iii(reader, "seven_two"),
						seven_three = iii(reader, "seven_three"),
						seven_four = iii(reader, "seven_four"),
						seven_five = iii(reader, "seven_five"),
						seven_six = iii(reader, "seven_six"),
						seven_seven = iii(reader, "seven_seven"),
						seven_eight = iii(reader, "seven_eight"),

					};
					Roster.Add(roster);
				}
			}
			sqlConnection.Close();
			return Roster;
		}
		public string iii(SqlDataReader reader, string clas)
		{
			string aa = null;
			if (!reader.IsDBNull(reader.GetOrdinal(clas)))
			{
				aa = reader.GetString(reader.GetOrdinal(clas));
			}
			else
				aa = null;
			return aa;
		}
	}
}