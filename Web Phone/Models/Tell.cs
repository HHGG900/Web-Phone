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
		[DisplayName("�m�W")]
		[Required]
		public string caser_name { get; set; }

		[DisplayName("����")]
		[Required]
		public string user_status { get; set; }

		[DisplayName("�N���ӷ�")]
		[Required]
		public string origin { get; set; }

		[DisplayName("�s���q��")]
		[Required]
		public string phone { get; set; }

		[DisplayName("���")]
		[DataType(DataType.Date)]
		public DateTime tim { get; set; }

		[DisplayName("�ƥ�")]
		[Required]
		public string cause { get; set; }
	}
}