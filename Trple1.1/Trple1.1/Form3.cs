using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Trple1._1.AraSayfalar;
using ZXing;

namespace Trple1._1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        ProductManager pm = new ProductManager(new EfProductDal());
        List<Product> p = new List<Product>();
        private void BTN_URUNEKLE_Click(object sender, EventArgs e)
        {
            AddProduct ap = new AddProduct(523342);
            ap.ShowDialog();
           // AddProduct ap = new AddProduct();
           // ap.ShowDialog();
        }

        private void BTN_URUNDUZENLE_Click(object sender, EventArgs e)
        {
        }

        //ürün Bulma
        public Product product(long barcod)
        {
            var value = pm.GetById(barcod);
            if (value != null)
                label_Barcod.Text = value.Barcod.ToString();
            return value;
        }






        //barcod icin
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;

        CameraManager cm = new CameraManager();

        private void Form3_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            for (int i = 0; i < filterInfoCollection.Count; i++)
            {
                comboBox1.Items.Add(filterInfoCollection[i].Name);
            }
            comboBox1.SelectedIndex = 0;
        }
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice != null)
            {
            if (captureDevice.IsRunning)
            {
                captureDevice.Stop();
            }
            }
        }

        public void productfilter(List<Product> p)
        {
            foreach (var value in p)
            {
                dataGridView1.Rows.Add(value.Barcod, value.productName, value.productPrice, value.productpurchasePrice, value.stockNumber, value.KDV, "birim", value.Category.categoryName, value.CategoryDetail.CategoryDetailName, value.Brand.brandName);
            }
        }
        private void button2_Click(object sender, EventArgs e)  //ürün eklemek için
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[comboBox1.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start(); //bimer1 bulunacak ürünü listeye atıyor
        }
        private void button3_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[comboBox1.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer2.Start();
        }
        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            productindex(timer1);  //ürün buluyor listeliyor
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            productindex(timer2);  //ürün ekleme ve güncelleme işlemi sayfalarını açıyor
        }
        public void productindex(Timer timer)
        {
            if (pictureBox1.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox1.Image);
                if (result != null)
                {
                    //maskedTextBox1.Text = result.ToString();
                    var value = product(Convert.ToInt64(result.ToString()));
                    if (value != null)
                    {
                        if (timer == timer1)
                        {
                            var price = value.productPrice;
                            //label1.Text = price.ToString();
                            dataGridView1.Rows.Add(value.Barcod, value.productName, value.productPrice, value.productpurchasePrice, value.stockNumber, value.KDV, "birim", value.Category.categoryName, value.CategoryDetail.CategoryDetailName, value.Brand.brandName);
                            //timer1.Stop();
                            //if (captureDevice.IsRunning)
                            //{
                            //    captureDevice.Stop();
                            //}
                            //timer1.Stop();
                            //captureDevice.Stop();
                        }
                        else
                        {
                            //form açılacak ve veri transfer edilecek
                            UpdateProduct up = new UpdateProduct(value);
                            up.ShowDialog();
                            //timer2.Stop();
                           // captureDevice.Stop();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bu barkod numarasına göre ürün bulunamadı ürün eklemeyi tercih edebilirsiniz");
                        //form açılacak ve veri transfer edilecek
                        AddProduct ap = new AddProduct(Convert.ToInt64(result.ToString()));
                        ap.ShowDialog();
                    }
                    
                }
            }
        }

        private void BTN_URUNSIL_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows.Count<2)
            {

                var getValue = pm.GetById(Convert.ToInt64(dataGridView1.SelectedRows[0].Cells[0].Value));
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                pm.ProductDelete(getValue);
                MessageBox.Show("Silme işlemi Gerçekleştirildi");
                //burada başka tabloya transfer veya aktif pasiflik durumu eklenebilir
            }
            else if(dataGridView1.SelectedRows.Count>=2)
            {
                MessageBox.Show("Lüffen Tek bir ürün seçiniz");
            }
            else
            {
                MessageBox.Show("Lüffen silinecek Ürünü seçin.");
            }
        }







        void productFilterList(List<Product> productList)
        {
            //liste geldi
            foreach (var value in productList)
            {
                dataGridView1.Rows.Add(value.Barcod, value.productName, value.productPrice, value.productpurchasePrice, value.stockNumber, value.KDV, "birim", value.Category.categoryName,
                    value.CategoryDetail.CategoryDetailName, value.Brand.brandName);
            }
            label12.Text = productList.Count.ToString();
        }

        //buton ile etkileşime girildi
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            FilterProduct filterPage = new FilterProduct();
            filterPage.even += new FilterProduct.delegat(productFilterList);
            filterPage.ShowDialog();
        }
    }


}




//qr icin


