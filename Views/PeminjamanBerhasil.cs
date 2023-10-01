using BikeLah_Setel.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace BikeLah_Setel
{
    public partial class PeminjamanBerhasil : Form
    {
        public PeminjamanBerhasil()
        {
            InitializeComponent();
            namaUser.Text = UserSession.userSession.peminjaman.NamaPeminjam;
            sepeda.Text = UserSession.userSession.peminjaman.kendaraan.JenisKendaraan;
            label1.Text = UserSession.userSession.peminjaman.kendaraan.NomorSeri;
            label4.Text = UserSession.userSession.peminjaman.shelterAwal;
            label5.Text = UserSession.userSession.peminjaman.shelterAkhir;
            label7.Text = UserSession.userSession.peminjaman.batasWaktuPengembalian.ToString();

        }

        private void nomorSeri_Click(object sender, EventArgs e)
        {

        }

        private void PeminjamanBerhasil_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (User user in DataGlobal.dataUser)
            {
                if (user.username == UserSession.userSession.username)
                {
                    if (user.historyPeminjaman == null)
                    {
                        foreach (Shelter shelter in DataGlobal.dataShelter)
                        {
                            if (shelter.LokasiShelter == UserSession.userSession.peminjaman.shelterAkhir)
                            {
                                if (shelter.KendaraanTersedia == null)
                                {
                                    shelter.KendaraanTersedia = new List<Kendaraan>();
                                    shelter.KendaraanTersedia.Add(UserSession.userSession.peminjaman.kendaraan);
                                    break;
                                }
                                else
                                {
                                    shelter.KendaraanTersedia.Add(UserSession.userSession.peminjaman.kendaraan);
                                    break;
                                }
                            }
                        }

                        user.historyPeminjaman = new List<Peminjaman>();
                        user.historyPeminjaman.Add(UserSession.userSession.peminjaman);
                        user.peminjaman = null;

                        UserSession.userSession.historyPeminjaman.Add(UserSession.userSession.peminjaman);
                        UserSession.userSession.peminjaman = null;
                    }
                    else
                    {
                        foreach (Shelter shelter in DataGlobal.dataShelter)
                        {
                            if (shelter.LokasiShelter == UserSession.userSession.peminjaman.shelterAkhir)
                            {
                                if (shelter.KendaraanTersedia == null)
                                {
                                    shelter.KendaraanTersedia = new List<Kendaraan>();
                                    shelter.KendaraanTersedia.Add(UserSession.userSession.peminjaman.kendaraan);
                                    break;
                                }
                                else
                                {
                                    shelter.KendaraanTersedia.Add(UserSession.userSession.peminjaman.kendaraan);
                                    break;
                                }
                            }
                        }

                        user.historyPeminjaman.Add(UserSession.userSession.peminjaman);
                        user.peminjaman = null;

                        UserSession.userSession.historyPeminjaman.Add(UserSession.userSession.peminjaman);
                        UserSession.userSession.peminjaman = null;
                    }

                    break;
                }
            }

            String dataUserJson = JsonConvert.SerializeObject(DataGlobal.dataUser, Formatting.Indented);
            File.WriteAllText("dataUser.json", dataUserJson);
            String dataShelterJson = JsonConvert.SerializeObject(DataGlobal.dataShelter, Formatting.Indented);
            File.WriteAllText("dataShelter.json", dataShelterJson);

            this.Hide();
        }

        private void namaUser_Click(object sender, EventArgs e)
        {

        }

        private void sepeda_Click(object sender, EventArgs e)
        {

        }
    }
}
