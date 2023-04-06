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

namespace Trple1._1.AraSayfalar.Crud_CategoryDetail
{
    public partial class AddCategoryDetailFrm : Form
    {
        public AddCategoryDetailFrm()
        {
            InitializeComponent();
        }

        private void AddCategoryDetailFrm_Load(object sender, EventArgs e)
        {
            CategoryManager cm = new CategoryManager(new EfCategoryDal());
            var cmlist = cm.GetList();
            Dictionary<string, string> comboSourceCategory = new Dictionary<string, string>();
            comboSourceCategory.Add("Kategori", null);
            foreach (var item in cmlist)
            {
                comboSourceCategory.Add(item.categoryName, item.categoryID.ToString());
            }
            comboBox1.DataSource = new BindingSource(comboSourceCategory, null);
            comboBox1.DisplayMember = "Key";
            comboBox1.ValueMember = "Value";
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Context c = new Context();
            var values = c.CategoryDetail.Where(x => x.CategoryDetailName == maskedTextBox1.Text).FirstOrDefault();
            if (values != null)
            {
                MessageBox.Show("Bu kategori detayına sahip başka bir Marka girişi yapılamaz!!!");
            }
            else
            {
                try
                {
                    CategoryDetailManager bm = new CategoryDetailManager(new EfCategoryDetailDal());  //çok tuhaf bir hata ile karşılaştık
                    CategoryDetail value = new CategoryDetail();                             //branmanagerden nesne oluşturma işlemi globalde tanımlıyken program runtıme'da iken bir kez cach bloğuna girince hata olmamasına ragmen hep cach'a giriyor.
                    int categoryDetailId = Convert.ToInt32(((KeyValuePair<string, string>)comboBox1.SelectedItem).Value);
                    value.categoryID = categoryDetailId;
                    value.CategoryDetailName = maskedTextBox1.Text;
                    bm.CategoryDetailkAdd(value);
                    MessageBox.Show("İşlem Başarılı!!!");
                }
                catch
                {//bir kez hata verince devamı da hatalı şekilde çalışıyor
                    MessageBox.Show("Lütfen Marka Seçiniz!!!");
                }

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ListCategoryDetailFrm lcd = new ListCategoryDetailFrm();
            lcd.ShowDialog();
        }
    }
}
