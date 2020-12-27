using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenhXa.DAO;

namespace BenhXa.DataAsset
{
    public class DALBenhNhan:Connection
    {
        public DataTable GetDataTimKiem(string chuoi)
        {
            try
            {
                string query = @"select MaBN, TenBN, NgaySinh, CapBac, ChucVu, DonVi, GioiTinh from BENHNHAN  where TenBN like N'%"+chuoi+"%'";
                return (DataTable)ShowDataInGridView(query);
            }
            catch (Exception ex)
            {
                SetEx(ex);
                return null;
            }
        }
        public DataTable GetDataDSK(int mabn, DateTime time)
        {

            try
            {
                string query = @"select pdk.MaDK , bn.TenBN, bn.DonVi, pdk.NgayDK from PHIEUDANGKY pdk, BENHNHAN bn where bn.MaBN= pdk.MaBN and bn.MaBN ="+mabn.ToString()+" and pdk.NgayDK='"+time.ToString()+"'";
                return (DataTable)ShowDataInGridView(query);
            }
            catch (Exception ex)
            {
                SetEx(ex);
                return null;
            }
        }
        public bool Them(BENHNHAN bn)
        {
            try
            {
                string query = @"INSERT INTO BENHNHAN
                    (
                      TenBN ,
                      NgaySinh,
                      CapBac,
                      ChucVu,
                      DonVi,
                      GioiTinh
                    )
            VALUES  ( N'" + bn.TenBN + "' ,'" + bn.NgaySinh.ToString()+"',N'"+bn.CapBac+ "',N'"+bn.ChucVu+"',N'"+bn.DonVi+"',N'"+bn.GioiTinh+ "')";
                MoKetNoi();
                ExecuteQueries(query);
                DongKetNoi();
                return true;
            }
            catch (Exception ex)
            {
                SetEx(ex);
                return false;
            }
        }
    }
}
