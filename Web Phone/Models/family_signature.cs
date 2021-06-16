using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;



namespace Web_Phone.Models
{
	public class family_signature
	{
		[DisplayName("個案姓名")]
		[Required]
		public string caser_name { get; set; }

		[DisplayName("簽章時間")]
		[Required]
		public string signature_time { get; set; }

		[DisplayName("簽章位置1")]
		[Required]
		public string seal_place_one { get; set; }

		[DisplayName("簽章位置2")]
		[Required]
		public string seal_place_twe { get; set; }

	}
}