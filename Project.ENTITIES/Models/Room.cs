using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project.ENTITIES.Models
{
    public class Room : BaseEntity
    {
        // public bool temizmi get set
        public bool Clean { get; set; }
        public bool RoomStatus { get; set; }

        public string Description { get; set; }

        public int? RoomTypeID { get; set; }

        //public int? currentcapacity get set******************************

        public int? GuestCapacity { get; set; }

        public int? Capacity { get; set; }

        //Relational Prop

        public virtual RoomType RoomType { get; set; }

        public virtual List<RoomReservation> RoomReservations { get; set; }

        public string BilgiGoster()
        {
            return $"{GuestCapacity} {Capacity}";
        }


        public override string ToString()
        {
            return $"Oda:{ID} Kapasite: {Capacity}";
        }
    }
}
