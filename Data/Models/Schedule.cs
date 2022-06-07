using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScheduleWeb.Data.Models
{
    public class Schedule
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public TimeSpan Monday { get; set; }
        public TimeSpan Tuesday { get; set; }
        public TimeSpan Wednesday { get; set; }
        public TimeSpan Thursday { get; set; }
        public TimeSpan Friday { get; set; }
        public TimeSpan Saturday { get; set; }
        public TimeSpan Sunday { get; set; }

    }
}
