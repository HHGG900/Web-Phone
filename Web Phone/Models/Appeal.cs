using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Web_Phone.Models
{
	public class Appeal
	{
		[DisplayName("�m�W")]
		[Required]
		public string US_name { get; set; }

		[DisplayName("����")]
		[Required]
		public string user_status { get; set; }

		[DisplayName("�q��")]
		[Required]
		public int phone { get; set; }

		[DisplayName("�ӶD���O")]
		[Required]
		public string fall_class { get; set; }

		[DisplayName("�ƥ�")]
		[Required]
		public string conten { get; set; }

		[DisplayName("�Ӥ�1")]
		[Required]
		public string pic_one { get; set; }

		[DisplayName("�ɶ�")]
		[DataType(DataType.Date)]
		[Required]
		public DateTime? tim { get; set; }

	}
}