using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web_Phone.Models
{
	public class worker_arrive
	{
		[DisplayName("���u�m�W")]
		[Required]
		public string worker_name { get; set; }

		[DisplayName("��Z�ɶ�")]
		[Required]
		public string arrive_time { get; set; }

		[DisplayName("���Z�ɶ�")]
		[Required]
		public string leave_time { get; set; }

		[DisplayName("���")]
		[Required]
		public string tim { get; set; }

	}
}