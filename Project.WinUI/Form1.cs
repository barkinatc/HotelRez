using Project.BLL.Design_Patterns.Singleton_Pattern;
using Project.BLL.GenericRepository.ConcRepo;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.WinUI
{
    public partial class Form1 : Form
    {

        //repositoryler
        MealRepository _mealRep;
        CustomerRepository _customerRep;
        ReservationRepository _reservationRep;
        RoomRepository _roomRep;
        OrderRepository _orderRep;
        OrderMealRepository _orderMealRep;

        RoomReservationRepository _roomReservationRep;
        ReservationGuestRepository _resGuestRep;
        GuestRepository _guestRep;





        // seçilenler
        Customer _secilenMusteri;
        Reservation _secilenRezervasyon;
        Meal _secilenYemek;

        Room _secilenOda;
        RoomReservation _secilenRoomRezervasyon;
        Guest _secilenGuest;




        List<Room> rooms = new List<Room>();
        public Form1()
        {
            InitializeComponent();
            _guestRep = new GuestRepository();
            _resGuestRep = new ReservationGuestRepository();
            _mealRep = new MealRepository();
            _customerRep = new CustomerRepository();
            _roomRep = new RoomRepository();
            _reservationRep = new ReservationRepository();
            _orderRep = new OrderRepository();
            _orderMealRep = new OrderMealRepository();
            _roomReservationRep = new RoomReservationRepository();


        }






        private void Form1_Load(object sender, EventArgs e)
        {
            lstOda.DataSource = _roomRep.GetAll();
            lstMisafir.DataSource = _guestRep.GetAll();
            //cmbRoom.DataSource = _roomRep.GetAll();
            lstRezervasyon.DataSource = _reservationRep.GetAll();
            cmbYemek.DataSource = _mealRep.GetAll();
            lstMusteri.DataSource = _customerRep.GetActives();




        }





        private void btnReservation_Click(object sender, EventArgs e)
        {

            if (_secilenMusteri != null)
            {
                //if (_secilenOda.RoomStatus == false)
                //{
                //    MessageBox.Show("Lütfen boş bir oda seçiniz..");
                //    return;
                //}
                if (_secilenMusteri.Status == ENTITIES.Enums.DataStatus.Deleted)
                {
                    MessageBox.Show("Lütfen aktif bir müşteri seçiniz");
                    return;
                }


                Reservation r = new Reservation();

                r.CustomerID = _secilenMusteri.ID;
                r.CheckIn = dtGiris.Value;
                r.CheckOut = dtCikis.Value;
                _secilenRezervasyon = r;
                _reservationRep.Add(r);
                btnRezOdaEkle.Enabled = true;
                lstRezervasyon.DataSource = _reservationRep.GetActives();




            }
            else
            {
                MessageBox.Show("Oda veya müşteri seçiniz.");
                return;
            }















        }

        private void btnYemekSec_Click(object sender, EventArgs e)
        {
            if (cmbYemek.SelectedIndex > -1)
            {
                _secilenYemek = cmbYemek.SelectedItem as Meal;
            }
            else
            {
                MessageBox.Show("Lütfen bir yemek seçiniz");

            }
        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            if (_secilenRezervasyon != null && _secilenYemek != null)
            {
                if (_secilenRezervasyon.Status != ENTITIES.Enums.DataStatus.Deleted)
                {
                    Order o = new Order();
                    o.TotalPrice += _secilenYemek.UnitPrice;
                    o.ReservationID = _secilenRezervasyon.ID;
                    o.CustomerID = _secilenRezervasyon.CustomerID;
                    _orderRep.Add(o);

                    _secilenRezervasyon.TotalPrice += o.TotalPrice;
                    OrderMeal om = new OrderMeal();
                    om.MealID = _secilenYemek.ID;
                    om.OrderID = o.ID;
                    _orderMealRep.Add(om);
                    lstRezervasyon.DataSource = _reservationRep.GetAll();
                }
                else
                {
                    MessageBox.Show("Lütfen aktif bir rezervasyon ve yemek seçiniz.");
                }


            }
            else
            {
                MessageBox.Show("Lütfen siparişin ekleneceği bir rezervasyon seçiniz.");
            }

        }

        private void lstRezervasyon_Click(object sender, EventArgs e)
        {


            if (lstRezervasyon.SelectedIndex > -1)
            {
                _secilenRezervasyon = lstRezervasyon.SelectedItem as Reservation;
                //Form4 frm4 = new Form4(_secilenRezervasyon);
                //frm4.Show();




                string isim = "";


                foreach (var item in _secilenRezervasyon.RoomReservations)
                {
                    isim += $"Oda {item.Room.ID}, ";
                    //fiyat += item.Room.RoomType.PricePerNight;
                }
                isim.TrimEnd(',');
                label2.Text = isim;




            }
        }





        private void btnSil_Click(object sender, EventArgs e)
        {

            if (_secilenRezervasyon != null)
            {
                _reservationRep.Delete(_secilenRezervasyon);
                foreach (RoomReservation item in _secilenRezervasyon.RoomReservations)
                {
                    item.Room.RoomStatus = true;
                    item.Room.Clean = false;
                    item.Room.GuestCapacity = 0;
                    //_secilenOda.ID = item.RoomID;
                    //_secilenOda.RoomStatus = true;
                }


                lstRezervasyon.DataSource = _reservationRep.GetActives();

                if (_secilenOda!=null)
                {
lblSonuc.Text = _secilenOda.BilgiGoster();
                }
                




			}




        }





        private void btnRezAktif_Click(object sender, EventArgs e)
        {
            lstRezervasyon.DataSource = _reservationRep.GetActives();
        }

        private void btnRezPasif_Click(object sender, EventArgs e)
        {
            lstRezervasyon.DataSource = _reservationRep.GetPassives();
        }

        private void btnRezHepsi_Click(object sender, EventArgs e)
        {
            lstRezervasyon.DataSource = _reservationRep.GetAll();
        }

        private void btnOdaBosalt_Click(object sender, EventArgs e)
        {
            if (_secilenOda != null)
            {
                _secilenOda.RoomStatus = true;
                _secilenOda.GuestCapacity = 0;
                _roomRep.Update(_secilenOda);

            }
        }



        private void btnMusteriSec_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Müşteri seçildi lütfen oda ekleyebilmek için rezervasyon oluşturunuz.");
            btnReservation.Enabled = true;
        }



        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }
        
        private void lstOda_Click(object sender, EventArgs e)

        {


            if (lstOda.SelectedIndex > -1)
            {
                _secilenOda = lstOda.SelectedItem as Room;
                lblSonuc.Text = _secilenOda.BilgiGoster();

          

            }

        }

        private void lstMusteri_Click(object sender, EventArgs e)
        {
            if (lstMusteri.SelectedIndex > -1)
            {
                _secilenMusteri = lstMusteri.SelectedItem as Customer;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_secilenOda != null)
            {
                if (_secilenOda.RoomStatus == false)
                {
                    MessageBox.Show("Lütfen boş bir oda seçiniz..");
                    return;
                }
                if (_secilenOda.Clean == false)
                {
                    MessageBox.Show("Oda 2 günlüğüne temizlenme aşamasında.. ");
                    return;
                }
            }

            if (_secilenOda != null && _secilenRezervasyon != null)
            {
                RoomReservation rr = new RoomReservation();

                rr.RoomID = _secilenOda.ID;


                rr.ReservationID = _secilenRezervasyon.ID;


                _secilenRezervasyon.RoomReservations.Add(rr);


                _roomReservationRep.Add(rr);
                btnRezFiyat.Enabled = true;



            }
            if (_secilenOda == null)
            {
                MessageBox.Show("lütfen bir oda seçiniz.");
                return;
            }
        }

        private void btnRezFiyat_Click(object sender, EventArgs e)
        {
            try
            {
                decimal fiyat = 0;
                foreach (RoomReservation item in _secilenRezervasyon.RoomReservations)
                {
                    fiyat += item.Room.RoomType.PricePerNight;
                }
                _secilenRezervasyon.TutarHesapla();

                _secilenRezervasyon.TotalPrice += fiyat;
                _reservationRep.Update(_secilenRezervasyon);
                lstRezervasyon.DataSource = _reservationRep.GetAll();
                btnRezGuestEkle.Enabled = true;
                btnRezFiyat.Enabled = false;


				btnRezFiyat.Enabled = false;



			}
			catch (Exception)
            {

                MessageBox.Show("hata");

            }
		}

        //int currentCapacity = 0;
        private void btnRezGuestEkle_Click(object sender, EventArgs e)
        {


            if (_secilenGuest != null && _secilenRezervasyon != null)
            {
                //foreach (RoomReservation item in _secilenRezervasyon.RoomReservations)
                //{
                //    a = Convert.ToInt32( item.Room.RoomTypeID);
                //}

                //ID ' si 6 olan iki kişilik  7 olan tek kişilik


                //Todo :  burada kaldık fakat keyler durumunda db save changes hata veriyor...
                //Hata çözüdlü sadece eklenen kişi ve çikarilanın secilenGuestten alınması gerekiyor..

                ReservationGuest rg = new ReservationGuest();

                rg.GuestID = _secilenGuest.ID;

                rg.ReservationID = _secilenRezervasyon.ID;



                _resGuestRep.Add(rg);
                btnMisafirCıkar.Enabled = true;







            }
            //if (_secilenOda.guestCapacity < _secilenOda.Capacity)
            //{
            //             _secilenOda.guestCapacity++;
            //	if (_secilenOda.guestCapacity == _secilenOda.Capacity)
            //	{
            //		btnRezGuestEkle.Enabled = false;
            //	}
            //	UpdateCapacityLabel();
            //}
            if (_secilenOda.GuestCapacity != _secilenOda.Capacity)
            {
                _secilenOda.GuestCapacity++;

                lblSonuc.Text = _secilenOda.BilgiGoster();

            }
            else
            {
                MessageBox.Show("Odanın max kapasitesine ulaşışdı");
                return;
            }


        }

        //void UpdateCapacityLabel()
        //{
        //    lblSonuc.Text = $"Mevcut Kapasite : {_secilenOda.guestCapacity} {_secilenOda.Capacity}";
        //}

        private void lstMisafir_Click(object sender, EventArgs e)
        {
            if (lstMisafir.SelectedIndex > -1)
            {
                _secilenGuest = lstMisafir.SelectedItem as Guest;
            }

        }

        private void btnMisafir_Click(object sender, EventArgs e)
        {
            Guest g = new Guest();

            g.FirstName = txtMisafirIsim.Text;

            g.LastName = txtMisafirSoyIsim.Text;


            _guestRep.Add(g);

            lstMisafir.DataSource = _guestRep.GetAll();
        }

        private void btnMisafirCıkar_Click(object sender, EventArgs e)
        {
            //if (currentCapacity >0)
            //{
            //    currentCapacity--;
            //    UpdateCapacityLabel();
            //    if (currentCapacity < _secilenOda.Capacity)
            //    {
            //        btnRezGuestEkle.Enabled = true;
            //    }
            //}

            if (_secilenOda.GuestCapacity > 0)
            {
                _secilenOda.GuestCapacity--;
                lblSonuc.Text = _secilenOda.BilgiGoster();

            }
        }

        private void btnMusteriAktif_Click(object sender, EventArgs e)
        {
            lstMusteri.DataSource = _customerRep.GetActives();
        }

        private void btnPasif_Click(object sender, EventArgs e)
        {
            lstMusteri.DataSource = _customerRep.GetPassives();
        }

        private void btnOdaTemizle_Click(object sender, EventArgs e)
        {
            if (_secilenOda != null)
            {
                _secilenOda.Clean = true;
                _roomRep.Update(_secilenOda);
            }
        }

		private void btnKalanlar_Click(object sender, EventArgs e)
		{
            Form4 form4 = new Form4();  

            form4.ShowDialog();
		}
	}
}
