using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Logo
	{
		[Key]
		public int Id { get; set; }
		public string LogoUrl { get; set; }
		public bool Status { get; set; }
		public string LogoYol { get; set; }
		[NotMapped]
		public IFormFile LogoResim { get; set; }
	}
}
