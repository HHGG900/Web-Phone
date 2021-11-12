using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Web_Phone.Models
{
	public class user_basic_db
	{
		private readonly string ConnStr = "Data Source=WIN-6M12QM5R44F;Initial Catalog=webphone;Persist Security Info=True;User ID=sa;Password=1qaz!QAZ;MultipleActiveResultSets=True;Application Name=EntityFramework";

		public void user_basic_insert(user_basic user_basic)
		{
			
			SqlConnection sqlConnection = new SqlConnection(ConnStr);
			SqlCommand sqlCommand = new SqlCommand(
				@"INSERT into user_basic (usr_name,usr_anonymous,usr_icustom_languagendex,mom_language,like_topic,interest,occupation,economic_status_one,economic_status_twe,new_identity,ban,accept_topic,usr_expect,family_expect,family_name,family_phone,family_Line,care_bind,care_year,care_name,care_one,care_twe,care_three,care_four,medical_history,medication_habits,medication_habits2,tell,usr_weight,BMI,diet_face,drink_face,drink_volume,chew,swallow,oral_cleaning,defecation_tim,defecation_time_period,urinate,circulation_status,left_hand_power,left_leg_power,right_hand_power,right_leg_power,pipeline,Skin_condition,sleep,substance_abuse,environment,self_psychology_one,self_psychology_twe,self_psychology_three,others_psychology_one,others_psychology_twe,religion,talk_status,participate_religion,participate_religion2,special_habits,pic_contract,urinapic_major_injuryte,pic_disability,pic_identity_card_correct,pic_identity_card_counter,tim)
				VALUES(@usr_name,@usr_anonymous,@usr_icustom_languagendex,@mom_language,@like_topic,@interest,@occupation,@economic_status_one,@economic_status_twe,@new_identity,@ban,@accept_topic,@usr_expect,@family_expect,@family_name,@family_phone,@family_Line,@care_bind,@care_year,@care_name,@care_one,@care_twe,@care_three,@care_four,@medical_history,@medication_habits,@medication_habits2,@tell,@usr_weight,@BMI,@diet_face,@drink_face,@drink_volume,@chew,@swallow,@oral_cleaning,@defecation_tim,@defecation_time_period,@urinate,@circulation_status,@left_hand_power,@left_leg_power,@right_hand_power,@right_leg_power,@pipeline,@Skin_condition,@sleep,@substance_abuse,@environment,@self_psychology_one,@self_psychology_twe,@self_psychology_three,@others_psychology_one,@others_psychology_twe,@religion,@talk_status,@participate_religion,@participate_religion2,@special_habits,@pic_contract,@urinapic_major_injuryte,@pic_disability,@pic_identity_card_correct,@pic_identity_card_counter,@tim)");
			sqlCommand.Connection = sqlConnection;
			sqlCommand.Parameters.Add(new SqlParameter("@usr_name", user_basic.usr_name));
			sqlCommand.Parameters.Add(new SqlParameter("@usr_anonymous", user_basic.usr_anonymous));
			sqlCommand.Parameters.Add(new SqlParameter("@usr_icustom_languagendex", user_basic.usr_icustom_languagendex));
			sqlCommand.Parameters.Add(new SqlParameter("@mom_language", user_basic.mom_language));
			sqlCommand.Parameters.Add(new SqlParameter("@like_topic", user_basic.like_topic));
			sqlCommand.Parameters.Add(new SqlParameter("@interest", user_basic.interest));
			sqlCommand.Parameters.Add(new SqlParameter("@occupation", user_basic.occupation)); 
			sqlCommand.Parameters.Add(new SqlParameter("@economic_status_one", user_basic.economic_status_one));
			sqlCommand.Parameters.Add(new SqlParameter("@economic_status_twe", user_basic.economic_status_twe));
			sqlCommand.Parameters.Add(new SqlParameter("@new_identity", user_basic.new_identity));
			sqlCommand.Parameters.Add(new SqlParameter("@ban", user_basic.ban));
			sqlCommand.Parameters.Add(new SqlParameter("@accept_topic", user_basic.accept_topic));
			sqlCommand.Parameters.Add(new SqlParameter("@usr_expect", user_basic.usr_expect));
			sqlCommand.Parameters.Add(new SqlParameter("@family_expect", user_basic.family_expect));
			sqlCommand.Parameters.Add(new SqlParameter("@family_name", user_basic.family_name));
			sqlCommand.Parameters.Add(new SqlParameter("@family_phone", user_basic.family_phone));
			sqlCommand.Parameters.Add(new SqlParameter("@family_Line", user_basic.family_Line));
			sqlCommand.Parameters.Add(new SqlParameter("@care_bind", user_basic.care_bind));
			sqlCommand.Parameters.Add(new SqlParameter("@care_year", user_basic.care_year));
			sqlCommand.Parameters.Add(new SqlParameter("@care_name", user_basic.care_name));
			sqlCommand.Parameters.Add(new SqlParameter("@care_one", user_basic.care_one));
			sqlCommand.Parameters.Add(new SqlParameter("@care_twe", user_basic.care_twe));
			sqlCommand.Parameters.Add(new SqlParameter("@care_three", user_basic.care_three));
			sqlCommand.Parameters.Add(new SqlParameter("@care_four", user_basic.care_four));
			sqlCommand.Parameters.Add(new SqlParameter("@medical_history", user_basic.medical_history));
			sqlCommand.Parameters.Add(new SqlParameter("@medication_habits", user_basic.medication_habits));
			sqlCommand.Parameters.Add(new SqlParameter("@medication_habits2", user_basic.medication_habits2));
			sqlCommand.Parameters.Add(new SqlParameter("@tell", user_basic.tell));
			sqlCommand.Parameters.Add(new SqlParameter("@usr_weight", user_basic.usr_weight));
			sqlCommand.Parameters.Add(new SqlParameter("@BMI", user_basic.BMI));
			sqlCommand.Parameters.Add(new SqlParameter("@diet_face", user_basic.diet_face));
			sqlCommand.Parameters.Add(new SqlParameter("@drink_face", user_basic.drink_face));
			sqlCommand.Parameters.Add(new SqlParameter("@drink_volume", user_basic.drink_volume));
			sqlCommand.Parameters.Add(new SqlParameter("@chew", user_basic.chew));
			sqlCommand.Parameters.Add(new SqlParameter("@swallow", user_basic.swallow));
			sqlCommand.Parameters.Add(new SqlParameter("@oral_cleaning", user_basic.oral_cleaning));
			sqlCommand.Parameters.Add(new SqlParameter("@defecation_tim", user_basic.defecation_tim));
			sqlCommand.Parameters.Add(new SqlParameter("@defecation_time_period", user_basic.defecation_time_period));
			sqlCommand.Parameters.Add(new SqlParameter("@urinate", user_basic.urinate));
			sqlCommand.Parameters.Add(new SqlParameter("@circulation_status", user_basic.circulation_status));
			sqlCommand.Parameters.Add(new SqlParameter("@left_hand_power", user_basic.left_hand_power));
			sqlCommand.Parameters.Add(new SqlParameter("@left_leg_power", user_basic.left_leg_power));
			sqlCommand.Parameters.Add(new SqlParameter("@right_hand_power", user_basic.right_hand_power));
			sqlCommand.Parameters.Add(new SqlParameter("@right_leg_power", user_basic.right_leg_power));
			sqlCommand.Parameters.Add(new SqlParameter("@pipeline", user_basic.pipeline));
			sqlCommand.Parameters.Add(new SqlParameter("@Skin_condition", user_basic.Skin_condition));
			sqlCommand.Parameters.Add(new SqlParameter("@sleep", user_basic.sleep));
			sqlCommand.Parameters.Add(new SqlParameter("@substance_abuse", user_basic.substance_abuse));
			sqlCommand.Parameters.Add(new SqlParameter("@environment", user_basic.environment));
			sqlCommand.Parameters.Add(new SqlParameter("@self_psychology_one", user_basic.self_psychology_one));
			sqlCommand.Parameters.Add(new SqlParameter("@self_psychology_twe", user_basic.self_psychology_twe));
			sqlCommand.Parameters.Add(new SqlParameter("@self_psychology_three", user_basic.self_psychology_three));
			sqlCommand.Parameters.Add(new SqlParameter("@others_psychology_one", user_basic.others_psychology_one));
			sqlCommand.Parameters.Add(new SqlParameter("@others_psychology_twe", user_basic.others_psychology_twe));
			sqlCommand.Parameters.Add(new SqlParameter("@religion", user_basic.religion));
			sqlCommand.Parameters.Add(new SqlParameter("@talk_status", user_basic.talk_status));
			sqlCommand.Parameters.Add(new SqlParameter("@participate_religion", user_basic.participate_religion));
			sqlCommand.Parameters.Add(new SqlParameter("@participate_religion2", user_basic.participate_religion2));
			sqlCommand.Parameters.Add(new SqlParameter("@special_habits", user_basic.special_habits));
			if (user_basic.pic_contract == null)
				sqlCommand.Parameters.Add(new SqlParameter("@pic_contract", DBNull.Value));
			else
				sqlCommand.Parameters.Add(new SqlParameter("@pic_contract", user_basic.pic_contract));
			if (user_basic.urinapic_major_injuryte == null)
				sqlCommand.Parameters.Add(new SqlParameter("@urinapic_major_injuryte", DBNull.Value));
			else
				sqlCommand.Parameters.Add(new SqlParameter("@urinapic_major_injuryte", user_basic.urinapic_major_injuryte));
			if (user_basic.pic_disability == null)
				sqlCommand.Parameters.Add(new SqlParameter("@pic_disability", DBNull.Value));
			else
				sqlCommand.Parameters.Add(new SqlParameter("@pic_disability", user_basic.pic_disability));
			if (user_basic.pic_identity_card_correct == null)
				sqlCommand.Parameters.Add(new SqlParameter("@pic_identity_card_correct", DBNull.Value));
			else
				sqlCommand.Parameters.Add(new SqlParameter("@pic_identity_card_correct", user_basic.pic_identity_card_correct));
			if (user_basic.pic_identity_card_counter == null)
				sqlCommand.Parameters.Add(new SqlParameter("@pic_identity_card_counter", DBNull.Value));
			else
				sqlCommand.Parameters.Add(new SqlParameter("@pic_identity_card_counter", user_basic.pic_identity_card_counter));
			sqlCommand.Parameters.Add(new SqlParameter("@tim", DateTime.Now.ToString("yyyyMMddHHmm")));

			sqlConnection.Open();
			sqlCommand.ExecuteNonQuery();
			sqlConnection.Close();
		}

		public List<user_basic> user_basic_select(string Username)
		{
			List<user_basic> user_basic = new List<user_basic>();
			SqlConnection sqlConnection = new SqlConnection(ConnStr);
			SqlCommand sqlCommand = new SqlCommand("SELECT * FROM user_basic WHERE usr_name = @usr_name and tim = (SELECT MAX (tim) FROM user_basic)");
			sqlCommand.Connection = sqlConnection;
			sqlCommand.Parameters.Add(new SqlParameter("@usr_name", Username));
			sqlConnection.Open();

			SqlDataReader reader = sqlCommand.ExecuteReader();
			if (reader.HasRows)
			{
				while (reader.Read())
				{
					user_basic user_ = new user_basic
					{
						usr_name = reader.GetString(reader.GetOrdinal("usr_name")),
						usr_anonymous = reader.GetString(reader.GetOrdinal("usr_anonymous")),
						usr_icustom_languagendex = reader.GetString(reader.GetOrdinal("usr_icustom_languagendex")),
						mom_language = reader.GetString(reader.GetOrdinal("mom_language")),
						like_topic = reader.GetString(reader.GetOrdinal("like_topic")),
						interest = reader.GetString(reader.GetOrdinal("interest")),
						occupation = reader.GetString(reader.GetOrdinal("occupation")),
						economic_status_one = reader.GetString(reader.GetOrdinal("economic_status_one")),
						economic_status_twe = reader.GetString(reader.GetOrdinal("economic_status_twe")),
						new_identity = reader.GetString(reader.GetOrdinal("new_identity")),
						ban = reader.GetString(reader.GetOrdinal("ban")),
						accept_topic = reader.GetString(reader.GetOrdinal("accept_topic")),
						usr_expect = reader.GetString(reader.GetOrdinal("usr_expect")),
						family_expect = reader.GetString(reader.GetOrdinal("family_expect")),
						family_name = reader.GetString(reader.GetOrdinal("family_name")),
						family_phone = reader.GetString(reader.GetOrdinal("family_phone")),
						family_Line = reader.GetString(reader.GetOrdinal("family_Line")),
						care_bind = reader.GetString(reader.GetOrdinal("care_bind")),
						care_year = reader.GetString(reader.GetOrdinal("care_year")),
						care_name = reader.GetString(reader.GetOrdinal("care_name")),
						care_one = reader.GetString(reader.GetOrdinal("care_one")),
						care_twe = reader.GetString(reader.GetOrdinal("care_twe")),
						care_three = reader.GetString(reader.GetOrdinal("care_three")),
						care_four = reader.GetString(reader.GetOrdinal("care_four")),
						medical_history = reader.GetString(reader.GetOrdinal("medical_history")),
						medication_habits = reader.GetString(reader.GetOrdinal("medication_habits")),
						medication_habits2 = reader.GetString(reader.GetOrdinal("medication_habits2")),
						tell = reader.GetString(reader.GetOrdinal("tell")),
						usr_weight = reader.GetString(reader.GetOrdinal("usr_weight")),
						BMI = reader.GetString(reader.GetOrdinal("BMI")),
						diet_face = reader.GetString(reader.GetOrdinal("diet_face")),
						drink_face = reader.GetString(reader.GetOrdinal("drink_face")),
						drink_volume = reader.GetString(reader.GetOrdinal("drink_volume")),
						chew = reader.GetString(reader.GetOrdinal("chew")),
						swallow = reader.GetString(reader.GetOrdinal("swallow")),
						oral_cleaning = reader.GetString(reader.GetOrdinal("oral_cleaning")),
						defecation_tim = reader.GetString(reader.GetOrdinal("defecation_tim")),
						defecation_time_period = reader.GetString(reader.GetOrdinal("defecation_time_period")),
						urinate = reader.GetString(reader.GetOrdinal("urinate")),
						circulation_status = reader.GetString(reader.GetOrdinal("circulation_status")),
						left_hand_power = reader.GetString(reader.GetOrdinal("left_hand_power")),
						left_leg_power = reader.GetString(reader.GetOrdinal("left_leg_power")),
						right_hand_power = reader.GetString(reader.GetOrdinal("right_hand_power")),
						right_leg_power = reader.GetString(reader.GetOrdinal("right_leg_power")),
						pipeline = reader.GetString(reader.GetOrdinal("pipeline")),
						Skin_condition = reader.GetString(reader.GetOrdinal("Skin_condition")),
						sleep = reader.GetString(reader.GetOrdinal("sleep")),
						substance_abuse = reader.GetString(reader.GetOrdinal("substance_abuse")),
						environment = reader.GetString(reader.GetOrdinal("environment")),
						self_psychology_one = reader.GetString(reader.GetOrdinal("self_psychology_one")),
						self_psychology_twe = reader.GetString(reader.GetOrdinal("self_psychology_twe")),
						self_psychology_three = reader.GetString(reader.GetOrdinal("self_psychology_three")),
						others_psychology_one = reader.GetString(reader.GetOrdinal("others_psychology_one")),
						others_psychology_twe = reader.GetString(reader.GetOrdinal("others_psychology_twe")),
						religion = reader.GetString(reader.GetOrdinal("religion")),
						talk_status = reader.GetString(reader.GetOrdinal("talk_status")),
						participate_religion = reader.GetString(reader.GetOrdinal("participate_religion")),
						participate_religion2 = reader.GetString(reader.GetOrdinal("participate_religion2")),
						special_habits = reader.GetString(reader.GetOrdinal("special_habits")),
						pic_contract = GetString(reader.GetOrdinal("pic_contract"), reader),
						urinapic_major_injuryte = GetString(reader.GetOrdinal("urinapic_major_injuryte"), reader),
						pic_disability = GetString(reader.GetOrdinal("pic_disability"), reader),
						pic_identity_card_correct = GetString(reader.GetOrdinal("pic_identity_card_correct"), reader),
						pic_identity_card_counter = GetString(reader.GetOrdinal("pic_identity_card_counter"), reader)					
	
					};
					user_basic.Add(user_);
				}
			}
			sqlConnection.Close();
			return user_basic;
		}
		public string GetString(int i, SqlDataReader reader)
		{
			try
			{
				return reader.GetString(i);
			}
			catch
			{
				return " ";
			}
		}
	}
}