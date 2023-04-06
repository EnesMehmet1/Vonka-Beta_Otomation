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

namespace Trple1._1.AraSayfalar.Crud_Category
{
    public partial class ListCategoryFrm : Form
    {
        public ListCategoryFrm()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            AddCategoryFrm acf = new AddCategoryFrm();
            acf.ShowDialog();
        }

        private void ListCategoryFrm_Load(object sender, EventArgs e)
        {
            dataGridUpdate();
        }

        public void dataGridUpdate()
        {
            CategoryManager bm = new CategoryManager(new EfCategoryDal());
            var value = bm.GetList();
            foreach (var item in value)
            {
                dataGridView1.Rows.Add(item.categoryID, item.categoryName);
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows.Count < 2)
            {
                CategoryManager cm = new CategoryManager(new EfCategoryDal());
                var getValue = cm.GetById(Convert.ToInt64(dataGridView1.SelectedRows[0].Cells[0].Value));
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                cm.CategoryDelete(getValue);
                MessageBox.Show("Silme işlemi Gerçekleştirildi");
                //burada başka tabloya transfer veya aktif pasiflik durumu eklenebilir
            }
            else if (dataGridView1.SelectedRows.Count >= 2)
            {
                MessageBox.Show("Lüffen Tek bir ürün seçiniz");
            }
            else
            {
                MessageBox.Show("Lüffen silinecek Ürünü seçin.");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows.Count < 2)
            {
                var CategoryId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                UpdateCategoryFrm ucf = new UpdateCategoryFrm(CategoryId);
                ucf.ShowDialog();
                dataGridView1.Rows.Clear();
                dataGridUpdate();
            }
            else
                MessageBox.Show("Lütfen bir kişi/kurum seçiniz!");
        }
    }
}
