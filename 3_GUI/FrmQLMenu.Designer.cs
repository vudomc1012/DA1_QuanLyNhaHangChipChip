
namespace _3_GUI
{
    partial class FrmQLMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgrid_MonCT = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_khongHoatDong = new System.Windows.Forms.RadioButton();
            this.rdo_hoatDong = new System.Windows.Forms.RadioButton();
            this.lbl_TrangThai = new System.Windows.Forms.Label();
            this.lbl_Gia = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_TenMon = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.tbx_Search = new System.Windows.Forms.TextBox();
            this.danhMụcMónĂnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhMụcMónĂnToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.đồTrênBờToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đồTrênTrờiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_MonCT)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrid_MonCT
            // 
            this.dgrid_MonCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_MonCT.Location = new System.Drawing.Point(446, 73);
            this.dgrid_MonCT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgrid_MonCT.Name = "dgrid_MonCT";
            this.dgrid_MonCT.RowHeadersWidth = 51;
            this.dgrid_MonCT.RowTemplate.Height = 25;
            this.dgrid_MonCT.Size = new System.Drawing.Size(858, 661);
            this.dgrid_MonCT.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.rdo_khongHoatDong);
            this.groupBox1.Controls.Add(this.rdo_hoatDong);
            this.groupBox1.Controls.Add(this.lbl_TrangThai);
            this.groupBox1.Controls.Add(this.lbl_Search);
            this.groupBox1.Controls.Add(this.tbx_Search);
            this.groupBox1.Controls.Add(this.lbl_Gia);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_TenMon);
            this.groupBox1.Controls.Add(this.btn_Delete);
            this.groupBox1.Controls.Add(this.btn_Update);
            this.groupBox1.Controls.Add(this.btn_Add);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.LightCoral;
            this.groupBox1.Location = new System.Drawing.Point(14, 55);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(426, 679);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lí món ăn";
            // 
            // rdo_khongHoatDong
            // 
            this.rdo_khongHoatDong.AutoSize = true;
            this.rdo_khongHoatDong.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdo_khongHoatDong.Location = new System.Drawing.Point(211, 109);
            this.rdo_khongHoatDong.Name = "rdo_khongHoatDong";
            this.rdo_khongHoatDong.Size = new System.Drawing.Size(175, 26);
            this.rdo_khongHoatDong.TabIndex = 11;
            this.rdo_khongHoatDong.TabStop = true;
            this.rdo_khongHoatDong.Text = "Không Hoạt động";
            this.rdo_khongHoatDong.UseVisualStyleBackColor = true;
            this.rdo_khongHoatDong.CheckedChanged += new System.EventHandler(this.rdo_khongHoatDong_CheckedChanged);
            // 
            // rdo_hoatDong
            // 
            this.rdo_hoatDong.AutoSize = true;
            this.rdo_hoatDong.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdo_hoatDong.Location = new System.Drawing.Point(108, 109);
            this.rdo_hoatDong.Name = "rdo_hoatDong";
            this.rdo_hoatDong.Size = new System.Drawing.Size(116, 26);
            this.rdo_hoatDong.TabIndex = 10;
            this.rdo_hoatDong.TabStop = true;
            this.rdo_hoatDong.Text = "Hoạt động";
            this.rdo_hoatDong.UseVisualStyleBackColor = true;
            this.rdo_hoatDong.CheckedChanged += new System.EventHandler(this.rdo_hoatDong_CheckedChanged);
            // 
            // lbl_TrangThai
            // 
            this.lbl_TrangThai.AutoSize = true;
            this.lbl_TrangThai.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_TrangThai.Location = new System.Drawing.Point(17, 111);
            this.lbl_TrangThai.Name = "lbl_TrangThai";
            this.lbl_TrangThai.Size = new System.Drawing.Size(79, 17);
            this.lbl_TrangThai.TabIndex = 9;
            this.lbl_TrangThai.Text = "Trạng Thái";
            // 
            // textBox2
            // 
            // 
            // lbl_Gia
            // 
            this.lbl_Gia.AutoSize = true;
            this.lbl_Gia.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Gia.Location = new System.Drawing.Point(54, 142);
            this.lbl_Gia.Name = "lbl_Gia";
            this.lbl_Gia.Size = new System.Drawing.Size(40, 22);
            this.lbl_Gia.TabIndex = 7;
            this.lbl_Gia.Text = "Giá";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 29);
            this.textBox1.TabIndex = 6;
            // 
            // lbl_TenMon
            // 
            this.lbl_TenMon.AutoSize = true;
            this.lbl_TenMon.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_TenMon.Location = new System.Drawing.Point(18, 94);
            this.lbl_TenMon.Name = "lbl_TenMon";
            this.lbl_TenMon.Size = new System.Drawing.Size(107, 22);
            this.lbl_TenMon.TabIndex = 5;
            this.lbl_TenMon.Text = "Tên món ăn";
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Search.Location = new System.Drawing.Point(7, 200);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(131, 17);
            this.lbl_Search.TabIndex = 4;
            this.lbl_Search.Text = "Tìm kiếm món ăn :";
            // 
            // tbx_Search
            // 
            this.tbx_Search.Location = new System.Drawing.Point(144, 194);
            this.tbx_Search.Name = "tbx_Search";
            this.tbx_Search.Size = new System.Drawing.Size(209, 29);
            this.tbx_Search.TabIndex = 3;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Delete.Location = new System.Drawing.Point(248, 149);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(120, 43);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Xóa món";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Update.Location = new System.Drawing.Point(128, 149);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(120, 45);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "Sửa món";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Add.Location = new System.Drawing.Point(14, 444);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(120, 43);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Thêm món";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Search.Location = new System.Drawing.Point(10, 621);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(163, 22);
            this.lbl_Search.TabIndex = 4;
            this.lbl_Search.Text = "Tìm kiếm món ăn :";
            // 
            // tbx_Search
            // 
            this.tbx_Search.Location = new System.Drawing.Point(183, 614);
            this.tbx_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_Search.Name = "tbx_Search";
            this.tbx_Search.Size = new System.Drawing.Size(223, 35);
            this.tbx_Search.TabIndex = 3;
            this.tbx_Search.TextChanged += new System.EventHandler(this.tbx_Search_TextChanged);
            // 
            // danhMụcMónĂnToolStripMenuItem
            // 
            this.danhMụcMónĂnToolStripMenuItem.Name = "danhMụcMónĂnToolStripMenuItem";
            this.danhMụcMónĂnToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.danhMụcMónĂnToolStripMenuItem.Text = "Danh mục món ăn";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcMónĂnToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1304, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhMụcMónĂnToolStripMenuItem1
            // 
            this.danhMụcMónĂnToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.đồTrênBờToolStripMenuItem,
            this.đồTrênTrờiToolStripMenuItem});
            this.danhMụcMónĂnToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.danhMụcMónĂnToolStripMenuItem1.ForeColor = System.Drawing.Color.Goldenrod;
            this.danhMụcMónĂnToolStripMenuItem1.Name = "danhMụcMónĂnToolStripMenuItem1";
            this.danhMụcMónĂnToolStripMenuItem1.Size = new System.Drawing.Size(146, 27);
            this.danhMụcMónĂnToolStripMenuItem1.Text = "Quản lý chi tiết";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Đồ hải sản";
            // 
            // đồTrênBờToolStripMenuItem
            // 
            this.đồTrênBờToolStripMenuItem.Name = "đồTrênBờToolStripMenuItem";
            this.đồTrênBờToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đồTrênBờToolStripMenuItem.Text = "Đồ trên bờ";
            // 
            // đồTrênTrờiToolStripMenuItem
            // 
            this.đồTrênTrờiToolStripMenuItem.Name = "đồTrênTrờiToolStripMenuItem";
            this.đồTrênTrờiToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.đồTrênTrờiToolStripMenuItem.Text = "Đơn vị tính";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(128, 136);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(256, 35);
            this.numericUpDown1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Danh mục";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(127, 188);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(256, 34);
            this.comboBox1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(18, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cách nấu";
            // 
            // button1
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(127, 247);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(256, 34);
            this.comboBox2.TabIndex = 13;
            // 
            // button2
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(30, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Đơn vị";
            // 
            // button3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(127, 308);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(256, 34);
            this.comboBox3.TabIndex = 13;
            // 
            // FrmQLMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 735);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgrid_MonCT);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmQLMenu";
            this.Text = "FrmQLMenu";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_MonCT)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrid_MonCT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.TextBox tbx_Search;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lbl_Gia;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_TenMon;
        private System.Windows.Forms.RadioButton rdo_khongHoatDong;
        private System.Windows.Forms.RadioButton rdo_hoatDong;
        private System.Windows.Forms.Label lbl_TrangThai;
        private System.Windows.Forms.ToolStripMenuItem danhMụcMónĂnToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcMónĂnToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem đồTrênBờToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đồTrênTrờiToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}