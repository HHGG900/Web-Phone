using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web_Phone.Models
{
	public class care_log_picture
	{
		[DisplayName("個案名稱")]
		[Required]
		public string usr_name { get; set; }

		[DisplayName("服務時間")]
		[Required]
		public string tim { get; set; }

		[DisplayName("服務人員")]
		[Required]
		public string worker_name { get; set; }

		[DisplayName("照片位置")]
		[Required]
		public string pic_place { get; set; }

		[DisplayName("BA01")]
		[Required]
		public string BA01 { get; set; }

		[DisplayName("BA02")]
		[Required]
		public string BA02 { get; set; }

		[DisplayName("BA03")]
		[Required]
		public string BA03 { get; set; }

		[DisplayName("BA04")]
		[Required]
		public string BA04 { get; set; }

		[DisplayName("BA05")]
		[Required]
		public string BA05 { get; set; }

		[DisplayName("BA06")]
		[Required]
		public string BA06 { get; set; }

		[DisplayName("BA07")]
		[Required]
		public string BA07 { get; set; }

		[DisplayName("BA08")]
		[Required]
		public string BA08 { get; set; }

		[DisplayName("BA09")]
		[Required]
		public string BA09 { get; set; }

		[DisplayName("BA10")]
		[Required]
		public string BA10 { get; set; }

		[DisplayName("BA01_tem")]
		[Required]
		public string BA01_tem { get; set; }

		[DisplayName("BA02_tem")]
		[Required]
		public string BA02_tem { get; set; }

		[DisplayName("BA03_tem")]
		[Required]
		public string BA03_tem { get; set; }

		[DisplayName("BA04_tem")]
		[Required]
		public string BA04_tem { get; set; }

		[DisplayName("BA05_tem")]
		[Required]
		public string BA05_tem { get; set; }

		[DisplayName("BA06_tem")]
		[Required]
		public string BA06_tem { get; set; }

		[DisplayName("BA07_tem")]
		[Required]
		public string BA07_tem { get; set; }

		[DisplayName("BA08_tem")]
		[Required]
		public string BA08_tem { get; set; }

		[DisplayName("BA09_tem")]
		[Required]
		public string BA09_tem { get; set; }

		[DisplayName("BA10_tem")]
		[Required]
		public string BA10_tem { get; set; }


	}
}