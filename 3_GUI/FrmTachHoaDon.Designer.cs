
namespace _3_GUI
{
    partial class FrmTachHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTachHoaDon));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Dgrid_HDCu = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Dgrid_HDMoi = new System.Windows.Forms.DataGridView();
            this.Btn_TaoHD = new System.Windows.Forms.Button();
            this.Btn_XacNhan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_TongTien = new System.Windows.Forms.Label();
            this.Lbl_Tien = new System.Windows.Forms.Label();
            this.Txt_Tien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Lbl_TienCu = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgrid_HDCu)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgrid_HDMoi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Dgrid_HDCu);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(14, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Size = new System.Drawing.Size(570, 658);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // Dgrid_HDCu
            // 
            this.Dgrid_HDCu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgrid_HDCu.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Dgrid_HDCu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgrid_HDCu.Location = new System.Drawing.Point(7, 29);
            this.Dgrid_HDCu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dgrid_HDCu.Name = "Dgrid_HDCu";
            this.Dgrid_HDCu.RowHeadersWidth = 51;
            this.Dgrid_HDCu.RowTemplate.Height = 25;
            this.Dgrid_HDCu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgrid_HDCu.Size = new System.Drawing.Size(555, 616);
            this.Dgrid_HDCu.TabIndex = 0;
            this.Dgrid_HDCu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgrid_HDCu_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Dgrid_HDMoi);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(752, 37);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox2.Size = new System.Drawing.Size(570, 663);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // Dgrid_HDMoi
            // 
            this.Dgrid_HDMoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgrid_HDMoi.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Dgrid_HDMoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgrid_HDMoi.Location = new System.Drawing.Point(16, 33);
            this.Dgrid_HDMoi.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Dgrid_HDMoi.Name = "Dgrid_HDMoi";
            this.Dgrid_HDMoi.RowHeadersWidth = 51;
            this.Dgrid_HDMoi.RowTemplate.Height = 25;
            this.Dgrid_HDMoi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgrid_HDMoi.Size = new System.Drawing.Size(539, 616);
            this.Dgrid_HDMoi.TabIndex = 1;
            this.Dgrid_HDMoi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgrid_HDMoi_CellClick);
            // 
            // Btn_TaoHD
            // 
            this.Btn_TaoHD.BackColor = System.Drawing.Color.LavenderBlush;
            this.Btn_TaoHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.Btn_TaoHD.Image = ((System.Drawing.Image)(resources.GetObject("Btn_TaoHD.Image")));
            this.Btn_TaoHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_TaoHD.Location = new System.Drawing.Point(602, 292);
            this.Btn_TaoHD.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Btn_TaoHD.Name = "Btn_TaoHD";
            this.Btn_TaoHD.Size = new System.Drawing.Size(127, 49);
            this.Btn_TaoHD.TabIndex = 2;
            this.Btn_TaoHD.Text = "Tạo Hóa Đơn";
            this.Btn_TaoHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_TaoHD.UseVisualStyleBackColor = false;
            this.Btn_TaoHD.Click += new System.EventHandler(this.Btn_TaoHD_Click);
            // 
            // Btn_XacNhan
            // 
            this.Btn_XacNhan.BackColor = System.Drawing.Color.LavenderBlush;
            this.Btn_XacNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.Btn_XacNhan.Image = ((System.Drawing.Image)(resources.GetObject("Btn_XacNhan.Image")));
            this.Btn_XacNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_XacNhan.Location = new System.Drawing.Point(1203, 713);
            this.Btn_XacNhan.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Btn_XacNhan.Name = "Btn_XacNhan";
            this.Btn_XacNhan.Size = new System.Drawing.Size(119, 49);
            this.Btn_XacNhan.TabIndex = 3;
            this.Btn_XacNhan.Text = "Thanh toán";
            this.Btn_XacNhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_XacNhan.UseVisualStyleBackColor = false;
            this.Btn_XacNhan.Click += new System.EventHandler(this.Btn_XacNhan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(594, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tổng tiền:";
            // 
            // Lbl_TongTien
            // 
            this.Lbl_TongTien.AutoSize = true;
            this.Lbl_TongTien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_TongTien.ForeColor = System.Drawing.Color.Red;
            this.Lbl_TongTien.Location = new System.Drawing.Point(697, 419);
            this.Lbl_TongTien.Name = "Lbl_TongTien";
            this.Lbl_TongTien.Size = new System.Drawing.Size(52, 21);
            this.Lbl_TongTien.TabIndex = 5;
            this.Lbl_TongTien.Text = "label2";
            // 
            // Lbl_Tien
            // 
            this.Lbl_Tien.AutoSize = true;
            this.Lbl_Tien.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Tien.ForeColor = System.Drawing.Color.White;
            this.Lbl_Tien.Location = new System.Drawing.Point(953, 727);
            this.Lbl_Tien.Name = "Lbl_Tien";
            this.Lbl_Tien.Size = new System.Drawing.Size(81, 35);
            this.Lbl_Tien.TabIndex = 4;
            this.Lbl_Tien.Text = "label2";
            // 
            // Txt_Tien
            // 
            this.Txt_Tien.Location = new System.Drawing.Point(740, 728);
            this.Txt_Tien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_Tien.Name = "Txt_Tien";
            this.Txt_Tien.Size = new System.Drawing.Size(163, 27);
            this.Txt_Tien.TabIndex = 5;
            this.Txt_Tien.TextChanged += new System.EventHandler(this.Txt_Tien_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(584, 732);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tiền khách đưa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(20, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hóa Đơn cũ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(752, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hóa Đơn mới :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(166, 722);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tổng tiền :";
            // 
            // Lbl_TienCu
            // 
            this.Lbl_TienCu.AutoSize = true;
            this.Lbl_TienCu.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_TienCu.ForeColor = System.Drawing.Color.White;
            this.Lbl_TienCu.Location = new System.Drawing.Point(288, 716);
            this.Lbl_TienCu.Name = "Lbl_TienCu";
            this.Lbl_TienCu.Size = new System.Drawing.Size(81, 35);
            this.Lbl_TienCu.TabIndex = 8;
            this.Lbl_TienCu.Text = "label2";
            // 
            // FrmTachHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(1337, 788);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Lbl_TienCu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Tien);
            this.Controls.Add(this.Lbl_Tien);
            this.Controls.Add(this.Btn_XacNhan);
            this.Controls.Add(this.Btn_TaoHD);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FrmTachHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tách hóa đơn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTachHoaDon_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmTachHoaDon_FormClosed);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgrid_HDCu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgrid_HDMoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Dgrid_HDCu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Dgrid_HDMoi;
        private System.Windows.Forms.Button Btn_TaoHD;
        private System.Windows.Forms.Button Btn_XacNhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_TongTien;
        private System.Windows.Forms.Label Lbl_Tien;
        private System.Windows.Forms.TextBox Txt_Tien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Lbl_TienCu;
    }
}