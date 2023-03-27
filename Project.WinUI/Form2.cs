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
    public partial class Form2 : Form
    {
        EmployeeProfileRepository _empProfileRep;
        public Form2()
        {
            InitializeComponent();
            _empProfileRep = new EmployeeProfileRepository();   

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (_empProfileRep.Any(x=>x.UserName == txtIsim.Text && x.Password ==txtSifre.Text)) 
            {
                Form1 frm1 = new Form1();

                frm1.Show();
                MessageBox.Show("Hoşgeldin admin.");
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre.");
                return;
            }
        }
    }
}
