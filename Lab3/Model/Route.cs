using System.ComponentModel.DataAnnotations;

namespace Lab3.Model
{
    public class Route
    {
        [Key]
        public int Number { get; set; }
        public string Name { get; set; }
        public Direction Direction { get; set; }
        public bool RampAccessible { get; set; }
        public bool BicycleAccessible { get; set; }
        public Queue<StopSchedule> StopSchedule { get; set; }
    }
    public enum Direction
    {
        North,
        South,
        East,
        West,
        Northeast,
        Northwest,
        Southeast,
        Southwest
    }
}
