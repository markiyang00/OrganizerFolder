using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using organizer.Data;
using organizer.Data.Model;

namespace organizer.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TestsController : ControllerBase
	{
		private readonly OrganizerContext context;

		public TestsController(OrganizerContext context)
		{
			this.context = context;
		}

		// GET api/values
		[HttpGet("{date}")]
		public Data.Model.Task[] Get(DateTime date)
		{
			var tasks = context.Tasks.Where(p => p.Date == date).OrderBy(i=>i.Id).ToArray();
			return tasks;
		}

		// POST api/values
		[HttpPost]
		public Data.Model.Task Post (Data.Model.Task task)
		{
			var day = context.Days.AsTracking().FirstOrDefault(p => p.Date == task.Date);
			if (day==null)
				context.Days.Add(new Day() { Date = task.Date });
			context.Tasks.Add(task);
			context.SaveChanges();
			var taskBase = context.Tasks.AsNoTracking().FirstOrDefault(p=>p.Date==task.Date & p.Title==task.Title);
			return taskBase;
		}

		// DELETE api/values/5
		[HttpDelete("{id}")]
		public async Task<ActionResult<Data.Model.Task>> Delete(string id)
		{
			var task = await context.Tasks.FindAsync(id);
			if (task == null)
			{
				return NotFound();
			}

			context.Tasks.Remove(task);
			await context.SaveChangesAsync();

			return task;
		}
	}
}
