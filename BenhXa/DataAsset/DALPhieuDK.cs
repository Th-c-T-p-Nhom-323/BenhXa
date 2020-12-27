using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenhXa.DAO;

namespace BenhXa.DataAsset
{
    class DALPhieuDK:Connection
    {
        public bool Them( PHIEUDANGKY pdk)
        {
            try
            {
                string query = @"INSERT INTO PHIEUDANGKY
                    (
                      NgayDK ,
                      MaBN
                    )
            VALUES  ( '" + pdk.NgayDK.ToString() + "' ,'" + pdk.MaBN + "')";
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
