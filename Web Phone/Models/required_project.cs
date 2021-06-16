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
		[DisplayName("個案名稱")]
		[Required]
		public string caser_name { get; set; }

		[DisplayName("健口項目")]
		[Required]
		public string health { get; set; }

		[DisplayName("活化運動")]
		[Required]
		public string sport { get; set; }

		[DisplayName("服務紀錄")]
		[Required]
		public string service_record { get; set; }
	}
}