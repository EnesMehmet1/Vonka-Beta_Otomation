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

namespace Trple1._1.AraSayfalar.Crud_Brand
{
    public partial class UpdateBrandFrm : Form
    {
        int BrandId;
        BrandManager bm = new BrandManager(new EfBrandDal());
        public UpdateBrandFrm(int BrandId)
        {
            InitializeComponent();
            this.BrandId = BrandId;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try {
                var value = bm.GetById(BrandId);
                value.brandName = maskedTextBox1.Text;
                value.categoryID = Convert.ToInt32(((KeyValuePair<string, string>)comboBox1.SelectedItem).Value);
                bm.BrandUpdate(value);
                MessageBox.Show("İşlem Başarılı");
                this.Close();
            }
            catch
            {
                MessageBox.Show("İşlem gerçekleştirilemedi lütfen tekrar deneyiniz!!!");
            }
        }

        private void UpdateBrandFrm_Load(object sender, EventArgs e)
        {
            CategoryManager cm = new CategoryManager(new EfCategoryDal());

            var value = bm.GetById(BrandId);
            maskedTextBox1.Text = value.brandName.ToString();


            var cmList = cm.GetList();
            Dictionary<string, string> comboSourceCategoryl = new Dictionary<string, string>();
            int indexBrand = 0, indexBrandFix = 0;
            foreach (var item in cmList)
            {
                comboSourceCategoryl.Add(item.categoryName, item.categoryID.ToString());
                if (value.categoryID == item.categoryID)
                {
                    indexBrandFix = indexBrand;
                }
                else
                    indexBrand++;
            }
            comboBox1.DataSource = new BindingSource(comboSourceCategoryl, null);
            comboBox1.SelectedIndex = indexBrandFix;
            comboBox1.DisplayMember = "Key";
            comboBox1.ValueMember = "Value";



        }
    }
}
