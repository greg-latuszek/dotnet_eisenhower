using System;

namespace MvcEisenhower.Models
{
	public class Task
	{
        public int TaskID { get; set; }  // ID or clasnameID is interpreted by EF as primary key

        public string Name { get; set; }

        public Boolean Important { get; set; }

        public Boolean Urgent { get; set; }

        public Task()
		{

		}
	}
}
