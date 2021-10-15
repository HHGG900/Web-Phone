using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web_Phone.Models
{
	public class Guarding_records_every
	{
		[DisplayName("個性名字")]
		[Required]
		public string caser_name { get; set; }

		[DisplayName("員工姓名")]
		[Required]
		public string worker_name { get; set; }

		
		[Required]
		public string signatur { get; set; }
		

		[DisplayName("日期")]
		[DataType(DataType.Date)]
		[Required]
		public DateTime time_m { get; set; }

		[DisplayName("體溫")]
		[Required]
		public float temperature { get; set; }

		[DisplayName("脈搏低")]
		[Required]
		public int pulse_low { get; set; }

		[DisplayName("脈搏高")]
		[Required]
		public int pulse_high { get; set; }

		[DisplayName("皮膚評估")]
		[Required]
		public string skin_assess { get; set; }

		[DisplayName("異常部位y/n")]
		[Required]
		public string odd_place_yes_no { get; set; }

		[DisplayName("異常部位")]
		[Required]
		public string odd_place { get; set; }

		[DisplayName("異常狀況")]
		[Required]
		public string odd_status { get; set; }

		[DisplayName("大小")]
		[Required]
		public string odd_range { get; set; }

		[DisplayName("照片位置")]
		[Required]
		public string odd_pic { get; set; }

		[DisplayName("疼痛評估")]
		[Required]
		public string pain_assess { get; set; }


		[DisplayName("情緒評估1")]
		[Required]
		public string feel_assess_one { get; set; }


		[DisplayName("情緒評估2")]
		[Required]
		public string feel_assess_twe { get; set; }


		[DisplayName("服藥1")]
		[Required]
		public string medicine_one { get; set; }


		[DisplayName("服藥2")]
		[Required]
		public string medicine_twe { get; set; }


		[DisplayName("注意事項")]
		[Required]
		public string Precautions { get; set; }

	}
}