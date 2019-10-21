using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace organizer.Data.Model
{
	public class Task
	{
		[Key]
		public string Id { get; set; }
		public string Title { get; set; }
		public DateTime Date { get; set; }
		public virtual Day Day { get; set; }
	}
}
