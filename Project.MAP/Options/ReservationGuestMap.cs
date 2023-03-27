using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class ReservationGuestMap:BaseMap<ReservationGuest>
    {
        public ReservationGuestMap()
        {
            Ignore(x => x.ID);
            HasKey(x => new
            {
                x.ReservationID,
                x.GuestID
            });
        }
    }
}
