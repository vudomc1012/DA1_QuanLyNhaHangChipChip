using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_BUS.BUSServices;
using _2_BUS.iBUSServices;
using _1_DAL.Models;
using _2_BUS.Models;
using _3_GUI.Properties;
using System.Drawing.Printing;
using iTextSharp.text.pdf;
using PdfSharp.Pdf;

namespace _3_GUI
{
    public partial class FrmQLBan : Form
    {
        public static string mail;

        IQLBanAnService _qlBanAn;
        IQLHoaDon _qlHoaDon;
        iQLMenuService _qlMeniu;

        IQLNhanVienService _qlNhanVien;
        int _IdBan;
        HoaDon _hoadon;
        int _soLuong;
        int _tongTien;
        int _IdHoaDon;
        int _idFood;
        int _IdHdCt;
        NhanVien _nhanVien;
        HoaDonChiTiet _hoadonCT;
        Form _f;
        FrmMain frm;
        public FrmQLBan(FrmMain frm0)
        {
            InitializeComponent();
            _qlBanAn = new QLBanAnService();
            _qlHoaDon = new QLHoaDon();
            _qlMeniu = new QLMenuService();
            _qlNhanVien = new QLNhanVienService();
            //_qlBanAn.GetTablesFromDB() = new List<BanAn>();
            LoadTableT1();
            LoadTableT2();
            LoadMeniu();
            LoadMangVe();
            Lbl_TongTien.Text = "0 VND";
            _IdBan = 0;
            _IdHoaDon = 0;
            //Lbl_GioVao.Text = DateTime.Now.ToString()            
            _nhanVien = _qlNhanVien.getlstNhanViens().FirstOrDefault(c => c.Email == mail);
            frm = frm0;
        }
        //public void NhanlstHoaDon(List<HoaDon> lstHoaDon)
        //{
        //    if (lstHoaDon == null)
        //    {
        //        _qlHoaDon.GetBillsFromDB() = _qlHoaDon.GetBillsFromDB();
        //    }
        //    else
        //    {
        //        _qlHoaDon.GetBillsFromDB() = lstHoaDon;
        //    }
        //}
        //public void NhanList(List<BanAn> lst, int flag)
        //{
        //    if (lst == null)
        //    {
        //        _qlBanAn.GetTablesFromDB() = _qlBanAn.GetTablesFromDB();
        //    }
        //    else
        //    {
        //        _qlBanAn.GetTablesFromDB() = lst;
        //    }
        //}

        void LoadMangVe()
        {
            FlPanl_MangVe.Controls.Clear();
            foreach (HoaDon x in _qlHoaDon.GetBillsFromDB().Where(c => c.DichVu == 2 && c.Status == true))
            {
                Button btn1 = new Button() { Width = 70, Height = 70 };
                btn1.Text = "Mang Về";
                btn1.ForeColor = Color.Black;
                btn1.Click += Btn1_Click1;
                btn1.Tag = x;
                btn1.BackColor = Color.Aqua;
                FlPanl_MangVe.Controls.Add(btn1);
            }

        }

        private void Btn1_Click1(object sender, EventArgs e)
        {
            int id = ((sender as Button).Tag as HoaDon).Id;
            _IdHoaDon = id;
            _IdBan = 0;
            FrmTachHoaDon._IdHoaDon = id;
            FrmTachHoaDon._IdBanTachHD = 0;
            Lbl_ViTriBan.Text = "Mang Về";
            _hoadon = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Id == _IdHoaDon);
            Lbl_TongTien.Text = decimal.Truncate(_qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Id == _IdHoaDon).TotalMoney).ToString() + " VND";
            Lbl_GioVao.Text = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Id == _IdHoaDon).DateCheckIn.ToString();
            LoadHoaDonMangVe(_IdHoaDon);

        }
        void LoadHoaDonMangVe(int hoadon)
        {
            var abc = (from a in _qlHoaDon.GetBillsFromDB().Where(c => c.Id == _IdHoaDon)
                       join c in _qlHoaDon.GetHoaDonCTFromDB().Where(c => c.Count > 0)
                       on a.Id equals c.Idbill
                       select new
                       {
                           IDHD = a.Id,
                           IdBan = a.Idtable,
                           TrangThai = a.Status,
                           DichVu = a.DichVu,
                           IDHDCT = c.Id,
                           IDFood = c.Idfood,
                           SoLuong = c.Count,

                       }).ToList();
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img.Name = "xoa";
            img.HeaderText = "Xóa món";
            Bitmap b = new Bitmap(@"C:\DuAn1\ChipChip\QuanLyNhaHangChipChip\3_GUI\Resources\001-close.png");
            img.Image = b;

            Dgid_HoaDon.ColumnCount = 5;
            Dgid_HoaDon.Columns[0].Name = "Tên món";
            Dgid_HoaDon.Columns[1].Name = "Số lượng";
            Dgid_HoaDon.Columns[2].Name = "Đơn giá";

            Dgid_HoaDon.Columns[3].Name = "thành tiền";

            Dgid_HoaDon.Columns[4].Name = "Id";
            Dgid_HoaDon.Columns[4].Visible = false;
            Dgid_HoaDon.Columns.Add(img);
            Dgid_HoaDon.Rows.Clear();
            //foreach (var x in _qlHoaDon.GetListDSHoaDon().Where(c => c.hoaDon.Idtable == bill && c.hoaDon.Status == true && c.hoaDon.DichVu == 1))
            //{
            //    Dgid_HoaDon.Rows.Add(_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == x.hoaDonChiTiet.Idfood).Select(c => c.Name).FirstOrDefault(), x.hoaDonChiTiet.Count,
            //        _qlMeniu.GetMonAnChiTiets().Where(c => c.Id == x.hoaDonChiTiet.Idfood).Select(c => c.Price).FirstOrDefault(),
            //        x.hoaDonChiTiet.Count * _qlMeniu.GetMonAnChiTiets().Where(c => c.Id == x.hoaDonChiTiet.Idfood).Select(c => c.Price).FirstOrDefault());
            //}
            foreach (var x in abc)
            {
                Dgid_HoaDon.Rows.Add(_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == x.IDFood).Select(c => c.Name).FirstOrDefault(), x.SoLuong,
                    decimal.Truncate(_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == x.IDFood).Select(c => c.Price).FirstOrDefault()),
                    decimal.Truncate(_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == x.IDFood).Select(c => c.Price).FirstOrDefault() * x.SoLuong), x.IDHDCT);
            }
            Dgid_HoaDon.Columns[3].DefaultCellStyle.Format = "#,0.# VNĐ";
            Dgid_HoaDon.Columns[2].DefaultCellStyle.Format = "#,0.# VNĐ";
        }

        public void LoadTableT1()
        {
            //FLPenal.Invalidate();
            FLPenal.Controls.Clear();
            //NhanList(_qlBanAn.GetTablesFromDB(), 0);
            //NhanlstHoaDon(_qlHoaDon.GetBillsFromDB());
            foreach (BanAn x in _qlBanAn.GetTablesFromDB().Where(c => c.Floor == 1 && (c.TinhTrang == 1 || c.TinhTrang == 0)))
            {
                Button btn = new Button() { Width = x.Rong, Height = x.Cao };
                //Bitmap b = new Bitmap(@"C:\DuAn1\ChipChip\QuanLyNhaHangChipChip\3_GUI\Resources\caiBan.png");                
                //btn.Image= b;
                btn.Text = x.Name + Environment.NewLine + (x.TinhTrang == 1 ? "Trống" : "Có người");
                btn.Click += Btn_Click;
                btn.Tag = x;
                switch (x.TinhTrang)
                {
                    case 1:
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }
                FLPenal.Controls.Add(btn);
            }
            //â
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            //NhanlstHoaDon(_qlHoaDon.GetBillsFromDB());
            int id = ((sender as Button).Tag as BanAn).Id;
            _IdBan = id;
            _IdHoaDon = 0;
            FrmChuyenBan._IdBanCu = id;
            FrmTachHoaDon._IdHoaDon = 0;
            FrmTachHoaDon._IdBanTachHD = id;
            BanAn banAn = _qlBanAn.GetTablesFromDB().FirstOrDefault(c => c.Id == id);
            LoadHoaDon(id);
            Lbl_ViTriBan.Text = "Tầng 1 - " + banAn.Name;
            if (_qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Idtable == _IdBan && c.Status == true && c.DichVu == 1) == null)
            {
                Lbl_TongTien.Text = "0";
                Lbl_GioVao.Text = "00:00:00 00/00/2021";
            }
            else
            {
                Lbl_TongTien.Text = decimal.Truncate(_qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Idtable == _IdBan && c.Status == true && c.DichVu == 1).TotalMoney).ToString() + " VNĐ";
                Lbl_GioVao.Text = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Idtable == _IdBan && c.Status == true && c.DichVu == 1).DateCheckIn.ToString();
            }

        }

        public void LoadTableT2()
        {
            FlPanel2.Controls.Clear();
            //NhanList(_qlBanAn.GetTablesFromDB(), 1);
            foreach (BanAn x in _qlBanAn.GetTablesFromDB().Where(c => c.Floor == 2 && (c.TinhTrang == 1 || c.TinhTrang == 0)))
            {
                Button btn1 = new Button() { Width = x.Rong, Height = x.Cao };
                btn1.Text = x.Name + Environment.NewLine + (x.TinhTrang == 1 ? "Trống" : "Có người");

                btn1.Click += Btn1_Click;
                btn1.Tag = x;
                switch (x.TinhTrang)
                {
                    case 1:
                        btn1.BackColor = Color.Aqua;
                        break;
                    default:
                        btn1.BackColor = Color.LightPink;
                        break;
                }
                FlPanel2.Controls.Add(btn1);
            }
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            int id = ((sender as Button).Tag as BanAn).Id;
            _IdBan = id;
            _IdHoaDon = 0;
            FrmChuyenBan._IdBanCu = id;
            FrmTachHoaDon._IdHoaDon = 0;
            FrmTachHoaDon._IdBanTachHD = id;
            LoadHoaDon(id);
            BanAn banAn = _qlBanAn.GetTablesFromDB().FirstOrDefault(c => c.Id == id);
            Lbl_ViTriBan.Text = "Tầng 2 - " + banAn.Name;
            if (_qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Idtable == _IdBan && c.Status == true && c.DichVu == 1) == null)
            {
                Lbl_TongTien.Text = "0";
                Lbl_GioVao.Text = "00:00:00 00/00/2021";
            }
            else
            {
                Lbl_TongTien.Text = decimal.Truncate(_qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Idtable == _IdBan && c.Status == true && c.DichVu == 1).TotalMoney).ToString() + " VNĐ";
                Lbl_GioVao.Text = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Idtable == _IdBan && c.Status == true && c.DichVu == 1).DateCheckIn.ToString();
            }
        }



        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn hủy", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BanAn ban = _qlBanAn.GetTablesFromDB().FirstOrDefault(c => c.Id == _qlBanAn.GetTablesFromDB().Where(c => c.Floor == 1 && (c.TinhTrang == 1 || c.TinhTrang == 0)).Select(c => c.Id).Max());
                    if (ban.TinhTrang == 0)
                    {
                        MessageBox.Show("Bàn đang có người không thể xóa", "Thông báo");
                        return;
                    }
                    ban.TinhTrang = 2;
                    _qlBanAn.UpdateBanAn(ban);
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    LoadTableT1();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Chức năng lỗi rồi :(. Liên hệ nhóm để sửa", "Thông báo");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BanAn ban = new BanAn();
            ban.Id = (_qlBanAn.GetTablesFromDB().Count() + 1);
            ban.Name = "Bàn " + (_qlBanAn.GetTablesFromDB().Where(c => c.Floor == 1 && (c.TinhTrang == 1 || c.TinhTrang == 0)).Count() + 1);
            ban.Floor = 1;
            ban.Busy = "a";
            ban.Status = true;
            ban.TinhTrang = 1;
            ban.Rong = 70;
            ban.Cao = 70;
            MessageBox.Show(_qlBanAn.AddBanAn(ban), "Thông báo");
            LoadTableT1();

        }

        private void Btn_ThemBanT2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_XoaBanT2_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc chắn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BanAn ban = _qlBanAn.GetTablesFromDB().FirstOrDefault(c => c.Id == _qlBanAn.GetTablesFromDB().Where(c => c.Floor == 2 && (c.TinhTrang == 1 || c.TinhTrang == 0)).Select(c => c.Id).Max());
                if (ban.TinhTrang == 0)
                {
                    MessageBox.Show("Bàn đang có người không thể xóa", "Thông báo");
                    return;
                }
                ban.TinhTrang = 2;
                _qlBanAn.UpdateBanAn(ban);
                MessageBox.Show("Xóa thành công", "Thông báo");
                LoadTableT2();
            }
        }
        void LoadMeniu()
        {
            DataGridViewButtonColumn Them = new DataGridViewButtonColumn();
            Them.Name = "Them";
            Them.HeaderText = "Thêm món";
            Them.UseColumnTextForButtonValue = true;
            Them.Text = "Thêm";

            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            cmb.HeaderText = "số lượng";
            cmb.Items.Add("1");
            cmb.Items.Add("2");
            cmb.Items.Add("3");
            cmb.Items.Add("4");
            cmb.Items.Add("5");
            cmb.Name = "combobox";

            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img.Name = "Thêm";
            img.HeaderText = "Thêm món";
            Bitmap b = new Bitmap(@"C:\DuAn1\ChipChip\QuanLyNhaHangChipChip\3_GUI\Resources\003-signs.png");
            img.Image = b;


            Dgid_Meniu.ColumnCount = 2;
            Dgid_Meniu.Columns[0].Name = "Tên món";
            Dgid_Meniu.Columns[1].Name = "Giá tiền";
            Dgid_Meniu.Columns[1].DefaultCellStyle.Format = "#,0.# VNÐ";
            Dgid_Meniu.Columns.Add(img);
            Dgid_Meniu.Rows.Clear();
            foreach (var x in _qlMeniu.GetViewMenus())
            {
                Dgid_Meniu.Rows.Add(x.details.Name, decimal.Truncate(x.details.Price));
            }

        }

        private void Dgid_Meniu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            var columns = e.ColumnIndex;
            if ((rowIndex == _qlMeniu.GetMonAnChiTiets().Count) || rowIndex == -1) return;
            _idFood = _qlMeniu.GetMonAnChiTiets().Where(c => c.Name == Dgid_Meniu.Rows[rowIndex].Cells[0].Value.ToString()).Select(c => c.Id).FirstOrDefault();
            if (e.ColumnIndex == Dgid_Meniu.Columns["Thêm"].Index)
            {
                if (_IdBan == 0 && _IdHoaDon == 0)
                {
                    MessageBox.Show("Phải chọn bàn trước khi thêm món nhé !", "Thông báo");
                    return;
                }
                _f = new Form();
                TextBox textBox = new TextBox();
                textBox.Width = 150;
                Button button = new Button();
                Label label = new Label();
                label.Text = "Số Lượng:";
                button.Text = "Xác Nhận";
                _f.Controls.Add(textBox);
                _f.Controls.Add(button);
                _f.Controls.Add(label);
                _f.Controls[2].Left = 10;
                _f.Controls[2].Top = 13;
                _f.Controls[0].Left = 80;
                _f.Controls[1].Left = 100;
                _f.Controls[0].Top = 10;
                _f.Controls[1].Top = 50;

                _f.Size = new Size(300, 200);
                _f.StartPosition = FormStartPosition.CenterScreen;
                //f.StartPosition=CenterToScreen();
                button.Size = new Size(100, 50);
                button.Click += Button_Click;
                _f.ShowDialog();

            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            //NhanList(_qlBanAn.GetTablesFromDB(), 0);
            // NhanlstHoaDon(_qlHoaDon.GetBillsFromDB());
            if (String.IsNullOrEmpty(_f.Controls[0].Text))
            {
                MessageBox.Show("không được để trống số lượng", "Thông báo");
                return;
            }
            if (_f.Controls[0].Text.All(char.IsDigit) == false)
            {
                MessageBox.Show("bạn không thể nhập chữ", "Thông báo");
                return;
            }
            _soLuong = Convert.ToInt32(_f.Controls[0].Text);
            if (_IdBan != 0 && _IdHoaDon == 0)
            {
                if (_qlBanAn.GetTablesFromDB().Where(c => c.Id == _IdBan).Select(c => c.TinhTrang).FirstOrDefault() == 1)
                {
                    NhanVien nhanVien = new NhanVien();

                    _hoadon = new HoaDon();
                    _hoadon.Id = (_qlHoaDon.GetBillsFromDB().Count()) + 1;
                    _hoadon.DateCheckIn = DateTime.Now;
                    _hoadon.DateCheckOut = DateTime.Now;
                    _hoadon.Idtable = _IdBan;
                    _hoadon.Status = true;
                    _hoadon.TotalMoney = 0;
                    _hoadon.IdnhanVien = _nhanVien.Id;
                    //_hoadon.IdnhanVien = 1;
                    _hoadon.DichVu = 1;
                    _qlHoaDon.AddHoaDon(_hoadon);
                    BanAn ban = _qlBanAn.GetTablesFromDB().FirstOrDefault(c => c.Id == _IdBan);
                    ban.TinhTrang = 0;
                    _qlBanAn.UpdateBanAn(ban);
                    LoadHoaDon(_IdBan);
                    _hoadonCT = _qlHoaDon.GetHoaDonCTFromDB().FirstOrDefault(c => c.Idbill == _hoadon.Id && _idFood == c.Idfood);

                }
                else if (_qlBanAn.GetTablesFromDB().Where(c => c.Id == _IdBan).Select(c => c.TinhTrang).FirstOrDefault() == 0)
                {
                    _hoadon = _qlHoaDon.GetBillsFromDB().Where(c => c.Idtable == _IdBan && c.Status == true && c.DichVu == 1).FirstOrDefault();
                    _hoadonCT = _qlHoaDon.GetHoaDonCTFromDB().FirstOrDefault(c => c.Idbill == _hoadon.Id && _idFood == c.Idfood);
                }

                if (_hoadonCT == null)
                {
                    HoaDonChiTiet hoaDonChiTiet = new HoaDonChiTiet();
                    hoaDonChiTiet.Id = (_qlHoaDon.GetHoaDonCTFromDB().Count()) + 1;
                    hoaDonChiTiet.Idbill = _hoadon.Id;
                    hoaDonChiTiet.Idfood = _idFood;
                    hoaDonChiTiet.Count = _soLuong;
                    hoaDonChiTiet.Price = _soLuong * (_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == _idFood).Select(c => c.Price).FirstOrDefault());
                    hoaDonChiTiet.Status = true;
                    _qlHoaDon.AddHoaDonCT(hoaDonChiTiet);

                    _hoadon.TotalMoney += hoaDonChiTiet.Price;
                    _qlHoaDon.UpdateHoaDon(_hoadon);
                    LoadHoaDon(_IdBan);
                    LoadTableT1();
                    LoadTableT2();
                    _f.Close();
                    Lbl_TongTien.Text = decimal.Truncate(_qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Idtable == _IdBan && c.Status == true && c.DichVu == 1).TotalMoney).ToString() + " VNĐ";


                }//ád
                else if (_hoadonCT != null)
                {

                    if (_idFood == _hoadonCT.Idfood)
                    {


                        HoaDonChiTiet hoaDonChiTiet1 = _qlHoaDon.GetHoaDonCTFromDB().FirstOrDefault(c => c.Idfood == _idFood && c.Idbill == _hoadon.Id);
                        hoaDonChiTiet1.Count += _soLuong;
                        hoaDonChiTiet1.Price += _soLuong * (_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == _idFood).Select(c => c.Price).FirstOrDefault());
                        _qlHoaDon.UpdateHoaDonCT(hoaDonChiTiet1);

                        _hoadon.TotalMoney += _soLuong * (_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == _idFood).Select(c => c.Price).FirstOrDefault());
                        _qlHoaDon.UpdateHoaDon(_hoadon);
                        LoadHoaDon(_IdBan);
                        LoadTableT1();
                        LoadTableT2();
                        _f.Close();
                        Lbl_TongTien.Text = decimal.Truncate(_qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Idtable == _IdBan && c.Status == true && c.DichVu == 1).TotalMoney).ToString() + " VNĐ";
                    }
                }
                Lbl_GioVao.Text = _hoadon.DateCheckIn.ToString();
            }
            else if (_IdHoaDon != 0 && _IdBan == 0)
            {
                _hoadon = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Id == _IdHoaDon);
                _hoadonCT = _qlHoaDon.GetHoaDonCTFromDB().FirstOrDefault(c => c.Idbill == _hoadon.Id && c.Idfood == _idFood);
                if (_hoadonCT == null)
                {

                    HoaDonChiTiet hoaDonChiTiet = new HoaDonChiTiet();
                    hoaDonChiTiet.Id = (_qlHoaDon.GetHoaDonCTFromDB().Count()) + 1;
                    hoaDonChiTiet.Idbill = _hoadon.Id;
                    hoaDonChiTiet.Idfood = _idFood;
                    hoaDonChiTiet.Count = _soLuong;
                    hoaDonChiTiet.Price = _soLuong * (_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == _idFood).Select(c => c.Price).FirstOrDefault());
                    hoaDonChiTiet.Status = true;
                    _qlHoaDon.AddHoaDonCT(hoaDonChiTiet);

                    _hoadon.TotalMoney += hoaDonChiTiet.Price;
                    _qlHoaDon.UpdateHoaDon(_hoadon);
                    LoadHoaDonMangVe(_hoadon.Id);
                    _f.Close();
                    Lbl_GioVao.Text = _hoadon.DateCheckIn.ToString();
                    Lbl_TongTien.Text = decimal.Truncate(_qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Id == _IdHoaDon).TotalMoney).ToString() + " VNĐ";


                }//ád
                else if (_hoadonCT != null)
                {

                    if (_idFood == _hoadonCT.Idfood)
                    {
                        HoaDonChiTiet hoaDonChiTiet1 = _qlHoaDon.GetHoaDonCTFromDB().FirstOrDefault(c => c.Idfood == _idFood && c.Idbill == _hoadon.Id);
                        hoaDonChiTiet1.Count += _soLuong;
                        hoaDonChiTiet1.Price += _soLuong * (_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == _idFood).Select(c => c.Price).FirstOrDefault());
                        _qlHoaDon.UpdateHoaDonCT(hoaDonChiTiet1);

                        _hoadon.TotalMoney += _soLuong * (_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == _idFood).Select(c => c.Price).FirstOrDefault());
                        _qlHoaDon.UpdateHoaDon(_hoadon);
                        LoadHoaDonMangVe(_hoadon.Id);
                        _f.Close();
                        Lbl_TongTien.Text = decimal.Truncate(_qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Idtable == _IdBan && c.Status == true).TotalMoney).ToString() + " VNĐ";
                    }
                }
            }
        }

        private void Tp_Tang1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_MangVe_Click(object sender, EventArgs e)
        {
            try
            {
                _f = new Form();
                TextBox textBox1 = new TextBox();
                textBox1.Width = 250;
                TextBox textBox2 = new TextBox();
                textBox2.Width = 250;
                Button button123 = new Button();
                Label label = new Label();
                Label label1 = new Label();
                label.Text = "Địa chỉ:";
                label1.Text = "Số Đt:";
                button123.Text = "Thêm";
                _f.Controls.Add(textBox1);
                _f.Controls.Add(button123);
                _f.Controls.Add(label);
                _f.Controls.Add(textBox2);
                _f.Controls.Add(label1);
                _f.Controls[3].Left = 80;
                _f.Controls[3].Top = 50;
                _f.Controls[4].Left = 10;
                _f.Controls[4].Top = 53;
                _f.Controls[2].Left = 10;
                _f.Controls[2].Top = 13;
                _f.Controls[0].Left = 80;
                _f.Controls[1].Left = 150;
                _f.Controls[0].Top = 10;
                _f.Controls[1].Top = 90;
                _f.Size = new Size(400, 240);
                _f.StartPosition = FormStartPosition.CenterScreen;
                button123.Size = new Size(100, 70);
                button123.Click += Button123_Click;
                _f.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Chức năng lỗi rồi :(. Liên hệ nhóm để sửa", "Thông báo");
            }

        }

        private void Button123_Click(object sender, EventArgs e)
        {
            //if (String.IsNullOrEmpty(_f.Controls[3].Text))
            //{
            //    MessageBox.Show("Không để số điện thoại trống", "Thông báo");
            //    return;
            //}
            if (_f.Controls[3].Text.All(char.IsDigit) == false)
            {
                MessageBox.Show("Số điện thoại không thể nhập chữ", "Thông báo");
                return;
            }
            //if (String.IsNullOrEmpty(_f.Controls[0].Text))
            //{
            //    MessageBox.Show("Không để địa chỉ trống", "Thông báo");
            //    return;
            //}
            HoaDon hoaDon = new HoaDon();
            hoaDon.DateCheckIn = DateTime.Now;
            hoaDon.DateCheckOut = DateTime.Now;
            hoaDon.Id = (_qlHoaDon.GetBillsFromDB().Count()) + 1;
            hoaDon.Idtable = 1;
            hoaDon.IdnhanVien = _nhanVien.Id;
            //hoaDon.IdnhanVien = 1;
            hoaDon.SoDT = _f.Controls[3].Text;
            hoaDon.Status = true;
            hoaDon.DiaChi = _f.Controls[0].Text;
            hoaDon.DichVu = 2;
            hoaDon.GhiChu = null;
            hoaDon.TotalMoney = 0;
            _qlHoaDon.AddHoaDon(hoaDon);
            LoadMangVe();
            _f.Close();
        }

        private void Btn_HuyBan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn hủy", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (_IdBan == 0 && _IdHoaDon == 0)
                {
                    MessageBox.Show("Chưa bọn bàn nào", "Thông báo");
                    return;
                }
                if (_IdBan != 0 && _IdHoaDon == 0)
                {
                    BanAn banAn = _qlBanAn.GetTablesFromDB().FirstOrDefault(c => c.Id == _IdBan);
                    if (banAn.TinhTrang == 1)
                    {
                        MessageBox.Show("Bàn hiện tại đang trống", "Thông báo");
                        return;
                    }
                }

                _f = new Form();
                TextBox textBox = new TextBox();
                textBox.Width = 200;

                Button button12 = new Button();
                Label label = new Label();
                label.Text = "Lý do:";
                button12.Text = "Hủy";

                _f.Controls.Add(textBox);
                _f.Controls.Add(button12);
                _f.Controls.Add(label);
                _f.Controls[2].Left = 10;
                _f.Controls[2].Top = 13;
                _f.Controls[0].Left = 80;
                _f.Controls[1].Left = 150;
                _f.Controls[0].Top = 10;
                _f.Controls[1].Top = 50;
                _f.Size = new Size(400, 200);

                _f.StartPosition = FormStartPosition.CenterScreen;
                button12.Size = new Size(100, 45);
                button12.Click += Button12_Click;
                _f.ShowDialog();

            }
        }

        private void Button12_Click(object sender, EventArgs e)
        {

            if (_IdBan == 0 && _IdHoaDon != 0)
            {
                _hoadon = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Id == _IdHoaDon);
                _hoadon.Status = false;
                _hoadon.GhiChu = _f.Controls[0].Text;
                _qlHoaDon.UpdateHoaDon(_hoadon);
                LoadMangVe();
                _f.Close();
            }
            else if (_IdBan != 0 && _IdHoaDon == 0)
            {
                _hoadon = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Idtable == _IdBan && c.Status == true && c.DichVu == 1);
                _hoadon.Status = false;
                _hoadon.GhiChu = _f.Controls[0].Text;
                _qlHoaDon.UpdateHoaDon(_hoadon);

                BanAn banAn = _qlBanAn.GetTablesFromDB().FirstOrDefault(c => c.Id == _IdBan);
                banAn.TinhTrang = 1;
                _qlBanAn.UpdateBanAn(banAn);
                LoadTableT1();
                LoadTableT2();
                _f.Close();
            }
        }
        private void CreateReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (_IdBan != 0 && _IdHoaDon == 0)
            {
                _hoadon = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Idtable == _IdBan && c.Status == true && c.DichVu == 1);
            }
            else if (_IdBan == 0 && _IdHoaDon != 0)
            {
                _hoadon = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Id == _IdHoaDon);
            }
            Graphics graphic = e.Graphics;
            Font font = new Font("Courier New", 12);
            float FontHeight = font.GetHeight();
            int startX = 10;
            int startY = 10;
            int offset = 40;
            graphic.DrawString("         Hóa đơn thanh toán", new Font("Courier New", 17), new SolidBrush(Color.Black), startX + 60, startY);
            string top = "Tên Sản Phẩm".PadRight(20) + "Số lương".PadRight(20) + "Thành Tiền";
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight; //make the spacing consistent
            graphic.DrawString("-------------------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight + 5; //make the spacing consistent

            int index = 0;
            for (int i = 0; i < Dgid_HoaDon.Rows.Count - 1; i++)
            {
                graphic.DrawString(Dgid_HoaDon.Rows[i].Cells[0].Value.ToString(), font, new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(Dgid_HoaDon.Rows[i].Cells[1].Value.ToString(), font, new SolidBrush(Color.Black), startX + 230, startY + offset);
                graphic.DrawString(Dgid_HoaDon.Rows[i].Cells[3].Value.ToString(), font, new SolidBrush(Color.Black), startX + 410, startY + offset);
                offset = offset + (int)FontHeight + 5; //make the spacing consistent      
            }
            //foreach (var x in Dgid_HoaDon.Rows.ToString())
            //{
            //    graphic.DrawString(Dgid_HoaDon.Rows[index].Cells[0].Value.ToString(), font, new SolidBrush(Color.Black), startX, startY + offset);
            //    graphic.DrawString(Dgid_HoaDon.Rows[index].Cells[3].Value.ToString(), font, new SolidBrush(Color.Black), startX + 250, startY + offset);
            //    offset = offset + (int)FontHeight + 5; //make the spacing consistent
            //    index++;
            //}

            offset = offset + 20; //make some room so that the total stands out.

            graphic.DrawString("TỔNG TIỀN ", new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(decimal.Truncate(_hoadon.TotalMoney).ToString() + " VNĐ", new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("TIỀN KHÁCH ĐƯA ", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(Txt_TienKhachDua.Text + " VNĐ", font, new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("TIỀN TRẢ KHÁCH ", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString((Convert.ToInt32(Txt_TienKhachDua.Text) - decimal.Truncate(_hoadon.TotalMoney)).ToString() + " VNĐ", font, new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("              Xin chân thành cảm ơn quý khách!", font, new SolidBrush(Color.Black), startX + 10, startY + offset);
            offset = offset + (int)FontHeight + 5; //make the spacing consistent    
            graphic.DrawString("-------------------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight + 5; //make the spacing consistent
            graphic.DrawString("                 HẸN GẶP LẠI!", font, new SolidBrush(Color.Black), startX + 110, startY + offset);
            offset = offset + (int)FontHeight + 5; //make the spacing consistent                                
            index = Dgid_HoaDon.RowCount;//dem so dong trong datagrid view

        }
        private void CreateReceipt1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (_IdBan != 0 && _IdHoaDon == 0)
            {
                _hoadon = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Idtable == _IdBan && c.Status == true && c.DichVu == 1);
            }
            else if (_IdBan == 0 && _IdHoaDon != 0)
            {
                _hoadon = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Id == _IdHoaDon);
            }
            Graphics graphic = e.Graphics;
            Font font = new Font("Courier New", 12);
            float FontHeight = font.GetHeight();
            int startX = 10;
            int startY = 10;
            int offset = 40;
            graphic.DrawString("         Hóa đơn thanh toán", new Font("Courier New", 17), new SolidBrush(Color.Black), startX + 60, startY);
            string top = "Tên Sản Phẩm".PadRight(20) + "Số lương".PadRight(20) + "Thành Tiền";
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight; //make the spacing consistent
            graphic.DrawString("-------------------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight + 5; //make the spacing consistent

            int index = 0;
            for (int i = 0; i < Dgid_HoaDon.Rows.Count - 1; i++)
            {
                graphic.DrawString(Dgid_HoaDon.Rows[i].Cells[0].Value.ToString(), font, new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(Dgid_HoaDon.Rows[i].Cells[1].Value.ToString(), font, new SolidBrush(Color.Black), startX + 230, startY + offset);
                graphic.DrawString(Dgid_HoaDon.Rows[i].Cells[3].Value.ToString(), font, new SolidBrush(Color.Black), startX + 410, startY + offset);
                offset = offset + (int)FontHeight + 5; //make the spacing consistent      
            }
            //foreach (var x in Dgid_HoaDon.Rows.ToString())
            //{
            //    graphic.DrawString(Dgid_HoaDon.Rows[index].Cells[0].Value.ToString(), font, new SolidBrush(Color.Black), startX, startY + offset);
            //    graphic.DrawString(Dgid_HoaDon.Rows[index].Cells[3].Value.ToString(), font, new SolidBrush(Color.Black), startX + 250, startY + offset);
            //    offset = offset + (int)FontHeight + 5; //make the spacing consistent
            //    index++;
            //}

            offset = offset + 20; //make some room so that the total stands out.

            graphic.DrawString("TỔNG TIỀN ", new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(decimal.Truncate(_hoadon.TotalMoney).ToString() + " VNĐ", new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("TIỀN KHÁCH ĐƯA ", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(Txt_TienKhachDua.Text + " VNĐ", font, new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("TIỀN TRẢ KHÁCH ", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString((Convert.ToInt32(Txt_TienKhachDua.Text) - decimal.Truncate(_hoadon.TotalMoney)).ToString() + " VNĐ", font, new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("SỐ ĐIỆN THOẠI ", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(_hoadon.SoDT, font, new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("ĐỊA CHỈ ", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(_hoadon.DiaChi, font, new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("              Xin chân thành cảm ơn quý khách!", font, new SolidBrush(Color.Black), startX + 10, startY + offset);
            offset = offset + (int)FontHeight + 5; //make the spacing consistent    
            graphic.DrawString("-------------------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight + 5; //make the spacing consistent
            graphic.DrawString("                 HẸN GẶP LẠI!", font, new SolidBrush(Color.Black), startX + 110, startY + offset);
            offset = offset + (int)FontHeight + 5; //make the spacing consistent                                
            index = Dgid_HoaDon.RowCount;//dem so dong trong datagrid view

        }
        private void Btn_ThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn thanh toán", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (_IdBan != 0 && _IdHoaDon == 0)
                    {
                        _hoadon = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Idtable == _IdBan && c.Status == true && c.DichVu == 1);
                    }
                    else if (_IdBan == 0 && _IdHoaDon != 0)
                    {
                        _hoadon = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Id == _IdHoaDon);
                    }
                    if (String.IsNullOrEmpty(Txt_TienKhachDua.Text))
                    {
                        MessageBox.Show("Bạn chua nhập tiền khách đưa", "Thông báo");
                        return;
                    }
                    if (Convert.ToInt32(Txt_TienKhachDua.Text) < _hoadon.TotalMoney)
                    {
                        MessageBox.Show("Tiền khách đưa chưa đủ", "Thông báo");
                        return;
                    }

                    _f = new Form();
                    Label label1 = new Label();
                    Label label2 = new Label();
                    Label label3 = new Label();
                    Label label14 = new Label();
                    Label label15 = new Label();
                    Button button = new Button();
                    button.Text = "OK";
                    label2.Text = "Tổng tiền:";
                    label3.Text = "ăn cứt";
                    label14.Text = "Tiền giả khách:";
                    _f.Controls.Add(label1);
                    _f.Controls.Add(label2);
                    _f.Controls.Add(label3);
                    _f.Controls.Add(button);
                    _f.Controls.Add(label14);
                    _f.Controls.Add(label15);
                    _f.Controls[4].Left = 30;
                    _f.Controls[4].Top = 70;
                    _f.Controls[5].Left = 130;
                    _f.Controls[5].Top = 70;
                    _f.Controls[3].Left = 130;
                    _f.Controls[3].Top = 110;
                    _f.Controls[0].Left = 130;
                    _f.Controls[1].Left = 30;
                    _f.Controls[1].Top = 30;
                    _f.Controls[2].Left = 130;
                    _f.Controls[2].Top = 30;
                    _f.Size = new Size(350, 200);
                    _f.StartPosition = FormStartPosition.CenterScreen;
                    button.Click += Button_Click1;
                    //_f.ShowDialog();


                    if (_IdHoaDon != 0 && _IdBan == 0)
                    {

                        _hoadon = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Id == _IdHoaDon);
                        if (MessageBox.Show("Bạn có muốn in hóa đơn không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            PrintDialog PrintDialog = new PrintDialog();
                            PrintDocument PrintDocument = new PrintDocument();
                            PrintDocument.DocumentName = "HoaDon" + _hoadon.Id;
                            PrintDialog.Document = PrintDocument; //add the document to the dialog box

                            PrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt1); //add an event handler that will do the printing                                                                                                                //on a till you will not want to ask the user where to print but this is fine for the test envoironment.
                            DialogResult result = PrintDialog.ShowDialog();
                            if (result == DialogResult.OK)
                            {
                                PrintDocument.Print();

                            }
                        }
                        _hoadon = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Id == _IdHoaDon);
                        _hoadon.Status = false;
                        _hoadon.DateCheckOut = DateTime.Now;
                        _qlHoaDon.UpdateHoaDon(_hoadon);
                        label1.Text = "Mang về";
                        label3.Text = decimal.Truncate(_qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Id == _hoadon.Id).TotalMoney).ToString() + " VNĐ";
                        label15.Text = Convert.ToDecimal((Convert.ToInt32(Txt_TienKhachDua.Text) - decimal.Truncate(_qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Id == _hoadon.Id).TotalMoney)).ToString()).ToString("#,##0") + " VNĐ";
                        LoadMangVe();
                        LoadHoaDonMangVe(_hoadon.Id);
                        _f.ShowDialog();
                        Lbl_TongTien.Text = "0 VND";


                    }
                    else if (_IdHoaDon == 0 && _IdBan != 0)
                    {
                        _hoadon = _qlHoaDon.GetBillsFromDB().Where(c => c.Idtable == _IdBan && c.Status == true && c.DichVu == 1).FirstOrDefault();
                        if (MessageBox.Show("Bạn có muốn in hóa đơn không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            PrintDialog PrintDialog = new PrintDialog();
                            PrintDocument PrintDocument = new PrintDocument();
                            PrintDocument.DocumentName = "HoaDon" + _hoadon.Id;
                            PrintDialog.Document = PrintDocument; //add the document to the dialog box

                            PrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt); //add an event handler that will do the printing                                                                                                                //on a till you will not want to ask the user where to print but this is fine for the test envoironment.
                            DialogResult result = PrintDialog.ShowDialog();
                            if (result == DialogResult.OK)
                            {
                                PrintDocument.Print();
                            }
                        }

                        _hoadon.Status = false;
                        _hoadon.DateCheckOut = DateTime.Now;
                        _qlHoaDon.UpdateHoaDon(_hoadon);
                        BanAn banAn = _qlBanAn.GetTablesFromDB().FirstOrDefault(c => c.Id == _IdBan);
                        banAn.TinhTrang = 1;
                        label1.Text = "Bàn " + _hoadon.Idtable.ToString();
                        label3.Text = decimal.Truncate(_qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Id == _hoadon.Id).TotalMoney).ToString();
                        label15.Text = Convert.ToDecimal((Convert.ToInt32(Txt_TienKhachDua.Text) - decimal.Truncate(_qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Id == _hoadon.Id).TotalMoney))).ToString("#,##0") + " VNĐ";
                        _qlBanAn.UpdateBanAn(banAn);
                        LoadHoaDon(banAn.Id);
                        LoadTableT1();
                        LoadTableT2();
                        _f.ShowDialog();
                        Lbl_TongTien.Text = "0 VND";
                    }
                    Txt_TienKhachDua.Text = "";
                    Lbl_GioVao.Text = "00:00:00 00/00/2021";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Số tiền quá lớn vượt quá dữ liệu", "Thông báo");
            }
        }

        private void Button_Click1(object sender, EventArgs e)
        {
            _f.Close();
        }//
        public void LoadHoaDon(int idban)
        {
            // NhanlstHoaDon(_qlHoaDon.GetBillsFromDB());
            try
            {
                var abc = (from a in _qlHoaDon.GetBillsFromDB().Where(c => c.Idtable == idban && c.Status == true && c.DichVu == 1)
                           join c in _qlHoaDon.GetHoaDonCTFromDB().Where(c => c.Count > 0)
                           on a.Id equals c.Idbill
                           select new
                           {
                               IDHD = a.Id,
                               IdBan = a.Idtable,
                               TrangThai = a.Status,
                               DichVu = a.DichVu,
                               IDHDCT = c.Id,
                               IDFood = c.Idfood,
                               SoLuong = c.Count,

                           }).ToList();
                DataGridViewImageColumn img = new DataGridViewImageColumn();
                img.Name = "xoa";
                img.HeaderText = "Xóa món";
                Bitmap b = new Bitmap(@"D:\QuanLyNhaHangChipChip\3_GUI\Resources\001-close.png");
                img.Image = b;

                Dgid_HoaDon.ColumnCount = 5;
                Dgid_HoaDon.Columns[0].Name = "Tên món";
                Dgid_HoaDon.Columns[1].Name = "Số lượng";
                Dgid_HoaDon.Columns[2].Name = "Đơn giá";

                Dgid_HoaDon.Columns[3].Name = "thành tiền";

                Dgid_HoaDon.Columns[4].Name = "Id";
                Dgid_HoaDon.Columns[4].Visible = false;
                Dgid_HoaDon.Columns.Add(img);
                Dgid_HoaDon.Rows.Clear();
                //foreach (var x in _qlHoaDon.GetListDSHoaDon().Where(c => c.hoaDon.Idtable == bill && c.hoaDon.Status == true && c.hoaDon.DichVu == 1))
                //{
                //    Dgid_HoaDon.Rows.Add(_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == x.hoaDonChiTiet.Idfood).Select(c => c.Name).FirstOrDefault(), x.hoaDonChiTiet.Count,
                //        _qlMeniu.GetMonAnChiTiets().Where(c => c.Id == x.hoaDonChiTiet.Idfood).Select(c => c.Price).FirstOrDefault(),
                //        x.hoaDonChiTiet.Count * _qlMeniu.GetMonAnChiTiets().Where(c => c.Id == x.hoaDonChiTiet.Idfood).Select(c => c.Price).FirstOrDefault());
                //}
                foreach (var x in abc)
                {
                    Dgid_HoaDon.Rows.Add(_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == x.IDFood).Select(c => c.Name).FirstOrDefault(), x.SoLuong,
                        decimal.Truncate(_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == x.IDFood).Select(c => c.Price).FirstOrDefault()),
                        decimal.Truncate(_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == x.IDFood).Select(c => c.Price).FirstOrDefault() * x.SoLuong), x.IDHDCT);
                }
                Dgid_HoaDon.Columns[3].DefaultCellStyle.Format = "#,0.# VNĐ";
                Dgid_HoaDon.Columns[2].DefaultCellStyle.Format = "#,0.# VNĐ";
            }
            catch (Exception)
            {
                MessageBox.Show("Chức năng lỗi rồi :(. Liên hệ nhóm để sửa", "Thông báo");
            }
        }
        private void Dgid_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            int rowIndex = e.RowIndex;
            var columns = e.ColumnIndex;
            if ((rowIndex == _qlHoaDon.GetHoaDonCTFromDB().Count - 1) || rowIndex == -1) return;
            if (Dgid_HoaDon.Rows[rowIndex].Cells[0].Value==null)
            {
                return;
            }
            else
            {
                _idFood = _qlMeniu.GetMonAnChiTiets().Where(c => c.Name == Dgid_HoaDon.Rows[rowIndex].Cells[0].Value.ToString()).Select(c => c.Id).FirstOrDefault();
            }            
            if (Dgid_HoaDon.Rows[rowIndex].Cells[4].Value == null)
            {
                return;
            }
            else
            {
                _IdHdCt = Convert.ToInt32(Dgid_HoaDon.Rows[rowIndex].Cells[4].Value.ToString());
            }
            if (e.ColumnIndex == Dgid_HoaDon.Columns["xoa"].Index)
            {
                _f = new Form();
                TextBox textBox31 = new TextBox();
                textBox31.Width = 150;
                Button Btn_XoaMon = new Button();
                Label label = new Label();
                label.Text = "Số Lượng:";
                Btn_XoaMon.Text = "Xác Nhận";
                _f.Controls.Add(textBox31);
                _f.Controls.Add(Btn_XoaMon);
                _f.Controls.Add(label);
                _f.Controls[2].Left = 10;
                _f.Controls[2].Top = 13;
                _f.Controls[0].Left = 80;
                _f.Controls[1].Left = 100;
                _f.Controls[0].Top = 10;
                _f.Controls[1].Top = 50;
                _f.Size = new Size(300, 220);
                _f.StartPosition = FormStartPosition.CenterScreen;
                Btn_XoaMon.Size = new Size(100, 60);
                Btn_XoaMon.Click += Btn_XoaMon_Click;
                _f.ShowDialog();
            }
            //}
            //catch (Exception a)
            //{
            //    MessageBox.Show(a.Message);

            //}
        }

        private void Btn_XoaMon_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(_f.Controls[0].Text))
            {
                MessageBox.Show("không được để trống số lượng", "Thông báo");
                return;
            }
            if (_f.Controls[0].Text.All(char.IsDigit) == false)
            {
                MessageBox.Show("bạn không thể nhập chữ", "Thông báo");
                return;
            }
            if (_IdBan != 0 && _IdHoaDon == 0)
            {
                _hoadon = _qlHoaDon.GetBillsFromDB().Where(c => c.Idtable == _IdBan && c.Status == true && c.DichVu == 1).FirstOrDefault();
                int giatru;
                _soLuong = Convert.ToInt32(_f.Controls[0].Text);
                HoaDonChiTiet hoaDonChiTiet = _qlHoaDon.GetHoaDonCTFromDB().FirstOrDefault(c => c.Id == _IdHdCt);
                hoaDonChiTiet.Count -= _soLuong;
                hoaDonChiTiet.Price -= _soLuong * (_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == _idFood).Select(c => c.Price).FirstOrDefault());
                giatru = (int)(_soLuong * (_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == _idFood).Select(c => c.Price).FirstOrDefault()));
                _qlHoaDon.UpdateHoaDonCT(hoaDonChiTiet);
                //List<HoaDonChiTiet> lstHDCT = _qlHoaDon.GetHoaDonCTFromDB().Where(c => c.Idbill == _hoadon.Id).ToList();
                //foreach (var x in lstHDCT)
                //{
                //    _hoadon.TotalMoney += x.Price;
                //}
                _hoadon.TotalMoney -=Convert.ToDecimal(_soLuong * (_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == _idFood).Select(c => c.Price).FirstOrDefault()));
                _qlHoaDon.UpdateHoaDon(_hoadon);
                LoadHoaDon(_IdBan);
                Lbl_TongTien.Text = /*string.Format("{#,0.#}",*/ decimal.Truncate(_qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Idtable == _IdBan && c.Status == true && c.DichVu == 1).TotalMoney).ToString();
                _f.Close();
            }
            else if (_IdBan == 0 && _IdHoaDon != 0)
            {
                _hoadon = _qlHoaDon.GetBillsFromDB().Where(c => c.Id == _IdHoaDon).FirstOrDefault();
                int giatru;
                _soLuong = Convert.ToInt32(_f.Controls[0].Text);
                HoaDonChiTiet hoaDonChiTiet = _qlHoaDon.GetHoaDonCTFromDB().FirstOrDefault(c => c.Id == _IdHdCt);
                hoaDonChiTiet.Count -= _soLuong;
                hoaDonChiTiet.Price -= _soLuong * (_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == _idFood).Select(c => c.Price).FirstOrDefault());
                giatru = (int)(_soLuong * (_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == _idFood).Select(c => c.Price).FirstOrDefault()));
                _qlHoaDon.UpdateHoaDonCT(hoaDonChiTiet);
                //List<Ho/*aDonChiTiet> lstHDC*/T = _qlHoaDon.GetHoaDonCTFromDB().Where(c => c.Idbill == _hoadon.Id).ToList();
                //foreach (var x in lstHDCT)
                //{
                //    _hoadon.TotalMoney += x.Price;
                //}
                _hoadon.TotalMoney -= giatru;
                _qlHoaDon.UpdateHoaDon(_hoadon);
                LoadHoaDonMangVe(_hoadon.Id);
                Lbl_TongTien.Text =/* string.Format("#,0.#"*/decimal.Truncate(_qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Id == _hoadon.Id).TotalMoney).ToString();
                _f.Close();
            }
        }

        private void Btn_ThemBanT2_Click_1(object sender, EventArgs e)
        {
            BanAn ban = new BanAn();
            ban.Id = (_qlBanAn.GetTablesFromDB().Count() + 1);
            ban.Name = "Bàn " + (_qlBanAn.GetTablesFromDB().Where(c => c.Floor == 2 && (c.TinhTrang == 1 || c.TinhTrang == 0)).Count() + 1);
            ban.Floor = 2;
            ban.Busy = "a";
            ban.Status = true;
            ban.TinhTrang = 1;
            ban.Rong = 60;
            ban.Cao = 60;
            MessageBox.Show(_qlBanAn.AddBanAn(ban), "Thông báo");
            LoadTableT2();
        }

        private void Btn_ChuyenBan_Click(object sender, EventArgs e)
        {
            try
            {

                if (_IdBan == 0 && _IdHoaDon != 0)
                {
                    MessageBox.Show("bạn đang ở vị trí mang về, không thể chuyển", "Thông báo");
                    return;
                }
                else if (_IdBan != 0 && _IdHoaDon == 0)
                {
                    BanAn banAn = _qlBanAn.GetTablesFromDB().FirstOrDefault(c => c.Id == _IdBan);
                    if (banAn.TinhTrang == 1)
                    {
                        MessageBox.Show("Bàn hiện tại đang trống", "Thông báo");
                        return;
                    }
                    FrmChuyenBan frmChuyenBan = new FrmChuyenBan(this);
                    frmChuyenBan.reloadBan += FrmChuyenBan_reloadBan;
                    frmChuyenBan.getFrmMain(frm);
                    frmChuyenBan.ShowDialog();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Chức năng lỗi rồi :(. Liên hệ nhóm để sửa", "Thông báo");
            }

        }

        private void FrmChuyenBan_reloadBan()
        {
            LoadTableT1();
            LoadTableT2();
            FLPenal.Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FLPenal.Controls.Clear();
        }

        private void Btn_TachHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                if (_IdBan == 0 && _IdHoaDon == 0)
                {
                    MessageBox.Show("Bạn chưa chọn bàn nào");
                    return;
                }
                if (_IdBan != 0 && _IdHoaDon == 0)
                {
                    FrmTachHoaDon frmTachHoaDon = new FrmTachHoaDon(this);
                    frmTachHoaDon.getformMain(frm);
                    frmTachHoaDon.ShowDialog();
                }
                else if (_IdBan == 0 && _IdHoaDon != 0)
                {
                    MessageBox.Show("Không thể tách hóa đơn mang về");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Chức năng lỗi rồi :(. Liên hệ nhóm để sửa", "Thông báo");
            }

        }
        public void getNhanVien(NhanVien nv)
        {
            _nhanVien = nv;
        }
        private void button12_Click_1(object sender, EventArgs e)
        {

        }

        public void getFrmMain(FrmMain forme)
        {
            frm = forme;
        }



        void LoadMeniu(string name)
        {
            DataGridViewButtonColumn Them = new DataGridViewButtonColumn();
            Them.Name = "Them";
            Them.HeaderText = "Thêm món";
            Them.UseColumnTextForButtonValue = true;
            Them.Text = "Thêm";

            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            cmb.HeaderText = "số lượng";
            cmb.Items.Add("1");
            cmb.Items.Add("2");
            cmb.Items.Add("3");
            cmb.Items.Add("4");
            cmb.Items.Add("5");
            cmb.Name = "combobox";

            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img.Name = "nut";
            Bitmap b = new Bitmap(@"C:\DuAn1\ChipChip\QuanLyNhaHangChipChip\3_GUI\Resources\003-signs.png");
            img.Image = b;


            Dgid_Meniu.ColumnCount = 2;
            Dgid_Meniu.Columns[0].Name = "Tên món";
            Dgid_Meniu.Columns[1].Name = "Giá tiền";
            Dgid_Meniu.Columns.Add(img);
            Dgid_Meniu.Rows.Clear();
            foreach (var x in _qlMeniu.GetViewMenus().Where(c => c.details.Name.ToLower().StartsWith(name)))
            {
                Dgid_Meniu.Rows.Add(x.details.Name, decimal.Truncate(x.details.Price));
            }
            Dgid_Meniu.Columns[1].DefaultCellStyle.Format = "#,0.# VND";
        }



        private void Txt_Seach_TextChanged(object sender, EventArgs e)
        {
            LoadMeniu(Txt_Seach.Text);
        }

        private void Txt_TienKhachDua_TextChanged(object sender, EventArgs e)
        {
            //Convert.ToDecimal(Txt_TienKhachDua.Text).ToString("#,##0");            
            if (Txt_TienKhachDua.Text.All(char.IsDigit) == false)
            {
                MessageBox.Show("Không được nhập chữ", "Thông báo");
                return;
            }
        }

        private void Dgid_HoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
