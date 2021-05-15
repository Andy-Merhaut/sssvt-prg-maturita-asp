using System.ComponentModel.DataAnnotations;

namespace MaturitaASP.Models.Bikes
{
    public class Bike
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public int Power { get; set; }
    }
}
