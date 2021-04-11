using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestPT
{
    public partial class frmPrice : Form
    {
        public frmPrice()
        {
            InitializeComponent();
        }
        MotelManagerEntities db;
        string taikhoan = "admin";
        private void frmPrice_Load(object sender, EventArgs e)
        {
            db = new MotelManagerEntities();

            cbbDaySC4.DataSource = db.ROOMRANGEs.ToList();
            cbbDaySC4.DisplayMember = "RangeName";
            cbbDaySC4.SelectedIndex = -1;

            cbbLoaiPhongSC4.DataSource = db.ROOMRANKs.ToList();
            cbbLoaiPhongSC4.DisplayMember = "RankName";
            cbbLoaiPhongSC4.SelectedIndex = -1;

           
        }
        private void showListRoomTheoDayVaLoaiPhong(string rangeName, string rankName)
        {
            lvDanhSachPhongSC4.Items.Clear();
            var rooms = from rent in db.REINTINFORs
                        group rent by rent.IDRoom into g
                        select new
                        {
                            ID = g.Key,
                            SL = g.Count(),
                        };
            if (!rangeName.Equals("") && !rankName.Equals(""))
            {
                var nRooms = (from r in rooms
                              join room in db.MOTELROOMs on r.ID equals room.ID
                              select new
                              {
                                  r.ID,
                                  room.RoomName,
                                  r.SL,
                                  room.IDRoomRange,
                                  room.IDRoomRank
                              } into x
                              join a in db.ROOMRANGEs on x.IDRoomRange equals a.ID
                              join b in db.ROOMRANKs on x.IDRoomRank equals b.ID
                              where a.RangeName.Equals(rangeName)
                              where b.RankName.Equals(rankName)
                              select new
                              {
                                  x.ID,
                                  x.RoomName,
                                  a.RangeName,
                                  b.RankName,
                                  x.SL
                              }).ToList();
                foreach (var nroom in nRooms)
                {
                    ListViewItem lvi = new ListViewItem(nroom.ID.ToString());
                    lvi.SubItems.Add(nroom.RoomName);
                    lvi.SubItems.Add(nroom.RangeName);
                    lvi.SubItems.Add(nroom.RankName);
                    lvi.SubItems.Add(nroom.SL.ToString());

                    lvDanhSachPhongSC4.Items.Add(lvi);
                }
            }
            else if (!rangeName.Equals(""))
            {
                var nRooms = (from r in rooms
                              join room in db.MOTELROOMs on r.ID equals room.ID
                              select new
                              {
                                  r.ID,
                                  room.RoomName,
                                  r.SL,
                                  room.IDRoomRange,
                                  room.IDRoomRank,
                              } into x
                              join a in db.ROOMRANGEs on x.IDRoomRange equals a.ID
                              join b in db.ROOMRANKs on x.IDRoomRank equals b.ID
                              where a.RangeName.Equals(rangeName)
                              select new
                              {
                                  x.ID,
                                  x.RoomName,
                                  a.RangeName,
                                  b.RankName,
                                  x.SL
                              }).ToList();
                foreach(var room in nRooms)
                {
                    ListViewItem lvi = new ListViewItem(room.ID.ToString());
                    lvi.SubItems.Add(room.RoomName);
                    lvi.SubItems.Add(room.RangeName);
                    lvi.SubItems.Add(room.RankName);
                    lvi.SubItems.Add(room.SL.ToString());

                    lvDanhSachPhongSC4.Items.Add(lvi);
                }
            }
            else if (!rankName.Equals(""))
            {
                var nRooms = (from r in rooms
                              join room in db.MOTELROOMs on r.ID equals room.ID
                              select new
                              {
                                  r.ID,
                                  room.RoomName,
                                  r.SL,
                                  room.IDRoomRange,
                                  room.IDRoomRank
                              } into x
                              join a in db.ROOMRANGEs on x.IDRoomRange equals a.ID
                              join b in db.ROOMRANKs on x.IDRoomRank equals b.ID
                              where b.RankName.Equals(rankName)
                              select new
                              {
                                  x.ID,
                                  x.RoomName,
                                  a.RangeName,
                                  b.RankName,
                                  x.SL
                              }).ToList();
                foreach (var room in nRooms)
                {
                    ListViewItem lvi = new ListViewItem(room.ID.ToString());
                    lvi.SubItems.Add(room.RoomName);
                    lvi.SubItems.Add(room.RangeName);
                    lvi.SubItems.Add(room.RankName);
                    lvi.SubItems.Add(room.SL.ToString());

                    lvDanhSachPhongSC4.Items.Add(lvi);
                }
            }
            else
            {
                var nRooms = (from r in rooms
                              join room in db.MOTELROOMs on r.ID equals room.ID
                              select new
                              {
                                  r.ID,
                                  room.RoomName,
                                  r.SL,
                                  room.IDRoomRange,
                                  room.IDRoomRank
                              } into x
                              join a in db.ROOMRANGEs on x.IDRoomRange equals a.ID
                              join b in db.ROOMRANKs on x.IDRoomRank equals b.ID
                              select new
                              {
                                  x.ID,
                                  x.RoomName,
                                  a.RangeName,
                                  b.RankName,
                                  x.SL
                              }).ToList();
                foreach (var room in nRooms)
                {
                    ListViewItem lvi = new ListViewItem(room.ID.ToString());
                    lvi.SubItems.Add(room.RoomName);
                    lvi.SubItems.Add(room.RangeName);
                    lvi.SubItems.Add(room.RankName);
                    lvi.SubItems.Add(room.SL.ToString());

                    lvDanhSachPhongSC4.Items.Add(lvi);
                }
            }
        }
        private void cbbDaySC4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCMNDSC4.Text.Equals(""))
            {
                showListRoomTheoDayVaLoaiPhong(cbbDaySC4.Text, cbbLoaiPhongSC4.Text);

            }
        }

        private void cbbLoaiPhongSC4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCMNDSC4.Text.Equals(""))
            {
                showListRoomTheoDayVaLoaiPhong(cbbDaySC4.Text, cbbLoaiPhongSC4.Text);

            }
        }

        private void lvDanhSachPhongSC4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDanhSachPhongSC4.SelectedItems.Count > 0)
            {
                // sau Khi click vào 1 List View Item thì ta cần truy vấn 
                // được customer, sau đó đổ thông tin vào các textBox
                ListViewItem lvi = lvDanhSachPhongSC4.SelectedItems[0];

                // IDRoom chính là lvi.Text
                int IDRoom = int.Parse(lvi.Text);

                var customers = (from rent in db.REINTINFORs
                                 join cus in db.CUSTOMERs on rent.IDCustomer equals cus.ID
                                 where rent.IDRoom == IDRoom
                                 select new
                                 {
                                     cus.ID,
                                 }).ToList();

                cbbCMNDSC4.DataSource = customers;
                cbbCMNDSC4.DisplayMember = "ID";

                var rankRooms = (from m in db.MOTELROOMs
                                join r in db.ROOMRANKs on m.IDRoomRank equals r.ID
                                where m.ID.Equals(IDRoom)
                                select new
                                {
                                    r.Price,
                                }).ToList();
                lbTienPhong.Text = String.Format("{0,0:0,0}", rankRooms[0].Price);
            }
        }

        private void cbbCMNDSC4_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!cbbCMNDSC4.Text.Equals(""))
            {
                var customers = (from cus in db.CUSTOMERs
                                 where cus.ID.Equals(cbbCMNDSC4.Text)
                                 select new
                                 {
                                     cus.ID,
                                     cus.CustomerName,
                                     cus.NumberPhone,
                                     cus.Address,
                                     cus.Sexual,
                                 }).ToList();
                if (customers.Count > 0)
                {
                    txtHoTenSC4.Text = customers[0].CustomerName;
                    txtSDTSC4.Text = customers[0].NumberPhone;
                    txtQueQuanSC4.Text = customers[0].Address;
                    txtGioiTinhSC4.Text = customers[0].Sexual;
                }
            }
        }

        // Bắt đầu xử lý tiền điện
        private void txtKiDien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtKiDien_TextChanged(object sender, EventArgs e)
        {
            var service = (from s in db.SERVICEs
                           where s.ServiceName.Equals("Điện")
                           select new
                           {
                               s.Price,
                           }).ToList();
            int price = Convert.ToInt32(service[0].Price);
            if (!txtKiDien.Text.Equals(""))
            {
                int tienDiem = price * (int.Parse(txtKiDien.Text));
                lbTienDien.Text = String.Format("{0,0:0,0}", tienDiem);
            }
            else
            {
                lbTienDien.Text = "0";
            }
        }
        // Kết thúc xử lý tiền điện

        // Bắt đầu xử lý tiền nước
        private void txtKhoiNuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtKhoiNuoc_TextChanged(object sender, EventArgs e)
        {
            var service = (from s in db.SERVICEs
                           where s.ServiceName.Equals("Nước")
                           select new
                           {
                               s.Price,
                           }).ToList();
            int price = Convert.ToInt32(service[0].Price);
            if (!txtKhoiNuoc.Text.Equals(""))
            {
                int tienNuoc = price * (int.Parse(txtKhoiNuoc.Text));
                lbTienNuoc.Text = String.Format("{0,0:0,0}", tienNuoc);
            }
            else
            {
                lbTienNuoc.Text = "0";
            }
        }
        // Kết thúc xử lý tiền nước
        private void ckRac_CheckedChanged(object sender, EventArgs e)
        {
            if (ckRac.Checked)
            {
                var service = (from s in db.SERVICEs
                               where s.ServiceName.Equals("Rác")
                               select new
                               {
                                   s.Price,
                               }).ToList();
                txtTienRac.Text = String.Format("{0:0,0}", service[0].Price);
            }
            else txtTienRac.Text = "0";
        }

        private void ckWifi_CheckedChanged(object sender, EventArgs e)
        {
            if (ckWifi.Checked)
            {
                var service = (from s in db.SERVICEs
                               where s.ServiceName.Equals("Wifi")
                               select new
                               {
                                   s.Price,
                               }).ToList();
                txtTienWifi.Text = String.Format("{0:0,0}", service[0].Price);
            }
            else txtTienWifi.Text = "0";
        }

        private void ckGuiXe_CheckedChanged(object sender, EventArgs e)
        {
            if (ckGuiXe.Checked)
            {
                var service = (from s in db.SERVICEs
                               where s.ServiceName.Equals("Gửi xe máy")
                               select new
                               {
                                   s.Price,
                               }).ToList();
                txtTienGuiXe.Text = String.Format("{0:0,0}", service[0].Price*nmrGuiXe.Value);
            }
            else txtTienGuiXe.Text = "0";
        }

        private void btnTinhTongTien_Click(object sender, EventArgs e)
        {
            if (lbTienPhong.Text.Equals("0"))
            {
                MessageBox.Show("Vui lòng chọn phòng!");
            }
            else
            {
                string tienPhong = lbTienPhong.Text.Replace(",", "");

                string tienDien = lbTienDien.Text.Replace(",", "");

                string tienNuoc = lbTienNuoc.Text.Replace(",", "");

                string tienWifi = txtTienWifi.Text.Replace(",", "");
                string tienRac = txtTienRac.Text.Replace(",", "");
                string tienGuiXe = txtTienGuiXe.Text.Replace(",", "");

                int tongTien = int.Parse(tienPhong) + int.Parse(tienDien)
                    + int.Parse(tienNuoc) + int.Parse(tienGuiXe)
                    + int.Parse(tienRac) + int.Parse(tienWifi);
                txtTongTien.Text = String.Format("{0:0,0}", tongTien);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Đầu tiên ta cần có ID Bill cũ
            // và DS service cũ
            var bills = (
                    from b in db.BILLs
                    join p in db.PARTICULARSERVICEs on b.ID equals p.IDBill
                    where b.IDRoom.ToString().Equals(lbIDPhongSC4.Text)
                    select b
                ).ToList();
            int oldIDBill;
            // Thêm Bill mới
            var nBill = new BILL();
            db.BILLs.Add(nBill);
            db.SaveChanges();
            // Thêm thành công
            if (bills.Count > 0) // CÓ bill trước đó => oldIndex là newIndex cũ
            {
                oldIDBill = bills.Max(x => x.ID);
                // Chắc gì những service cũ, khách hàng cũng muốn tiếp tục sử dụng
                // Vd: Gửi xe tháng này 4 chiếc, tháng sau không ai gửi


                // Hướng giải quyết là ta phải đi kiểm tra từng service
                // Nếu có thì tiếp tục kiểm tra bill cũ
                // Chỉ kiểm tra bill cũ nếu đó là service điện hoặc nước

                // Tiếp tục gặp vấn đề là đâu phải phòng lúc nào cũng có người thuê
                // Chỉ có điện và nước mới sử dụng chỉ số cũ và chỉ số mới
                // xe - thì ta chỉ sử dụng chỉ số mới để lưu trữ


                // Thử cách này
                // Chắc chắn là các service mặc định là phòng nào cũng có
                // Chỉ khác ở chổ phòng đó có đăng kí gửi xe hay không
                // và số lượng xe thay đổi theo từng tháng là bao nhiêu

                // Mặc định pars này luôn luôn có
                // Chỉ khác nhau giữa các index , nếu không có thi 0

                // Vấn đề làm sao để Lấy ID Của nó đây 

                foreach(var s in db.SERVICEs)
                {
                    var ps = new PARTICULARSERVICE();
                    ps.IDBill = nBill.ID;
                    ps.IDService = s.ID;
                    var oldPar = (
                        from a in db.PARTICULARSERVICEs
                        join b in db.BILLs on a.IDBill equals b.ID
                        where b.ID == oldIDBill
                        where s.ID == a.IDService
                        select new
                        {
                            a.NewIndex
                        }
                                  ).ToList();
                    ps.OldIndex = oldPar[0].NewIndex;
                    // Đoạn này cải tiến thành 1 Grid View Data ta có thể chỉnh sửa được
                    if (s.ServiceName.Equals("Điện"))
                    {
                        ps.NewIndex = ps.OldIndex + int.Parse(txtKiDien.Text);
                    }
                    else if (s.ServiceName.Equals("Nước"))
                    {
                        ps.NewIndex = ps.OldIndex + int.Parse(txtKhoiNuoc.Text);
                    }
                    else if (s.ServiceName.Equals("Gửi xe máy"))
                    {
                        ps.NewIndex = Convert.ToInt32(nmrGuiXe.Value);
                    }
                    else if (s.ServiceName.Equals("Wifi"))
                    {
                        ps.NewIndex = 1;
                    }
                    else if (s.ServiceName.Equals("Rác"))
                    {
                        ps.NewIndex = 1;
                    }
                    // Không cần total của từng Phần
                    //string tongtien = txtTongTien.Text.Replace(",", "");
                    //ps.Total = Decimal.Parse(tongtien);


                    // Add Particular Service
                    db.PARTICULARSERVICEs.Add(ps);
                }
                nBill.Date = DateTime.Now;
                nBill.IDRoom = int.Parse(lbIDPhongSC4.Text);
                nBill.Paid = false;
                string tongtien = txtTongTien.Text.Replace(",", "");
                nBill.TotalMoney = Decimal.Parse(tongtien);

                // Kết thúc bước này đồng nghĩa với việc ta đã thêm thành công 
                // các particular service

                // Tiếp theo ta chỉnh sữa các thuộc tính còn lại của Bill
                // IDRoom - IDStaff - Date - TotalMoney - Paid

                nBill.IDRoom = int.Parse(lbIDPhongSC4.Text);
                nBill.Date = DateTime.Now;
                string tongTien = txtTongTien.Text.Replace(",", "");
                nBill.TotalMoney =  (Decimal)int.Parse(tongTien);
                nBill.Paid = false;
                db.SaveChanges();
            }
            else // không có bill trước đó => oldIndex = 0
            {
                // Chỉ cần thiết lập toàn bộ particular service của phòng này
                // với oldIndex = 0;
                foreach(var s in db.SERVICEs)
                {
                    var par = new PARTICULARSERVICE();
                    par.IDBill = nBill.ID;
                    par.IDService = s.ID;
                    par.OldIndex = 0;
                    if (s.ServiceName.Equals("Điện"))
                    {
                        par.NewIndex = par.OldIndex + int.Parse(txtKiDien.Text);
                    }
                    else if (s.ServiceName.Equals("Nước"))
                    {
                        par.NewIndex = par.OldIndex + int.Parse(txtKhoiNuoc.Text);
                    }
                    else if (s.ServiceName.Equals("Gửi xe máy"))
                    {
                        par.NewIndex = Convert.ToInt32(nmrGuiXe.Value);
                    }
                    else if (s.ServiceName.Equals("Wifi"))
                    {
                        par.NewIndex = 1;
                    }
                    else if (s.ServiceName.Equals("Rác"))
                    {
                        par.NewIndex = 1;
                    }

                    db.PARTICULARSERVICEs.Add(par);
                }
                // Thêm property cho Bill
                nBill.IDRoom = int.Parse(lbIDPhongSC4.Text);
                nBill.Date = DateTime.Now;
                string tongTien = txtTongTien.Text.Replace(",", "");
                nBill.TotalMoney = (Decimal)int.Parse(tongTien);
                nBill.Paid = false;
                db.SaveChanges();
            }
            MessageBox.Show("Thành công");
        }

        private void nmrGuiXe_ValueChanged(object sender, EventArgs e)
        {
            var service = (from s in db.SERVICEs
                           where s.ServiceName.Equals("Gửi xe máy")
                           select new
                           {
                               s.Price,
                           }).ToList();
            txtTienGuiXe.Text = String.Format("{0:0,0}", service[0].Price * nmrGuiXe.Value);
        }


    }
}
