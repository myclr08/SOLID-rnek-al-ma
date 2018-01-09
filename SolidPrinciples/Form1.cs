using SolidPrinciples.DIP.BadPractice;
using SolidPrinciples.DIP.BestPractice;
using SolidPrinciples.ISP.BadPractice;
using SolidPrinciples.OCP.BestPractice;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolidPrinciples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //sadece e-posta atar
            SolidPrinciples.DIP.BestPractice.MusteriServis mm = new DIP.BestPractice.MusteriServis();
            mm.MusteriKayıt();


            //enjecte edilen servise göre mesaj atar
            MusteriServisCopy s3 = new MusteriServisCopy(new EmailServisCopy());
            s3.MusteriKayıt();

            


            HashCryptoServis s = new HashCryptoServis();
            string dep =  s.Encrypte("8454545");

            string a = s.Decrypte(dep);

            SatınAlmaUIManager manager = new SatınAlmaUIManager(new QrCodeServis());
            manager.satinAl();
        }
    }
}
