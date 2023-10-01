using BikeLah_Setel.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace BikeLah_Setel
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            Shelter shelter1 = new Shelter("GKU");
            Shelter shelter2 = new Shelter("TULT");
            Shelter shelter3 = new Shelter("MSU");
            Shelter shelter4 = new Shelter("OPLIB");


            Kendaraan kendaraan = new Kendaraan();
            kendaraan.JenisKendaraan = "Sepeda";
            kendaraan.NomorSeri = "A101";
            Kendaraan kendaraan2 = new Kendaraan();
            kendaraan2.JenisKendaraan = "Sepeda";
            kendaraan2.NomorSeri = "A102";
            Kendaraan kendaraan3 = new Kendaraan();
            kendaraan3.JenisKendaraan = "Sepeda";
            kendaraan3.NomorSeri = "A103";
            Kendaraan kendaraan4 = new Kendaraan();
            kendaraan4.JenisKendaraan = "Sepeda";
            kendaraan4.NomorSeri = "A104";
            Kendaraan kendaraan5 = new Kendaraan();
            kendaraan5.JenisKendaraan = "Sepeda";
            kendaraan5.NomorSeri = "A105";

            Kendaraan kendaraan6 = new Kendaraan();
            kendaraan6.JenisKendaraan = "Sekuter";
            kendaraan6.NomorSeri = "B101";
            Kendaraan kendaraan7 = new Kendaraan();
            kendaraan7.JenisKendaraan = "Sekuter";
            kendaraan7.NomorSeri = "B102";
            Kendaraan kendaraan8 = new Kendaraan();
            kendaraan8.JenisKendaraan = "Sekuter";
            kendaraan8.NomorSeri = "B103";
            Kendaraan kendaraan9 = new Kendaraan();
            kendaraan9.JenisKendaraan = "Sekuter";
            kendaraan9.NomorSeri = "B104";
            Kendaraan kendaraan10 = new Kendaraan();
            kendaraan10.JenisKendaraan = "Sekuter";
            kendaraan10.NomorSeri = "B105";

            Kendaraan kendaraan11 = new Kendaraan();
            kendaraan.JenisKendaraan = "Sepeda";
            kendaraan.NomorSeri = "A106";
            Kendaraan kendaraan12 = new Kendaraan();
            kendaraan2.JenisKendaraan = "Sepeda";
            kendaraan2.NomorSeri = "A107";
            Kendaraan kendaraan13 = new Kendaraan();
            kendaraan3.JenisKendaraan = "Sepeda";
            kendaraan3.NomorSeri = "A108";
            Kendaraan kendaraan14 = new Kendaraan();
            kendaraan4.JenisKendaraan = "Sepeda";
            kendaraan4.NomorSeri = "A109";
            Kendaraan kendaraan15 = new Kendaraan();
            kendaraan5.JenisKendaraan = "Sepeda";
            kendaraan5.NomorSeri = "A110";

            Kendaraan kendaraan16 = new Kendaraan();
            kendaraan16.JenisKendaraan = "Sekuter";
            kendaraan16.NomorSeri = "B106";
            Kendaraan kendaraan17 = new Kendaraan();
            kendaraan17.JenisKendaraan = "Sekuter";
            kendaraan17.NomorSeri = "B107";
            Kendaraan kendaraan18 = new Kendaraan();
            kendaraan18.JenisKendaraan = "Sekuter";
            kendaraan18.NomorSeri = "B108";

            shelter1.KendaraanTersedia.Add(kendaraan);
            shelter1.KendaraanTersedia.Add(kendaraan2);
            shelter2.KendaraanTersedia.Add(kendaraan3);
            shelter2.KendaraanTersedia.Add(kendaraan4);
            shelter3.KendaraanTersedia.Add(kendaraan5);
            shelter3.KendaraanTersedia.Add(kendaraan6);
            shelter4.KendaraanTersedia.Add(kendaraan7);
            shelter4.KendaraanTersedia.Add(kendaraan8);
            shelter1.KendaraanTersedia.Add(kendaraan9);
            shelter1.KendaraanTersedia.Add(kendaraan10);
            shelter3.KendaraanTersedia.Add(kendaraan11);
            shelter4.KendaraanTersedia.Add(kendaraan12);
            shelter4.KendaraanTersedia.Add(kendaraan13);
            shelter1.KendaraanTersedia.Add(kendaraan14);
            shelter2.KendaraanTersedia.Add(kendaraan15);
            shelter3.KendaraanTersedia.Add(kendaraan16);
            shelter2.KendaraanTersedia.Add(kendaraan17);
            shelter2.KendaraanTersedia.Add(kendaraan18);

            DataGlobal.dataShelter.Add(shelter1);
            DataGlobal.dataShelter.Add(shelter2);
            DataGlobal.dataShelter.Add(shelter3);
            DataGlobal.dataShelter.Add(shelter4);

            String dataShelter = JsonConvert.SerializeObject(DataGlobal.dataShelter, Formatting.Indented);
            File.WriteAllText("dataShelter.json", dataShelter);

            string dataUserString = File.ReadAllText("userLogin.json");
            DataGlobal.dataUser = JsonConvert.DeserializeObject<List<User>>(dataUserString);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DataGlobal.dataUser.Count; i++)
            {
                if (textBoxUsername.Text.Equals(DataGlobal.dataUser[i].username))
                {
                    if (textBoxPassword.Text.Equals(DataGlobal.dataUser[i].password))
                    {
                        MessageBox.Show("Login Berhasil");
                        UserSession.userSession = DataGlobal.dataUser[i];
                        PageHome pageHome = new PageHome();
                        
                        this.Hide();
                        pageHome.Show();
                    }
                    else
                    {
                        MessageBox.Show("Password Anda salah");
                    }
                    return;
                }
            }
        }


        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
