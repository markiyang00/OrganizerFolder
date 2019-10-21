using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using organizer.Data.Model;
using Task = organizer.Data.Model.Task;

namespace organizer.Data
{
	public class OrganizerContext:DbContext
	{
		public OrganizerContext(DbContextOptions<OrganizerContext> options) : base(options)
		{
		}

		public DbSet<Day> Days { get; set; }
		public DbSet<Task> Tasks { get; set; }
	}
}
