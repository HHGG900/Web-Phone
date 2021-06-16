using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web_Phone.Models
{
	public class home_write
	{
		[DisplayName("個案姓名")]
		[Required]
		public string caser_name { get; set; }

		[DisplayName("照顧日誌")]
		[Required]
		public string daily_record { get; set; }

		[DisplayName("守護紀錄")]
		[Required]
		public string record { get; set; }

		[DisplayName("有話說")]
		[Required]
		public string question { get; set; }

		[DisplayName("給予回饋")]
		[Required]
		public string reply { get; set; }

		[DisplayName("照顧專區")]
		[Required]
		public string attend_area { get; set; }

		[DisplayName("照顧紀錄")]
		[Required]
		public string attend_record { get; set; }

	}
}