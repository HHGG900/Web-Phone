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
		[DisplayName("�ӮצW��")]
		[Required]
		public string caser_name { get; set; }

		[DisplayName("���N��")]
		[Required]
		public string reply1 { get; set; }

		[DisplayName("�^�X")]
		[Required]
		public string satisfaction { get; set; }

		[DisplayName("���")]
		[Required]
		public string tim { get; set; }
	}
}