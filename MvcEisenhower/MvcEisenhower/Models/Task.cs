using System;
using System.Collections.Generic;

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

    public class User
    {
        public int UserID { get; set; }
        public string Login { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public ICollection<Task> Tasks { get; set; }
    }
}
