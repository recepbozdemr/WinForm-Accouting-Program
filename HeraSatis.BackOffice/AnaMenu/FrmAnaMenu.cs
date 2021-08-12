using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using HeraSatis.BackOffice.Stok;
using HeraSatis.Entities.Context;
using HeraSatis.Entities.DataAccess;
using HeraSatis.Entities.Tables;

namespace HeraSatis.BackOffice
{
	public partial class Form1: DevExpress.XtraBars.Ribbon.RibbonForm
	{
        public Form1()
		{
          
            InitializeComponent(); //Context    Database Oluşturma
            using (var context = new HeraSatisContext())
            {
                context.Database.CreateIfNotExists();
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmStok form = new FrmStok();
            form.MdiParent = this; // iç içe form açmak için,xtratabbedmanager özelliğini kullanarak bu kodu ekledim.
            form.Show();
        }
    }
}