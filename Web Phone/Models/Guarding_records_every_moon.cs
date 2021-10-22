using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web_Phone.Models
{
	public class Guarding_records_every_moon
	{
		[DisplayName("個案姓名")]
		[Required]
		public string caser_name { get; set; }

		[DisplayName("服務人員")]
		[Required]
		public string worker_name { get; set; }


		[DisplayName("簽名")]
		[Required]
		public string signatur { get; set; }


		[DisplayName("日期")]
		[Required]
		public string time_m { get; set; }

		[DisplayName("壓力總數")]
		[Required]
		public string pressure_all { get; set; }

		[DisplayName("資源總數")]
		[Required]
		public string resources_all { get; set; }

		[DisplayName("視力")]
		[Required]
		public string sight { get; set; }

		[DisplayName("聽力")]
		[Required]
		public string listen { get; set; }

		[DisplayName("語言")]
		[Required]
		public string languag { get; set; }

		[DisplayName("理解")]
		[Required]
		public string understand { get; set; }

		[DisplayName("輔具合宜性")]
		[Required]
		public string assistive { get; set; }


		[DisplayName("肌力1")]
		[Required]
		public string muscle_status { get; set; }

		[DisplayName("受虐")]
		[Required]
		public string abuse { get; set; }

		[DisplayName("安全認知")]
		[Required]
		public string safet { get; set; }

		[DisplayName("十大指標")]
		[Required]
		public string ten_key { get; set; }
	}
}