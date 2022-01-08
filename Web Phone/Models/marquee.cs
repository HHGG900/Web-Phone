using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web_Phone.Models
{
	public class marquee
	{
		[Required]
		public string marquee1 { get; set; }

		[Required]
		public string tim { get; set; }

	}
}