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
    public partial class AddCariFrm : Form
    {
        public AddCariFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = maskedTextBox3.Text;
            string managerPerson=maskedTextBox6.Text;
            long phone1 = Convert.ToInt64(maskedTextBox7.Text),phone2 = Convert.ToInt64(maskedTextBox8.Text);
            string tur = comboBox6.SelectedItem.ToString();
            string adress=maskedTextBox9.Text;
            string province = maskedTextBox5.Text,district=maskedTextBox4.Text;
            int taxCircle = Convert.ToInt32(maskedTextBox10.Text), vkn = Convert.ToInt32(maskedTextBox2.Text);
            string email = maskedTextBox11.Text;
            int cariLimit = Convert.ToInt32(maskedTextBox1.Text);
            int cariIndex = comboBox6.SelectedIndex;
            bool cariState = true;
            if (cariIndex == 1)
                cariState = false;
            CariManager cm = new CariManager(new EfCariDal(), name, managerPerson, phone1,
                phone2, tur, adress, province, district, taxCircle, vkn, email, cariLimit,
                cariState);
            MessageBox.Show("İşlem Başarılı");
            this.Close();
        }

        private void AddCariFrm_Load(object sender, EventArgs e)
        {
            comboBox6.Items.Add("KURUM");
            comboBox6.Items.Add("BİREYSEL");
            comboBox5.Items.Add("AKTİF");
            comboBox5.Items.Add("PASİF");
            comboBox5.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
        }
    }
}
