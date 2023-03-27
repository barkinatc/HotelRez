using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Customer : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }

        public string PhoneNo { get; set; }
        public int? EmployeeID { get; set; }

        //Relational Prop

        public virtual List<Reservation> Reservations { get; set; }
        public virtual List<Order> Orders { get; set; }

        public virtual Employee Employee { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {PhoneNo}";
        }
    }
}
