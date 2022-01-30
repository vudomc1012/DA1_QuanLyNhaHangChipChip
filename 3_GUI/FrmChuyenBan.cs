using _1_DAL.Models;
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
using System.Drawing;
using _3_GUI.Properties;

namespace _3_GUI
{
    public partial class FrmChuyenBan : Form
    {
        public event Action reloadBan;
        private FrmQLBan _FrmQLBan;
        public static int _IdBanCu;
        IQLBanAnService _qlBanAn;
        IQLHoaDon _qlHoaDon;
        iQLMenuService _qlMeniu;
        int _IdBan;
        HoaDon _hoaDon;
        BanAn _banAn;
        FrmMain frm;
        List<BanAn> _lstBan;
        List<HoaDon> _lstHoaDon;
        public FrmChuyenBan(FrmQLBan alo)
        {
            InitializeComponent();
            _qlBanAn = new QLBanAnService();
            _qlHoaDon = new QLHoaDon();
            _qlMeniu = new QLMenuService();
            _lstBan = new List<BanAn>();
            _FrmQLBan = alo;
            LoadTableT1();
            LoadTableT2();

        }
        void LoadTableT2()
        {
            FlPanel2.Controls.Clear();
            _lstBan = new List<BanAn>();
            _lstBan = _qlBanAn.GetTablesFromDB();
            foreach (BanAn x in _lstBan.Where(c => c.Floor == 2 && (c.TinhTrang == 1 || c.TinhTrang == 0)))
            {
                Button btn = new Button() { Width = x.Rong, Height = x.Cao };
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
                FlPanel2.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int id = ((sender as Button).Tag as BanAn).Id;
            _IdBan = id;
            BanAn banAn = _qlBanAn.GetTablesFromDB().FirstOrDefault(c => c.Id == id);
            if (MessageBox.Show("Bạn có chắc muốn chuyển đến T2 - " + banAn.Name, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                _banAn = _qlBanAn.GetTablesFromDB().FirstOrDefault(c => c.Id == _IdBanCu);

                _hoaDon = _qlHoaDon.GetBillsFromDB().Where(c => c.Idtable == _IdBanCu && c.Status == true && c.DichVu == 1).FirstOrDefault();
                if (_IdBanCu == id)
                {
                    MessageBox.Show("Vị trí bàn trùng nhau", "Thông báo");
                    return;
                }
                if (banAn.TinhTrang == 1)
                {
                    
                    _hoaDon.Idtable = _IdBan;
                    _qlHoaDon.UpdateHoaDon(_hoaDon);
                    _banAn.TinhTrang = 1;
                    _qlBanAn.UpdateBanAn(_banAn);
                    banAn.TinhTrang = 0;
                    _qlBanAn.UpdateBanAn(banAn);
                    LoadTableT1();
                    LoadTableT2();

                    //_FrmQLBan.NhanList(_lstBan,0);
                    _lstHoaDon = _qlHoaDon.GetBillsFromDB();
                    //_FrmQLBan.NhanlstHoaDon(_lstHoaDon);
                    _FrmQLBan.LoadTableT1();
                    this.Close();
                }
                else if (banAn.TinhTrang == 0)
                {
                    if (MessageBox.Show("Bàn này đang có người bạn có người, nếu chuyển sẽ gộp lại", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        HoaDon hoaDon = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Idtable == _IdBan && c.Status == true && c.DichVu == 1);
                        _hoaDon.TotalMoney = 0;
                        _hoaDon.Status = false;
                        _qlHoaDon.UpdateHoaDon(_hoaDon);
                        List<HoaDonChiTiet> lstHDCT = _qlHoaDon.GetHoaDonCTFromDB().Where(c => c.Idbill == _hoaDon.Id).ToList();
                        foreach (var x in lstHDCT)
                        {
                            x.Idbill = hoaDon.Id;
                            _qlHoaDon.UpdateHoaDonCT(x);
                            hoaDon.TotalMoney += x.Price;
                        }
                        _qlHoaDon.UpdateHoaDon(hoaDon);
                        _banAn.TinhTrang = 1;
                        _qlBanAn.UpdateBanAn(_banAn);
                        LoadTableT1();
                        LoadTableT2();
                        // _FrmQLBan.NhanList(_lstBan,0);
                        _lstHoaDon = _qlHoaDon.GetBillsFromDB();
                        //_FrmQLBan.NhanlstHoaDon(_lstHoaDon);
                        _FrmQLBan.LoadTableT1();
                        this.Close();
                    }
                }
            }
        }

        void LoadTableT1()
        {
            FLPenal.Controls.Clear();
            _lstBan = new List<BanAn>();
            _lstBan = _qlBanAn.GetTablesFromDB();
            foreach (BanAn x in _lstBan.Where(c => c.Floor == 1 && (c.TinhTrang == 1 || c.TinhTrang == 0)))
            {
                Button btn1 = new Button() { Width = x.Rong, Height = x.Cao };
                //Bitmap b = new Bitmap(@"C:\Users\XAPE\Desktop\TestGit-master\RestaurantApp\Resources\caiBan.png");                
                //btn.Image= b;
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
                FLPenal.Controls.Add(btn1);

            }
            //â
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            int id = ((sender as Button).Tag as BanAn).Id;
            _IdBan = id;
            BanAn banAn = _qlBanAn.GetTablesFromDB().FirstOrDefault(c => c.Id == id);
            _banAn = _qlBanAn.GetTablesFromDB().FirstOrDefault(c => c.Id == _IdBanCu);
            if (MessageBox.Show("Bạn có chắc muốn chuyển đến T1 - "+banAn.Name, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                
                _hoaDon = _qlHoaDon.GetBillsFromDB().Where(c => c.Idtable == _IdBanCu && c.Status == true && c.DichVu == 1).FirstOrDefault();
                if (_IdBanCu == id)
                {
                    MessageBox.Show("Vị trí bàn trùng nhau", "Thông báo");
                    return;
                }
                if (banAn.TinhTrang == 1)
                {

                    //FrmQLBan frmQLBan = new FrmQLBan();
                    //frmQLBan.Hide();
                    _hoaDon.Idtable = _IdBan;
                    _qlHoaDon.UpdateHoaDon(_hoaDon);
                    _banAn.TinhTrang = 1;
                    _qlBanAn.UpdateBanAn(_banAn);
                    banAn.TinhTrang = 0;
                    _qlBanAn.UpdateBanAn(banAn);
                    _FrmQLBan.LoadTableT1();
                    LoadTableT1();
                    LoadTableT2();
                    // _FrmQLBan.NhanList(_lstBan,0);
                    _FrmQLBan.LoadTableT1();
                    _lstHoaDon = _qlHoaDon.GetBillsFromDB();
                    //_FrmQLBan.NhanlstHoaDon(_lstHoaDon);
                    this.Close();
                    //LoadTableT1();
                    //frmQLBan.Show();
                    //ok
                }
                else if (banAn.TinhTrang == 0)
                {
                    if (MessageBox.Show("Bàn này đang có người bạn có người, nếu chuyển sẽ gộp lại", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {


                        HoaDon hoaDon = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Idtable == _IdBan && c.Status == true && c.DichVu == 1);
                        _hoaDon.TotalMoney = 0;
                        _hoaDon.Status = false;
                        _qlHoaDon.UpdateHoaDon(_hoaDon);
                        List<HoaDonChiTiet> lstHDCT = _qlHoaDon.GetHoaDonCTFromDB().Where(c => c.Idbill == _hoaDon.Id).ToList();
                        foreach (var x in lstHDCT)
                        {
                            x.Idbill = hoaDon.Id;
                            _qlHoaDon.UpdateHoaDonCT(x);
                            hoaDon.TotalMoney += x.Price;
                        }
                        // FrmQLBan frmQLBan = new FrmQLBan();
                        //frmQLBan.Hide();
                        _qlHoaDon.UpdateHoaDon(hoaDon);
                        _banAn.TinhTrang = 1;
                        _qlBanAn.UpdateBanAn(_banAn);
                        LoadTableT1();
                        LoadTableT2();
                        //_FrmQLBan.NhanList(_lstBan,0);
                        _FrmQLBan.LoadTableT1();
                        _lstHoaDon = _qlHoaDon.GetBillsFromDB();
                        //_FrmQLBan.NhanlstHoaDon(_lstHoaDon);
                        this.Close();

                        // frmQLBan.Show();
                    }
                }
            }

        }

        private void FrmChuyenBan_FormClosed(object sender, FormClosedEventArgs e)
        {
            _FrmQLBan.LoadTableT1();
            _FrmQLBan.LoadTableT2();
            _FrmQLBan.Close();
            frm.other = 0;
            frm.OpenChildForm(new FrmQLBan(frm), sender);

        }
        public void getFrmMain(FrmMain forme)
        {
            frm = forme;
        }
    }
}
