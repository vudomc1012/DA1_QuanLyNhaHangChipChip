
namespace _3_GUI
{
    partial class FrmQuanLyHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyHoaDon));
            this.Dgid_HoaDon = new System.Windows.Forms.DataGridView();
            this.btn_danhsach = new System.Windows.Forms.Button();
            this.btn_thongKe = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dgrid_hdct = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Lbl_TongHoaDon = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Lbl_DaThanhToan = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Lbl_DaHuy = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Lbl_DoanhThu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgid_HoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_hdct)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgid_HoaDon
            // 
            this.Dgid_HoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgid_HoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgid_HoaDon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.Dgid_HoaDon.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Dgid_HoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgid_HoaDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.Dgid_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgid_HoaDon.Location = new System.Drawing.Point(21, 123);
            this.Dgid_HoaDon.Name = "Dgid_HoaDon";
            this.Dgid_HoaDon.RowHeadersWidth = 51;
            this.Dgid_HoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgid_HoaDon.Size = new System.Drawing.Size(617, 448);
            this.Dgid_HoaDon.TabIndex = 33;
            this.Dgid_HoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgid_HoaDon_CellClick);
            // 
            // btn_danhsach
            // 
            this.btn_danhsach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_danhsach.BackColor = System.Drawing.Color.LavenderBlush;
            this.btn_danhsach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_danhsach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.btn_danhsach.Image = ((System.Drawing.Image)(resources.GetObject("btn_danhsach.Image")));
            this.btn_danhsach.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_danhsach.Location = new System.Drawing.Point(521, 73);
            this.btn_danhsach.Name = "btn_danhsach";
            this.btn_danhsach.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_danhsach.Size = new System.Drawing.Size(117, 33);
            this.btn_danhsach.TabIndex = 31;
            this.btn_danhsach.Text = "Danh Sách";
            this.btn_danhsach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_danhsach.UseVisualStyleBackColor = false;
            this.btn_danhsach.Click += new System.EventHandler(this.btn_danhsach_Click);
            // 
            // btn_thongKe
            // 
            this.btn_thongKe.BackColor = System.Drawing.Color.LavenderBlush;
            this.btn_thongKe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_thongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_thongKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.btn_thongKe.Image = ((System.Drawing.Image)(resources.GetObject("btn_thongKe.Image")));
            this.btn_thongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_thongKe.Location = new System.Drawing.Point(521, 13);
            this.btn_thongKe.Name = "btn_thongKe";
            this.btn_thongKe.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_thongKe.Size = new System.Drawing.Size(117, 33);
            this.btn_thongKe.TabIndex = 30;
            this.btn_thongKe.Text = "Thống kê";
            this.btn_thongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thongKe.UseVisualStyleBackColor = false;
            this.btn_thongKe.Click += new System.EventHandler(this.btn_thongKe_Click_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.MenuBar;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.Control;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.AntiqueWhite;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.SystemColors.Control;
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(91, 19);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker1.Size = new System.Drawing.Size(146, 27);
            this.dateTimePicker1.TabIndex = 36;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateTimePicker2.CalendarTitleForeColor = System.Drawing.Color.AntiqueWhite;
            this.dateTimePicker2.CalendarTrailingForeColor = System.Drawing.SystemColors.Control;
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(370, 17);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker2.Size = new System.Drawing.Size(130, 27);
            this.dateTimePicker2.TabIndex = 37;
            // 
            // dgrid_hdct
            // 
            this.dgrid_hdct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrid_hdct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_hdct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgrid_hdct.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgrid_hdct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrid_hdct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgrid_hdct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_hdct.Location = new System.Drawing.Point(682, 123);
            this.dgrid_hdct.Name = "dgrid_hdct";
            this.dgrid_hdct.RowHeadersWidth = 51;
            this.dgrid_hdct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_hdct.Size = new System.Drawing.Size(442, 448);
            this.dgrid_hdct.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Từ ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(289, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Đến ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 132;
            this.label3.Text = "Hóa đơn :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(682, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 23);
            this.label4.TabIndex = 132;
            this.label4.Text = "Chi tiết hóa đơn :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 616);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 28);
            this.label5.TabIndex = 133;
            this.label5.Text = "Số hóa đơn:";
            // 
            // Lbl_TongHoaDon
            // 
            this.Lbl_TongHoaDon.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Lbl_TongHoaDon.AutoSize = true;
            this.Lbl_TongHoaDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_TongHoaDon.ForeColor = System.Drawing.Color.White;
            this.Lbl_TongHoaDon.Location = new System.Drawing.Point(134, 616);
            this.Lbl_TongHoaDon.Name = "Lbl_TongHoaDon";
            this.Lbl_TongHoaDon.Size = new System.Drawing.Size(65, 28);
            this.Lbl_TongHoaDon.TabIndex = 134;
            this.Lbl_TongHoaDon.Text = "label6";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(271, 616);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 28);
            this.label7.TabIndex = 135;
            this.label7.Text = "Đã thanh toán:";
            // 
            // Lbl_DaThanhToan
            // 
            this.Lbl_DaThanhToan.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Lbl_DaThanhToan.AutoSize = true;
            this.Lbl_DaThanhToan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_DaThanhToan.ForeColor = System.Drawing.Color.White;
            this.Lbl_DaThanhToan.Location = new System.Drawing.Point(405, 616);
            this.Lbl_DaThanhToan.Name = "Lbl_DaThanhToan";
            this.Lbl_DaThanhToan.Size = new System.Drawing.Size(65, 28);
            this.Lbl_DaThanhToan.TabIndex = 136;
            this.Lbl_DaThanhToan.Text = "label8";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(567, 616);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 28);
            this.label9.TabIndex = 137;
            this.label9.Text = "Đã hủy:";
            // 
            // Lbl_DaHuy
            // 
            this.Lbl_DaHuy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Lbl_DaHuy.AutoSize = true;
            this.Lbl_DaHuy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_DaHuy.ForeColor = System.Drawing.Color.White;
            this.Lbl_DaHuy.Location = new System.Drawing.Point(656, 616);
            this.Lbl_DaHuy.Name = "Lbl_DaHuy";
            this.Lbl_DaHuy.Size = new System.Drawing.Size(76, 28);
            this.Lbl_DaHuy.TabIndex = 138;
            this.Lbl_DaHuy.Text = "label10";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(837, 616);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 28);
            this.label11.TabIndex = 139;
            this.label11.Text = "Doanh Thu:";
            // 
            // Lbl_DoanhThu
            // 
            this.Lbl_DoanhThu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Lbl_DoanhThu.AutoSize = true;
            this.Lbl_DoanhThu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_DoanhThu.ForeColor = System.Drawing.Color.White;
            this.Lbl_DoanhThu.Location = new System.Drawing.Point(945, 616);
            this.Lbl_DoanhThu.Name = "Lbl_DoanhThu";
            this.Lbl_DoanhThu.Size = new System.Drawing.Size(76, 28);
            this.Lbl_DoanhThu.TabIndex = 140;
            this.Lbl_DoanhThu.Text = "label12";
            // 
            // FrmQuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1136, 668);
            this.Controls.Add(this.Lbl_DoanhThu);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Lbl_DaHuy);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Lbl_DaThanhToan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Lbl_TongHoaDon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgrid_hdct);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Dgid_HoaDon);
            this.Controls.Add(this.btn_danhsach);
            this.Controls.Add(this.btn_thongKe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmQuanLyHoaDon";
            this.Text = "Thống kê hóa đơn";
            ((System.ComponentModel.ISupportInitialize)(this.Dgid_HoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_hdct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Dgid_HoaDon;
        private System.Windows.Forms.Button btn_danhsach;
        private System.Windows.Forms.Button btn_thongKe;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridView dgrid_hdct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Lbl_TongHoaDon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Lbl_DaThanhToan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Lbl_DaHuy;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Lbl_DoanhThu;
    }
}