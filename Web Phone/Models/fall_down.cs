using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web_Phone.Models
{
	public class fall_down
	{
		[DisplayName("個案姓名")]
		[Required]
		public string caser_name { get; set; }

		[DisplayName("時間")]
		[Required]
		public string tim { get; set; }

		[DisplayName("1")]
		[Required]
		public string one { get; set; }

		[DisplayName("2")]
		[Required]
		public string twe { get; set; }

		[DisplayName("3")]
		[Required]
		public string there { get; set; }

		[DisplayName("4")]
		[Required]
		public string four { get; set; }

		[DisplayName("5")]
		[Required]
		public string five { get; set; }

		[DisplayName("6")]
		[Required]
		public string six { get; set; }

		[DisplayName("7")]
		[Required]
		public string seven { get; set; }

		[DisplayName("8")]
		[Required]
		public string eight { get; set; }

		[DisplayName("9")]
		[Required]
		public string nine { get; set; }

		[DisplayName("10")]
		[Required]
		public string ten { get; set; }

		[DisplayName("11")]
		[Required]
		public string eleven { get; set; }


	}
}