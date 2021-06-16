using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web_Phone.Models
{
	public class Tell
	{
		[DisplayName("姓名")]
		[Required]
		public string caser_name { get; set; }

		[DisplayName("身分")]
		[Required]
		public string user_status { get; set; }

		[DisplayName("意見來源")]
		[Required]
		public string origin { get; set; }

		[DisplayName("連絡電話")]
		[Required]
		public string phone { get; set; }

		[DisplayName("日期")]
		[DataType(DataType.Date)]
		public DateTime tim { get; set; }

		[DisplayName("事由")]
		[Required]
		public string cause { get; set; }
	}
}