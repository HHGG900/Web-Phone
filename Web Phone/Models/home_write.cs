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
		[DisplayName("�Ӯשm�W")]
		[Required]
		public string caser_name { get; set; }

		[DisplayName("���U��x")]
		[Required]
		public string daily_record { get; set; }

		[DisplayName("�u�@����")]
		[Required]
		public string record { get; set; }

		[DisplayName("���ܻ�")]
		[Required]
		public string question { get; set; }

		[DisplayName("�����^�X")]
		[Required]
		public string reply { get; set; }

		[DisplayName("���U�M��")]
		[Required]
		public string attend_area { get; set; }

		[DisplayName("���U����")]
		[Required]
		public string attend_record { get; set; }

	}
}