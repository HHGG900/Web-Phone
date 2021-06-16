using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web_Phone.Models
{
	public class family_attend
	{
		[DisplayName("個案姓名")]
		[Required]
		public string caser_name { get; set; }

		[DisplayName("日期")]
		[Required]
		public string tim { get; set; }

		[DisplayName("吃飯")]
		[Required]
		public string eat { get; set; }

		[DisplayName("飲水")]
		[Required]
		public string drink { get; set; }


		[DisplayName("服藥")]
		[Required]
		public string drink_medicine { get; set; }

		[DisplayName("睡眠")]
		[Required]
		public string sleep { get; set; }

		[DisplayName("情緒")]
		[Required]
		public string depression { get; set; }

		[DisplayName("就醫")]
		[Required]
		public string doctor { get; set; }

		[DisplayName("醫生囑咐")]
		[Required]
		public string doctor_tell { get; set; }

		[DisplayName("家屬叮嚀")]
		[Required]
		public string family_tell { get; set; }
	}
}