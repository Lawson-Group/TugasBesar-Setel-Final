using BikeLah_Setel.Models;
using System;
using System.Windows.Forms;

namespace BikeLah_Setel
{
    public partial class PageInfoShelter : Form
    {
        int gkuSepeda = 0;
        int gkuSekuter = 0;
        int tultSepeda = 0;
        int tultSekuter = 0;
        int msuSepeda = 0;
        int msuSekuter = 0;
        int oplibSepeda = 0;
        int oplibSekuter = 0;
        public PageInfoShelter()
        {
            InitializeComponent();
            foreach (Shelter s in DataGlobal.dataShelter)
            {
                if (s.LokasiShelter == "GKU")
                {
                    foreach (Kendaraan k in s.KendaraanTersedia)
                    {
                        if (k.JenisKendaraan == "Sepeda")
                        {
                            gkuSepeda++;

                        }
                        if (k.JenisKendaraan == "Sekuter")
                        {
                            gkuSekuter++;
                        }
                    }

                }
                if (s.LokasiShelter == "TULT")
                {
                    foreach (Kendaraan k in s.KendaraanTersedia)
                    {
                        if (k.JenisKendaraan == "Sepeda")
                        {
                            tultSepeda++;

                        }
                        if (k.JenisKendaraan == "Sekuter")
                        {
                            tultSekuter++;
                        }
                    }

                }
                if (s.LokasiShelter == "MSU")
                {
                    foreach (Kendaraan k in s.KendaraanTersedia)
                    {
                        if (k.JenisKendaraan == "Sepeda")
                        {
                            msuSepeda++;

                        }
                        if (k.JenisKendaraan == "Sekuter")
                        {
                            msuSekuter++;
                        }
                    }

                }
                if (s.LokasiShelter == "OPLIB")
                {
                    foreach (Kendaraan k in s.KendaraanTersedia)
                    {
                        if (k.JenisKendaraan == "Sepeda")
                        {
                            oplibSepeda++;

                        }
                        if (k.JenisKendaraan == "Sekuter")
                        {
                            oplibSekuter++;
                        }
                    }

                }
            }
            label19.Text = gkuSepeda.ToString() + " Unit";
            label10.Text = gkuSekuter.ToString() + " Unit";
            label8.Text = msuSepeda.ToString() + " Unit";
            label7.Text = msuSekuter.ToString() + " Unit";
            label17.Text = tultSepeda.ToString() + " Unit";
            label15.Text = tultSekuter.ToString() + " Unit";
            label12.Text = oplibSepeda.ToString() + " Unit";
            label9.Text = oplibSekuter.ToString() + " Unit";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PagePinjam pinjam = new PagePinjam();
            pinjam.Show();
            Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PagePinjam pinjam = new PagePinjam();
            pinjam.Show();
            Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PageHome home = new PageHome();
            home.Show();
            Visible = false;
        }

        private void PageInfoShelter_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PagePinjam pinjam = new PagePinjam();
            pinjam.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PagePanduan guide = new PagePanduan();
            guide.Show();
            Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PageHistory history = new PageHistory();
            history.Show();
            Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Akun acc = new Akun();
            acc.Show();
            Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PagePinjam pinjam = new PagePinjam();
            pinjam.Show();
            Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            PagePinjam pinjam = new PagePinjam();
            pinjam.Show();
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
