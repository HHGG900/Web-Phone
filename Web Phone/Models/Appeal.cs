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
		[DisplayName("姓名")]
		[Required]
		public string US_name { get; set; }

		[DisplayName("身分")]
		[Required]
		public string user_status { get; set; }

		[DisplayName("電話")]
		[Required]
		public int phone { get; set; }

		[DisplayName("申訴類別")]
		[Required]
		public string fall_class { get; set; }

		[DisplayName("事由")]
		[Required]
		public string conten { get; set; }

		[DisplayName("照片1")]
		[Required]
		public string pic_one { get; set; }

		[DisplayName("時間")]
		[DataType(DataType.Date)]
		[Required]
		public DateTime? tim { get; set; }

	}
}