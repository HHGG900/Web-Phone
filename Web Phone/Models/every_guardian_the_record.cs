using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web_Phone.Models
{
	public class Every_guardian_the_record
	{
		[DisplayName("單位代號")]
		[Required]
		public int id { get; set; }

		[DisplayName("生命")]
		[Required]
		public string temperature { get; set; }

		[DisplayName("脈搏")]
		[Required]
		public string pulse { get; set; }

		[DisplayName("血壓")]
		[Required]
		public string bloodpressure { get; set; }

		[DisplayName("血壓1")]
		[Required]
		public string C_blood_pressure1 { get; set; }

		[DisplayName("皮膚")]
		[Required]
		public string skin { get; set; }

		[DisplayName("皮膚1")]
		[Required]
		public string skin1 { get; set; }

		[DisplayName("皮膚2")]
		[Required]
		public string skin2 { get; set; }

		[DisplayName("皮膚3")]
		[Required]
		public string skin3 { get; set; }

		[DisplayName("皮膚4")]
		[Required]
		public string skin4 { get; set; }

		[DisplayName("皮膚5")]
		[Required]
		public string skin5 { get; set; }

		[DisplayName("服藥")]
		[Required]
		public string drug { get; set; }

		[DisplayName("服藥1")]
		[Required]
		public string drug1 { get; set; }

		[DisplayName("照顧交代")]
		[Required]
		public string explain { get; set; }

	}
}