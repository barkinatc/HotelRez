using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Guest : BaseEntity
    {
        public string RoomNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }



        //Relational Prop

        public virtual List<ReservationGuest> ReservationGuests { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
