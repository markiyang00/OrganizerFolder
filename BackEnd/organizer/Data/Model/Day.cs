using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace organizer.Data.Model
{
	public class Day
	{
		[Key]
		public DateTime Date { get; set; }

		public virtual  ICollection<Task> Tasks { get; set; }
	}
}
