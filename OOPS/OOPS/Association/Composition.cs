using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Association
{
    internal class Room
    {
        public string roomtype { get; set; }    
        public Room(string type)
        {
            roomtype = type;
        }
    }
    internal class House
    {
        List<Room> _rooms;
        public void addRoom(Room room)
        {
            _rooms.Add(room);
        }
        public void getRooms()
        {
            foreach (Room room in _rooms)
            {
                Console.WriteLine(room.roomtype);
            }
        }

    }
    internal class Composition
    {
       public static void test()
        {
            Room room = new Room("AC");
            Room r2 = new Room("non-ac");
            House house = new House();
            house.addRoom(room);
            house.addRoom(r2);
            house.getRooms();

        }
    }
}
