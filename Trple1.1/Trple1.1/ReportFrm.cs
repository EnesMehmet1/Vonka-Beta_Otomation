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

namespace Trple1._1
{
    public partial class ReportFrm : Form
    {
        public ReportFrm()
        {
            InitializeComponent();
        }
        TypeSalesManager tsm = new TypeSalesManager(new EfTypeSalesDal());
        Context c = new Context();
        private void ReportFrm_Load(object sender, EventArgs e)
        {
            CategoryManager cm = new CategoryManager(new EfCategoryDal());
            var cmlist = cm.GetList();
            Dictionary<string, string> comboSourceCategory = new Dictionary<string, string>();
            comboSourceCategory.Add("Kategori", null);
            foreach (var item in cmlist)
            {
                comboSourceCategory.Add(item.categoryName, item.categoryID.ToString());
            }
            comboBox1.DataSource = new BindingSource(comboSourceCategory, null);
            comboBox1.DisplayMember = "Key";
            comboBox1.ValueMember = "Value";





            CategoryDetailManager cdm = new CategoryDetailManager(new EfCategoryDetailDal());
            var cdmList = cdm.GetList();
            Dictionary<string, string> comboSourceCategoryDetail = new Dictionary<string, string>();
            comboSourceCategoryDetail.Add("Alt Kategori", null);
            foreach (var item in cdmList)
            {
                comboSourceCategoryDetail.Add(item.CategoryDetailName, item.CategoryDetailID.ToString());
            }
            comboBox2.DataSource = new BindingSource(comboSourceCategoryDetail, null);
            comboBox2.DisplayMember = "Key";
            comboBox2.ValueMember = "Value";



            BrandManager bm = new BrandManager(new EfBrandDal());
            var bmList = bm.GetList();
            Dictionary<string, string> comboSourceBrandl = new Dictionary<string, string>();
            comboSourceBrandl.Add("Marka", null);
            foreach (var item in bmList)
            {
                comboSourceBrandl.Add(item.brandName, item.brandID.ToString());
            }
            comboBox3.DataSource = new BindingSource(comboSourceBrandl, null);
            comboBox3.DisplayMember = "Key";
            comboBox3.ValueMember = "Value";


            var tsmList = tsm.GetList();
            Dictionary<string, string> comboSourceTypeSales = new Dictionary<string, string>();
            comboSourceTypeSales.Add("Kullanıcı", null);
            foreach (var item in tsmList)
            {
                comboSourceTypeSales.Add(item.TypeSalesName, item.typeSalesId.ToString());
            }
            comboBox6.DataSource = new BindingSource(comboSourceTypeSales, null);
            comboBox6.DisplayMember = "Key";
            comboBox6.ValueMember = "Value";
        }







        private void simpleButton3_Click(object sender, EventArgs e)
        {
            List<productSales> psl = new List<productSales>();
            if (radioButton1.Checked)
            {
                var y = DateTime.Parse(dateTimePicker1.Value.ToString());                           
                psl = c.ProductSales.Where(x => x.salesDate.Day == y.Day).
                    Where(x => x.salesDate.Month == y.Month).
                    Where(x => x.salesDate.Year == y.Year).ToList();
            }
            if (radioButton2.Checked)
            {
                var y = DateTime.Parse(dateTimePicker1.Value.ToLongDateString()); //eğer tostring derse saati almıyor ve y'nin saat verisi anlık saat verisi oluyor
                var z = DateTime.Parse(dateTimePicker2.Value.ToLongDateString()); //eğer tostring derse saati almıyor ve z'nin saat verisi anlık saat verisi oluyor
                psl = c.ProductSales.Where(x => x.salesDate >= y && x.salesDate <= z).ToList();
            }
            if (comboBox1.SelectedIndex != 0)
            {
                int categoryId = Convert.ToInt32(((KeyValuePair<string, string>)comboBox1.SelectedItem).Value);
                psl = psl.Where(x => x.Product.categoryID == categoryId).ToList();
            }
            if (comboBox2.SelectedIndex != 0)
            {
                int categoryDetailId = Convert.ToInt32(((KeyValuePair<string, string>)comboBox2.SelectedItem).Value);
                psl = psl.Where(x => x.Product.CategoryDetailID == categoryDetailId).ToList();
            }
            if (comboBox3.SelectedIndex != 0)
            {
                int BrandId = Convert.ToInt32(((KeyValuePair<string, string>)comboBox3.SelectedItem).Value);
                psl = psl.Where(x => x.Product.brandID == BrandId).ToList();
            }
            if (comboBox6.SelectedIndex != 0)
            {
                int TypeSalesId = Convert.ToInt32(((KeyValuePair<string, string>)comboBox6.SelectedItem).Value);
                psl = psl.Where(x => x.typeSalesId == TypeSalesId).ToList();
            }
            if (maskedTextBox1.Text != "Ürün adı/Fiş No")
            {
                if (maskedTextBox1.Text != "")
                {

                    long y = Convert.ToInt64(maskedTextBox1.Text);
                    psl = c.ProductSales.Where(x => x.receiptNo == y).ToList();
                    addTableRows(psl);

                }
            }
            addTableRows(psl);

        }







        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var yestardayDate = DateTime.Parse(DateTime.Now.AddDays(-1).ToShortDateString());
            var value = c.ProductSales.Where(x => x.salesDate.Day == yestardayDate.Day).
                Where(x => x.salesDate.Month == yestardayDate.Month).
                Where(x => x.salesDate.Year == yestardayDate.Year).ToList(); //error var
            addTableRows(value);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var Mounth = DateTime.Parse(DateTime.Now.ToShortDateString());
            var value = c.ProductSales.Where(x => x.salesDate.Month == Mounth.Month).ToList(); //error var
            addTableRows(value);
        }

        public void addTableRows(List<productSales> value)
        {
            double amount = 0, stock = 0, prushPrice = 0, price = 0;
            dataGridView1.Rows.Clear();
            foreach (var item in value)
            {
                dataGridView1.Rows.Add(item.receiptNo, item.Product.Barcod, item.Product.productName, item.productAmount, item.salesDate, item.prushPrice, item.price,
                    item.productAmount * item.price, (item.price - item.prushPrice) * item.productAmount);
                amount += item.productAmount;
                stock += item.Product.stockNumber;
                prushPrice += item.prushPrice * item.productAmount;
                price += item.price * item.productAmount;
            }
            label12.Text = amount.ToString();
            label13.Text = stock.ToString();
            label14.Text = price.ToString();
            label15.Text = prushPrice.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Visible = false;
        }
    }
}
