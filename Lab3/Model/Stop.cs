using System.ComponentModel.DataAnnotations;

namespace Lab3.Model
{
    public class Stop
    {
        [Key]
        public int Number { get; set; }
        public string Street { get; set; }
        public string Name { get; set; }
        public Direction Direction { get; set; }
        public List<StopSchedule> StopSchedules { get; set; }
    }
}
