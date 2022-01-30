
namespace _3_GUI
{
    partial class FrmChuyenBan
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tp_Tang1 = new System.Windows.Forms.TabPage();
            this.FLPenal = new System.Windows.Forms.FlowLayoutPanel();
            this.Tp_Tang2 = new System.Windows.Forms.TabPage();
            this.FlPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.Tp_Tang1.SuspendLayout();
            this.Tp_Tang2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Tp_Tang1);
            this.tabControl1.Controls.Add(this.Tp_Tang2);
            this.tabControl1.Location = new System.Drawing.Point(11, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(843, 373);
            this.tabControl1.TabIndex = 25;
            // 
            // Tp_Tang1
            // 
            this.Tp_Tang1.Controls.Add(this.FLPenal);
            this.Tp_Tang1.Location = new System.Drawing.Point(4, 24);
            this.Tp_Tang1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Tp_Tang1.Name = "Tp_Tang1";
            this.Tp_Tang1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Tp_Tang1.Size = new System.Drawing.Size(835, 345);
            this.Tp_Tang1.TabIndex = 0;
            this.Tp_Tang1.Text = "Tầng 1";
            this.Tp_Tang1.UseVisualStyleBackColor = true;
            // 
            // FLPenal
            // 
            this.FLPenal.Location = new System.Drawing.Point(7, 7);
            this.FLPenal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FLPenal.Name = "FLPenal";
            this.FLPenal.Size = new System.Drawing.Size(824, 314);
            this.FLPenal.TabIndex = 29;
            // 
            // Tp_Tang2
            // 
            this.Tp_Tang2.Controls.Add(this.FlPanel2);
            this.Tp_Tang2.Location = new System.Drawing.Point(4, 24);
            this.Tp_Tang2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Tp_Tang2.Name = "Tp_Tang2";
            this.Tp_Tang2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tp_Tang2.Size = new System.Drawing.Size(835, 345);
            this.Tp_Tang2.TabIndex = 1;
            this.Tp_Tang2.Text = "Tầng 2";
            this.Tp_Tang2.UseVisualStyleBackColor = true;
            // 
            // FlPanel2
            // 
            this.FlPanel2.Location = new System.Drawing.Point(6, 7);
            this.FlPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FlPanel2.Name = "FlPanel2";
            this.FlPanel2.Size = new System.Drawing.Size(824, 332);
            this.FlPanel2.TabIndex = 36;
            // 
            // FrmChuyenBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(863, 390);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmChuyenBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuyển bàn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmChuyenBan_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.Tp_Tang1.ResumeLayout(false);
            this.Tp_Tang2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Tp_Tang1;
        private System.Windows.Forms.FlowLayoutPanel FLPenal;
        private System.Windows.Forms.TabPage Tp_Tang2;
        private System.Windows.Forms.FlowLayoutPanel FlPanel2;
    }
}