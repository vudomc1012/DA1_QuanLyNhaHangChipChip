using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_DAL.Models;
using _2_BUS.iBUSServices;
using _2_BUS.BUSServices;

namespace _3_GUI
{
    public partial class FrmQLMenu : Form
    {
        private iQLMenuService _iQLMenuService;
        private MonAnChiTiet _monCT;
        private DonVi _donVi;
        private DanhMucFood _dmFood;
        private CachCheBien _cachCB;
        private ThucDon _item;
        private List<MonAnChiTiet> _lstMonCT;
        private List<ThucDon> _lstMenu;
        public FrmQLMenu()
        {
            InitializeComponent();
            _iQLMenuService = new QLMenuService();
            _monCT = new MonAnChiTiet();
            _item = new ThucDon();
            _lstMonCT = _iQLMenuService.GetMonAnChiTiets();
            _lstMenu = _iQLMenuService.GetThucDons();

        }
        void Load()
        {
            dgrid_MonCT.ColumnCount = 6;
            dgrid_MonCT.Columns[0].Name = "Tên món";
            dgrid_MonCT.Columns[1].Name = "Giá";
            dgrid_MonCT.Columns[2].Name = "Danh mục";
            dgrid_MonCT.Columns[3].Name = "Cách chế biên";
            dgrid_MonCT.Columns[4].Name = "Đơn vị tính";
            dgrid_MonCT.Columns[5].Name = "Trạng thái";
            dgrid_MonCT.Rows.Clear();
            foreach(var x in _iQLMenuService.GetViewMenus())
            {
                dgrid_MonCT.Rows.Add(x.details.Name, x.details.Price, x.cat.Name, x.method.Name, x.unit.Name, x.details.Status == 1 ? "Đang bán" : "Dừng bán");
            }
        }
        private void tbx_Search_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdo_khongHoatDong_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdo_hoatDong_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
