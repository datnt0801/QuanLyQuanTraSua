namespace WindowsFormsApp1
{
    partial class fTableManager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.comboBoxSwitchTable = new System.Windows.Forms.ComboBox();
            this.buttonSwitchTable = new System.Windows.Forms.Button();
            this.numericUpDownDiscount = new System.Windows.Forms.NumericUpDown();
            this.buttonDiscount = new System.Windows.Forms.Button();
            this.buttonCheckOut = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.numericUpDownFoodCount = new System.Windows.Forms.NumericUpDown();
            this.buttonAddFood = new System.Windows.Forms.Button();
            this.comboBoxFood = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanelTable = new System.Windows.Forms.FlowLayoutPanel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiscount)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFoodCount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 22);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textBoxTotalPrice);
            this.panel3.Controls.Add(this.comboBoxSwitchTable);
            this.panel3.Controls.Add(this.buttonSwitchTable);
            this.panel3.Controls.Add(this.numericUpDownDiscount);
            this.panel3.Controls.Add(this.buttonDiscount);
            this.panel3.Controls.Add(this.buttonCheckOut);
            this.panel3.Location = new System.Drawing.Point(500, 378);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(334, 61);
            this.panel3.TabIndex = 3;
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalPrice.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBoxTotalPrice.Location = new System.Drawing.Point(154, 21);
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.ReadOnly = true;
            this.textBoxTotalPrice.Size = new System.Drawing.Size(92, 25);
            this.textBoxTotalPrice.TabIndex = 6;
            this.textBoxTotalPrice.Text = "0";
            this.textBoxTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBoxSwitchTable
            // 
            this.comboBoxSwitchTable.FormattingEnabled = true;
            this.comboBoxSwitchTable.Location = new System.Drawing.Point(4, 36);
            this.comboBoxSwitchTable.Name = "comboBoxSwitchTable";
            this.comboBoxSwitchTable.Size = new System.Drawing.Size(56, 21);
            this.comboBoxSwitchTable.TabIndex = 4;
            // 
            // buttonSwitchTable
            // 
            this.buttonSwitchTable.Location = new System.Drawing.Point(3, 3);
            this.buttonSwitchTable.Name = "buttonSwitchTable";
            this.buttonSwitchTable.Size = new System.Drawing.Size(57, 30);
            this.buttonSwitchTable.TabIndex = 5;
            this.buttonSwitchTable.Text = "Chuyển Bàn";
            this.buttonSwitchTable.UseVisualStyleBackColor = true;
            // 
            // numericUpDownDiscount
            // 
            this.numericUpDownDiscount.Location = new System.Drawing.Point(66, 36);
            this.numericUpDownDiscount.Name = "numericUpDownDiscount";
            this.numericUpDownDiscount.Size = new System.Drawing.Size(82, 20);
            this.numericUpDownDiscount.TabIndex = 4;
            this.numericUpDownDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonDiscount
            // 
            this.buttonDiscount.Location = new System.Drawing.Point(66, 3);
            this.buttonDiscount.Name = "buttonDiscount";
            this.buttonDiscount.Size = new System.Drawing.Size(82, 30);
            this.buttonDiscount.TabIndex = 1;
            this.buttonDiscount.Text = "Giảm giá";
            this.buttonDiscount.UseVisualStyleBackColor = true;
            // 
            // buttonCheckOut
            // 
            this.buttonCheckOut.Location = new System.Drawing.Point(247, 3);
            this.buttonCheckOut.Name = "buttonCheckOut";
            this.buttonCheckOut.Size = new System.Drawing.Size(82, 54);
            this.buttonCheckOut.TabIndex = 0;
            this.buttonCheckOut.Text = "Thanh toán";
            this.buttonCheckOut.UseVisualStyleBackColor = true;
            this.buttonCheckOut.Click += new System.EventHandler(this.buttonCheckOut_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.numericUpDownFoodCount);
            this.panel4.Controls.Add(this.buttonAddFood);
            this.panel4.Controls.Add(this.comboBoxFood);
            this.panel4.Controls.Add(this.comboBoxCategory);
            this.panel4.Location = new System.Drawing.Point(500, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(334, 51);
            this.panel4.TabIndex = 4;
            // 
            // numericUpDownFoodCount
            // 
            this.numericUpDownFoodCount.Location = new System.Drawing.Point(252, 17);
            this.numericUpDownFoodCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownFoodCount.Name = "numericUpDownFoodCount";
            this.numericUpDownFoodCount.Size = new System.Drawing.Size(69, 20);
            this.numericUpDownFoodCount.TabIndex = 3;
            // 
            // buttonAddFood
            // 
            this.buttonAddFood.Location = new System.Drawing.Point(171, 3);
            this.buttonAddFood.Name = "buttonAddFood";
            this.buttonAddFood.Size = new System.Drawing.Size(75, 44);
            this.buttonAddFood.TabIndex = 2;
            this.buttonAddFood.Text = "Thêm món";
            this.buttonAddFood.UseVisualStyleBackColor = true;
            this.buttonAddFood.Click += new System.EventHandler(this.buttonAddFood_Click);
            // 
            // comboBoxFood
            // 
            this.comboBoxFood.FormattingEnabled = true;
            this.comboBoxFood.Location = new System.Drawing.Point(3, 26);
            this.comboBoxFood.Name = "comboBoxFood";
            this.comboBoxFood.Size = new System.Drawing.Size(168, 21);
            this.comboBoxFood.TabIndex = 1;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(3, 3);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(168, 21);
            this.comboBoxCategory.TabIndex = 0;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // flowLayoutPanelTable
            // 
            this.flowLayoutPanelTable.AutoScroll = true;
            this.flowLayoutPanelTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelTable.Location = new System.Drawing.Point(13, 27);
            this.flowLayoutPanelTable.Name = "flowLayoutPanelTable";
            this.flowLayoutPanelTable.Size = new System.Drawing.Size(482, 412);
            this.flowLayoutPanelTable.TabIndex = 5;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(500, 84);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(334, 271);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 40;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tổng tiền";
            this.columnHeader4.Width = 70;
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(834, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.flowLayoutPanelTable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fTableManager";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý quán cafe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiscount)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFoodCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonAddFood;
        private System.Windows.Forms.ComboBox comboBoxFood;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.NumericUpDown numericUpDownFoodCount;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTable;
        private System.Windows.Forms.NumericUpDown numericUpDownDiscount;
        private System.Windows.Forms.Button buttonDiscount;
        private System.Windows.Forms.Button buttonCheckOut;
        private System.Windows.Forms.ComboBox comboBoxSwitchTable;
        private System.Windows.Forms.Button buttonSwitchTable;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox textBoxTotalPrice;
    }
}