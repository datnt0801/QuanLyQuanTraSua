namespace WindowsFormsApp1
{
    partial class fAdmin
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
            this.tabControlAdmin = new System.Windows.Forms.TabControl();
            this.tabPageBill = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewBill = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonViewBill = new System.Windows.Forms.Button();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.tabPageFood = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.textBoxFoodName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBoxFoodID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonSearchFood = new System.Windows.Forms.Button();
            this.textBoxSearchFood = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridViewFood = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonShowFood = new System.Windows.Forms.Button();
            this.buttonEditFood = new System.Windows.Forms.Button();
            this.buttonDeleteFood = new System.Windows.Forms.Button();
            this.buttonAddFood = new System.Windows.Forms.Button();
            this.tabPageFoodCategory = new System.Windows.Forms.TabPage();
            this.tabPageTable = new System.Windows.Forms.TabPage();
            this.tabPageAccount = new System.Windows.Forms.TabPage();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tabControlAdmin.SuspendLayout();
            this.tabPageBill.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPageFood.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFood)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.Controls.Add(this.tabPageBill);
            this.tabControlAdmin.Controls.Add(this.tabPageFood);
            this.tabControlAdmin.Controls.Add(this.tabPageFoodCategory);
            this.tabControlAdmin.Controls.Add(this.tabPageTable);
            this.tabControlAdmin.Controls.Add(this.tabPageAccount);
            this.tabControlAdmin.Location = new System.Drawing.Point(12, 12);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.SelectedIndex = 0;
            this.tabControlAdmin.Size = new System.Drawing.Size(1548, 991);
            this.tabControlAdmin.TabIndex = 0;
            // 
            // tabPageBill
            // 
            this.tabPageBill.Controls.Add(this.panel2);
            this.tabPageBill.Controls.Add(this.panel1);
            this.tabPageBill.Location = new System.Drawing.Point(8, 39);
            this.tabPageBill.Name = "tabPageBill";
            this.tabPageBill.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBill.Size = new System.Drawing.Size(1532, 944);
            this.tabPageBill.TabIndex = 0;
            this.tabPageBill.Text = "Doanh Thu";
            this.tabPageBill.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewBill);
            this.panel2.Location = new System.Drawing.Point(6, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1520, 879);
            this.panel2.TabIndex = 1;
            // 
            // dataGridViewBill
            // 
            this.dataGridViewBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBill.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewBill.Name = "dataGridViewBill";
            this.dataGridViewBill.RowHeadersWidth = 82;
            this.dataGridViewBill.RowTemplate.Height = 33;
            this.dataGridViewBill.Size = new System.Drawing.Size(1517, 823);
            this.dataGridViewBill.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonViewBill);
            this.panel1.Controls.Add(this.dateTimePickerToDate);
            this.panel1.Controls.Add(this.dateTimePickerFromDate);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1520, 47);
            this.panel1.TabIndex = 0;
            // 
            // buttonViewBill
            // 
            this.buttonViewBill.Location = new System.Drawing.Point(687, 3);
            this.buttonViewBill.Name = "buttonViewBill";
            this.buttonViewBill.Size = new System.Drawing.Size(164, 40);
            this.buttonViewBill.TabIndex = 3;
            this.buttonViewBill.Text = "Thống Kê";
            this.buttonViewBill.UseVisualStyleBackColor = true;
            this.buttonViewBill.Click += new System.EventHandler(this.buttonViewBill_Click);
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.Location = new System.Drawing.Point(1122, 3);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(395, 31);
            this.dateTimePickerToDate.TabIndex = 1;
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(3, 3);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(395, 31);
            this.dateTimePickerFromDate.TabIndex = 0;
            // 
            // tabPageFood
            // 
            this.tabPageFood.Controls.Add(this.panel6);
            this.tabPageFood.Controls.Add(this.panel5);
            this.tabPageFood.Controls.Add(this.panel4);
            this.tabPageFood.Controls.Add(this.panel3);
            this.tabPageFood.Location = new System.Drawing.Point(8, 39);
            this.tabPageFood.Name = "tabPageFood";
            this.tabPageFood.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFood.Size = new System.Drawing.Size(1532, 944);
            this.tabPageFood.TabIndex = 1;
            this.tabPageFood.Text = "Thức Ăn";
            this.tabPageFood.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.panel10);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(861, 132);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(665, 806);
            this.panel6.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(278, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(372, 33);
            this.comboBox1.TabIndex = 5;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.comboBox1);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Location = new System.Drawing.Point(6, 214);
            this.panel9.Margin = new System.Windows.Forms.Padding(6);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(656, 92);
            this.panel9.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh Mục:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.textBoxFoodName);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Location = new System.Drawing.Point(9, 110);
            this.panel8.Margin = new System.Windows.Forms.Padding(6);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(656, 92);
            this.panel8.TabIndex = 3;
            // 
            // textBoxFoodName
            // 
            this.textBoxFoodName.Location = new System.Drawing.Point(278, 27);
            this.textBoxFoodName.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxFoodName.Name = "textBoxFoodName";
            this.textBoxFoodName.ReadOnly = true;
            this.textBoxFoodName.Size = new System.Drawing.Size(372, 31);
            this.textBoxFoodName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Món:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.textBoxFoodID);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(6, 6);
            this.panel7.Margin = new System.Windows.Forms.Padding(6);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(656, 92);
            this.panel7.TabIndex = 2;
            // 
            // textBoxFoodID
            // 
            this.textBoxFoodID.Location = new System.Drawing.Point(278, 27);
            this.textBoxFoodID.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxFoodID.Name = "textBoxFoodID";
            this.textBoxFoodID.ReadOnly = true;
            this.textBoxFoodID.Size = new System.Drawing.Size(372, 31);
            this.textBoxFoodID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.buttonSearchFood);
            this.panel5.Controls.Add(this.textBoxSearchFood);
            this.panel5.Location = new System.Drawing.Point(861, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(665, 120);
            this.panel5.TabIndex = 1;
            // 
            // buttonSearchFood
            // 
            this.buttonSearchFood.Location = new System.Drawing.Point(505, 0);
            this.buttonSearchFood.Name = "buttonSearchFood";
            this.buttonSearchFood.Size = new System.Drawing.Size(157, 117);
            this.buttonSearchFood.TabIndex = 4;
            this.buttonSearchFood.Text = "Tìm";
            this.buttonSearchFood.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchFood
            // 
            this.textBoxSearchFood.Location = new System.Drawing.Point(22, 43);
            this.textBoxSearchFood.Name = "textBoxSearchFood";
            this.textBoxSearchFood.Size = new System.Drawing.Size(398, 31);
            this.textBoxSearchFood.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridViewFood);
            this.panel4.Location = new System.Drawing.Point(6, 132);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(849, 806);
            this.panel4.TabIndex = 1;
            // 
            // dataGridViewFood
            // 
            this.dataGridViewFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFood.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewFood.Name = "dataGridViewFood";
            this.dataGridViewFood.RowHeadersWidth = 82;
            this.dataGridViewFood.RowTemplate.Height = 33;
            this.dataGridViewFood.Size = new System.Drawing.Size(846, 800);
            this.dataGridViewFood.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.buttonShowFood);
            this.panel3.Controls.Add(this.buttonEditFood);
            this.panel3.Controls.Add(this.buttonDeleteFood);
            this.panel3.Controls.Add(this.buttonAddFood);
            this.panel3.Location = new System.Drawing.Point(6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(849, 120);
            this.panel3.TabIndex = 0;
            // 
            // buttonShowFood
            // 
            this.buttonShowFood.Location = new System.Drawing.Point(689, 0);
            this.buttonShowFood.Name = "buttonShowFood";
            this.buttonShowFood.Size = new System.Drawing.Size(157, 117);
            this.buttonShowFood.TabIndex = 3;
            this.buttonShowFood.Text = "Xem";
            this.buttonShowFood.UseVisualStyleBackColor = true;
            // 
            // buttonEditFood
            // 
            this.buttonEditFood.Location = new System.Drawing.Point(463, 0);
            this.buttonEditFood.Name = "buttonEditFood";
            this.buttonEditFood.Size = new System.Drawing.Size(157, 117);
            this.buttonEditFood.TabIndex = 2;
            this.buttonEditFood.Text = "Sửa";
            this.buttonEditFood.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteFood
            // 
            this.buttonDeleteFood.Location = new System.Drawing.Point(234, 3);
            this.buttonDeleteFood.Name = "buttonDeleteFood";
            this.buttonDeleteFood.Size = new System.Drawing.Size(157, 117);
            this.buttonDeleteFood.TabIndex = 1;
            this.buttonDeleteFood.Text = "Xóa";
            this.buttonDeleteFood.UseVisualStyleBackColor = true;
            // 
            // buttonAddFood
            // 
            this.buttonAddFood.Location = new System.Drawing.Point(0, 0);
            this.buttonAddFood.Name = "buttonAddFood";
            this.buttonAddFood.Size = new System.Drawing.Size(157, 117);
            this.buttonAddFood.TabIndex = 0;
            this.buttonAddFood.Text = "Thêm";
            this.buttonAddFood.UseVisualStyleBackColor = true;
            // 
            // tabPageFoodCategory
            // 
            this.tabPageFoodCategory.Location = new System.Drawing.Point(8, 39);
            this.tabPageFoodCategory.Name = "tabPageFoodCategory";
            this.tabPageFoodCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFoodCategory.Size = new System.Drawing.Size(1532, 944);
            this.tabPageFoodCategory.TabIndex = 2;
            this.tabPageFoodCategory.Text = "Danh mục";
            this.tabPageFoodCategory.UseVisualStyleBackColor = true;
            // 
            // tabPageTable
            // 
            this.tabPageTable.Location = new System.Drawing.Point(8, 39);
            this.tabPageTable.Name = "tabPageTable";
            this.tabPageTable.Size = new System.Drawing.Size(1532, 944);
            this.tabPageTable.TabIndex = 3;
            this.tabPageTable.Text = "Bàn Ăn";
            this.tabPageTable.UseVisualStyleBackColor = true;
            // 
            // tabPageAccount
            // 
            this.tabPageAccount.Location = new System.Drawing.Point(8, 39);
            this.tabPageAccount.Name = "tabPageAccount";
            this.tabPageAccount.Size = new System.Drawing.Size(1532, 944);
            this.tabPageAccount.TabIndex = 4;
            this.tabPageAccount.Text = "Tài Khoản";
            this.tabPageAccount.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.numericUpDown1);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Location = new System.Drawing.Point(6, 318);
            this.panel10.Margin = new System.Windows.Forms.Padding(6);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(656, 92);
            this.panel10.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 37);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(278, 27);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(372, 31);
            this.numericUpDown1.TabIndex = 1;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1572, 1015);
            this.Controls.Add(this.tabControlAdmin);
            this.Name = "fAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAdmin";
            this.tabControlAdmin.ResumeLayout(false);
            this.tabPageBill.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabPageFood.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFood)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAdmin;
        private System.Windows.Forms.TabPage tabPageBill;
        private System.Windows.Forms.TabPage tabPageFood;
        private System.Windows.Forms.TabPage tabPageFoodCategory;
        private System.Windows.Forms.TabPage tabPageTable;
        private System.Windows.Forms.TabPage tabPageAccount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewBill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonViewBill;
        private System.Windows.Forms.DateTimePicker dateTimePickerToDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDate;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button buttonSearchFood;
        private System.Windows.Forms.TextBox textBoxSearchFood;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridViewFood;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonShowFood;
        private System.Windows.Forms.Button buttonEditFood;
        private System.Windows.Forms.Button buttonDeleteFood;
        private System.Windows.Forms.Button buttonAddFood;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox textBoxFoodName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textBoxFoodID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
    }
}