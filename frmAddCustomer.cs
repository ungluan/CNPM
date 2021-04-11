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
    public partial class frmAddCustomer : Form
    {
        public frmAddCustomer()
        {
            InitializeComponent();
        }
        MotelManagerEntities db;
        private void frmAddCustomer_Load(object sender, EventArgs e)
        {
            db = new MotelManagerEntities();
            cbbDaySC3.DataSource = db.ROOMRANGEs.ToList();
            cbbDaySC3.DisplayMember = "RangeName";
            cbbDaySC3.SelectedIndex = -1;

            cbbLoaiPhongSC3.DataSource = db.ROOMRANKs.ToList();
            cbbLoaiPhongSC3.DisplayMember = "RankName";
            cbbLoaiPhongSC3.SelectedIndex = -1;

            dtDateSC3.Format = DateTimePickerFormat.Custom;
            dtDateSC3.CustomFormat = "dd-MM-yyyy";
           
        }
        private void showListRoomTheoDayVaLoaiPhong(string rangeName, string rankName)
        {
            lvDanhSachPhongSC3.Items.Clear();
            if (!rangeName.Equals("") && !rankName.Equals(""))
            {
                var nRooms = (
                              from r in db.MOTELROOMs 
                              join a in db.ROOMRANGEs on r.IDRoomRange equals a.ID
                              join b in db.ROOMRANKs on r.IDRoomRank equals b.ID
                              where a.RangeName.Equals(rangeName)
                              where b.RankName.Equals(rankName)
                              select new
                              {
                                  r.ID,
                                  r.RoomName,
                                  a.RangeName,
                                  b.RankName,
                                  r.StateRoom,
                              }).ToList();
                foreach (var nroom in nRooms)
                {
                    ListViewItem lvi = new ListViewItem(nroom.ID.ToString());
                    lvi.SubItems.Add(nroom.RoomName);
                    lvi.SubItems.Add(nroom.StateRoom==true?"Đã cho thuê":"Trống");
                    lvi.SubItems.Add(nroom.RangeName);
                    lvi.SubItems.Add(nroom.RankName);

                    lvDanhSachPhongSC3.Items.Add(lvi);
                }
            }
            else if (!rangeName.Equals(""))
            {
                var nRooms = (
                              from r in db.MOTELROOMs
                              join a in db.ROOMRANGEs on r.IDRoomRange equals a.ID
                              join b in db.ROOMRANKs on r.IDRoomRank equals b.ID
                              where a.RangeName.Equals(rangeName)
                              select new
                              {
                                  r.ID,
                                  r.RoomName,
                                  a.RangeName,
                                  b.RankName,
                                  r.StateRoom,
                              }).ToList();
                foreach (var nroom in nRooms)
                {
                    ListViewItem lvi = new ListViewItem(nroom.ID.ToString());
                    lvi.SubItems.Add(nroom.RoomName);
                    lvi.SubItems.Add(nroom.StateRoom == true ? "Đã cho thuê" : "Trống");
                    lvi.SubItems.Add(nroom.RangeName);
                    lvi.SubItems.Add(nroom.RankName);

                    lvDanhSachPhongSC3.Items.Add(lvi);
                }
            }
            else if (!rankName.Equals(""))
            {
                var nRooms = (
                              from r in db.MOTELROOMs
                              join a in db.ROOMRANGEs on r.IDRoomRange equals a.ID
                              join b in db.ROOMRANKs on r.IDRoomRank equals b.ID
                              where b.RankName.Equals(rankName)
                              select new
                              {
                                  r.ID,
                                  r.RoomName,
                                  a.RangeName,
                                  b.RankName,
                                  r.StateRoom,
                              }).ToList();
                foreach (var nroom in nRooms)
                {
                    ListViewItem lvi = new ListViewItem(nroom.ID.ToString());
                    lvi.SubItems.Add(nroom.RoomName);
                    lvi.SubItems.Add(nroom.StateRoom == true ? "Đã cho thuê" : "Trống");
                    lvi.SubItems.Add(nroom.RangeName);
                    lvi.SubItems.Add(nroom.RankName);

                    lvDanhSachPhongSC3.Items.Add(lvi);
                }
            }
            else
            {
                var nRooms = (
                              from r in db.MOTELROOMs
                              join a in db.ROOMRANGEs on r.IDRoomRange equals a.ID
                              join b in db.ROOMRANKs on r.IDRoomRank equals b.ID
                              select new
                              {
                                  r.ID,
                                  r.RoomName,
                                  a.RangeName,
                                  b.RankName,
                                  r.StateRoom,
                              }).ToList();
                foreach (var nroom in nRooms)
                {
                    ListViewItem lvi = new ListViewItem(nroom.ID.ToString());
                    lvi.SubItems.Add(nroom.RoomName);
                    lvi.SubItems.Add(nroom.StateRoom == true ? "Đã cho thuê" : "Trống");
                    lvi.SubItems.Add(nroom.RangeName);
                    lvi.SubItems.Add(nroom.RankName);

                    lvDanhSachPhongSC3.Items.Add(lvi);
                }
            }
        }


        private void cbbDaySC3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDaySC3.SelectedIndex != -1)
            {
                showListRoomTheoDayVaLoaiPhong(cbbDaySC3.Text, cbbLoaiPhongSC3.Text);
            }
        }

        private void cbbLoaiPhongSC3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLoaiPhongSC3.SelectedIndex != -1)
            {
                showListRoomTheoDayVaLoaiPhong(cbbDaySC3.Text, cbbLoaiPhongSC3.Text);
            }
        }

        private void lvDanhSachPhongSC3_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvDanhSachKhachSC3.Items.Clear();
            if (lvDanhSachPhongSC3.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvDanhSachPhongSC3.SelectedItems[0];
                int IDRoom = int.Parse(lvi.Text);
                lbPhongSC3.Text =lvi.Text;
                var customers = (from rent in db.REINTINFORs
                                 join room in db.MOTELROOMs on rent.IDRoom equals room.ID
                                 join cus in db.CUSTOMERs on rent.IDCustomer equals cus.ID
                                 where room.ID == IDRoom
                                 select new
                                 {
                                     cus.ID,
                                     cus.CustomerName,
                                     cus.Sexual,
                                     cus.Address,
                                 }).ToList();
                
                foreach(var c in customers)
                {
                    ListViewItem lv = new ListViewItem(c.ID);
                    lv.SubItems.Add(c.CustomerName);
                    lv.SubItems.Add(c.Sexual);
                    lv.SubItems.Add(c.Address);

                    lvDanhSachKhachSC3.Items.Add(lv);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(txtCMNDSC3.TextLength==9 || txtCMNDSC3.TextLength == 12)
            {
                var customer = (from cus in db.CUSTOMERs
                               where cus.ID.Equals(txtCMNDSC3.Text)
                               select cus).ToList();
                if (customer.Count == 1)
                {
                    txtHoTenSC3.Text = customer[0].CustomerName;
                    txtHoTenSC3.ReadOnly = true;

                    txtSDTSC3.Text = customer[0].NumberPhone;
                    //txtSDTSC3.ReadOnly = true;

                    txtDiaChiSC3.Text = customer[0].Address;
                    txtDiaChiSC3.ReadOnly = true;

                    cbbGioiTinhSC3.Text = customer[0].Sexual;

                    dtDateSC3.Value = (DateTime) customer[0].DateOfBirth;
                }
            }
            else
            {
                txtHoTenSC3.ReadOnly = false;
                txtDiaChiSC3.ReadOnly = false;
                dtDateSC3.Value = DateTime.Now;
                cbbGioiTinhSC3.SelectedIndex = -1;

                txtHoTenSC3.Text = "";
                txtSDTSC3.Text = "";
                txtDiaChiSC3.Text = "";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSDTSC3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnXoaSC3_Click(object sender, EventArgs e)
        {
            txtHoTenSC3.ReadOnly = false;
            txtDiaChiSC3.ReadOnly = false;
            dtDateSC3.Value = DateTime.Now;
            cbbGioiTinhSC3.SelectedIndex = -1;

            txtCMNDSC3.Text = "";
            txtHoTenSC3.Text = "";
            txtSDTSC3.Text = "";
            txtDiaChiSC3.Text = "";
        }

        private void btnThemSC3_Click_1(object sender, EventArgs e)
        {
            string firstNumber = txtSDTSC3.Text;
            bool isOk = (txtCMNDSC3.TextLength == 9 || txtCMNDSC3.TextLength == 12)
                && (txtHoTenSC3.Text.Length > 0) && (txtDiaChiSC3.Text.Length > 0)
                && (txtSDTSC3.Text.Length == 10 && firstNumber[0].Equals('0')
                && cbbGioiTinhSC3.SelectedIndex!=-1
                );

            if (isOk)
            {
                if (txtHoTenSC3.ReadOnly == true) // sửa
                {
                    // Nếu IDRoom khác thì thêm bảng rent
                    // Nếu IDRoom giống thì kiểm tra
                    // Nếu như đã chưa ngày checkout thì báo: Khách hàng đã thuê phòng này
                    // Nếu như đã có ngày checkout ?? Chỉnh sửa lại ngày hả?


                    var rentInfor = db.REINTINFORs.FirstOrDefault(x => x.IDCustomer == txtCMNDSC3.Text);
                    if (rentInfor != null)
                    {
                        if (lbPhongSC3.Text.Equals(rentInfor.IDRoom.ToString()))
                        {
                            if (rentInfor.CheckOutDate != null) // có nghĩa đã trả phòng thì ta vẫn tạo hợp đồng mới
                                // chứ sao có thể Edit hợp đồng đó được
                            {
                               // Database phải thêm CheckInDate cũng là khóa chính
                                var newRent = new REINTINFOR();
                                newRent.IDCustomer = txtCMNDSC3.Text;
                                newRent.IDRoom = int.Parse(lbPhongSC3.Text);
                                newRent.CheckInDate = DateTime.Now;

                                db.REINTINFORs.Add(newRent);
                                db.SaveChanges();
                            }
                            else // chưa trả phòng mà thuê nữa thì không cho
                            {
                                MessageBox.Show("Khách hiện đang ở phòng này, không thể đăng kí thêm!");
                            }
                        }
                        else
                        {
                            var newRent = new REINTINFOR();
                            newRent.IDCustomer = txtCMNDSC3.Text;
                            newRent.IDRoom = int.Parse(lbPhongSC3.Text);
                            newRent.CheckInDate = DateTime.Now;

                            db.REINTINFORs.Add(newRent);
                            db.SaveChanges();
                        }
                    }
                }
                else // thêm
                {
                    // Thêm customer
                    var newCustumer = new CUSTOMER();
                    newCustumer.ID = txtCMNDSC3.Text;
                    newCustumer.CustomerName = txtHoTenSC3.Text;
                    newCustumer.NumberPhone = txtSDTSC3.Text;
                    newCustumer.Sexual = cbbGioiTinhSC3.Text;
                    newCustumer.Address = txtDiaChiSC3.Text;
                    newCustumer.DateOfBirth = dtDateSC3.Value;

                    db.CUSTOMERs.Add(newCustumer);
                    db.SaveChanges();

                    // Thêm rent_info
                    var newRent = new REINTINFOR();
                    newRent.IDCustomer = txtCMNDSC3.Text;
                    newRent.IDRoom = int.Parse(lbPhongSC3.Text);
                    newRent.CheckInDate = DateTime.Now;

                    db.REINTINFORs.Add(newRent);
                    db.SaveChanges();

                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và chính xác thông tin");
            }
        }


        // Nhập ID sau đó kiểm tra 9 - 12

    }
}
