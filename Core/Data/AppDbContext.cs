using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data
{
    public static class AppDbContext
    {
        private static List<Room> rooms = new List<Room>();
        static List<Hotel> hotels = new List<Hotel>();
        public static void AddRoom(Room room)
        {
            rooms.Add(room);
        }
        public static Room FindAllRooms(int id)
        {
            return rooms.Find(x=>x.Id == id);
        }
    }
}
