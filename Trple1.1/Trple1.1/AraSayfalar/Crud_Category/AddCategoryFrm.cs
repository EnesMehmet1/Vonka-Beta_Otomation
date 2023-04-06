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

namespace Trple1._1.AraSayfalar.Crud_Category
{
    public partial class AddCategoryFrm : Form
    {
        public AddCategoryFrm()
        {
            InitializeComponent();
        }

        private void AddCategoryFrm_Load(object sender, EventArgs e)
        {
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "Kategori" || maskedTextBox1.Text!="")
            {
            try
            {
                CategoryManager cm = new CategoryManager(new EfCategoryDal());
                Category c = new Category();
                c.categoryName = maskedTextBox1.Text;
                cm.CategorykAdd(c);
                MessageBox.Show("Kategori Eklendi!!!");
            }
            catch
            {
                MessageBox.Show("Kategori Ekleme İşlemi Gerçekleştirilemedi!!!");
            }

            }
            else
                MessageBox.Show("Lütfen Geçerli bir kategori ismi giriniz");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ListCategoryFrm lcf = new ListCategoryFrm();
            lcf.ShowDialog();
        }
    }
}
