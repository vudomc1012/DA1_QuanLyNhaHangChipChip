using _2_BUS.BUSServices;
using _2_BUS.iBUSServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI
{
    public partial class FrmQuanLyHoaDon : Form
    {
        IQLHoaDon _qlHoaDon;
        int _idHoaDon;
        int _doangthu;
        int _huy;
        int _dathanhtoan;

        public FrmQuanLyHoaDon()
        {
            InitializeComponent();
            _qlHoaDon = new QLHoaDon();
            LoadHoaDon();
            Hien();
        }
        void Hien()
        {
            _huy = 0;
            _doangthu = 0;
            _dathanhtoan = 0;
            Lbl_TongHoaDon.Text = (Dgid_HoaDon.Rows.Count - 1).ToString();
            for (int i = 0; i < Dgid_HoaDon.Rows.Count - 1; i++)
            {
                if (Dgid_HoaDon.Rows[i].Cells[4].Value.ToString() == "Đã huỷ")
                {
                    _huy += 1;
                }
                if (Dgid_HoaDon.Rows[i].Cells[4].Value.ToString() == "đã thanh toán")
                {
                    _dathanhtoan += 1;
                }
            }
            foreach (var x in _qlHoaDon.GetBillsFromDB())
            {
                for (int i = 0; i < Dgid_HoaDon.Rows.Count - 1; i++)
                {
                    if (x.Id == Convert.ToInt32(Dgid_HoaDon.Rows[i].Cells[7].Value.ToString()) && Dgid_HoaDon.Rows[i].Cells[4].Value.ToString() == "đã thanh toán")
                    {
                        _doangthu += Convert.ToInt32(x.TotalMoney);
                    }
                }
            }//s
            Lbl_DaHuy.Text = _huy.ToString();
            Lbl_DaThanhToan.Text = _dathanhtoan.ToString();
            Lbl_DoanhThu.Text = _doangthu.ToString() +"VNĐ";
         
        }
        void LoadHoaDon()
        {

            Dgid_HoaDon.ColumnCount = 8;
            Dgid_HoaDon.Columns[0].Name = "Tên bàn";
            Dgid_HoaDon.Columns[1].Name = "tổng tiền";
            Dgid_HoaDon.Columns[2].Name = "date check in";
            Dgid_HoaDon.Columns[3].Name = "date check out";
            Dgid_HoaDon.Columns[4].Name = "tình trạng";
            Dgid_HoaDon.Columns[5].Name = "Loại hình";
            Dgid_HoaDon.Columns[6].Name = "Nhân viên tạo";
            Dgid_HoaDon.Columns[7].Name = "id";
            Dgid_HoaDon.Columns[7].Visible = false;
            

            Dgid_HoaDon.Rows.Clear();
            foreach (var x in _qlHoaDon.GetListDSHoaDon())
            {
                Dgid_HoaDon.Rows.Add(_qlHoaDon.GetListDSHoaDon().Where(c => c.hoaDon.Idtable == x.banAn.Id).Select(c => c.banAn.Name).FirstOrDefault(), decimal.Truncate(x.hoaDon.TotalMoney),
                    x.hoaDon.DateCheckIn, x.hoaDon.DateCheckOut,x.hoaDon.GhiChu != null?"Đã huỷ":Convert.ToInt32(x.hoaDon.Status) == 0 ? "đã thanh toán" : Convert.ToInt32(x.hoaDon.Status) == 1 ? "chưa thanh toán" :"" 
                   ,x.hoaDon.DichVu==1?"Tại bàn":"Mang về", _qlHoaDon.GetListDSHoaDon().Where(c => c.nhanVien.Id == x.hoaDon.IdnhanVien).Select(c => c.nhanVien.Name).FirstOrDefault(), x.hoaDon.Id);

            }
            Dgid_HoaDon.Columns[1].DefaultCellStyle.Format = "#,0.# VND";

        }
        void LoadHoaDon(DateTime date1, DateTime date2)
        {
            Dgid_HoaDon.ColumnCount = 8;
            Dgid_HoaDon.Columns[0].Name = "Tên bàn";
            Dgid_HoaDon.Columns[1].Name = "tổng tiền";
            Dgid_HoaDon.Columns[2].Name = "date check in";
            Dgid_HoaDon.Columns[3].Name = "date check out";
            Dgid_HoaDon.Columns[4].Name = "tình trạng";
            Dgid_HoaDon.Columns[5].Name = "Loại hình";
            Dgid_HoaDon.Columns[6].Name = "Nhân viên tạo";
            Dgid_HoaDon.Columns[7].Name = "id";
            Dgid_HoaDon.Columns[7].Visible = false;
            Dgid_HoaDon.Columns[1].DefaultCellStyle.Format = "#,0.# VND";
            Dgid_HoaDon.Rows.Clear();
            foreach (var x in _qlHoaDon.GetListDSHoaDon().Where(c => (c.hoaDon.DateCheckIn >= date1.AddDays(-1) && c.hoaDon.DateCheckIn <= date2)))
            {
                Dgid_HoaDon.Rows.Add(_qlHoaDon.GetListDSHoaDon().Where(c => c.hoaDon.Idtable == x.banAn.Id).Select(c => c.banAn.Name).FirstOrDefault(), decimal.Truncate(x.hoaDon.TotalMoney)+",000 VND",
                     x.hoaDon.DateCheckIn, x.hoaDon.DateCheckOut, x.hoaDon.GhiChu != null ? "Đã huỷ" : Convert.ToInt32(x.hoaDon.Status) == 0 ? "đã thanh toán" : Convert.ToInt32(x.hoaDon.Status) == 1 ? "chưa thanh toán" : ""
                    , x.hoaDon.DichVu == 1 ? "Tại bàn" : "Mang về", _qlHoaDon.GetListDSHoaDon().Where(c => c.nhanVien.Id == x.hoaDon.IdnhanVien).Select(c => c.nhanVien.Name).FirstOrDefault(), x.hoaDon.Id);
            }
            
        }
        void LoadHoaDonChiTiet(int id)
        {
            dgrid_hdct.ColumnCount = 5;
            dgrid_hdct.Columns[0].Name = "tên món";
            dgrid_hdct.Columns[1].Name = "số lượng";
            dgrid_hdct.Columns[2].Name = "đơn giá";
            dgrid_hdct.Columns[3].Name = "thành tiền";
         
            dgrid_hdct.Columns[4].Name = "id";
            dgrid_hdct.Columns[4].Visible = false;

            dgrid_hdct.Rows.Clear();
            foreach (var x in _qlHoaDon.GetListDSHoaDon().Where(c => c.hoaDon.Id == id))
            {
                dgrid_hdct.Rows.Add(_qlHoaDon.GetListDSHoaDon().Where(c => c.hoaDonChiTiet.Idfood == x.monAnChiTiet.Id).Select(c => c.monAnChiTiet.Name).FirstOrDefault(), x.hoaDonChiTiet.Count,
                   decimal.Truncate(x.monAnChiTiet.Price),decimal.Truncate(x.hoaDonChiTiet.Price), x.hoaDonChiTiet.Id);

            }
            dgrid_hdct.Columns[2].DefaultCellStyle.Format = "#,0.# VND";
            dgrid_hdct.Columns[3].DefaultCellStyle.Format = "#,0.# VND";

        }

        private void Dgid_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if ((rowIndex == _qlHoaDon.GetBillsFromDB().Count) || rowIndex == -1) return;
            _idHoaDon = Convert.ToInt32(Dgid_HoaDon.Rows[rowIndex].Cells[7].Value.ToString());
            LoadHoaDonChiTiet(_idHoaDon);
            //ádsdsasdsdff
        }
        

        private void btn_thongKe_Click_1(object sender, EventArgs e)
        {
            DateTime date1 = dateTimePicker1.Value;
            DateTime date2 = dateTimePicker2.Value;
            LoadHoaDon(date1, date2);
            Hien();            
        }

        private void btn_danhsach_Click(object sender, EventArgs e)
        {
            LoadHoaDon();
        }
    }
}
       
