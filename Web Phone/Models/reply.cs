using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web_Phone.Models
{
	public class reply
	{
		[DisplayName("個案名稱")]
		[Required]
		public string caser_name { get; set; }

		[DisplayName("滿意度")]
		[Required]
		public string reply1 { get; set; }

		[DisplayName("回饋")]
		[Required]
		public string satisfaction { get; set; }

		[DisplayName("日期")]
		[Required]
		public string tim { get; set; }
	}
}