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
    public partial class ListCategoryDetailFrm : Form
    {
        public ListCategoryDetailFrm()
        {
            InitializeComponent();
        }

        private void ListCategoryDetailFrm_Load(object sender, EventArgs e)
        {
            dataGridUpdate();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            AddCategoryDetailFrm acdf = new AddCategoryDetailFrm();
            acdf.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows.Count < 2)
            {
                var CategoryDetailId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                UpdateCategoryDetailFrm ucf = new UpdateCategoryDetailFrm(CategoryDetailId);
                ucf.ShowDialog();
                dataGridUpdate();
            }
            else
                MessageBox.Show("Lütfen bir alt kategori seçiniz!");
        }


        public void dataGridUpdate()
        {
            dataGridView1.Rows.Clear();
            CategoryDetailManager cm = new CategoryDetailManager(new EfCategoryDetailDal());
            var value = cm.GetList();
            foreach (var item in value)
            {
                dataGridView1.Rows.Add(item.CategoryDetailID, item.CategoryDetailName, item.Category.categoryName);
            }
        }
    }
}
