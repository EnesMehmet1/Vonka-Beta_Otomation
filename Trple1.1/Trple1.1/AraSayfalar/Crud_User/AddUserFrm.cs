using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trple1._1.AraSayfalar.Crud_User
{
    public partial class AddUserFrm : Form
    {
        public AddUserFrm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MailMessage mesaj = new MailMessage();
            mesaj.From = new MailAddress("yildirimenes401@gmail.com");
            mesaj.To.Add(maskedTextBox3.Text);
            mesaj.Subject = "Yeni Kullanıcı Kaydı";
            Random random = new Random();
            int rand = random.Next(1000, 10000);
            mesaj.Body = rand.ToString();


            SmtpClient a = new SmtpClient();
            a.Credentials = new System.Net.NetworkCredential("yildirimenes401@gmail.com", "MEHMETBEY12.");
            a.Port = 587;
            a.Host = "yildirimenes401@gmail.com";
            a.EnableSsl = true;
            object userState = mesaj;

            try
            {
                a.SendAsync(mesaj, (object)mesaj);
                MessageBox.Show("Mail Gönderilmiştir");
            }

            catch (SmtpException ex)
            {

                MessageBox.Show(ex.Message, "Mail Gönderme Hatasi");
            }

        }

        private void AddUserFrm_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> comboSourceBrandl = new Dictionary<string, string>();
            comboSourceBrandl.Add("Müdür", "Manager");
            comboSourceBrandl.Add("Personel", "Person");
            comboSourceBrandl.Add("Geçici Kullanıcı", "User");

            comboBox1.DataSource = new BindingSource(comboSourceBrandl, null);
            comboBox1.DisplayMember = "Key";
            comboBox1.ValueMember = "Value";
        }
    }
}
