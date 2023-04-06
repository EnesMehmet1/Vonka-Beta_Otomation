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
using Trple1._1.AraSayfalar;

namespace Trple1._1
{
    public partial class CariFrm : Form
    {
        public CariFrm()
        {
            InitializeComponent();
        }

        private void CariFrm_Load(object sender, EventArgs e)
        {
            Context c = new Context();
            var value = c.Caris.Where(x => x.cariState == true).ToList();
            cariList(value);
            comboBox1.Items.Add("CARİ TÜRÜ");
            comboBox1.Items.Add("KURUM");
            comboBox1.Items.Add("BİREYSEL");
            comboBox2.Items.Add("CARİ DURUMU");
            comboBox2.Items.Add("AKTİF");
            comboBox2.Items.Add("PASİF");
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            AddCariFrm acf = new AddCariFrm();
            acf.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows.Count < 2)
            {
                var CariId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                UpdateCariFrm ucf = new UpdateCariFrm(CariId);
                ucf.ShowDialog();
                Context c = new Context();
                var value = c.Caris.Where(x => x.cariState == true).ToList();
                cariList(value);
            }
            else
                MessageBox.Show("Lütfen bir kişi/kurum seçiniz!");
        }
        public void cariList(List<Cari> value)
        {
            dataGridView1.Rows.Clear();
            double cariNumber = 0, marketBuy = 0;
            foreach (var item in value)
            {
                dataGridView1.Rows.Add(item.cariId, item.title, item.accountype, item.phoneNumber, item.date, item.balance);
                cariNumber++; marketBuy += item.balance;
            }


            label12.Text = cariNumber.ToString();
            if (marketBuy < 0)
            {
                label13.Text = marketBuy.ToString();
                label14.Text = "0,00";
            }
            else
            {
                label13.Text = "0,00";
                label14.Text = marketBuy.ToString();
            }
            label15.Text = marketBuy.ToString();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Context c = new Context();
            List<Cari> cari = new List<Cari>();
            cari = c.Caris.ToList();
            if (comboBox2.SelectedIndex != 0)
            {
                if (comboBox2.SelectedIndex == 1)
                    cari = c.Caris.Where(x => x.cariState == true).ToList();
                else
                    cari = c.Caris.Where(x => x.cariState == false).ToList();
            }
            if (comboBox1.SelectedIndex != 0)
            {
                    cari = cari.Where(x => x.accountype == comboBox1.SelectedItem.ToString()).ToList();
            }
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
            cariList(cari);
        }
    }
}