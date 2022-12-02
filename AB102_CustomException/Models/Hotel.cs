using AB102_CustomException.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AB102_CustomException.Models
{
    public class Hotel
    {
        public string Name { get; set; }
        public int StarCount { get; set; }
        private Room[] rooms;

        public Hotel(string name)
        {
            Name = name;
            rooms = new Room[0];
        }

        public void AddRoom(Room room)
        {
            Array.Resize(ref rooms, rooms.Length + 1);
            rooms[rooms.Length - 1] = room;
        }

        public void MakeReservation(int? roomId)
        {
            if (roomId == null)
                throw new NullReferenceException("Bu id-li otaq tapilmadi");

            foreach (var room in rooms)
            {
                if (room.Id == roomId)
                {
                    if (!room.IsAvailable)
                        throw new NotAvailableException("Aktiv deyil");

                    room.IsAvailable = false;
                    
                }
            }
        }



    }
}
