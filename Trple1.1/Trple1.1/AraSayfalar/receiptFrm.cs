using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using EntityLayer.Concrete;

namespace Trple1._1.AraSayfalar
{
    public partial class receiptFrm : Form
    {
        public receiptFrm(XtraReport report,List<Product> receiptlist)
        {
            InitializeComponent();
            documentViewer1.DocumentSource = report;
        }
    }
}
