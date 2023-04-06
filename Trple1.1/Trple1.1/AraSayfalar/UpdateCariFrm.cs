using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DevExpress.XtraBars;

namespace Trple1._1.AraSayfalar
{
    public partial class UpdateCariFrm : Form
    {
        int cariID;
        public UpdateCariFrm(int cariId)
        {
            cariID = cariId;
            InitializeComponent();
        }

        private void UpdateCariFrm_Load(object sender, EventArgs e)
        {
            comboBox6.Items.Add("KURUM");     //ÖNEMLİ           //BURADA BİR EKSİK VAR O DA GETİRİLEN CARİ TÜRÜ VE DURUMU YERİNE 0 İNDEXİ VERİLİYOR!!!
            comboBox6.Items.Add("BİREYSEL");
            comboBox5.Items.Add("TRUE");
            comboBox5.Items.Add("FALSE");
            comboBox5.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;

            CariManager cm = new CariManager(new EfCariDal());
            var value = cm.GetById(cariID);

            maskedTextBox3.Text=value.title;
            maskedTextBox6.Text = value.managerPerson;
            maskedTextBox7.Text = value.phoneNumber.ToString();maskedTextBox8.Text = value.phoneNumber2.ToString();
            maskedTextBox9.Text = value.adress;
            maskedTextBox5.Text=value.province; maskedTextBox4.Text=value.district;
            maskedTextBox10.Text = value.taxcircle.ToString(); maskedTextBox2.Text=value.VKN.ToString();
            maskedTextBox11.Text = value.email;
            maskedTextBox1.Text = value.carilimit.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CariManager cm = new CariManager(new EfCariDal());
            var value = cm.GetById(cariID);


            string name = maskedTextBox3.Text;
            string managerPerson = maskedTextBox6.Text;
            long phone1 = Convert.ToInt64(maskedTextBox7.Text), phone2 = Convert.ToInt64(maskedTextBox8.Text);
            string tur = comboBox6.SelectedItem.ToString();
            string adress = maskedTextBox9.Text;
            string province = maskedTextBox5.Text, district = maskedTextBox4.Text;
            int taxCircle = Convert.ToInt32(maskedTextBox10.Text), vkn = Convert.ToInt32(maskedTextBox2.Text);
            string email = maskedTextBox11.Text;
            int cariLimit = Convert.ToInt32(maskedTextBox1.Text);
            int cariIndex = comboBox6.SelectedIndex;
            bool cariState = true;
            if (cariIndex == 1)
                cariState = false;
            CariManager cm2 = new CariManager(new EfCariDal(), name, managerPerson, phone1,
                phone2, tur, adress, province, district, taxCircle, vkn, email, cariLimit,
                cariState, value);
            MessageBox.Show("İşlem Başarılı");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
