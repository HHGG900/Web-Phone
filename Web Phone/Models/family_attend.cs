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
		[DisplayName("�Ӯשm�W")]
		[Required]
		public string caser_name { get; set; }

		[DisplayName("���")]
		[Required]
		public string tim { get; set; }

		[DisplayName("�Y��")]
		[Required]
		public string eat { get; set; }

		[DisplayName("����")]
		[Required]
		public string drink { get; set; }


		[DisplayName("�A��")]
		[Required]
		public string drink_medicine { get; set; }

		[DisplayName("�ίv")]
		[Required]
		public string sleep { get; set; }

		[DisplayName("����")]
		[Required]
		public string depression { get; set; }

		[DisplayName("�N��")]
		[Required]
		public string doctor { get; set; }

		[DisplayName("�����J")]
		[Required]
		public string doctor_tell { get; set; }

		[DisplayName("�a�ݥm�{")]
		[Required]
		public string family_tell { get; set; }
	}
}