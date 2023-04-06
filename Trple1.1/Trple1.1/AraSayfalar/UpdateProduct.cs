using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Windows.Forms;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DevExpress.XtraEditors.Controls;
using EntityLayer.Concrete;

namespace Trple1._1.AraSayfalar
{
    public partial class UpdateProduct : Form
    {
        Product p;
        public UpdateProduct(Product p)
        {
            this.p = p;
            InitializeComponent();
        }
        ProductManager pm = new ProductManager(new EfProductDal());
        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Text = p.Barcod.ToString();
            maskedTextBox2.Text = p.productName.ToString();
            maskedTextBox3.Text = p.productPrice.ToString();
            maskedTextBox4.Text = p.KDV.ToString();
            maskedTextBox5.Text = p.productpurchasePrice.ToString();
            maskedTextBox1.Enabled = false;
            maskedTextBox6.Text = p.stockNumber.ToString();
            maskedTextBox7.Text = "0";


            CategoryManager cm = new CategoryManager(new EfCategoryDal());
            var cmlist=cm.GetList();
            Dictionary<string, string> comboSourceCategory = new Dictionary<string, string>();
            int indexCategory = 0, indexCategoryFix = 0;
            foreach (var item in cmlist)
            {
                comboSourceCategory.Add(item.categoryName, item.categoryID.ToString());
                if (p.categoryID == item.categoryID)
                {
                    indexCategoryFix = indexCategory;
                }
                else
                    indexCategory++;
            }
            comboBox1.DataSource = new BindingSource(comboSourceCategory, null);
            comboBox1.SelectedIndex = indexCategoryFix;
            comboBox1.DisplayMember = "Key";
            comboBox1.ValueMember = "Value";


            CategoryDetailManager cdm = new CategoryDetailManager(new EfCategoryDetailDal());
            var cdmList = cdm.GetList();
            Dictionary<string, string> comboSourceCategoryDetail = new Dictionary<string, string>();
            int indexCategoryDetail = 0, indexCategoryDetailFix=0;
            foreach (var item in cdmList)
            {
                comboSourceCategoryDetail.Add(item.CategoryDetailName, item.CategoryDetailID.ToString());
                if (p.CategoryDetailID == item.CategoryDetailID)
                {
                    indexCategoryDetailFix = indexCategoryDetail;
                }
                else
                    indexCategoryDetail++;
            }
            comboBox2.DataSource = new BindingSource(comboSourceCategoryDetail, null);
            comboBox2.SelectedIndex = indexCategoryDetailFix;
            comboBox2.DisplayMember = "Key";
            comboBox2.ValueMember = "Value";



            BrandManager bm = new BrandManager(new EfBrandDal());
            var bmList = bm.GetList();
            Dictionary<string, string> comboSourceBrandl = new Dictionary<string, string>();
            int indexBrand = 0, indexBrandFix=0;
            foreach (var item in bmList)
            {
                comboSourceBrandl.Add(item.brandName, item.brandID.ToString());
                if (p.brandID == item.brandID)
                {
                    indexBrandFix = indexBrand;
                }
                else
                    indexBrand++;
            }
            comboBox3.DataSource = new BindingSource(comboSourceBrandl, null);
            comboBox3.SelectedIndex = indexBrandFix;
            comboBox3.DisplayMember = "Key";
            comboBox3.ValueMember = "Value";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var value = pm.GetById(p.Barcod);
            int stock = Convert.ToInt32(maskedTextBox6.Text) + Convert.ToInt32(maskedTextBox7.Text);
            value.stockNumber = stock;
            value.productName = maskedTextBox2.Text;
            value.productPrice = Convert.ToDouble(maskedTextBox3.Text);
            value.categoryID = Convert.ToInt32(((KeyValuePair<string, string>)comboBox1.SelectedItem).Value);
            value.CategoryDetailID = Convert.ToInt32(((KeyValuePair<string, string>)comboBox2.SelectedItem).Value);
            value.brandID = Convert.ToInt32(((KeyValuePair<string, string>)comboBox3.SelectedItem).Value);
            value.KDV = Convert.ToInt32(maskedTextBox4.Text);
            value.productpurchasePrice = Convert.ToInt32(maskedTextBox5.Text);  //burası double olacak
            pm.ProductUpdate(value);
            MessageBox.Show("İşlem Başarılı!");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
