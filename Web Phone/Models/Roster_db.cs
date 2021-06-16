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
		private readonly string ConnStr = "Data Source=webphone20201109.database.windows.net;Initial Catalog=webphone1109;Persist Security Info=True;User ID=oa123;Password=OOaa12345;MultipleActiveResultSets=True;Application Name=EntityFramework";

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

		public Roster Roster_select(string UserId)
		{
			Roster Roster = new Roster();
			SqlConnection sqlConnection = new SqlConnection(ConnStr);
			SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Roster_db WHERE worker_name = @worker_name");
			sqlCommand.Connection = sqlConnection;
			sqlCommand.Parameters.Add(new SqlParameter("@worker_name", UserId));
			sqlConnection.Open();

			SqlDataReader reader = sqlCommand.ExecuteReader();
			if (reader.HasRows)
			{
				while (reader.Read())
				{
					Roster = new Roster
					{
						worker_name = reader.GetString(reader.GetOrdinal("worker_name")),
						one_one = reader.GetString(reader.GetOrdinal("one_one")),
						one_two = reader.GetString(reader.GetOrdinal("one_two")),
						one_three = reader.GetString(reader.GetOrdinal("one_three")),
						one_four = reader.GetString(reader.GetOrdinal("one_four")),
						one_five = reader.GetString(reader.GetOrdinal("one_five")),
						one_six = reader.GetString(reader.GetOrdinal("one_six")),
						one_seven = reader.GetString(reader.GetOrdinal("one_seven")),
						one_eight = reader.GetString(reader.GetOrdinal("one_eight")),
						two_one = reader.GetString(reader.GetOrdinal("two_one")),
						two_two = reader.GetString(reader.GetOrdinal("two_two")),
						two_three = reader.GetString(reader.GetOrdinal("two_three")),
						two_four = reader.GetString(reader.GetOrdinal("two_four")),
						two_five = reader.GetString(reader.GetOrdinal("two_five")),
						two_six = reader.GetString(reader.GetOrdinal("two_six")),
						two_seven = reader.GetString(reader.GetOrdinal("two_seven")),
						two_eight = reader.GetString(reader.GetOrdinal("two_eight")),
						three_one = reader.GetString(reader.GetOrdinal("three_one")),
						three_two = reader.GetString(reader.GetOrdinal("three_two")),
						three_three = reader.GetString(reader.GetOrdinal("three_three")),
						three_four = reader.GetString(reader.GetOrdinal("three_four")),
						three_five = reader.GetString(reader.GetOrdinal("three_five")),
						three_six = reader.GetString(reader.GetOrdinal("three_six")),
						three_seven = reader.GetString(reader.GetOrdinal("three_seven")),
						three_eight = reader.GetString(reader.GetOrdinal("three_eight")),
						four_one = reader.GetString(reader.GetOrdinal("four_one")),
						four_two = reader.GetString(reader.GetOrdinal("four_two")),
						four_three = reader.GetString(reader.GetOrdinal("four_three")),
						four_four = reader.GetString(reader.GetOrdinal("four_four")),
						four_five = reader.GetString(reader.GetOrdinal("four_five")),
						four_six = reader.GetString(reader.GetOrdinal("four_six")),
						four_seven = reader.GetString(reader.GetOrdinal("four_seven")),
						four_eight = reader.GetString(reader.GetOrdinal("four_eight")),
						five_one = reader.GetString(reader.GetOrdinal("five_one")),
						five_two = reader.GetString(reader.GetOrdinal("five_two")),
						five_three = reader.GetString(reader.GetOrdinal("five_three")),
						five_four = reader.GetString(reader.GetOrdinal("five_four")),
						five_five = reader.GetString(reader.GetOrdinal("five_five")),
						five_six = reader.GetString(reader.GetOrdinal("five_six")),
						five_seven = reader.GetString(reader.GetOrdinal("five_seven")),
						five_eight = reader.GetString(reader.GetOrdinal("five_eight")),
						six_one = reader.GetString(reader.GetOrdinal("six_one")),
						six_two = reader.GetString(reader.GetOrdinal("six_two")),
						six_three = reader.GetString(reader.GetOrdinal("six_three")),
						six_four = reader.GetString(reader.GetOrdinal("six_four")),
						six_five = reader.GetString(reader.GetOrdinal("six_five")),
						six_six = reader.GetString(reader.GetOrdinal("six_six")),
						six_seven = reader.GetString(reader.GetOrdinal("six_seven")),
						six_eight = reader.GetString(reader.GetOrdinal("six_eight")),
						seven_one = reader.GetString(reader.GetOrdinal("seven_one")),
						seven_two = reader.GetString(reader.GetOrdinal("seven_two")),
						seven_three = reader.GetString(reader.GetOrdinal("seven_three")),
						seven_four = reader.GetString(reader.GetOrdinal("seven_four")),
						seven_five = reader.GetString(reader.GetOrdinal("seven_five")),
						seven_six = reader.GetString(reader.GetOrdinal("seven_six")),
						seven_seven = reader.GetString(reader.GetOrdinal("seven_seven")),
						seven_eight = reader.GetString(reader.GetOrdinal("seven_eight")),

					};
				}
			}
			sqlConnection.Close();
			return Roster;
		}
	}
}