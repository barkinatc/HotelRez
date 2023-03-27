using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Order : BaseEntity
    {
        public decimal TotalPrice { get; set; }

        public int? ReservationID { get; set; }

        public int? CustomerID { get; set; }

        public int? EmployeeID { get; set; }


        //Relational Prop

        public virtual Reservation Reservation { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }

        public List<OrderMeal> OrderMeals { get; set; }


    }
}
