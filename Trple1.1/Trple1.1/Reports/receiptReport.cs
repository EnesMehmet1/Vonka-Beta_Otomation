using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraReports.UI;
using EntityLayer.Concrete;

namespace Trple1._1.Reports
{
    public partial class receiptReport : DevExpress.XtraReports.UI.XtraReport
    {
        public receiptReport(List<Product> productlist)
        {
            //ObjectDataSource source = new ObjectDataSource();
            //source.DataSource = productlist;
            //xrTableUrunAdi.DataBindings.Add("Text",source.DataSource,"Product.productName");
            InitializeComponent();
        }

    }
}
