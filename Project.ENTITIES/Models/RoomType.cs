using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class RoomType : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal PricePerNight { get; set; }

     

        //Relational Prop

        public List<Room> Rooms { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }


    }
}
