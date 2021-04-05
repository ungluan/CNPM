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
    public partial class frmCollect : Form
    {
        public frmCollect()
        {
            InitializeComponent();
        }
        MotelManagerEntities db;
        private void frmCollect_Load(object sender, EventArgs e)
        {
            db = new MotelManagerEntities();

            cbbDaySC5.DataSource = db.ROOMRANGEs.ToList();
            cbbDaySC5.DisplayMember = "RangeName";
            cbbDaySC5.SelectedIndex = -1;

            // Tại đây hóa đơn có vấn về
            loadListViewDanhSachHoaDon();
        }
        void loadListViewDanhSachHoaDon()
        {
            lvDanhSachHoaDonSC5.Items.Clear();
                var bills = (from b in db.BILLs
                             where b.Paid == false
                             select b).ToList();
                foreach (var bill in bills)
                {
                    ListViewItem lvi = new ListViewItem(bill.ID.ToString());
                    lvi.SubItems.Add(bill.IDRoom.ToString());
                    lvi.SubItems.Add(String.Format("{0:d}", bill.Date));
                    // Chưa có đăng nhập
                    // lvi.SubItems.Add(bill.IDStaff);
                    lvi.SubItems.Add("Admin");
                    lvi.SubItems.Add(String.Format("{0:0,0}", bill.TotalMoney));

                    lvDanhSachHoaDonSC5.Items.Add(lvi);
                }
        }

        private void txtIDPhongSC5_TextChanged(object sender, EventArgs e)
        {
            if (txtIDPhongSC5.Text.Length != 0)
            {
                lvDanhSachHoaDonSC5.Items.Clear();
                var bill = (from b in db.BILLs
                            where b.IDRoom.ToString().Equals(txtIDPhongSC5.Text)
                            select b).ToList();

                if (bill.Count > 0)
                {
                    ListViewItem lvi = new ListViewItem(bill[0].ID.ToString());
                    lvi.SubItems.Add(bill[0].IDRoom.ToString());
                    lvi.SubItems.Add(String.Format("{0:d}", bill[0].Date));
                    // Chưa có đăng nhập
                    // lvi.SubItems.Add(bill.IDStaff);
                    lvi.SubItems.Add("Admin");
                    lvi.SubItems.Add(String.Format("{0:0,0}", bill[0].TotalMoney));

                    lvDanhSachHoaDonSC5.Items.Add(lvi);
                }
            }
        }

        private void cbbDaySC5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDaySC5.SelectedIndex > -1)
            {
                var Rooms = from ra in db.ROOMRANGEs
                            join r in db.MOTELROOMs on ra.ID equals r.IDRoomRange
                            where ra.RangeName.Equals(cbbDaySC5.Text)
                            select r;
                var bills = (from b in db.BILLs
                             join r in Rooms on b.IDRoom equals r.ID
                             select b).ToList();
                if (bills.Count > 0)
                {
                    lvChiTietHoaDonSC5.Items.Clear();
                    foreach (var bill in bills)
                    {
                        ListViewItem lvi = new ListViewItem(bill.ID.ToString());
                        lvi.SubItems.Add(bill.IDRoom.ToString());
                        lvi.SubItems.Add(String.Format("{0:d}", bill.Date));
                        // Chưa có đăng nhập
                        // lvi.SubItems.Add(bill.IDStaff);
                        lvi.SubItems.Add("Admin");
                        lvi.SubItems.Add(String.Format("{0:0,0}", bill.TotalMoney));

                        lvDanhSachHoaDonSC5.Items.Add(lvi);
                    }
                }


            }
        }

        private void lvDanhSachHoaDonSC5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDanhSachHoaDonSC5.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvDanhSachHoaDonSC5.SelectedItems[0];
                string id = lvi.SubItems[0].Text;

                var services = (from p in db.PARTICULARSERVICEs
                                join s in db.SERVICEs on p.IDService equals s.ID
                                join b in db.BILLs on p.IDBill equals b.ID
                                where p.IDBill.ToString().Equals(id)
                                select new
                                {
                                    s.ServiceName,
                                    p.OldIndex,
                                    p.NewIndex,
                                    p.Total,
                                }).ToList();
                MessageBox.Show(services.Count().ToString());
                if (services.Count() > 0)
                {
                    foreach (var s in services)
                    {
                        ListViewItem lvi1 = new ListViewItem(s.ServiceName);
                        lvi1.SubItems.Add(s.OldIndex.ToString());
                        lvi1.SubItems.Add(s.NewIndex.ToString());
                        lvi1.SubItems.Add(String.Format("{0:0,0}", s.Total));

                        lvChiTietHoaDonSC5.Items.Add(lvi1);
                    }
                }
            }
        }

        private void btnXacNhanDaDong_Click(object sender, EventArgs e)
        {
            if (lvDanhSachHoaDonSC5.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvDanhSachHoaDonSC5.SelectedItems[0];
                int idBill = int.Parse(lvi.SubItems[0].Text);
                var bill = (from b in db.BILLs
                           where b.ID == idBill
                           select b).ToList();
                bill[0].Paid = true;
                db.SaveChanges();
                loadListViewDanhSachHoaDon();
                MessageBox.Show("Cập nhật thành công!");
            }
        }
    }
}
