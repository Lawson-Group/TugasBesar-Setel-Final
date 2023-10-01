using BikeLah_Setel.Models;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace BikeLah_Setel
{
    public partial class PagePinjam : Form
    {
        public PagePinjam()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Peminjaman minjam = new Peminjaman();
            foreach (Shelter shelter in DataGlobal.dataShelter)
            {
                if (shelter.LokasiShelter == comboBox2.SelectedItem.ToString())
                {
                    foreach (Kendaraan kendaraan in shelter.KendaraanTersedia)
                    {
                        if (kendaraan.JenisKendaraan == comboBox1.SelectedItem.ToString() && kendaraan.NomorSeri == textBox3.Text)
                        {
                            minjam.kendaraan = kendaraan;
                            minjam.WaktuPeminjaman = DateTime.Now;
                            minjam.NamaPeminjam = UserSession.userSession.dataUser.dataCivitas.namaLengkap;
                            minjam.shelterAwal = comboBox2.SelectedItem.ToString();
                            minjam.shelterAkhir = comboBox3.SelectedItem.ToString();
                            minjam.batasWaktuPengembalian = DateTime.Now.AddMinutes(30);
                            UserSession.userSession.peminjaman = minjam;
                            shelter.KendaraanTersedia.Remove(kendaraan);
                            foreach (User user in DataGlobal.dataUser)
                            {
                                if (user.username == UserSession.userSession.username)
                                {
                                    user.peminjaman = UserSession.userSession.peminjaman;
                                    break;

                                }
                            }
                            String dataUser = JsonConvert.SerializeObject(DataGlobal.dataUser, Formatting.Indented);
                            File.WriteAllText("dataUser.json", dataUser);

                            String dataKendaraan = JsonConvert.SerializeObject(DataGlobal.dataShelter, Formatting.Indented);
                            File.WriteAllText("dataShelter.json", dataKendaraan);
                            PeminjamanBerhasil success = new PeminjamanBerhasil();
                            success.ShowDialog();
                            break;
                        }

                    }

                }
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            PageHome home = new PageHome();
            home.Show();
            Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PageInfoShelter info = new PageInfoShelter();
            info.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PagePanduan pagePanduan = new PagePanduan();
            pagePanduan.Show();
            Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PageHistory pageHistory = new PageHistory();
            pageHistory.Show();
            Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Visible = false;
        }

        private void PagePinjam_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
