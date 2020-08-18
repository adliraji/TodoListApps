using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApps.Models
{
    public class TodoItem
    {
        [Key]
        public int ItemId { get; set; }
        public string Title { get; set; }
        //  public int Priority { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? DueDate { get; set; }
        public int? PercentCompleted { get; set; }
        public bool? TrackProgress { get; set; }
        public bool? RemindOnDelay { get; set; }
        public bool? IsAccomplished { get; set; }
    }
}