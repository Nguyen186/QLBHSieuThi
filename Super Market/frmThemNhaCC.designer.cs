namespace Super_Market
{
    partial class frmThemNhaCC
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
            this.txtMatHangCC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDienThoai = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtDiachi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMatHangCC
            // 
            this.txtMatHangCC.Location = new System.Drawing.Point(125, 168);
            this.txtMatHangCC.Name = "txtMatHangCC";
            this.txtMatHangCC.Size = new System.Drawing.Size(148, 20);
            this.txtMatHangCC.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(20, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Mặt hàng cung cấp";
            // 
            // TxtDienThoai
            // 
            this.TxtDienThoai.Location = new System.Drawing.Point(125, 121);
            this.TxtDienThoai.Name = "TxtDienThoai";
            this.TxtDienThoai.Size = new System.Drawing.Size(148, 20);
            this.TxtDienThoai.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(20, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Điện thoại";
            // 
            // TxtDiachi
            // 
            this.TxtDiachi.Location = new System.Drawing.Point(125, 74);
            this.TxtDiachi.Name = "TxtDiachi";
            this.TxtDiachi.Size = new System.Drawing.Size(148, 20);
            this.TxtDiachi.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(20, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Đỉa chỉ";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(125, 34);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(148, 20);
            this.TxtName.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(20, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Tên nhà cung cấp";
            // 
            // BtnOK
            // 
            this.BtnOK.BackColor = System.Drawing.SystemColors.Info;
            this.BtnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnOK.Location = new System.Drawing.Point(67, 211);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 27);
            this.BtnOK.TabIndex = 29;
            this.BtnOK.Text = "&OK";
            this.BtnOK.UseVisualStyleBackColor = false;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnDong
            // 
            this.BtnDong.BackColor = System.Drawing.SystemColors.Info;
            this.BtnDong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDong.Location = new System.Drawing.Point(168, 211);
            this.BtnDong.Name = "BtnDong";
            this.BtnDong.Size = new System.Drawing.Size(75, 27);
            this.BtnDong.TabIndex = 30;
            this.BtnDong.Text = "&Đóng";
            this.BtnDong.UseVisualStyleBackColor = false;
            this.BtnDong.Click += new System.EventHandler(this.BtnDong_Click);
            // 
            // frmThemNhaCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(292, 272);
            this.Controls.Add(this.BtnDong);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.txtMatHangCC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtDienThoai);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TxtDiachi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label6);
            this.MaximizeBox = false;
            this.Name = "frmThemNhaCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm nhà cung cấp";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMatHangCC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDienThoai;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtDiachi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnDong;

    }
}