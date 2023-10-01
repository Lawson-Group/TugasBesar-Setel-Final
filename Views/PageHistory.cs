using BikeLah_Setel.Models;
using System;
using System.Windows.Forms;

namespace BikeLah_Setel
{
    public partial class PageHistory : Form
    {
        public PageHistory()
        {
            InitializeComponent();
           
            if (UserSession.userSession.historyPeminjaman != null)
            {
                label1.Text = UserSession.userSession.historyPeminjaman[0].WaktuPeminjaman.ToString("dddd, d MMMM yyyy");
                label2.Text = "Unit #" + UserSession.userSession.historyPeminjaman[0].kendaraan.NomorSeri;
                label3.Text = UserSession.userSession.historyPeminjaman[0].WaktuPeminjaman.ToString("HH:mm:ss");
                label4.Text = UserSession.userSession.historyPeminjaman[0].shelterAwal;
                label6.Text = UserSession.userSession.historyPeminjaman[0].shelterAkhir;

                panel7.Hide();
                panel8.Hide();
                panel9.Hide();
                panel10.Hide();
                panel12.Hide();
                panel14.Hide();

            } else
            {
                panel3.Hide();
                panel6.Hide();
                
            } 
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PageHome home = new PageHome();
            home.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PagePanduan guide = new PagePanduan();
            guide.Show();
            Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Akun acc = new Akun();
            acc.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PagePinjam pinjam = new PagePinjam();
            pinjam.Show();
            Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PageInfoShelter info = new PageInfoShelter();
            info.Show();
            Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Visible = false;
        }
    }
}
