using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Web_Phone.Models
{
	public class user_basic
	{
		[DisplayName("個案姓名")]
		[Required]
		public string usr_name { get; set; }

		[DisplayName("匿名")]
		[Required]
		public string usr_anonymous { get; set; }

		[DisplayName("習慣語言")]//1-5
		[Required]
		public string usr_icustom_languagendex { get; set; }

		[DisplayName("母語")]//6-10
		[Required]
		public string mom_language { get; set; }

		[DisplayName("喜歡的話題")]
		[Required]
		public string like_topic { get; set; }

		[DisplayName("興趣")]//14
		[Required]
		public string interest { get; set; }

		[DisplayName("過去職業")]
		[Required]
		public string occupation { get; set; }

		[DisplayName("經濟狀況1")]
		[Required]
		public string economic_status_one { get; set; }

		[DisplayName("經濟狀況2")]
		[Required]
		public string economic_status_twe { get; set; }

		[DisplayName("現在個性")]
		[Required]
		public string new_identity { get; set; }

		[DisplayName("禁忌")]
		[Required]
		public string ban { get; set; }

		[DisplayName("易接受方式")]
		[Required]
		public string accept_topic { get; set; }

		[DisplayName("照顧期待-個案")]
		[Required]
		public string usr_expect { get; set; }

		[DisplayName("照顧期待-家屬")]
		[Required]
		public string family_expect { get; set; }

		[DisplayName("聯絡人-姓名")]
		[Required]
		public string family_name { get; set; }

		[DisplayName("聯絡人-手機")]
		[Required]
		public string family_phone { get; set; }

		[DisplayName("聯絡人-ID")]
		[Required]
		public string family_Line { get; set; }

		[DisplayName("主要照顧者-關係")]
		[Required]
		public string care_bind { get; set; }

		[DisplayName("主要照顧者-年紀")]
		[Required]
		public string care_year { get; set; }

		[DisplayName("主要照顧者-姓名")]
		[Required]
		public string care_name { get; set; }

		[DisplayName("主要照顧者1")]
		[Required]
		public string care_one { get; set; }

		[DisplayName("主要照顧者2")]
		[Required]
		public string care_twe { get; set; }

		[DisplayName("主要照顧者3")]
		[Required]
		public string care_three { get; set; }

		[DisplayName("主要照顧者4")]
		[Required]
		public string care_four { get; set; }

		[DisplayName("疾病史")]
		[Required]
		public string medical_history { get; set; }

		[DisplayName("疾病史")]
		[Required]
		public string Resource_scale { get; set; }

		[DisplayName("用藥習慣")]
		[Required]
		public string medication_habits { get; set; }

		[DisplayName("營養面相")]
		[Required]
		public string nutrition_face { get; set; }

		[DisplayName("身高")]
		[Required]
		public int tell { get; set; }

		[DisplayName("體重")]
		[Required]
		public string usr_weight { get; set; }

		[DisplayName("中臀圍")]
		[Required]
		public int BMI { get; set; }

		[DisplayName("飲食種類")]
		[Required]
		public string diet_face { get; set; }

		[DisplayName("飲水習慣")]
		[Required]
		public string drink_face { get; set; }

		[DisplayName("水份攝取")]
		[Required]
		public string drink_volume { get; set; }

		[DisplayName("口腔咀嚼")]
		[Required]
		public string chew { get; set; }

		[DisplayName("口腔吞嚥")]
		[Required]
		public string swallow { get; set; }

		[DisplayName("口腔清潔")]
		[Required]
		public string oral_cleaning { get; set; }

		[DisplayName("排便頻率")]
		[Required]
		public string defecation_tim { get; set; }

		[DisplayName("排便時段")]
		[Required]
		public string defecation_time_period { get; set; }

		[DisplayName("排尿")]
		[Required]
		public string urinate { get; set; }

		[DisplayName("循環狀況")]
		[Required]
		public string circulation_status { get; set; }

		[DisplayName("左手力量")]
		[Required]
		public string left_hand_power { get; set; }

		[DisplayName("左腿力量")]
		[Required]
		public string left_leg_power { get; set; }

		[DisplayName("右手力量")]
		[Required]
		public string right_hand_power { get; set; }

		[DisplayName("右腿力量")]
		[Required]
		public string right_leg_power { get; set; }

		[DisplayName("管路")]
		[Required]
		public string pipeline { get; set; }

		[DisplayName("皮膚狀況")]
		[Required]
		public string Skin_condition { get; set; }


		[DisplayName("睡眠狀況")]
		[Required]
		public string sleep { get; set; }

		[DisplayName("物質濫用")]
		[Required]
		public string substance_abuse { get; set; }

		[DisplayName("環境評估")]
		[Required]
		public string environment { get; set; }

		[DisplayName("自我心理1")]
		[Required]
		public string self_psychology_one { get; set; }

		[DisplayName("自我心理2")]
		[Required]
		public string self_psychology_twe { get; set; }

		[DisplayName("自我心理3")]
		[Required]
		public string self_psychology_three { get; set; }

		[DisplayName("自我心理4")]
		[Required]
		public string self_psychology_four { get; set; }

		[DisplayName("他人心理1")]
		[Required]
		public string others_psychology_one { get; set; }

		[DisplayName("他人心理2")]
		[Required]
		public string others_psychology_twe { get; set; }

		[DisplayName("宗教")]
		[Required]
		public string religion { get; set; }

		[DisplayName("談話狀況")]
		[Required]
		public string talk_status { get; set; }

		[DisplayName("參與宗教")]
		[Required]
		public string participate_religion { get; set; }

		[DisplayName("特殊習慣")]
		[Required]
		public string special_habits { get; set; }

		[DisplayName("契約書")]
		[Required]
		public string pic_contract { get; set; }

		[DisplayName("重大傷患卡")]
		[Required]
		public string urinapic_major_injuryte { get; set; }


		[DisplayName("身心障礙手冊")]
		[Required]
		public string pic_disability { get; set; }

		[DisplayName("身分證-正面")]
		[Required]
		public string pic_identity_card_correct { get; set; }

		[DisplayName("身分證-反面")]
		[Required]
		public string pic_identity_card_counter { get; set; }

	}
}