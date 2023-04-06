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

namespace Trple1._1.AraSayfalar.Crud_Category
{
    public partial class UpdateCategoryFrm : Form
    {
        long CategoryId;
        public UpdateCategoryFrm(int id)
        {
            InitializeComponent();
            CategoryId = id;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            CategoryManager cm = new CategoryManager(new EfCategoryDal());
            Context c = new Context();
            var value=c.Categories.Where(x => x.categoryName == maskedTextBox1.Text);
            if (value == null)
            {
                try
                {
                    var values = cm.GetById(CategoryId);
                    values.categoryName=maskedTextBox1.Text;
                    cm.CategoryUpdate(values);
                    MessageBox.Show("Güncelleme işlemi başarılı!!!");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Güncelleme işlemi Başarısız!!!");
                }
            }
        }

        private void UpdateCategoryFrm_Load(object sender, EventArgs e)
        {
            CategoryManager cm = new CategoryManager(new EfCategoryDal());
            var value = cm.GetById(CategoryId);
            maskedTextBox1.Text = value.categoryName.ToString();
        }
    }
}
