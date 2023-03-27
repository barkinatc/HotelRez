using Project.BLL.GenericRepository.ConcRepo;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.WinUI
{
    public partial class Form4 : Form
    {

        GuestRepository _guestRep;
        public Form4()
        {
           _guestRep = new GuestRepository();
            InitializeComponent();
       
        }

        private void Form4_Load(object sender, EventArgs e)
        {
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (_selectGuest != null)
            {
                _guestRep.Delete(_selectGuest);

                _guestRep.GetActives();
            }
        }

         private void TemizleVeListele()
        {
            _selectGuest = null;

            _guestRep.GetAll();
        }

		private void btnAktif_Click(object sender, EventArgs e)
		{
			dataGridView1.DataSource = _guestRep.GetActives();

		}
        Guest _selectGuest;
		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
            if (dataGridView1.SelectedRows.Count >0)
            {
                _selectGuest = dataGridView1.SelectedRows[0].DataBoundItem as Guest;
            }
		}

		private void btnPasif_Click(object sender, EventArgs e)
		{
            dataGridView1.DataSource = _guestRep.GetPassives();
		}

		private void btnHepsi_Click(object sender, EventArgs e)
		{
            dataGridView1.DataSource = _guestRep.GetAll();
		}
	}
}
