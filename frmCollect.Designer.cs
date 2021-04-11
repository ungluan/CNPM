
namespace TestPT
{
    partial class frmCollect
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
            this.panel13 = new System.Windows.Forms.Panel();
            this.txtIDPhongSC5 = new System.Windows.Forms.TextBox();
            this.label128 = new System.Windows.Forms.Label();
            this.lvChiTietHoaDonSC5 = new System.Windows.Forms.ListView();
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnXacNhanDaDong = new System.Windows.Forms.Button();
            this.label134 = new System.Windows.Forms.Label();
            this.label141 = new System.Windows.Forms.Label();
            this.label142 = new System.Windows.Forms.Label();
            this.lvDanhSachHoaDonSC5 = new System.Windows.Forms.ListView();
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbbDaySC5 = new System.Windows.Forms.ComboBox();
            this.label149 = new System.Windows.Forms.Label();
            this.label150 = new System.Windows.Forms.Label();
            this.panel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.txtIDPhongSC5);
            this.panel13.Controls.Add(this.label128);
            this.panel13.Controls.Add(this.lvChiTietHoaDonSC5);
            this.panel13.Controls.Add(this.btnXacNhanDaDong);
            this.panel13.Controls.Add(this.label134);
            this.panel13.Controls.Add(this.label141);
            this.panel13.Controls.Add(this.label142);
            this.panel13.Controls.Add(this.lvDanhSachHoaDonSC5);
            this.panel13.Controls.Add(this.cbbDaySC5);
            this.panel13.Controls.Add(this.label149);
            this.panel13.Controls.Add(this.label150);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1232, 722);
            this.panel13.TabIndex = 65;
            // 
            // txtIDPhongSC5
            // 
            this.txtIDPhongSC5.Location = new System.Drawing.Point(100, 96);
            this.txtIDPhongSC5.Name = "txtIDPhongSC5";
            this.txtIDPhongSC5.Size = new System.Drawing.Size(192, 31);
            this.txtIDPhongSC5.TabIndex = 57;
            this.txtIDPhongSC5.TextChanged += new System.EventHandler(this.txtIDPhongSC5_TextChanged);
            // 
            // label128
            // 
            this.label128.AutoSize = true;
            this.label128.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label128.Location = new System.Drawing.Point(3, 99);
            this.label128.Name = "label128";
            this.label128.Size = new System.Drawing.Size(100, 25);
            this.label128.TabIndex = 56;
            this.label128.Text = "ID Phòng";
            // 
            // lvChiTietHoaDonSC5
            // 
            this.lvChiTietHoaDonSC5.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader23,
            this.columnHeader24,
            this.columnHeader25,
            this.columnHeader1});
            this.lvChiTietHoaDonSC5.HideSelection = false;
            this.lvChiTietHoaDonSC5.Location = new System.Drawing.Point(702, 112);
            this.lvChiTietHoaDonSC5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvChiTietHoaDonSC5.Name = "lvChiTietHoaDonSC5";
            this.lvChiTietHoaDonSC5.Size = new System.Drawing.Size(478, 302);
            this.lvChiTietHoaDonSC5.TabIndex = 55;
            this.lvChiTietHoaDonSC5.UseCompatibleStateImageBehavior = false;
            this.lvChiTietHoaDonSC5.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "Tên dịch vụ";
            this.columnHeader23.Width = 120;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "Chỉ số cũ";
            this.columnHeader24.Width = 100;
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "Chỉ số mới";
            this.columnHeader25.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tiền";
            this.columnHeader1.Width = 100;
            // 
            // btnXacNhanDaDong
            // 
            this.btnXacNhanDaDong.AutoSize = true;
            this.btnXacNhanDaDong.Location = new System.Drawing.Point(967, 538);
            this.btnXacNhanDaDong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXacNhanDaDong.Name = "btnXacNhanDaDong";
            this.btnXacNhanDaDong.Size = new System.Drawing.Size(103, 35);
            this.btnXacNhanDaDong.TabIndex = 54;
            this.btnXacNhanDaDong.Text = "Đã đóng";
            this.btnXacNhanDaDong.UseVisualStyleBackColor = true;
            this.btnXacNhanDaDong.Click += new System.EventHandler(this.btnXacNhanDaDong_Click);
            // 
            // label134
            // 
            this.label134.AutoSize = true;
            this.label134.Location = new System.Drawing.Point(748, 548);
            this.label134.Name = "label134";
            this.label134.Size = new System.Drawing.Size(198, 25);
            this.label134.TabIndex = 49;
            this.label134.Text = "Xác nhận đóng tiền";
            // 
            // label141
            // 
            this.label141.AutoSize = true;
            this.label141.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label141.Location = new System.Drawing.Point(817, 69);
            this.label141.Name = "label141";
            this.label141.Size = new System.Drawing.Size(179, 25);
            this.label141.TabIndex = 38;
            this.label141.Text = "Chi tiết hóa đơn";
            // 
            // label142
            // 
            this.label142.AutoSize = true;
            this.label142.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label142.Location = new System.Drawing.Point(181, 145);
            this.label142.Name = "label142";
            this.label142.Size = new System.Drawing.Size(199, 25);
            this.label142.TabIndex = 35;
            this.label142.Text = "Danh sách hóa đơn";
            // 
            // lvDanhSachHoaDonSC5
            // 
            this.lvDanhSachHoaDonSC5.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader2,
            this.columnHeader3});
            this.lvDanhSachHoaDonSC5.FullRowSelect = true;
            this.lvDanhSachHoaDonSC5.GridLines = true;
            this.lvDanhSachHoaDonSC5.HideSelection = false;
            this.lvDanhSachHoaDonSC5.Location = new System.Drawing.Point(12, 174);
            this.lvDanhSachHoaDonSC5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvDanhSachHoaDonSC5.Name = "lvDanhSachHoaDonSC5";
            this.lvDanhSachHoaDonSC5.Size = new System.Drawing.Size(569, 535);
            this.lvDanhSachHoaDonSC5.TabIndex = 33;
            this.lvDanhSachHoaDonSC5.UseCompatibleStateImageBehavior = false;
            this.lvDanhSachHoaDonSC5.View = System.Windows.Forms.View.Details;
            this.lvDanhSachHoaDonSC5.SelectedIndexChanged += new System.EventHandler(this.lvDanhSachHoaDonSC5_SelectedIndexChanged);
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Mã hóa đơn";
            this.columnHeader15.Width = 120;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Mã phòng";
            this.columnHeader16.Width = 100;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Ngày lập";
            this.columnHeader17.Width = 102;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Người tạo";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tổng tiền";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 98;
            // 
            // cbbDaySC5
            // 
            this.cbbDaySC5.FormattingEnabled = true;
            this.cbbDaySC5.Location = new System.Drawing.Point(100, 50);
            this.cbbDaySC5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbDaySC5.Name = "cbbDaySC5";
            this.cbbDaySC5.Size = new System.Drawing.Size(192, 33);
            this.cbbDaySC5.TabIndex = 18;
            this.cbbDaySC5.SelectedIndexChanged += new System.EventHandler(this.cbbDaySC5_SelectedIndexChanged);
            // 
            // label149
            // 
            this.label149.AutoSize = true;
            this.label149.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label149.Location = new System.Drawing.Point(467, 9);
            this.label149.Name = "label149";
            this.label149.Size = new System.Drawing.Size(226, 29);
            this.label149.TabIndex = 1;
            this.label149.Text = "Danh sách thu tiền";
            // 
            // label150
            // 
            this.label150.AutoSize = true;
            this.label150.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label150.Location = new System.Drawing.Point(12, 58);
            this.label150.Name = "label150";
            this.label150.Size = new System.Drawing.Size(50, 25);
            this.label150.TabIndex = 0;
            this.label150.Text = "Dãy";
            // 
            // frmCollect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 722);
            this.Controls.Add(this.panel13);
            this.Name = "frmCollect";
            this.Text = "frmCollect";
            this.Load += new System.EventHandler(this.frmCollect_Load);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label128;
        private System.Windows.Forms.ListView lvChiTietHoaDonSC5;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.Button btnXacNhanDaDong;
        private System.Windows.Forms.Label label134;
        private System.Windows.Forms.Label label141;
        private System.Windows.Forms.Label label142;
        private System.Windows.Forms.ListView lvDanhSachHoaDonSC5;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ComboBox cbbDaySC5;
        private System.Windows.Forms.Label label149;
        private System.Windows.Forms.Label label150;
        private System.Windows.Forms.TextBox txtIDPhongSC5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}