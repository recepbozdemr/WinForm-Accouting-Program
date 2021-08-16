using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using HeraSatis.Entities.Context;
using HeraSatis.Entities.DataAccess;

namespace HeraSatis.BackOffice.Stok
{
    
    
    public partial class FrmStok : DevExpress.XtraEditors.XtraForm
    {
        private HeraSatisContext context = new HeraSatisContext();
        private StokDAL stokDal = new StokDAL();
        public FrmStok()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmStokIslem form = new FrmStokIslem();
            form.Show();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            GetAll();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize, Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo)==DialogResult.Yes)

            {
                string secilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
                stokDal.Delete(context,c=>c.StokKodu==secilen);
                stokDal.Save(context);
                GetAll();

            }





        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {

        }
        private void btnFiltreKapat_Click(object sender, EventArgs e)
        {
            filterControl1.FilterString = null;  //Filtreyi boşaltıp kayıt ettik.
            filterControl1.ApplyFilter();
        }

        private void btnFiltre_Click(object sender, EventArgs e)
        {
            filterControl1.ApplyFilter(); //Filter kontrolün filtresini kabul eder
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {

        }

        private void GetAll()
        {


        gridControl1.DataSource=stokDal.GetAllJoin(context);
             



        }
        
        private void FrmStok_Load(object sender, EventArgs e)
        {

            GetAll();
         
        }

        private void filterControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}

