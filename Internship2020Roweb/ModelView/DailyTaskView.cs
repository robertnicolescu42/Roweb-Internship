using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Internship2020Roweb.ModelView
{
    public class DailyTaskView
    {
        public int DailyTaskID { get; set; }

        public string TaskName { get; set; }

        public string TaskDescription { get; set; }

        public bool? IsCompleted { get; set; }

        public DateTime TaskDueDate { get; set; }

    }
}
