using QuanLyQuanTraSua.DAO;
using QuanLyQuanTraSua.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;
using Menu = QuanLyQuanTraSua.DTO.Menu;

namespace WindowsFormsApp1
{
    public partial class fTableManager : Form
    {
        public fTableManager()
        {
            InitializeComponent();

            LoadTable();
            LoadCategory();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            this.Hide();
            f.ShowDialog(); 
            this.Show();
        }

        #region Method

        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            comboBoxCategory.DataSource = listCategory;
            comboBoxCategory.DisplayMember = "Name";
        }
        private void LoadFoodListByCategoryID(int id)
        {
           List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            comboBoxFood.DataSource = listFood;
            comboBoxFood.DisplayMember = "Name";
        }
        private void LoadTable()
        {
            flowLayoutPanelTable.Controls.Clear();

            List<Table> tableList = TableDAO.Instance.LoadTableList();

            foreach(Table item  in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight};
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Tag = item;


                btn.Click += Btn_Click;

                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    case "Có người":
                        btn.BackColor = Color.LightPink;
                        break;
                }

                flowLayoutPanelTable.Controls.Add(btn);
            }
        }
        void ShowBill(int id)
        {
            listView1.Items.Clear();
            
            List<Menu> menuList = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;

            foreach (Menu item in menuList)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                listView1.Items.Add(lsvItem);
            }

            textBoxTotalPrice.Text = totalPrice.ToString();

           
        }
        #endregion Method


        #region Events
        private void Btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            listView1.Tag = (sender as Button).Tag;
            ShowBill(tableID);          
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
            {
                return;
            }
            Category selected = cb.SelectedItem as Category;
            id = selected.ID;

            LoadFoodListByCategoryID(id);
        }

        private void buttonAddFood_Click(object sender, EventArgs e)
        {
            Table table = listView1.Tag as Table;

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int foodID = (comboBoxFood.SelectedItem as Food).ID;
            int count = (int)numericUpDownFoodCount.Value;  
            if(count == 0)
            {
                MessageBox.Show("Chưa nhập số lượng", "Thông báo");
                return;
            }


            if(idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);

            }

            ShowBill(table.ID);

            LoadTable();

        }

        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            Table table = listView1.Tag as Table ;
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int discount = (int)numericUpDownDiscount.Value;
            float totalPrice = Convert.ToSingle(textBoxTotalPrice.Text.ToString());
            float finalTotalPrice = totalPrice - totalPrice * discount / 100;

            if (idBill != -1)
            {
                if (
                    MessageBox.Show("Bạn có chắc muốn thanh toán " + table.Name + "\n" 
                    + "Tổng tiền: " + totalPrice + "\n"
                    + "Giảm giá: " + discount +"%\n"
                    + "Thành tiền: " + finalTotalPrice,
                    "Thông báo",
                    MessageBoxButtons.OKCancel) 
                    == 
                    System.Windows.Forms.DialogResult.OK
                    )
                {
                    BillDAO.Instance.Checkout(idBill);
                    ShowBill(table.ID);
                }
            }

            LoadTable();

        }



        #endregion Events

    }
}
