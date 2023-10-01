using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace BikeLah_Setel
{
    public partial class PageHome : Form
    {
        public PageHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            PageInfoShelter infoShelter = new PageInfoShelter();
            infoShelter.Show();
            Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PagePinjam pinjam = new PagePinjam();
            pinjam.Show();
            Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

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

        private void button7_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            PagePanduan guide = new PagePanduan();
            guide.Show();
            Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
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

        private void button11_Click(object sender, EventArgs e)
        {
            Akun acc = new Akun();
            acc.Show();
            Visible = false;
        }

        private void PageHome_Load(object sender, EventArgs e)
        {

        }

        private void buttonPinjam_Click(object sender, EventArgs e)
        {
            PagePinjam pinjam = new PagePinjam();
            pinjam.Show();
            Visible = false;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            PageInfoShelter infoShelter = new PageInfoShelter();
            infoShelter.Show();
            Visible = false;
        }
    }
}
