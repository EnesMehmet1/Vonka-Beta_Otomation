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

namespace Trple1._1.AraSayfalar.Crud_Brand
{
    public partial class ListBrandFrm : Form
    {
        public ListBrandFrm()
        {
            InitializeComponent();
        }
        private void ListBrandFrm_Load(object sender, EventArgs e)
        {
            dataGridUpdate();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            AddBrandFrm abf = new AddBrandFrm();
            abf.ShowDialog();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows.Count < 2)
            {
                BrandManager bm = new BrandManager(new EfBrandDal());
                var getValue = bm.GetById(Convert.ToInt64(dataGridView1.SelectedRows[0].Cells[0].Value));
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                bm.BrandDelete(getValue);
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
                var brandId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                UpdateBrandFrm ubf = new UpdateBrandFrm(brandId);
                ubf.ShowDialog();
                dataGridView1.Rows.Clear();
                dataGridUpdate();
            }
            else
                MessageBox.Show("Lütfen bir marka seçiniz!");
        }

        public void dataGridUpdate()
        {
            BrandManager bm = new BrandManager(new EfBrandDal());
            var value = bm.GetList();
            foreach (var item in value)
            {
                dataGridView1.Rows.Add(item.brandID, item.brandName, item.Category.categoryName);
            }
        }
    }
}
//Marka eklemenin 42.satırında ve burada farkettiğim birşey oldu.
//manager sınıflarından nesneyı globalade oluşturup daha sonra bellı methodlarda kullnadıgımda 
//eskı halı gıbı bır udurm oluyor
//burada markayı güncelleme yaparken global manager kullanırsak, güncellengıdı halini cagırdıgımızda
//eksı halı gozukuyor, Üzerine biraz daha durulabılır bir detay