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
using HeraSatis.Entities.Context;

namespace HeraSatis.BackOffice
{
	public partial class Form1: DevExpress.XtraBars.Ribbon.RibbonForm
	{
        public Form1()
		{
            InitializeComponent();
		}

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent(); //Context    Database Oluşturma
            using (var context = new HeraSatisContext())
            {
                context.Database.CreateIfNotExists();
            }


            
        }
    }
}