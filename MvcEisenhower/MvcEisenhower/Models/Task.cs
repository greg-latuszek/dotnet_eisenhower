using System;

namespace MvcEisenhower.Models
{
	public class Task
	{
        public int Id { get; set; }

        public string Name { get; set; }

        public Boolean Important { get; set; }

        public Boolean Urgent { get; set; }

        public Task()
		{

		}
	}
}
