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
    public partial class MainMenu : Form
    {
        DALBenhNhan bn = new DALBenhNhan();
        DALPhieuDK dk = new DALPhieuDK();
        public MainMenu()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_search_nameBN_Click(object sender, EventArgs e)
        {
            if (txt_search_nameBN.Text != "")
            {
                if (bn.GetDataTimKiem(txt_search_nameBN.Text.Trim()) != null)
                {
                    dtv_TT_BN.DataSource = bn.GetDataTimKiem(txt_search_nameBN.Text.Trim());
                    MessageBox.Show("Tìm thành công");
                }
                else
                {
                    Exception ex = bn.GetEx();
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Bạn cần nhập thông tin để tìm kiếm !");
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

        }

        private void dtv_TT_BN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtv_TT_BN.Rows[e.RowIndex];
                PHIEUDANGKY pdk = new PHIEUDANGKY (DateTime.Now, int.Parse(row.Cells["MaBN"].Value.ToString()));
                dk.Them(pdk);
                dtv_DSK.DataSource = bn.GetDataDSK(int.Parse(row.Cells["MaBN"].Value.ToString()), DateTime.Now);
            }
            catch (Exception ex)
            {
                ex = bn.GetEx();
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_Themmoi_Click(object sender, EventArgs e)
        {
            ThemMoiBN add = new ThemMoiBN();
            add.ShowDialog();
        }
    }
}
