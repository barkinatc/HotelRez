using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Employee : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Position { get; set; }

        //Relational Prop

        public virtual EmployeeProfile EmployeeProfile { get; set; }

        public virtual List<Customer> Customers { get; set; }

        public virtual List<Reservation> Reservations { get; set; }

        public virtual List<Order> Orders { get; set; }
    }
}
