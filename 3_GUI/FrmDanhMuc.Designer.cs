
namespace _3_GUI
{
    partial class FrmDanhMuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDanhMuc));
            this.rbtn_KHDdanhmuc = new System.Windows.Forms.RadioButton();
            this.rbtn_HDdanhmuc = new System.Windows.Forms.RadioButton();
            this.dgvDanhMuc = new System.Windows.Forms.DataGridView();
            this.label18 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTimkiemDM = new System.Windows.Forms.TextBox();
            this.txtTenDanhMuc = new System.Windows.Forms.TextBox();
            this.txtMaDanhMuc = new System.Windows.Forms.TextBox();
            this.btnXoaNhom = new System.Windows.Forms.Button();
            this.btnSuaNhom = new System.Windows.Forms.Button();
            this.btnThemNhom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtn_KHDdanhmuc
            // 
            this.rbtn_KHDdanhmuc.AutoSize = true;
            this.rbtn_KHDdanhmuc.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtn_KHDdanhmuc.ForeColor = System.Drawing.Color.White;
            this.rbtn_KHDdanhmuc.Location = new System.Drawing.Point(495, 179);
            this.rbtn_KHDdanhmuc.Name = "rbtn_KHDdanhmuc";
            this.rbtn_KHDdanhmuc.Size = new System.Drawing.Size(132, 21);
            this.rbtn_KHDdanhmuc.TabIndex = 48;
            this.rbtn_KHDdanhmuc.TabStop = true;
            this.rbtn_KHDdanhmuc.Text = "Không hoạt động";
            this.rbtn_KHDdanhmuc.UseVisualStyleBackColor = true;
            // 
            // rbtn_HDdanhmuc
            // 
            this.rbtn_HDdanhmuc.AutoSize = true;
            this.rbtn_HDdanhmuc.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtn_HDdanhmuc.ForeColor = System.Drawing.Color.White;
            this.rbtn_HDdanhmuc.Location = new System.Drawing.Point(356, 178);
            this.rbtn_HDdanhmuc.Name = "rbtn_HDdanhmuc";
            this.rbtn_HDdanhmuc.Size = new System.Drawing.Size(92, 21);
            this.rbtn_HDdanhmuc.TabIndex = 49;
            this.rbtn_HDdanhmuc.TabStop = true;
            this.rbtn_HDdanhmuc.Text = "Hoạt động";
            this.rbtn_HDdanhmuc.UseVisualStyleBackColor = true;
            // 
            // dgvDanhMuc
            // 
            this.dgvDanhMuc.AllowUserToResizeRows = false;
            this.dgvDanhMuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhMuc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvDanhMuc.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvDanhMuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDanhMuc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvDanhMuc.Location = new System.Drawing.Point(19, 285);
            this.dgvDanhMuc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDanhMuc.MultiSelect = false;
            this.dgvDanhMuc.Name = "dgvDanhMuc";
            this.dgvDanhMuc.ReadOnly = true;
            this.dgvDanhMuc.RowHeadersVisible = false;
            this.dgvDanhMuc.RowHeadersWidth = 51;
            this.dgvDanhMuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhMuc.Size = new System.Drawing.Size(866, 474);
            this.dgvDanhMuc.TabIndex = 41;
            this.dgvDanhMuc.TabStop = false;
            this.dgvDanhMuc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhMuc_CellClick);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(530, 253);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 23);
            this.label18.TabIndex = 43;
            this.label18.Text = "Tìm kiếm :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(215, 179);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 23);
            this.label6.TabIndex = 44;
            this.label6.Text = "Trạng thái :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(213, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 23);
            this.label5.TabIndex = 45;
            this.label5.Text = "Tên Danh Mục";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(213, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 23);
            this.label4.TabIndex = 47;
            this.label4.Text = "Mã Danh Mục";
            // 
            // txtTimkiemDM
            // 
            this.txtTimkiemDM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimkiemDM.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTimkiemDM.ForeColor = System.Drawing.Color.Black;
            this.txtTimkiemDM.Location = new System.Drawing.Point(654, 250);
            this.txtTimkiemDM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimkiemDM.Name = "txtTimkiemDM";
            this.txtTimkiemDM.PlaceholderText = "Mời bạn nhập tên danh mục";
            this.txtTimkiemDM.Size = new System.Drawing.Size(225, 30);
            this.txtTimkiemDM.TabIndex = 36;
            this.txtTimkiemDM.TextChanged += new System.EventHandler(this.txtTimkiemDM_TextChanged);
            // 
            // txtTenDanhMuc
            // 
            this.txtTenDanhMuc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenDanhMuc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTenDanhMuc.ForeColor = System.Drawing.Color.Black;
            this.txtTenDanhMuc.Location = new System.Drawing.Point(339, 126);
            this.txtTenDanhMuc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenDanhMuc.Name = "txtTenDanhMuc";
            this.txtTenDanhMuc.Size = new System.Drawing.Size(256, 30);
            this.txtTenDanhMuc.TabIndex = 37;
            // 
            // txtMaDanhMuc
            // 
            this.txtMaDanhMuc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtMaDanhMuc.Cursor = System.Windows.Forms.Cursors.No;
            this.txtMaDanhMuc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaDanhMuc.ForeColor = System.Drawing.Color.Black;
            this.txtMaDanhMuc.Location = new System.Drawing.Point(339, 82);
            this.txtMaDanhMuc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaDanhMuc.Name = "txtMaDanhMuc";
            this.txtMaDanhMuc.ReadOnly = true;
            this.txtMaDanhMuc.Size = new System.Drawing.Size(256, 30);
            this.txtMaDanhMuc.TabIndex = 46;
            this.txtMaDanhMuc.TabStop = false;
            // 
            // btnXoaNhom
            // 
            this.btnXoaNhom.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnXoaNhom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoaNhom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXoaNhom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.btnXoaNhom.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaNhom.Image")));
            this.btnXoaNhom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaNhom.Location = new System.Drawing.Point(603, 783);
            this.btnXoaNhom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaNhom.Name = "btnXoaNhom";
            this.btnXoaNhom.Size = new System.Drawing.Size(119, 49);
            this.btnXoaNhom.TabIndex = 42;
            this.btnXoaNhom.Text = "Xóa";
            this.btnXoaNhom.UseVisualStyleBackColor = false;
            this.btnXoaNhom.Click += new System.EventHandler(this.btnXoaNhom_Click);
            // 
            // btnSuaNhom
            // 
            this.btnSuaNhom.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSuaNhom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSuaNhom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSuaNhom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.btnSuaNhom.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaNhom.Image")));
            this.btnSuaNhom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaNhom.Location = new System.Drawing.Point(394, 783);
            this.btnSuaNhom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSuaNhom.Name = "btnSuaNhom";
            this.btnSuaNhom.Size = new System.Drawing.Size(119, 49);
            this.btnSuaNhom.TabIndex = 40;
            this.btnSuaNhom.Text = "Sửa";
            this.btnSuaNhom.UseVisualStyleBackColor = false;
            this.btnSuaNhom.Click += new System.EventHandler(this.btnSuaNhom_Click);
            // 
            // btnThemNhom
            // 
            this.btnThemNhom.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnThemNhom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThemNhom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThemNhom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.btnThemNhom.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNhom.Image")));
            this.btnThemNhom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemNhom.Location = new System.Drawing.Point(171, 783);
            this.btnThemNhom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemNhom.Name = "btnThemNhom";
            this.btnThemNhom.Size = new System.Drawing.Size(119, 49);
            this.btnThemNhom.TabIndex = 39;
            this.btnThemNhom.Text = "Thêm";
            this.btnThemNhom.UseVisualStyleBackColor = false;
            this.btnThemNhom.Click += new System.EventHandler(this.btnThemNhom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(371, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 34);
            this.label1.TabIndex = 38;
            this.label1.Text = "DANH MỤC";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(663, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 138);
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // FrmDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(898, 859);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rbtn_KHDdanhmuc);
            this.Controls.Add(this.rbtn_HDdanhmuc);
            this.Controls.Add(this.dgvDanhMuc);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTimkiemDM);
            this.Controls.Add(this.txtTenDanhMuc);
            this.Controls.Add(this.txtMaDanhMuc);
            this.Controls.Add(this.btnXoaNhom);
            this.Controls.Add(this.btnSuaNhom);
            this.Controls.Add(this.btnThemNhom);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmDanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtn_KHDdanhmuc;
        private System.Windows.Forms.RadioButton rbtn_HDdanhmuc;
        private System.Windows.Forms.DataGridView dgvDanhMuc;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTimkiemDM;
        private System.Windows.Forms.TextBox txtTenDanhMuc;
        private System.Windows.Forms.TextBox txtMaDanhMuc;
        private System.Windows.Forms.Button btnXoaNhom;
        private System.Windows.Forms.Button btnSuaNhom;
        private System.Windows.Forms.Button btnThemNhom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}