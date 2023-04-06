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
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using DataAccessLayer.Concrete;
using Trple1._1.AraSayfalar;
using Trple1._1.Reports;

namespace Trple1._1
{
    public partial class Form2 : Form
    {
        public Form2()
        {

            InitializeComponent();

        }
        List<Product> receiptlist = new List<Product>();
        ProductManager pm = new ProductManager(new EfProductDal());
        List<Product> p = new List<Product>();
        List<double> amountlist = new List<double>();
        Context c = new Context();

        private void button2_Click(object sender, EventArgs e)
        {
            //var value = product(Convert.ToInt32(maskedTextBox1.Text));
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.SelectedRows[0].Cells[2].Value = Convert.ToInt32(maskedTextBox2.Text);
                dataGridView1.SelectedRows[0].Cells[6].Value = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value) * Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[3].Value);
            }
            else
            {
                MessageBox.Show("Lüffen eklenecek satırı seçiniz");
            }
            totalPrice();
        }
        public void totalPrice()
        {
            int toplam = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)//burada bir değişiklik yapıldı
            {
                toplam += Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value);
                label1.Text = toplam.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            maskedTextBox2.Text = "1";
            //iptal();                        datagridview sıfırlanacak
            dataGridView1.Rows.Clear();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count <= 0)
            {
                MessageBox.Show("Lütfen ürün ekleyiniz");
            }
            else if (radiCari.Checked == true)
            {
                sellCariFrm scf = new sellCariFrm();    //buradan devam
                scf.even += new sellCariFrm.delegat(carimet);
                scf.ShowDialog();
                if (cariid != 0)
                {
                    satisyap();
                }
            }
            else
                satisyap();
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            label10.Text = (Convert.ToInt32(maskedTextBox2.Text) - Convert.ToUInt32(label1.Text)).ToString();
        }
        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {
            var value = product(Convert.ToInt64(maskedTextBox1.Text));
            var price = Convert.ToInt32(maskedTextBox2.Text) * value.productPrice;
            //label1.Text = price.ToString();
            if (dataGridView1.Rows.Count == 0)
                dataGridView1.Rows.Add(value.Barcod, value.productName, maskedTextBox2.Text, value.productPrice, value.KDV, value.stockNumber, price);
            else
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    var barcod = Convert.ToInt64(dataGridView1.Rows[i].Cells[0].Value);
                    if (value.Barcod == barcod)
                    {
                        dataGridView1.Rows[i].Cells[2].Value = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value) + 1;
                        dataGridView1.Rows[i].Cells[6].Value = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value) * Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                    }
                    else
                    {
                        dataGridView1.Rows.Add(value.Barcod, value.productName, maskedTextBox2.Text, value.productPrice, value.KDV, value.stockNumber, price);
                    }
                    dataGridView1.Rows[i].Cells[6].Value = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value) * Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                    totalPrice();
                }
            }

        }


        private void button8_Click(object sender, EventArgs e)
        {
            var values = Convert.ToInt32(maskedTextBox3.Text) - Convert.ToInt32(label1.Text);
            label18.Text = values.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //iptal();                                  datagridview sıfırlanacak
            dataGridView1.Rows.Clear();
            MessageBox.Show("İşlem İptal Edildi");
        }




        public Product product(long barcod)
        {
            var value = pm.GetById(barcod);
            var price = Convert.ToInt32(maskedTextBox2.Text) * value.productPrice;
            label1.Text = price.ToString();
            return value;
        }

        public double price(Product value)
        {
            var price = Convert.ToInt32(maskedTextBox2.Text) * value.productPrice;
            label1.Text = price.ToString();
            return price;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Lüffen silinecek satırı seçin.");
            }
        }

        public void satisyap()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var products = product(Convert.ToInt64(dataGridView1.Rows[i].Cells[0].Value));
                var amounts = Convert.ToInt64(dataGridView1.Rows[i].Cells[2].Value);
                p.Add(products);
                amountlist.Add(amounts);
            }
            ProductSalesManager psm = new ProductSalesManager(new EfProductSalesDal());
            productSales ps = new productSales();

            if (radioNakit.Checked)                  //ödeme tipi alındı sırada fiş no var !!!
                ps.typeSalesId = 1;
            else if (radiocredicart.Checked)
                ps.typeSalesId = 2;
            else if (radiCari.Checked)
                ps.typeSalesId = 3;                   //buraya ek bir kısım eklenecek caride işlemler için cari kısmında
            else
                ps.typeSalesId = 1;

            var value = c.ProductSales.Max(x => x.receiptNo);  //buraya ek bir sorgu yazılabilir!!!!!!d
            ps.receiptNo = value + 1;

            if (n == 1) //cari kişisine tutar giriliyor
            {
                ps.cariId = cariid;
                CariManager cm = new CariManager(new EfCariDal());
                var valueCari = cm.GetById(cariid);
                valueCari.balance -= Convert.ToDouble(label1.Text);
                cm.CariUpdate(valueCari);
            }

            for (int i = 0; i < p.Count; i++)
            {
                ps.Productid = (long)p[i].Productid;
                ps.salesDate = DateTime.Parse(DateTime.Now.ToLongTimeString());
                ps.productAmount = Convert.ToInt32(amountlist[i]);
                ps.price = p[i].productPrice;
                ps.prushPrice = p[i].productpurchasePrice;
                if (n == 1)
                    ps.cariId = cariid;

                psm.productSalesAdd(ps);
            }
            receiptReport receipt = new receiptReport(receiptlist);
            receiptFrm rf = new receiptFrm(receipt, receiptlist);
            rf.ShowDialog();
            MessageBox.Show("Satış Yapıldı");
            p.Clear();
            deleteStock();
            dataGridView1.Rows.Clear();
        }

        public void deleteStock()
        {
            //Devam Ediliyor

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var value = pm.GetById(Convert.ToInt64(dataGridView1.Rows[i].Cells[0].Value));
                receiptlist.Add(value);
                value.stockNumber = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value) - Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                pm.ProductUpdate(value);
            }
        }


        long cariid = 0; int n = 0;
        void carimet(Cari Cari)
        {
            n = 1;
            cariid = Cari.cariId;
        }


        //barcod icin
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;

        CameraManager cm = new CameraManager();


        //qr icin
        private void Form2_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            for (int i = 0; i < filterInfoCollection.Count; i++)
            {
                comboBox1.Items.Add(filterInfoCollection[i].Name);
            }

        }
        //form kapanırken kamera acıksa kapanıyor
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice != null)
            {
                if (captureDevice.IsRunning)
                {
                    captureDevice.Stop();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[comboBox1.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox1.Image);
                if (result != null)
                {
                    maskedTextBox1.Text = result.ToString();
                    var value = product(Convert.ToInt64(maskedTextBox1.Text));
                    var price = Convert.ToInt32(maskedTextBox2.Text) * value.productPrice;
                    //label1.Text = price.ToString();
                    dataGridView1.Rows.Add(value.Barcod, value.productName, maskedTextBox2.Text, value.productPrice, "%18", value.stockNumber, price);
                    //timer1.Stop();
                    //if (captureDevice.IsRunning)
                    //{
                    //    captureDevice.Stop();
                    //}
                }
            }
        }
    }
}
