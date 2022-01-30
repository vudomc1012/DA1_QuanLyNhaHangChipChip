namespace _3_GUI
{
    partial class FrmQuanLyThucDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyThucDon));
            this.txtTenMonAn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnXoaMon = new System.Windows.Forms.Button();
            this.btnSuaMon = new System.Windows.Forms.Button();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.rbtn_HDthucdon = new System.Windows.Forms.RadioButton();
            this.rbtn_KHDthucdon = new System.Windows.Forms.RadioButton();
            this.txt_TimKiemThucDon = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cbx_Meth = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbx_Cat = new System.Windows.Forms.ComboBox();
            this.cbx_Unit = new System.Windows.Forms.ComboBox();
            this.txt_Price = new System.Windows.Forms.NumericUpDown();
            this.btn_ConfigUnit = new System.Windows.Forms.Button();
            this.btn_ConfigMeth = new System.Windows.Forms.Button();
            this.btn_ConfigCat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_GC = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxHinhAnh = new System.Windows.Forms.PictureBox();
            this.btnMoAnh = new System.Windows.Forms.Button();
            this.btnResetAnh = new System.Windows.Forms.Button();
            this.txtHinhAnh = new System.Windows.Forms.TextBox();
            this.dgvMonAn = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Price)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHinhAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenMonAn
            // 
            this.txtTenMonAn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTenMonAn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenMonAn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTenMonAn.ForeColor = System.Drawing.Color.Black;
            this.txtTenMonAn.Location = new System.Drawing.Point(161, 49);
            this.txtTenMonAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenMonAn.Name = "txtTenMonAn";
            this.txtTenMonAn.Size = new System.Drawing.Size(205, 30);
            this.txtTenMonAn.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(36, 50);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 11;
            this.label8.Text = "Tên món ăn";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(36, 97);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 23);
            this.label9.TabIndex = 15;
            this.label9.Text = "Giá tiền";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(36, 151);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 23);
            this.label12.TabIndex = 13;
            this.label12.Text = "Đơn vị tính";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(373, 101);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = " VNĐ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1923, 111);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 20);
            this.label14.TabIndex = 34;
            this.label14.Text = "label14";
            // 
            // btnXoaMon
            // 
            this.btnXoaMon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaMon.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnXoaMon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoaMon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaMon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXoaMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.btnXoaMon.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaMon.Image")));
            this.btnXoaMon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaMon.Location = new System.Drawing.Point(954, 605);
            this.btnXoaMon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaMon.Name = "btnXoaMon";
            this.btnXoaMon.Size = new System.Drawing.Size(119, 49);
            this.btnXoaMon.TabIndex = 10;
            this.btnXoaMon.Text = "Xóa";
            this.btnXoaMon.UseVisualStyleBackColor = false;
            this.btnXoaMon.Click += new System.EventHandler(this.btnXoaMon_Click);
            // 
            // btnSuaMon
            // 
            this.btnSuaMon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaMon.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSuaMon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSuaMon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaMon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSuaMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.btnSuaMon.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaMon.Image")));
            this.btnSuaMon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaMon.Location = new System.Drawing.Point(749, 605);
            this.btnSuaMon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSuaMon.Name = "btnSuaMon";
            this.btnSuaMon.Size = new System.Drawing.Size(119, 49);
            this.btnSuaMon.TabIndex = 9;
            this.btnSuaMon.Text = "Sửa";
            this.btnSuaMon.UseVisualStyleBackColor = false;
            this.btnSuaMon.Click += new System.EventHandler(this.btnSuaMon_Click);
            // 
            // btnThemMon
            // 
            this.btnThemMon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemMon.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnThemMon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThemMon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemMon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThemMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.btnThemMon.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMon.Image")));
            this.btnThemMon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMon.Location = new System.Drawing.Point(528, 605);
            this.btnThemMon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(119, 49);
            this.btnThemMon.TabIndex = 8;
            this.btnThemMon.Text = "Thêm";
            this.btnThemMon.UseVisualStyleBackColor = false;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(36, 301);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 23);
            this.label15.TabIndex = 11;
            this.label15.Text = "Cách nấu";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(38, 203);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 23);
            this.label17.TabIndex = 5;
            this.label17.Text = "Trạng thái ";
            // 
            // rbtn_HDthucdon
            // 
            this.rbtn_HDthucdon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rbtn_HDthucdon.AutoSize = true;
            this.rbtn_HDthucdon.ForeColor = System.Drawing.Color.White;
            this.rbtn_HDthucdon.Location = new System.Drawing.Point(161, 203);
            this.rbtn_HDthucdon.Name = "rbtn_HDthucdon";
            this.rbtn_HDthucdon.Size = new System.Drawing.Size(102, 24);
            this.rbtn_HDthucdon.TabIndex = 35;
            this.rbtn_HDthucdon.TabStop = true;
            this.rbtn_HDthucdon.Text = "Hoạt động";
            this.rbtn_HDthucdon.UseVisualStyleBackColor = true;
            // 
            // rbtn_KHDthucdon
            // 
            this.rbtn_KHDthucdon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rbtn_KHDthucdon.AutoSize = true;
            this.rbtn_KHDthucdon.ForeColor = System.Drawing.Color.White;
            this.rbtn_KHDthucdon.Location = new System.Drawing.Point(274, 203);
            this.rbtn_KHDthucdon.Name = "rbtn_KHDthucdon";
            this.rbtn_KHDthucdon.Size = new System.Drawing.Size(146, 24);
            this.rbtn_KHDthucdon.TabIndex = 35;
            this.rbtn_KHDthucdon.TabStop = true;
            this.rbtn_KHDthucdon.Text = "Không hoạt động";
            this.rbtn_KHDthucdon.UseVisualStyleBackColor = true;
            // 
            // txt_TimKiemThucDon
            // 
            this.txt_TimKiemThucDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_TimKiemThucDon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TimKiemThucDon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TimKiemThucDon.ForeColor = System.Drawing.Color.Black;
            this.txt_TimKiemThucDon.Location = new System.Drawing.Point(898, 13);
            this.txt_TimKiemThucDon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_TimKiemThucDon.Name = "txt_TimKiemThucDon";
            this.txt_TimKiemThucDon.PlaceholderText = "Mời nhập tên món ăn";
            this.txt_TimKiemThucDon.Size = new System.Drawing.Size(225, 30);
            this.txt_TimKiemThucDon.TabIndex = 0;
            this.txt_TimKiemThucDon.TextChanged += new System.EventHandler(this.txt_TimKiemThucDon_TextChanged);
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(788, 13);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 20);
            this.label19.TabIndex = 5;
            this.label19.Text = "Tìm kiếm :";
            // 
            // cbx_Meth
            // 
            this.cbx_Meth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbx_Meth.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbx_Meth.FormattingEnabled = true;
            this.cbx_Meth.Location = new System.Drawing.Point(161, 301);
            this.cbx_Meth.Name = "cbx_Meth";
            this.cbx_Meth.Size = new System.Drawing.Size(205, 31);
            this.cbx_Meth.TabIndex = 36;
            this.cbx_Meth.DropDown += new System.EventHandler(this.cbx_Meth_DropDown);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(36, 253);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Danh mục";
            // 
            // cbx_Cat
            // 
            this.cbx_Cat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbx_Cat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbx_Cat.FormattingEnabled = true;
            this.cbx_Cat.Location = new System.Drawing.Point(161, 251);
            this.cbx_Cat.Name = "cbx_Cat";
            this.cbx_Cat.Size = new System.Drawing.Size(205, 31);
            this.cbx_Cat.TabIndex = 36;
            this.cbx_Cat.DropDown += new System.EventHandler(this.cbx_Cat_DropDown);
            // 
            // cbx_Unit
            // 
            this.cbx_Unit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbx_Unit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbx_Unit.FormattingEnabled = true;
            this.cbx_Unit.Location = new System.Drawing.Point(161, 149);
            this.cbx_Unit.Name = "cbx_Unit";
            this.cbx_Unit.Size = new System.Drawing.Size(205, 31);
            this.cbx_Unit.TabIndex = 36;
            this.cbx_Unit.DropDown += new System.EventHandler(this.cbx_Unit_DropDown);
            // 
            // txt_Price
            // 
            this.txt_Price.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_Price.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Price.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txt_Price.Location = new System.Drawing.Point(161, 97);
            this.txt_Price.Maximum = new decimal(new int[] {
            999000000,
            0,
            0,
            0});
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(205, 30);
            this.txt_Price.TabIndex = 37;
            // 
            // btn_ConfigUnit
            // 
            this.btn_ConfigUnit.BackgroundImage = global::_3_GUI.Properties.Resources._568239;
            this.btn_ConfigUnit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ConfigUnit.Location = new System.Drawing.Point(383, 151);
            this.btn_ConfigUnit.Name = "btn_ConfigUnit";
            this.btn_ConfigUnit.Size = new System.Drawing.Size(29, 29);
            this.btn_ConfigUnit.TabIndex = 64;
            this.btn_ConfigUnit.UseVisualStyleBackColor = true;
            this.btn_ConfigUnit.Click += new System.EventHandler(this.btn_ConfigUnit_Click);
            // 
            // btn_ConfigMeth
            // 
            this.btn_ConfigMeth.BackgroundImage = global::_3_GUI.Properties.Resources._568239;
            this.btn_ConfigMeth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ConfigMeth.Location = new System.Drawing.Point(383, 303);
            this.btn_ConfigMeth.Name = "btn_ConfigMeth";
            this.btn_ConfigMeth.Size = new System.Drawing.Size(29, 29);
            this.btn_ConfigMeth.TabIndex = 64;
            this.btn_ConfigMeth.UseVisualStyleBackColor = true;
            this.btn_ConfigMeth.Click += new System.EventHandler(this.btn_ConfigMeth_Click);
            // 
            // btn_ConfigCat
            // 
            this.btn_ConfigCat.BackgroundImage = global::_3_GUI.Properties.Resources._568239;
            this.btn_ConfigCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ConfigCat.Location = new System.Drawing.Point(383, 253);
            this.btn_ConfigCat.Name = "btn_ConfigCat";
            this.btn_ConfigCat.Size = new System.Drawing.Size(29, 29);
            this.btn_ConfigCat.TabIndex = 64;
            this.btn_ConfigCat.UseVisualStyleBackColor = true;
            this.btn_ConfigCat.Click += new System.EventHandler(this.btn_ConfigCat_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 360);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 23);
            this.label1.TabIndex = 66;
            this.label1.Text = "Mô tả";
            // 
            // txt_GC
            // 
            this.txt_GC.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_GC.Location = new System.Drawing.Point(161, 357);
            this.txt_GC.Multiline = true;
            this.txt_GC.Name = "txt_GC";
            this.txt_GC.Size = new System.Drawing.Size(259, 51);
            this.txt_GC.TabIndex = 67;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBoxHinhAnh);
            this.panel1.Controls.Add(this.btnMoAnh);
            this.panel1.Controls.Add(this.btnResetAnh);
            this.panel1.Controls.Add(this.txtTenMonAn);
            this.panel1.Controls.Add(this.txt_GC);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtHinhAnh);
            this.panel1.Controls.Add(this.btn_ConfigCat);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.btn_ConfigMeth);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btn_ConfigUnit);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txt_Price);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cbx_Unit);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.cbx_Cat);
            this.panel1.Controls.Add(this.rbtn_HDthucdon);
            this.panel1.Controls.Add(this.cbx_Meth);
            this.panel1.Controls.Add(this.rbtn_KHDthucdon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 668);
            this.panel1.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 70;
            this.label2.Text = "Hình Ảnh";
            // 
            // pictureBoxHinhAnh
            // 
            this.pictureBoxHinhAnh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxHinhAnh.Location = new System.Drawing.Point(36, 428);
            this.pictureBoxHinhAnh.Name = "pictureBoxHinhAnh";
            this.pictureBoxHinhAnh.Size = new System.Drawing.Size(384, 195);
            this.pictureBoxHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHinhAnh.TabIndex = 68;
            this.pictureBoxHinhAnh.TabStop = false;
            // 
            // btnMoAnh
            // 
            this.btnMoAnh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMoAnh.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnMoAnh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.btnMoAnh.Location = new System.Drawing.Point(85, 629);
            this.btnMoAnh.Name = "btnMoAnh";
            this.btnMoAnh.Size = new System.Drawing.Size(94, 27);
            this.btnMoAnh.TabIndex = 69;
            this.btnMoAnh.Text = "Mở  ảnh";
            this.btnMoAnh.UseVisualStyleBackColor = false;
            this.btnMoAnh.Click += new System.EventHandler(this.btnMoAnh_Click);
            // 
            // btnResetAnh
            // 
            this.btnResetAnh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnResetAnh.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnResetAnh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.btnResetAnh.Location = new System.Drawing.Point(272, 628);
            this.btnResetAnh.Name = "btnResetAnh";
            this.btnResetAnh.Size = new System.Drawing.Size(94, 27);
            this.btnResetAnh.TabIndex = 69;
            this.btnResetAnh.Text = "Reset ảnh";
            this.btnResetAnh.UseVisualStyleBackColor = false;
            this.btnResetAnh.Click += new System.EventHandler(this.btnResetAnh_Click);
            // 
            // txtHinhAnh
            // 
            this.txtHinhAnh.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHinhAnh.Location = new System.Drawing.Point(119, 661);
            this.txtHinhAnh.Multiline = true;
            this.txtHinhAnh.Name = "txtHinhAnh";
            this.txtHinhAnh.Size = new System.Drawing.Size(205, 29);
            this.txtHinhAnh.TabIndex = 67;
            this.txtHinhAnh.Visible = false;
            // 
            // dgvMonAn
            // 
            this.dgvMonAn.AllowUserToResizeRows = false;
            this.dgvMonAn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMonAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonAn.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvMonAn.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvMonAn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMonAn.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonAn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvMonAn.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvMonAn.Location = new System.Drawing.Point(464, 49);
            this.dgvMonAn.Margin = new System.Windows.Forms.Padding(5);
            this.dgvMonAn.MultiSelect = false;
            this.dgvMonAn.Name = "dgvMonAn";
            this.dgvMonAn.ReadOnly = true;
            this.dgvMonAn.RowHeadersVisible = false;
            this.dgvMonAn.RowHeadersWidth = 51;
            this.dgvMonAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonAn.Size = new System.Drawing.Size(658, 546);
            this.dgvMonAn.TabIndex = 69;
            this.dgvMonAn.TabStop = false;
            this.dgvMonAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonAn_CellClick);
            // 
            // FrmQuanLyThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(1136, 668);
            this.Controls.Add(this.dgvMonAn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txt_TimKiemThucDon);
            this.Controls.Add(this.btnXoaMon);
            this.Controls.Add(this.btnSuaMon);
            this.Controls.Add(this.btnThemMon);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmQuanLyThucDon";
            this.ShowInTaskbar = false;
            this.Text = "Quản Lý Thực Đơn";
            ((System.ComponentModel.ISupportInitialize)(this.txt_Price)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHinhAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.Button btnSuaMon;
        private System.Windows.Forms.Button btnXoaMon;
        private System.Windows.Forms.TextBox txtTenMonAn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton rbtn_HDthucdon;
        private System.Windows.Forms.RadioButton rbtn_KHDthucdon;
        private System.Windows.Forms.TextBox txt_TimKiemThucDon;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbx_Meth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbx_Cat;
        private System.Windows.Forms.ComboBox cbx_Unit;
        private System.Windows.Forms.NumericUpDown txt_Price;
        private System.Windows.Forms.Button btn_ConfigUnit;
        private System.Windows.Forms.Button btn_ConfigMeth;
        private System.Windows.Forms.Button btn_ConfigCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_GC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvMonAn;
        private System.Windows.Forms.TextBox txtHinhAnh;
        private System.Windows.Forms.Button btnMoAnh;
        private System.Windows.Forms.Button btnResetAnh;
        private System.Windows.Forms.PictureBox pictureBoxHinhAnh;
        private System.Windows.Forms.Label label2;
    }
}