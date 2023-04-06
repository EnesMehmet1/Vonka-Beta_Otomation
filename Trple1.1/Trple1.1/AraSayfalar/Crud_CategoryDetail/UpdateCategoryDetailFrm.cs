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

namespace Trple1._1.AraSayfalar.Crud_CategoryDetail
{
    public partial class UpdateCategoryDetailFrm : Form
    {
        int CategoryDetailId;
       
        public UpdateCategoryDetailFrm(int CategoryDetailId)
        {
            InitializeComponent();
            this.CategoryDetailId = CategoryDetailId;
        }

        private void UpdateCategoryDetailFrm_Load(object sender, EventArgs e)
        {
            CategoryDetailManager cdm = new CategoryDetailManager(new EfCategoryDetailDal());

            var value = cdm.GetById(CategoryDetailId);
            maskedTextBox1.Text = value.CategoryDetailName.ToString();

            CategoryManager cm = new CategoryManager(new EfCategoryDal());
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

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            CategoryDetailManager cdm = new CategoryDetailManager(new EfCategoryDetailDal());
            try
            {
                var value = cdm.GetById(CategoryDetailId);
                value.CategoryDetailName = maskedTextBox1.Text;
                value.categoryID = Convert.ToInt32(((KeyValuePair<string, string>)comboBox1.SelectedItem).Value);
                cdm.CategoryDetailUpdate(value);
                MessageBox.Show("İşlem Başarılı");
                this.Close();
            }
            catch
            {
                MessageBox.Show("İşlem gerçekleştirilemedi lütfen tekrar deneyiniz!!!");
            }
        }
    }
}
