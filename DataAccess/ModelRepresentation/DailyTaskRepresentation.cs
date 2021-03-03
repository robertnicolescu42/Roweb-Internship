using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccess.ModelRepresentation
{
    public class DailyTaskRepresentation
    {
        public static object dailyTaskRepresentation;

        [Key]

        public int DailyTaskID { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public bool? IsCompleted { get; set; }
        public DateTime TaskDueDate { get; set; }
    }
}
