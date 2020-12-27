using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BenhXa.DataAsset;
using BenhXa.DAO;

namespace BenhXa
{
    public partial class ThemMoiBN : Form
    {
        public ThemMoiBN()
        {
            InitializeComponent();
        }
        DALBenhNhan BN = new DALBenhNhan();
        MainMenu main = new MainMenu();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            BENHNHAN bn_new = new BENHNHAN(txt_tenBN.Text, dtp_NS.Value, txt_capbac.Text, txt_chucvu.Text, txt_donvi.Text, cbb_Sex.SelectedItem.ToString());
            BN.Them(bn_new);
            main.dtv_TT_BN.DataSource = BN.GetDataTimKiem(txt_tenBN.Text);
            this.Close();
        }
    }
}
