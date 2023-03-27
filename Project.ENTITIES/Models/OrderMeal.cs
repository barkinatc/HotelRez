using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class OrderMeal : BaseEntity
    {
        public string RoomNo { get; set; }
        public int OrderID { get; set; }

        public int MealID { get; set; }

        //Relational Prop

        public virtual Order Order { get; set; }

        public virtual Meal Meal { get; set; }
    }
}
