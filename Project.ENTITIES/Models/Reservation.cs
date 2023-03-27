using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Reservation : BaseEntity
    {
        public Reservation()
        {
            RoomReservations = new List<RoomReservation>();
            Orders = new List<Order>();
            ReservationGuests = new List<ReservationGuest>();
        }

        public DateTime? CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }

        public decimal TotalPrice { get; set; }

        public int? CustomerID { get; set; }

        public int? EmployeeID { get; set; }

        //Relational Prop

        public virtual Customer Customer { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual List<RoomReservation> RoomReservations { get; set; }

        public virtual List<Order> Orders { get; set; }
        public virtual List<ReservationGuest> ReservationGuests { get; set; }


        public void TutarHesapla()
        {
            decimal toplam = 0;
            if (RoomReservations != null)
            {
                foreach (RoomReservation item in RoomReservations)
                {
                    toplam += item.Room.RoomType.PricePerNight;
                }
            }
            if (Orders!=null)
            {
                foreach (Order item in Orders)
                {
                    toplam += item.TotalPrice;
                }
            }

        }
        public override string ToString()
        {


            string roomNo = "";
            foreach (RoomReservation item in RoomReservations)
            {
                roomNo += $"{item.RoomID},";
            }
            roomNo = roomNo.TrimEnd(',');
            foreach (RoomReservation item in RoomReservations)
            {
                if (item.Room != null)
                {
                    return $"Oda {roomNo},  {Customer.FirstName} {Customer.LastName}'isimli müşteriye rezerve edildi.  {TotalPrice:C2}";
                }
            }
             
            //if (RoomReservations !=null)
            //{
            //    return $"Oda no : {roomNo}  {Customer.FirstName} {Customer.LastName}  {TotalPrice:C2} ";
            //}
            return $" {Customer.FirstName} {Customer.LastName}' üzerine rezervasyon.  {TotalPrice:C2}  ";
        }
    }
}
