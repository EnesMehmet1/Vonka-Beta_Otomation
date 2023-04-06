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

namespace Trple1._1.AraSayfalar.Crud_Brand
{
    public partial class AddBrandFrm : Form
    {
        public AddBrandFrm()
        {
            InitializeComponent();

        }

        private void AddBrandFrm_Load(object sender, EventArgs e)
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
            var values=c.Brands.Where(x => x.brandName == maskedTextBox1.Text).FirstOrDefault();
            if (values != null)
            {
                MessageBox.Show("Bu isme sahip başka bir Marka girişi yapılamaz!!!");
            }
            else
            {
            try
            {
                BrandManager bm = new BrandManager(new EfBrandDal());  //çok tuhaf bir hata ile karşılaştık
                Brand value = new Brand();                             //branmanagerden nesne oluşturma işlemi globalde tanımlıyken program runtıme'da iken bir kez cach bloğuna girince hata olmamasına ragmen hep cach'a giriyor.
                int categoryId = Convert.ToInt32(((KeyValuePair<string, string>)comboBox1.SelectedItem).Value);
                value.categoryID = categoryId;
                value.brandName = maskedTextBox1.Text;
                bm.BrandAdd(value);
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
            ListBrandFrm lbf = new ListBrandFrm();
            lbf.ShowDialog();
        }
    }
}
