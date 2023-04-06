using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer.Concrete;
using Trple1._1.AraSayfalar.Crud_Brand;
using Trple1._1.AraSayfalar.Crud_Category;
using Trple1._1.AraSayfalar.Crud_CategoryDetail;
using Trple1._1.AraSayfalar.Crud_User;
using Trple1._1.Reports;

namespace Trple1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void satis_btn_Click(object sender, EventArgs e)
        {
            SalesView();
        }
        public string userRoll;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = userRoll;
            if (userRoll == "Person")
            {

            }
            //Context cs = new Context();
            //cs.Database.Create();

        }

        private void Stok_Btn_Click(object sender, EventArgs e)
        {
            stockView();
        }

        private void bilgisayaraYedekAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesReport sr = new SalesReport();
            sr.ExportToXls("C:\\Users\\yildi\\Desktop\\BilgisayarAglari\\Report1.xls");


        }

        private void Rapor_btn_Click(object sender, EventArgs e)
        {
            reportView();
        }

        private void Cari_btn_Click(object sender, EventArgs e)
        {
            cariView();
        }

        private void satışEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesView();
        }
        private void raporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportView();
        }

        private void cariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cariView();
        }

        private void stokEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stockView();
        }

        public void SalesView()
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
        public void stockView()
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
        public void reportView()
        {
            ReportFrm rf = new ReportFrm();
            rf.ShowDialog();
        }
        public void cariView()
        {
            CariFrm cf = new CariFrm();
            cf.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void interneteYedekAlToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void markaEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBrandFrm sd = new AddBrandFrm();
            sd.ShowDialog();
        }

        private void markaSilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListBrandFrm sd = new ListBrandFrm();
            sd.ShowDialog();
        }

        private void markaDüzenlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListBrandFrm sd = new ListBrandFrm();
            sd.ShowDialog();
        }

        private void kategoriEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCategoryFrm acf = new AddCategoryFrm();
            acf.ShowDialog();
        }

        private void kategoriSilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listCategory();
        }
        private void kategoriDüzenlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listCategory();
        }
        public void listCategory()
        {
            ListCategoryFrm lcf = new ListCategoryFrm();
            lcf.ShowDialog();
        }

        private void altKategoriDüzenlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listCategoryDetail();
        }
        private void altKategoriEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCategoryDetailFrm acdf = new AddCategoryDetailFrm();
            acdf.ShowDialog();
        }

        private void altKategoriSilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listCategoryDetail();
        }
        public void listCategoryDetail()
        {
            ListCategoryDetailFrm lcdf = new ListCategoryDetailFrm();
            lcdf.ShowDialog();
        }

        private void kullanıcıEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (roll() == 0)
            {
                AddUserFrm addUserFrm = new AddUserFrm();
                addUserFrm.ShowDialog();
            }

        }

        private void kullanıcıDüzenlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (roll() == 0)
            {
                //işlemler
                UpdateUserFrm updateUserFrm = new UpdateUserFrm();
                updateUserFrm.ShowDialog();
            }
        }
        protected int roll()
        {
            if (userRoll == "Person")
            {
                MessageBox.Show("Bu menüye erişiminiz yok!");
                return 1;
            }
            else
                return 0;
        }

        private void kullanıcıSilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (roll() == 0)
            {
                UpdateUserFrm deleteUserFrm = new UpdateUserFrm();
                deleteUserFrm.ShowDialog();
            }
        }
    }
}
