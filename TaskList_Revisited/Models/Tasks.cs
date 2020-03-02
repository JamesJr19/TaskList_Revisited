using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TaskList_Revisited.Models
{
    public partial class Tasks
    {
        public int Id { get; set; }
       
        public string TaskName { get; set; }
        
        public DateTime DueDate { get; set; }
        public bool Completed { get; set; }
        public string EmployeeId { get; set; }

        public virtual AspNetUsers Employee { get; set; }
    }
}
