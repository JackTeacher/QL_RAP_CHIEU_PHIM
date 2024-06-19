using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CinemaManagement
{
    public class LopDungChung
    {
        public string cnStr;
        public SqlConnection cn;
        public int check;
        public string path = Application.ExecutablePath + ".config";
        public void TaoKetNoi()
        {
            cnStr = "Server = " + ConfigurationManager.AppSettings["Server"] + ";Database = " + ConfigurationManager.AppSettings["Database"] + "; Integrated Security = true;";
            cn = new SqlConnection(cnStr);
        }
        public void Connect()
        {
            try
            {
                if (cn != null && cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                    check = 1;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Kết nối thất bại!!! Please type your server or database name correctly");
            }
            MessageBox.Show("Kết nối thành công!! This application will be restart to save anything you config");
        }
        public void Disconnect()
        {
            try
            {
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                    MessageBox.Show("Disconnected");
                }
                else check = 0;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void CheckConfig()
        {
            if (System.IO.File.Exists(path) == false)
            {
                MessageBox.Show("Đây là lần đầu tiên bạn chạy ứng dụng ?");
                frConfig c = new frConfig();
                c.Show() ;
            }
            else
            {
                try
                {
                    string test = "Server = " + ConfigurationManager.AppSettings["Server"] + "; Database = " + ConfigurationManager.AppSettings["Database"] + ";Integrated Security = true;";
                    SqlConnection checkConnect = new SqlConnection(test);
                    checkConnect.Open();
                    frLogin l = new frLogin();
                    l.Show();
                }
                catch
                {
                    MessageBox.Show("Your Configuration information doesn't correct, please check your info now");
                    frConfig c = new frConfig();
                    c.Show();
                }
            }
        }
        public void TinhTien()
        {
            TruyenData.ThanhTien = TruyenData.TongGhe * (TruyenData.GiaVe - TruyenData.MucGiamGia);
        }
    }
}
