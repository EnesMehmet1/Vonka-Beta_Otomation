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
    public partial class FilterProduct : Form
    {
        public FilterProduct()
        {
            InitializeComponent();
        }
        ProductManager pm = new ProductManager(new EfProductDal());
        Context c = new Context();
        private void FilterProduct_Load(object sender, EventArgs e)
        {
            CategoryManager cm = new CategoryManager(new EfCategoryDal());
            var cmlist = cm.GetList();
            Dictionary<string, string> comboSourceCategory = new Dictionary<string, string>();
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
            foreach (var item in bmList)
            {
                comboSourceBrandl.Add(item.brandName, item.brandID.ToString());
            }
            comboBox3.DataSource = new BindingSource(comboSourceBrandl, null);
            comboBox3.DisplayMember = "Key";
            comboBox3.ValueMember = "Value";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            List<Product> lnqName = null;


            //var memberinfo = c.Products.
            //    Where(x => x.productName == name).
            //    Where(x => x.stockNumber >= minStock && checkBox7.Checked == true).
            //    Where(x => x.stockNumber <= maxStock && checkBox7.Checked == true).
            //    Where(x => x.productPrice >= minPrice).
            //    Where(x => x.productPrice <= maxPrice).
            //    Where(x => x.productpurchasePrice >= minPruchPrice).
            //    Where(x => x.productpurchasePrice <= maxPruchPrice).
            //    Where(x => x.categoryID == categoryId).
            //    Where(x => x.CategoryDetailID == categoryDetailId).
            //    Where(x => x.brandID == brandId).
            //    Select(y => y).ToList();
            if (checkBox1.Checked == true)
            {
                long barcod = Convert.ToInt64(maskedTextBox1.Text);
                lnqName = c.Products.Where(x => x.Barcod == barcod).Select(y => y).ToList();
            }
            if (checkBox2.Checked == true)
            {
                string name = maskedTextBox2.Text;
                if (lnqName != null)
                    lnqName = lnqName.Where(x => x.productName == name).Select(y => y).ToList();
                else
                    lnqName = c.Products.Where(x => x.productName == name).Select(y => y).ToList();
            }
            if (checkBox7.Checked == true)
            {
                int minStock = Convert.ToInt32(maskedTextBox3.Text);
                int maxStock = Convert.ToInt32(maskedTextBox4.Text);
                if (lnqName != null)
                    lnqName = lnqName.Where(x => x.stockNumber >= minStock && x.stockNumber <= maxStock).Select(y => y).ToList();
                else
                    lnqName = c.Products.Where(x => x.stockNumber >= minStock && x.stockNumber <= maxStock).Select(y => y).ToList();
            }
            if (checkBox8.Checked == true)
            {
                double minPrice = Convert.ToDouble(maskedTextBox6.Text);
                double maxPrice = Convert.ToDouble(maskedTextBox5.Text);
                if (lnqName != null)
                    lnqName = lnqName.Where(x => x.productPrice >= minPrice && x.productPrice <= maxPrice).Select(y => y).ToList();
                else
                    lnqName = c.Products.Where(x => x.productPrice >= minPrice && x.productPrice <= maxPrice).Select(y => y).ToList();
            }
            if (checkBox9.Checked == true)
            {
                int minPruchPrice = Convert.ToInt32(maskedTextBox8.Text);
                int maxPruchPrice = Convert.ToInt32(maskedTextBox7.Text);
                if (lnqName != null)
                    lnqName = lnqName.Where(x => x.productpurchasePrice >= minPruchPrice && x.productpurchasePrice <= maxPruchPrice).Select(y => y).ToList();
                else
                    lnqName = c.Products.Where(x => x.productpurchasePrice >= minPruchPrice && x.productpurchasePrice <= maxPruchPrice).Select(y => y).ToList();
            }
            if (checkBox3.Checked == true)
            {
                int categoryId = Convert.ToInt32(((KeyValuePair<string, string>)comboBox1.SelectedItem).Value);
                if (lnqName != null)
                    lnqName = lnqName.Where(x => x.categoryID == categoryId).Select(y => y).ToList();
                else
                    lnqName = c.Products.Where(x => x.categoryID == categoryId).Select(y => y).ToList();

            }
            if (checkBox6.Checked == true)
            {
                int categoryDetailId = Convert.ToInt32(((KeyValuePair<string, string>)comboBox2.SelectedItem).Value);
                if (lnqName != null)
                    lnqName = lnqName.Where(x => x.CategoryDetailID == categoryDetailId).Select(y => y).ToList();
                else
                    lnqName = c.Products.Where(x => x.CategoryDetailID == categoryDetailId).Select(y => y).ToList();
            }
            if (checkBox4.Checked == true)
            {
                int brandId = Convert.ToInt32(((KeyValuePair<string, string>)comboBox3.SelectedItem).Value);
                if (lnqName != null)
                    lnqName = lnqName.Where(x => x.brandID == brandId).Select(y => y).ToList();
                else
                    lnqName = c.Products.Where(x => x.brandID == brandId).Select(y => y).ToList();
            }




            if (lnqName == null || lnqName.Count==0)
            {
                MessageBox.Show("Aranan kriterlerde ürün nulunamadı");
            }
            else
            {
                this.even(lnqName);//form3 yani stok ekranına veri gönderildi
                this.Close();
            }
            lnqName = null;
        }


        public delegate void delegat(List<Product> Product);

        public event delegat even;



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
