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
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace Trple1._1.AraSayfalar
{
    public partial class sellCariFrm : Form
    {
        public sellCariFrm()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            AddCariFrm acf = new AddCariFrm();
            acf.ShowDialog();
            Context c = new Context();
            dataGridView1.Rows.Clear();
            var value = c.Caris.Where(x => x.cariState == true).ToList();
            list(value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sellCariFrm_Load(object sender, EventArgs e)
        {
            Context c = new Context();
            dataGridView1.Rows.Clear();
            var value = c.Caris.Where(x=>x.cariState==true).ToList();
            list(value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Context c = new Context();
            var cariId=Convert.ToInt64(dataGridView1.SelectedRows[0].Cells[0].Value); //delegate kullnarak arkadaki forma gönderiyorum
            var cari = c.Caris.Where(x => x.cariId == cariId).FirstOrDefault();
            this.even(cari);
            this.Close();
        }
        public void list(List<Cari> value)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in value)
            {
                dataGridView1.Rows.Add(item.cariId, item.title, item.phoneNumber);
            }
        }
        public delegate void delegat(Cari Cari);
        public event delegat even;

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows.Count < 2)
            {
                CariManager cm = new CariManager(new EfCariDal());
                var value = cm.GetById(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                value.balance = 0;
                cm.CariUpdate(value);
                MessageBox.Show("Kişi/Kurum'un alacak/vereceği sıfırlanmıştır!");

            }
            else if (dataGridView1.SelectedRows.Count >= 2)
                MessageBox.Show("Lutfen tek bir kişi/kurum seçiniz!");
            else
                MessageBox.Show("Lutfen kişi/kurum seçiniz!");
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Context c = new Context();
            List<Cari> cari = new List<Cari>();
            cari = c.Caris.ToList();
            if (maskedTextBox1.Text != "Ünvan")
            {
                if (maskedTextBox1.Text != "")
                {
                    cari = cari.Where(x => x.title == maskedTextBox1.Text).ToList();

                }
            }
            if (maskedTextBox2.Text != "Telefon")
            {
                if (maskedTextBox2.Text != "")
                {
                    cari = cari.Where(x => x.phoneNumber == Convert.ToInt64(maskedTextBox2.Text) || x.phoneNumber2 == Convert.ToInt64(maskedTextBox2.Text)).ToList();
                }
            }
            list(cari);
        }
    }
}
