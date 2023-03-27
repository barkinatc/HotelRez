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
    public partial class Form3 : Form
    {
        CustomerRepository _customerRep;
        MealRepository _mealRep;
        RoomTypeRepository _roomTypeRep;
		RoomRepository _roomRep;

		//seçilen

		Customer _secilenMusteri;
        public Form3()
        {
            InitializeComponent();
            _customerRep = new CustomerRepository();
            _mealRep = new MealRepository();
            _roomTypeRep = new RoomTypeRepository();
            _roomRep = new RoomRepository();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lstMusteri.DataSource = _customerRep.GetAll();
            cmbRoomTip.DataSource = _roomTypeRep.GetAll();
            cmbYemek.DataSource = _mealRep.GetAll();
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.FirstName = txtIsim.Text;
            c.LastName = txtSoyIsim.Text;
            c.PhoneNo = txtTel.Text;
            _customerRep.Add(c);
            lstMusteri.DataSource = _customerRep.GetAll();

        }





        private void btnHepsi_Click(object sender, EventArgs e)
        {
            lstMusteri.DataSource = _customerRep.GetAll();
        }

        private void btnAktif_Click(object sender, EventArgs e)
        {
            lstMusteri.DataSource = _customerRep.GetActives();
        }

        private void btnPasif_Click(object sender, EventArgs e)
        {
            lstMusteri.DataSource = _customerRep.GetPassives();
        }

        private void btnYemekEkle_Click(object sender, EventArgs e)
        {
            Meal m = new Meal();
            m.Name = txtYemekIsim.Text;
            m.UnitPrice = Convert.ToDecimal(txtYemekFiyat.Text) ;
            _mealRep.Add(m);
            cmbYemek.DataSource = _mealRep.GetAll();
        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            _customerRep.Delete(_secilenMusteri);
            lstMusteri.DataSource= _customerRep.GetPassives();
        }

        private void lstMusteri_Click(object sender, EventArgs e)
        {
            if (lstMusteri.SelectedIndex>-1)
            {
                _secilenMusteri = lstMusteri.SelectedItem as Customer;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RoomType rt = new RoomType();
            rt.Name = txtRoomTipiIsim.Text;
            rt.Description = txtRoomTipiAciklama.Text;
            rt.PricePerNight = Convert.ToDecimal(txtRoomTipiFiyat.Text) ;
         
            _roomTypeRep.Add(rt);
            cmbRoomTip.DataSource = _roomTypeRep.GetAll();
        }

		private void btnOdaEkle_Click(object sender, EventArgs e)
		{
            try
            {
				Room r = new Room();

				r.Capacity = Convert.ToInt16(txtRoomKapasite.Text);
				r.Description = txtRoomAcıklama.Text;

				_roomRep.Add(r);

				dataGridView1.DataSource = _roomRep.GetAll();
			}
            catch (Exception ex)
            {

                MessageBox.Show("Lütfen İlgili verileri giriniz");
            }
           
		}
	}
}
