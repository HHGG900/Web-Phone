using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web_Phone.Models
{
	public class required_project
	{
		[DisplayName("�ӮצW��")]
		[Required]
		public string caser_name { get; set; }

		[DisplayName("���f����")]
		[Required]
		public string health { get; set; }

		[DisplayName("���ƹB��")]
		[Required]
		public string sport { get; set; }

		[DisplayName("�A�Ȭ���")]
		[Required]
		public string service_record { get; set; }
	}
}