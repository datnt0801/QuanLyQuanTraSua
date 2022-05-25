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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBoxSwitchTable = new System.Windows.Forms.ComboBox();
            this.buttonSwitchTable = new System.Windows.Forms.Button();
            this.numtonDiscounDiscount = new System.Windows.Forms.NumericUpDown();
            this.buttonDiscount = new System.Windows.Forms.Button();
            this.buttonCheckOut = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.numericUpDownFoodCount = new System.Windows.Forms.NumericUpDown();
            this.buttonAddFood = new System.Windows.Forms.Button();
            this.comboBoxFood = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanelTable = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numtonDiscounDiscount)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFoodCount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1667, 48);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(104, 36);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(244, 36);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(342, 44);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(342, 44);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(1000, 160);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(624, 556);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.comboBoxSwitchTable);
            this.panel3.Controls.Add(this.buttonSwitchTable);
            this.panel3.Controls.Add(this.numtonDiscounDiscount);
            this.panel3.Controls.Add(this.buttonDiscount);
            this.panel3.Controls.Add(this.buttonCheckOut);
            this.panel3.Location = new System.Drawing.Point(1000, 727);
            this.panel3.Margin = new System.Windows.Forms.Padding(6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(624, 115);
            this.panel3.TabIndex = 3;
            // 
            // comboBoxSwitchTable
            // 
            this.comboBoxSwitchTable.FormattingEnabled = true;
            this.comboBoxSwitchTable.Location = new System.Drawing.Point(8, 69);
            this.comboBoxSwitchTable.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxSwitchTable.Name = "comboBoxSwitchTable";
            this.comboBoxSwitchTable.Size = new System.Drawing.Size(160, 33);
            this.comboBoxSwitchTable.TabIndex = 4;
            // 
            // buttonSwitchTable
            // 
            this.buttonSwitchTable.Location = new System.Drawing.Point(6, 6);
            this.buttonSwitchTable.Margin = new System.Windows.Forms.Padding(6);
            this.buttonSwitchTable.Name = "buttonSwitchTable";
            this.buttonSwitchTable.Size = new System.Drawing.Size(164, 58);
            this.buttonSwitchTable.TabIndex = 5;
            this.buttonSwitchTable.Text = "Chuyển Bàn";
            this.buttonSwitchTable.UseVisualStyleBackColor = true;
            // 
            // numtonDiscounDiscount
            // 
            this.numtonDiscounDiscount.Location = new System.Drawing.Point(278, 71);
            this.numtonDiscounDiscount.Margin = new System.Windows.Forms.Padding(6);
            this.numtonDiscounDiscount.Name = "numtonDiscounDiscount";
            this.numtonDiscounDiscount.Size = new System.Drawing.Size(164, 31);
            this.numtonDiscounDiscount.TabIndex = 4;
            this.numtonDiscounDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonDiscount
            // 
            this.buttonDiscount.Location = new System.Drawing.Point(278, 6);
            this.buttonDiscount.Margin = new System.Windows.Forms.Padding(6);
            this.buttonDiscount.Name = "buttonDiscount";
            this.buttonDiscount.Size = new System.Drawing.Size(164, 58);
            this.buttonDiscount.TabIndex = 1;
            this.buttonDiscount.Text = "Giảm giá";
            this.buttonDiscount.UseVisualStyleBackColor = true;
            // 
            // buttonCheckOut
            // 
            this.buttonCheckOut.Location = new System.Drawing.Point(454, 6);
            this.buttonCheckOut.Margin = new System.Windows.Forms.Padding(6);
            this.buttonCheckOut.Name = "buttonCheckOut";
            this.buttonCheckOut.Size = new System.Drawing.Size(164, 104);
            this.buttonCheckOut.TabIndex = 0;
            this.buttonCheckOut.Text = "Thanh toán";
            this.buttonCheckOut.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.numericUpDownFoodCount);
            this.panel4.Controls.Add(this.buttonAddFood);
            this.panel4.Controls.Add(this.comboBoxFood);
            this.panel4.Controls.Add(this.comboBoxCategory);
            this.panel4.Location = new System.Drawing.Point(1000, 52);
            this.panel4.Margin = new System.Windows.Forms.Padding(6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(624, 96);
            this.panel4.TabIndex = 4;
            // 
            // numericUpDownFoodCount
            // 
            this.numericUpDownFoodCount.Location = new System.Drawing.Point(504, 33);
            this.numericUpDownFoodCount.Margin = new System.Windows.Forms.Padding(6);
            this.numericUpDownFoodCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownFoodCount.Name = "numericUpDownFoodCount";
            this.numericUpDownFoodCount.Size = new System.Drawing.Size(114, 31);
            this.numericUpDownFoodCount.TabIndex = 3;
            // 
            // buttonAddFood
            // 
            this.buttonAddFood.Location = new System.Drawing.Point(342, 6);
            this.buttonAddFood.Margin = new System.Windows.Forms.Padding(6);
            this.buttonAddFood.Name = "buttonAddFood";
            this.buttonAddFood.Size = new System.Drawing.Size(150, 85);
            this.buttonAddFood.TabIndex = 2;
            this.buttonAddFood.Text = "Thêm món";
            this.buttonAddFood.UseVisualStyleBackColor = true;
            // 
            // comboBoxFood
            // 
            this.comboBoxFood.FormattingEnabled = true;
            this.comboBoxFood.Location = new System.Drawing.Point(6, 50);
            this.comboBoxFood.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxFood.Name = "comboBoxFood";
            this.comboBoxFood.Size = new System.Drawing.Size(332, 33);
            this.comboBoxFood.TabIndex = 1;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(6, 6);
            this.comboBoxCategory.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(332, 33);
            this.comboBoxCategory.TabIndex = 0;
            // 
            // flowLayoutPanelTable
            // 
            this.flowLayoutPanelTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelTable.Location = new System.Drawing.Point(26, 52);
            this.flowLayoutPanelTable.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanelTable.Name = "flowLayoutPanelTable";
            this.flowLayoutPanelTable.Size = new System.Drawing.Size(962, 790);
            this.flowLayoutPanelTable.TabIndex = 5;
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1667, 866);
            this.Controls.Add(this.flowLayoutPanelTable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "fTableManager";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý quán cafe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numtonDiscounDiscount)).EndInit();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonAddFood;
        private System.Windows.Forms.ComboBox comboBoxFood;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.NumericUpDown numericUpDownFoodCount;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTable;
        private System.Windows.Forms.NumericUpDown numtonDiscounDiscount;
        private System.Windows.Forms.Button buttonDiscount;
        private System.Windows.Forms.Button buttonCheckOut;
        private System.Windows.Forms.ComboBox comboBoxSwitchTable;
        private System.Windows.Forms.Button buttonSwitchTable;
    }
}