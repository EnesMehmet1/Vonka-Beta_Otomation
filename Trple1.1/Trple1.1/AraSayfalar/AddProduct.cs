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
using EntityLayer.Concrete;

namespace Trple1._1.AraSayfalar
{
    public partial class AddProduct : Form
    {
        long barcod;
        public AddProduct(long barcod)
        {
            this.barcod = barcod;
            InitializeComponent();
        }


        private void AddProduct_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Text = barcod.ToString();
            CategoryManager cm = new CategoryManager(new EfCategoryDal());
            var cmlist = cm.GetList();
            Dictionary<string, string> comboSourceCategory = new Dictionary<string, string>();
            foreach (var item in cmlist)
            {
                comboSourceCategory.Add(item.categoryName, item.categoryID.ToString());
            }
            comboBox1.DataSource = new BindingSource(comboSourceCategory, null);
            comboBox1.SelectedIndex = 0;
            comboBox1.DisplayMember = "Key";
            comboBox1.ValueMember = "Value";


            CategoryDetailManager cdm = new CategoryDetailManager(new EfCategoryDetailDal());
            var cdmList = cdm.GetList();
            Dictionary<string, string> comboSourceCategoryDetail = new Dictionary<string, string>();
            foreach (var item in cdmList)
            {
                comboSourceCategoryDetail.Add(item.CategoryDetailName, item.CategoryDetailID.ToString());
            }
            comboBox2.DataSource = new BindingSource(comboSourceCategoryDetail, null);
            comboBox2.SelectedIndex = 0;
            comboBox2.DisplayMember = "Key";
            comboBox2.ValueMember = "Value";



            BrandManager bm = new BrandManager(new EfBrandDal());
            var bmList = bm.GetList();
            Dictionary<string, string> comboSourceBrandl = new Dictionary<string, string>();
            foreach (var item in bmList)
            {
                comboSourceBrandl.Add(item.brandName, item.brandID.ToString());
            }
            comboBox3.DataSource = new BindingSource(comboSourceBrandl, null);
            comboBox3.SelectedIndex = 0;
            comboBox3.DisplayMember = "Key";
            comboBox3.ValueMember = "Value";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ProductManager pm = new ProductManager(new EfProductDal());
            Product value = new Product();
            value.Barcod = Convert.ToInt64(maskedTextBox1.Text);
            int stock = Convert.ToInt32(maskedTextBox6.Text) + Convert.ToInt32(maskedTextBox7.Text);
            value.stockNumber = stock;
            value.productName = maskedTextBox2.Text;
            value.productPrice = Convert.ToDouble(maskedTextBox3.Text);
            value.categoryID = Convert.ToInt32(((KeyValuePair<string, string>)comboBox1.SelectedItem).Value);
            value.CategoryDetailID = Convert.ToInt32(((KeyValuePair<string, string>)comboBox2.SelectedItem).Value);
            value.brandID = Convert.ToInt32(((KeyValuePair<string, string>)comboBox3.SelectedItem).Value);
            value.KDV = Convert.ToInt32(maskedTextBox4.Text);
            value.productpurchasePrice = Convert.ToInt32(maskedTextBox5.Text);  //burası double olacak
            value.productWeight = 12;//Demo
            pm.ProductAdd(value);
            MessageBox.Show("Ürüm Ekleme İşlemi Başarılı!");
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}