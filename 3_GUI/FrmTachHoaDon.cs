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
    public partial class FrmTachHoaDon : Form
    {
        public static int _IdBanTachHD;
        public static int _IdHoaDon;
        public static string _EmailTachHD;
        List<HoaDon> _lstHoaDon;
        IQLBanAnService _qlBanAn;
        IQLHoaDon _qlHoaDon;
        IQLNhanVienService _qlNhanVien;
        int _idHD;
        int _idHDCT;
        iQLMenuService _qlMeniu;
        Form _f;
        int _soLuong;
        HoaDon _hoaDon;
        int _idFood;
        HoaDonChiTiet _HDCT;
        List<BanAn> _lstBan;
        FrmMain _FrmMain;
        FrmQLBan _FrmQLBan;
        public FrmTachHoaDon(FrmQLBan frm)
        {
            InitializeComponent();
            _qlBanAn = new QLBanAnService();
            _qlHoaDon = new QLHoaDon();
            _qlNhanVien = new QLNhanVienService();
            _qlMeniu = new QLMenuService();
            LoadHDCu(_IdBanTachHD);
            _FrmQLBan = frm;
            Lbl_Tien.Visible = false;
            HoaDon hoa = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c=>c.Idtable==_IdBanTachHD && c.Status==true && c.DichVu==1);
            Lbl_TienCu.Text =decimal.Truncate(hoa.TotalMoney).ToString() + "VNĐ";
        }
        public void getformMain(FrmMain frm)
        {
            _FrmMain = frm;
        }
        void LoadHDCu(int id)
        {
            _lstHoaDon = new List<HoaDon>();
            _lstHoaDon = _qlHoaDon.GetBillsFromDB();
            var abc = (from a in _qlHoaDon.GetBillsFromDB().Where(c => c.Idtable == id && c.Status == true && c.DichVu == 1 && c.Id!=_idHD)
                       join c in _qlHoaDon.GetHoaDonCTFromDB().Where(c=>c.Count>0)
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
            img.Name = "Xóa";
            img.HeaderText = "Tách";
            Bitmap b = new Bitmap(@"C:\DuAn1\ChipChip\QuanLyNhaHangChipChip\3_GUI\Resources\001-close.png");
            img.Image = b;

            Dgrid_HDCu.ColumnCount = 5;
            Dgrid_HDCu.Columns[0].Name = "Tên món";
            Dgrid_HDCu.Columns[1].Name = "Số lượng";
            Dgrid_HDCu.Columns[2].Name = "Đơn giá";
            Dgrid_HDCu.Columns[3].Name = "thành tiền";
            Dgrid_HDCu.Columns[2].DefaultCellStyle.Format = "#,0.# VNÐ";
            Dgrid_HDCu.Columns[3].DefaultCellStyle.Format = "#,0.# VNÐ";
            Dgrid_HDCu.Columns[4].Name = "Id";
            Dgrid_HDCu.Columns[4].Visible = false;
            Dgrid_HDCu.Columns.Add(img);
            Dgrid_HDCu.Rows.Clear();
            foreach (var x in abc)
            {
                Dgrid_HDCu.Rows.Add(_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == x.IDFood).Select(c => c.Name).FirstOrDefault(), x.SoLuong,
                    _qlMeniu.GetMonAnChiTiets().Where(c => c.Id == x.IDFood).Select(c => c.Price).FirstOrDefault(),
                    _qlMeniu.GetMonAnChiTiets().Where(c => c.Id == x.IDFood).Select(c => c.Price).FirstOrDefault() * x.SoLuong, x.IDHDCT);
            }
        }
        

        private void Btn_TaoHD_Click(object sender, EventArgs e)
        {
            try
            {
                HoaDon hoaDon = new HoaDon();
                NhanVien nhanVien = _qlNhanVien.getlstNhanViens().FirstOrDefault(c => c.Email == _EmailTachHD);
                hoaDon.DateCheckIn = DateTime.Now;
                hoaDon.DateCheckOut = DateTime.Now;
                hoaDon.Id = (_qlHoaDon.GetBillsFromDB().Count()) + 1;
                hoaDon.Idtable = _IdBanTachHD;
                hoaDon.IdnhanVien = nhanVien.Id;
                //hoaDon.IdnhanVien = 1;
                hoaDon.SoDT = null;
                hoaDon.Status = true;
                hoaDon.DiaChi = null;
                hoaDon.DichVu = 1;
                hoaDon.GhiChu = null;
                hoaDon.TotalMoney = 0;
                _qlHoaDon.AddHoaDon(hoaDon);
                _idHD = hoaDon.Id;
                MessageBox.Show("Tạo thành công", "Thông báo");
                LoadHDMoi();

            }
            catch (Exception)
            {
                MessageBox.Show("Chức năng lỗi rồi :(. Liên hệ nhóm để sửa", "Thông báo");
            }
        }

        private void Dgrid_HDCu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            var columns = e.ColumnIndex;
            if ((rowIndex == _qlHoaDon.GetHoaDonCTFromDB().Count) || rowIndex == -1) return;
            if (Dgrid_HDCu.Rows[rowIndex].Cells[4].Value==null)
            {
                return;
            }
            else
            {
                _idHDCT = Convert.ToInt32(Dgrid_HDCu.Rows[rowIndex].Cells[4].Value.ToString());
            }
            

            if (e.ColumnIndex == Dgrid_HDCu.Columns["Xóa"].Index)
            {
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
                _f.Size = new Size(300, 120);
                //f.StartPosition=CenterToScreen();
                button.Click += Button_Click; ;
                _f.ShowDialog();

            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            
            if (_idHD==0)
            {
                MessageBox.Show("Bạn chưa tạo hóa đơn mới");
                _f.Close();
                return;
            }
            else if (_idHD!=0)
            {
                HoaDon hoaDon1 = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Id == _idHD);
                if (hoaDon1.Status==false)
                {
                    MessageBox.Show("Bạn chưa tạo hóa đơn mới");
                    _f.Close();
                    return;
                }
            }
          
            HoaDon hoaDon = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Id == _idHD);
            _HDCT = _qlHoaDon.GetHoaDonCTFromDB().FirstOrDefault(c => c.Id == _idHDCT);
            HoaDonChiTiet hoaDonChiTiet2 = _qlHoaDon.GetHoaDonCTFromDB().FirstOrDefault(c=>c.Idbill==_idHD && c.Idfood==_HDCT.Idfood);
            if (String.IsNullOrEmpty(_f.Controls[0].Text))
            {
                MessageBox.Show("Bạn chưa nhập số lượng","Thông báo");
                return;
            }
            if (_f.Controls[0].Text.All(char.IsDigit)==false)
            {
                MessageBox.Show("Số lượng không được nhập chữ","Thông báo");
                return;
            }
            _soLuong = Convert.ToInt32(_f.Controls[0].Text);
            if (_soLuong>_HDCT.Count)
            {
                MessageBox.Show("Số lượng lớn hơn rồi","Thông báo");
                return;
            }
            if (hoaDonChiTiet2==null)
            {
                HoaDonChiTiet hoaDonChiTiet = new HoaDonChiTiet();
                hoaDonChiTiet.Id = (_qlHoaDon.GetHoaDonCTFromDB().Count()) + 1;
                hoaDonChiTiet.Idbill = _idHD;
                hoaDonChiTiet.Idfood = _HDCT.Idfood;
                hoaDonChiTiet.Count = _soLuong;
                hoaDonChiTiet.Price = _soLuong * (_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == _HDCT.Idfood).Select(c => c.Price).FirstOrDefault());
                hoaDonChiTiet.Status = true;
                _qlHoaDon.AddHoaDonCT(hoaDonChiTiet);
                hoaDon.TotalMoney += hoaDonChiTiet.Price;
                _qlHoaDon.UpdateHoaDon(hoaDon);
                _hoaDon = _qlHoaDon.GetBillsFromDB().Where(c => c.Idtable == _IdBanTachHD && c.Status == true && c.DichVu == 1 && c.Id!=_idHD).FirstOrDefault();
                int giatru;
                HoaDonChiTiet hoaDonChiTiet1 = _qlHoaDon.GetHoaDonCTFromDB().FirstOrDefault(c => c.Id == _idHDCT);
                if (hoaDonChiTiet1.Count == 0)
                {
                    _hoaDon.TotalMoney -= hoaDonChiTiet1.Price;
                    _qlHoaDon.DeleteHoaDonCT(hoaDonChiTiet1);
                    _qlHoaDon.UpdateHoaDon(_hoaDon);
                    return;
                }
                else if (hoaDonChiTiet1.Count!=0)
                {
                    hoaDonChiTiet1.Count -= _soLuong;
                    hoaDonChiTiet1.Price -= _soLuong * (_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == _HDCT.Idfood).Select(c => c.Price).FirstOrDefault());
                    giatru = (int)(_soLuong * (_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == _HDCT.Idfood).Select(c => c.Price).FirstOrDefault()));
                    _qlHoaDon.UpdateHoaDonCT(hoaDonChiTiet1);
                    _hoaDon.TotalMoney -= giatru;
                    _qlHoaDon.UpdateHoaDon(_hoaDon);
                }
                
            }
            else if (hoaDonChiTiet2!=null)
            {
                hoaDonChiTiet2.Count += _soLuong;
                hoaDonChiTiet2.Price += _soLuong * (_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == _HDCT.Idfood).Select(c => c.Price).FirstOrDefault());
                _qlHoaDon.UpdateHoaDonCT(hoaDonChiTiet2);                
                hoaDon.TotalMoney += _soLuong * (_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == _HDCT.Idfood).Select(c => c.Price).FirstOrDefault());
                _qlHoaDon.UpdateHoaDon(hoaDon);
                _hoaDon = _qlHoaDon.GetBillsFromDB().Where(c => c.Idtable == _IdBanTachHD && c.Status == true && c.DichVu == 1 && c.Id!=_idHD).FirstOrDefault();
                int giatru;
                HoaDonChiTiet hoaDonChiTiet1 = _qlHoaDon.GetHoaDonCTFromDB().FirstOrDefault(c => c.Id == _idHDCT);
                if (hoaDonChiTiet1.Count == 0)
                {
                    _hoaDon.TotalMoney -= hoaDonChiTiet1.Price;
                    _qlHoaDon.DeleteHoaDonCT(hoaDonChiTiet1);
                    _qlHoaDon.UpdateHoaDon(_hoaDon);
                    return;
                }
                else if (hoaDonChiTiet1.Count!=0)
                {
                    hoaDonChiTiet1.Count -= _soLuong;
                    hoaDonChiTiet1.Price -= _soLuong * (_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == _HDCT.Idfood).Select(c => c.Price).FirstOrDefault());
                    giatru = (int)(_soLuong * (_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == _HDCT.Idfood).Select(c => c.Price).FirstOrDefault()));
                    _qlHoaDon.UpdateHoaDonCT(hoaDonChiTiet1);
                    _hoaDon.TotalMoney -= giatru;
                    _qlHoaDon.UpdateHoaDon(_hoaDon);
                }
                
            }
            Lbl_Tien.Visible = true;
            Lbl_TienCu.Text = decimal.Truncate(_hoaDon.TotalMoney).ToString() + "VNĐ";
            Lbl_Tien.Text =decimal.Truncate(_qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Id == _idHD).TotalMoney).ToString() +"VNĐ";
            LoadHDCu(_IdBanTachHD);
            LoadHDMoi();            
            _f.Close();
        }

        private void Btn_XacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                HoaDon hoaDon = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Id == _idHD);
                if (MessageBox.Show("Bạn có chắc chắn muốn thanh toán không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (String.IsNullOrEmpty(Txt_Tien.Text))
                    {
                        MessageBox.Show("Chưa nhập tiền khách đưa", "Thông báo");
                        return;
                    }
                    if (Convert.ToInt32(Txt_Tien.Text) < hoaDon.TotalMoney)
                    {
                        MessageBox.Show("Tiền khách đưa chưa đủ", "Thông báo");
                        return;
                    }
                    if (MessageBox.Show("Bạn có muốn in hóa đơn không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        PrintDialog PrintDialog = new PrintDialog();
                        PrintDocument PrintDocument = new PrintDocument();
                        PrintDialog.Document = PrintDocument; //add the document to the dialog box

                        PrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt2); //add an event handler that will do the printing                                                                                                                //on a till you will not want to ask the user where to print but this is fine for the test envoironment.
                        DialogResult result = PrintDialog.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            PrintDocument.Print();

                        }
                    }
                    _hoaDon = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Id == _idHD);
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
                    button.Click += Button_Click2;
                    hoaDon.Status = false;
                    hoaDon.DateCheckOut = DateTime.Now;
                    _qlHoaDon.UpdateHoaDon(hoaDon);
                    label3.Text = decimal.Truncate(hoaDon.TotalMoney).ToString() + "VNĐ";
                    label15.Text = decimal.Truncate((Convert.ToInt32(Txt_Tien.Text) - hoaDon.TotalMoney)).ToString() + "VNĐ";
                    _f.ShowDialog();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Chức năng lỗi rồi :(. Liên hệ nhóm để sửa", "Thông báo");
            }
            
        }

        private void Button_Click2(object sender, EventArgs e)
        {
            LoadHDMoi();
            //FrmQLBan frmQLBan = new FrmQLBan();
            //frmQLBan.NhanlstHoaDon(_lstHoaDon);
            //frmQLBan.LoadHoaDon(_IdBanTachHD);
            Lbl_Tien.Text = "0 VND";
            _f.Close();

        }               
        void LoadHDMoi()
        {
            //_lstHoaDon = new List<HoaDon>();
            //_lstHoaDon = _qlHoaDon.GetBillsFromDB();
            var abc = (from a in _qlHoaDon.GetBillsFromDB().Where(c => c.Id == _idHD && c.Status == true)
                       join c in _qlHoaDon.GetHoaDonCTFromDB().Where(c=>c.Count>0)
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
            img.Name = "Xóa";
            //C:\DuAn1\ChipChip\QuanLyNhaHangChipChip\3_GUI\Resources\003-signs.png
            Bitmap b = new Bitmap(@"C:\DuAn1\ChipChip\QuanLyNhaHangChipChip\3_GUI\Resources\001-close.png");
            img.Image = b;

            Dgrid_HDMoi.ColumnCount = 5;
            Dgrid_HDMoi.Columns[0].Name = "Tên món";
            Dgrid_HDMoi.Columns[1].Name = "Số lượng";
            Dgrid_HDMoi.Columns[2].Name = "Đơn giá";
            Dgrid_HDMoi.Columns[3].Name = "thành tiền";
            Dgrid_HDMoi.Columns[2].DefaultCellStyle.Format = "#,0.# VNÐ";
            Dgrid_HDMoi.Columns[3].DefaultCellStyle.Format = "#,0.# VNÐ";
            Dgrid_HDMoi.Columns[4].Name = "Id";
            Dgrid_HDMoi.Columns[4].Visible = false;
            Dgrid_HDMoi.Columns.Add(img);
            Dgrid_HDMoi.Rows.Clear();
            //Convert.ToDecimal((Convert.ToInt32(Txt_TienKhachDua.Text) - decimal.Truncate(_qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Id == _hoadon.Id).TotalMoney)).ToString()).ToString("#,##0")  + ".000 VND";
            foreach (var x in abc)
            {
                Dgrid_HDMoi.Rows.Add(_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == x.IDFood).Select(c => c.Name).FirstOrDefault(), x.SoLuong,
                   decimal.Truncate(_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == x.IDFood).Select(c => c.Price).FirstOrDefault()),
                   decimal.Truncate(_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == x.IDFood).Select(c => c.Price).FirstOrDefault() * x.SoLuong).ToString(), x.IDHDCT);
            }
        }//as

        private void Dgrid_HDMoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            var columns = e.ColumnIndex;
            if ((rowIndex == _qlHoaDon.GetHoaDonCTFromDB().Count) || rowIndex == -1) return;
            if (Dgrid_HDCu.Rows[rowIndex].Cells[4].Value==null)
            {
                return;
            }
            else
            {
                _idHDCT = Convert.ToInt32(Dgrid_HDCu.Rows[rowIndex].Cells[4].Value.ToString());
            }
            
            if (e.ColumnIndex == Dgrid_HDMoi.Columns["Xóa"].Index)
            {
                MessageBox.Show("Chức năng đang được nâng cấp", "Thông báo");
                //_f = new Form();
                //TextBox textBox = new TextBox();
                //textBox.Width = 150;
                //Button button1 = new Button();
                //Label label = new Label();
                //label.Text = "Số Lượng:";
                //button1.Text = "Xác Nhận";
                //_f.Controls.Add(textBox);
                //_f.Controls.Add(button1);
                //_f.Controls.Add(label);
                //_f.Controls[2].Left = 10;
                //_f.Controls[2].Top = 13;
                //_f.Controls[0].Left = 80;
                //_f.Controls[1].Left = 100;
                //_f.Controls[0].Top = 10;
                //_f.Controls[1].Top = 50;
                //_f.Size = new Size(300, 120);
                ////f.StartPosition=CenterToScreen();
                //button1.Click += Button1_Click;
                //_f.ShowDialog();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            //if (String.IsNullOrEmpty(_f.Controls[0].Text))
            //{
            //    MessageBox.Show("Bạn chưa nhập số lượng","Thông báo");                
            //    return;
            //}
            //if (_f.Controls[0].Text.All(char.IsDigit)==false)
            //{
            //    MessageBox.Show("Số lượng không được nhập chữ","Thông báo");
            //    return;
            //}
            //_soLuong = Convert.ToInt32(_f.Controls[0].Text);
            //_hoaDon = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Idtable == _IdBanTachHD && c.Status == true && c.DichVu == 1 && c.Id != _idHD);
            //HoaDon hoaDon = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c=>c.Id==_idHD);
            //HoaDonChiTiet hoaDonChiTiet = _qlHoaDon.GetHoaDonCTFromDB().FirstOrDefault(c => c.Id == _idHDCT);
            //_HDCT = _qlHoaDon.GetHoaDonCTFromDB().FirstOrDefault(c=>c.Idbill==_hoaDon.Id && c.Idfood==hoaDonChiTiet.Idfood);
            //if (_soLuong>hoaDonChiTiet.Count)
            //{
            //    MessageBox.Show("Số lượng lớn hơn rồi","Thông báo");
            //    _f.Close();
            //    return;
            //}
            ////int giatru = (int)(_soLuong * (_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == hoaDonChiTiet.Idfood).Select(c => c.Price).FirstOrDefault()));
            //hoaDonChiTiet.Count -=Convert.ToInt32(_f.Controls[0].Text);             
            //hoaDonChiTiet.Price = hoaDonChiTiet.Count * (_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == hoaDonChiTiet.Idfood).Select(c => c.Price).FirstOrDefault());
            //_qlHoaDon.UpdateHoaDonCT(hoaDonChiTiet);
            //hoaDon.TotalMoney -= _soLuong * (_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == hoaDonChiTiet.Idfood).Select(c => c.Price).FirstOrDefault());
            //_qlHoaDon.UpdateHoaDon(hoaDon);
            //LoadHDMoi();

            _HDCT.Count += _soLuong;
            _HDCT.Price+= _soLuong * (_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == hoaDonChiTiet.Idfood).Select(c => c.Price).FirstOrDefault());
            _qlHoaDon.UpdateHoaDonCT(_HDCT);
            _hoaDon.TotalMoney += _soLuong * (_qlMeniu.GetMonAnChiTiets().Where(c => c.Id == hoaDonChiTiet.Idfood).Select(c => c.Price).FirstOrDefault());
            _qlHoaDon.UpdateHoaDon(_hoaDon);

            LoadHDCu(_IdBanTachHD);
            LoadHDMoi();
            Lbl_Tien.Visible = true;
            Lbl_Tien.Text = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Id == _idHD).TotalMoney.ToString()+"VNĐ";
        }
        private void CreateReceipt1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            HoaDon hoa = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c=>c.Idtable==_IdBanTachHD && c.Status==true && c.DichVu==1);
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
            for (int i = 0; i < Dgrid_HDCu.Rows.Count - 1; i++)
            {
                graphic.DrawString(Dgrid_HDCu.Rows[i].Cells[0].Value.ToString(), font, new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(Dgrid_HDCu.Rows[i].Cells[1].Value.ToString(), font, new SolidBrush(Color.Black), startX + 230, startY + offset);
                graphic.DrawString(Dgrid_HDCu.Rows[i].Cells[3].Value.ToString(), font, new SolidBrush(Color.Black), startX + 410, startY + offset);
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
            graphic.DrawString(decimal.Truncate(hoa.TotalMoney).ToString() + ".000 VND", new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("TIỀN KHÁCH ĐƯA ", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(Txt_Tien.Text + ".000 VND", font, new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("TIỀN TRẢ KHÁCH ", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString((Convert.ToInt32(Txt_Tien.Text) - decimal.Truncate(hoa.TotalMoney)).ToString() + ".000 VND", font, new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("              Xin chân thành cảm ơn quý khách!", font, new SolidBrush(Color.Black), startX + 10, startY + offset);
            offset = offset + (int)FontHeight + 5; //make the spacing consistent    
            graphic.DrawString("-------------------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight + 5; //make the spacing consistent
            graphic.DrawString("                 HẸN GẶP LẠI!", font, new SolidBrush(Color.Black), startX + 110, startY + offset);
            offset = offset + (int)FontHeight + 5; //make the spacing consistent                                
            index = Dgrid_HDCu.RowCount;//dem so dong trong datagrid view

        }
        private void CreateReceipt2(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            HoaDon hoa = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Id==_idHD);
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
            for (int i = 0; i < Dgrid_HDMoi.Rows.Count - 1; i++)
            {
                graphic.DrawString(Dgrid_HDMoi.Rows[i].Cells[0].Value.ToString(), font, new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(Dgrid_HDMoi.Rows[i].Cells[1].Value.ToString(), font, new SolidBrush(Color.Black), startX + 230, startY + offset);
                graphic.DrawString(Dgrid_HDMoi.Rows[i].Cells[3].Value.ToString(), font, new SolidBrush(Color.Black), startX + 410, startY + offset);
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
            graphic.DrawString(decimal.Truncate(hoa.TotalMoney).ToString() + ".000 VND", new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("TIỀN KHÁCH ĐƯA ", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(Txt_Tien.Text + ".000 VND", font, new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("TIỀN TRẢ KHÁCH ", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString((Convert.ToInt32(Txt_Tien.Text) - decimal.Truncate(hoa.TotalMoney)).ToString() + ".000 VND", font, new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("              Xin chân thành cảm ơn quý khách!", font, new SolidBrush(Color.Black), startX + 10, startY + offset);
            offset = offset + (int)FontHeight + 5; //make the spacing consistent    
            graphic.DrawString("-------------------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight + 5; //make the spacing consistent
            graphic.DrawString("                 HẸN GẶP LẠI!", font, new SolidBrush(Color.Black), startX + 110, startY + offset);
            offset = offset + (int)FontHeight + 5; //make the spacing consistent                                
            index = Dgrid_HDMoi.RowCount;//dem so dong trong datagrid view

        }
        private void FrmTachHoaDon_FormClosed(object sender, FormClosedEventArgs e)
        {
            

        }      

        private void Btn_ThanhToan1_Click(object sender, EventArgs e)
        {
            HoaDon hoaDon = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Idtable == _IdBanTachHD && c.Status == true && c.DichVu == 1);
            if (MessageBox.Show("Bạn có chắc chắn muốn thanh toán không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (String.IsNullOrEmpty(Txt_Tien.Text))
                {
                    MessageBox.Show("Chưa nhập tiền khách đưa","Thông báo");
                    return;
                }
                if (Convert.ToInt32(Txt_Tien.Text)<hoaDon.TotalMoney)
                {
                    MessageBox.Show("Tiền khách đưa chưa đủ","Thông báo");
                    return;
                }
                if (MessageBox.Show("Bạn có muốn in hóa đơn không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    PrintDialog PrintDialog = new PrintDialog();
                    PrintDocument PrintDocument = new PrintDocument();                    
                    PrintDialog.Document = PrintDocument; //add the document to the dialog box

                    PrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt1); //add an event handler that will do the printing                                                                                                                //on a till you will not want to ask the user where to print but this is fine for the test envoironment.
                    DialogResult result = PrintDialog.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        PrintDocument.Print();

                    }
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
                button.Click += Button_Click3;                
                hoaDon.Status = false;
                hoaDon.DateCheckOut = DateTime.Now;
                _qlHoaDon.UpdateHoaDon(hoaDon);
                label3.Text =decimal.Truncate(hoaDon.TotalMoney).ToString() + "VNĐ";
                label15.Text =decimal.Truncate((Convert.ToInt32(Txt_Tien.Text) - hoaDon.TotalMoney)).ToString() + "VNĐ";
                BanAn banAn = _qlBanAn.GetTablesFromDB().FirstOrDefault(c=>c.Id==_IdBanTachHD);
                banAn.TinhTrang = 1;
                _qlBanAn.UpdateBanAn(banAn);
                _f.ShowDialog();
            }
        }

        private void Button_Click3(object sender, EventArgs e)
        {
            //_lstBan = _qlBanAn.GetTablesFromDB();
            //FrmQLBan frmQLBan = new FrmQLBan();
            //frmQLBan.NhanList(_lstBan,0);
            //LoadHDCu(_IdBanTachHD);
            //frmQLBan.NhanlstHoaDon(_lstHoaDon);
            //frmQLBan.LoadHoaDon(_IdBanTachHD);
            //frmQLBan.LoadTableT1();
            //frmQLBan.LoadTableT2();
            //Lbl_TienCu.Text = "0 VND";
            //_f.Close();
        }

        private void Txt_Tien_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Tien.Text.All(char.IsDigit)==false)
            {
                MessageBox.Show("Không được nhập chữ","Thông báo");
                return;
            }
        }

        private void FrmTachHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            HoaDon hoaDon = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Id == _idHD);
            if (hoaDon != null)
            {
                if (hoaDon.Status == true)
                {
                    MessageBox.Show("Bạn phải thanh toán hóa Đơn này trước khi thoát", "Thông báo");                                      
                    e.Cancel=true;
                    return;
                }
            }
            _FrmQLBan.Close();
            _FrmMain.other = 0;
            _FrmMain.OpenChildForm(new FrmQLBan(_FrmMain), sender);
        }
    }
}
