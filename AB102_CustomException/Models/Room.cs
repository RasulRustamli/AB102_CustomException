using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AB102_CustomException.Models
{
    public class Room
    {
        private static int _id;
        public int Id { get; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvailable { get; set; } = true;
        public Room(string name, double price, int personCapacity)
        {
            _id++;
            Id = _id;
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
        }
        public string ShowInfo()
        {
            return $"Id: {Id} - Room: {Name} - IsAvailable: {IsAvailable}";
        }
        public override string ToString()
        {
            return ShowInfo();
        }
    }
}
