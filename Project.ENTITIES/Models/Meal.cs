using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Meal : BaseEntity
    {
        public string Name { get; set; }

        public decimal UnitPrice { get; set; }



        //Relational Prop

        public List<OrderMeal> OrderMeals { get; set; }

        public override string ToString()
        {
            return $"{Name} {UnitPrice:C2}";
        }
    }
}
