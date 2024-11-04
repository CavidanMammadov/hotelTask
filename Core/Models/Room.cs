using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    internal class Room
    {
        private int _id;
        public int Id { get; }
        public string Name { get; set; }
        public double  Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvailable { get; set; }
        public Room(string name , double price, int personCapacity , bool isavailable)
        {
            Id = ++_id;
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
            IsAvailable = isavailable;
            
        }
      public string ShowFullInfo()
        {
             return$" Name:{Name} Price{Price} PersonCapacity{PersonCapacity} isAvailable{isAvailable}";

        }
        public override string ToString()
        {
            return ShowFullInfo();
        }
        
    }
}
