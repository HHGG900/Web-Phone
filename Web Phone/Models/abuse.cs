using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web_Phone.Models
{
	public class abuse
	{

		[DisplayName("個案姓名")]
		[Required]
		public string caser_name { get; set; }

		[DisplayName("時間")]
		[Required]
		public int tim { get; set; }

		[DisplayName("第一項")]
		[Required]
		public int one { get; set; }

		[DisplayName("第二項")]
		[Required]
		public int twe { get; set; }

		[DisplayName("第三項")]
		[Required]
		public int there { get; set; }

		[DisplayName("第四項")]
		[Required]
		public int four { get; set; }

		[DisplayName("第五項")]
		[Required]
		public int five { get; set; }

		[DisplayName("第六項")]
		[Required]
		public int six { get; set; }

		[DisplayName("第七項")]
		[Required]
		public int seven { get; set; }

		[DisplayName("第八項")]
		[Required]
		public int eight { get; set; }

		[DisplayName("第九項")]
		[Required]
		public int nine { get; set; }

		[DisplayName("第十項")]
		[Required]
		public int ten { get; set; }

		[DisplayName("第十一項")]
		[Required]
		public int eleven { get; set; }

	}
}