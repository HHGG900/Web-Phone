using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web_Phone.Models
{
	public class Care_place
	{
		[DisplayName("")]
		[Required]
		public string usr_name { get; set; }

		[DisplayName("")]
		[Required]
		public DateTime tim { get; set; }

		[DisplayName("")]
		[Required]
		public string worker_name { get; set; }

		[DisplayName("")]
		[Required]
		public string pic_place { get; set; }

		[DisplayName("")]
		[Required]
		public string BA01 { get; set; }

		[DisplayName("")]
		[Required]
		public string BA02 { get; set; }

		[DisplayName("")]
		[Required]
		public string BA03 { get; set; }

		[DisplayName("")]
		[Required]
		public string BA04 { get; set; }

		[DisplayName("")]
		[Required]
		public string BA05 { get; set; }

		[DisplayName("")]
		[Required]
		public string BA06 { get; set; }

		[DisplayName("")]
		[Required]
		public string BA07 { get; set; }

		[DisplayName("")]
		[Required]
		public string BA08 { get; set; }

		[DisplayName("")]
		[Required]
		public string BA09 { get; set; }

		[DisplayName("")]
		[Required]
		public string BA10 { get; set; }

		[DisplayName("")]
		[Required]
		public int BA01_tem { get; set; }

		[DisplayName("")]
		[Required]
		public int BA02_tem { get; set; }

		[DisplayName("")]
		[Required]
		public int BA03_tem { get; set; }

		[DisplayName("")]
		[Required]
		public int BA04_tem { get; set; }

		[DisplayName("")]
		[Required]
		public int BA05_tem { get; set; }

		[DisplayName("")]
		[Required]
		public int BA06_tem { get; set; }

		[DisplayName("")]
		[Required]
		public int BA07_tem { get; set; }

		[DisplayName("")]
		[Required]
		public int BA08_tem { get; set; }

		[DisplayName("")]
		[Required]
		public int BA09_tem { get; set; }

		[DisplayName("")]
		[Required]
		public int BA10_tem { get; set; }

		[DisplayName("")]
		[Required]
		public string BA { get; set; }


	}
}