namespace Simple_accounting_device
{
    partial class addAccDate
    {
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.ComboBox transactionTypeComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Button addButton;

        private void InitializeComponent()
        {
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.transactionTypeComboBox = new System.Windows.Forms.ComboBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.amountError = new System.Windows.Forms.Label();
            this.typeError = new System.Windows.Forms.Label();
            this.costTyprError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDateTimePicker.Location = new System.Drawing.Point(26, 39);
            this.dateDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(153, 27);
            this.dateDateTimePicker.TabIndex = 1;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(206, 39);
            this.amountTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(127, 27);
            this.amountTextBox.TabIndex = 2;
            // 
            // transactionTypeComboBox
            // 
            this.transactionTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transactionTypeComboBox.FormattingEnabled = true;
            this.transactionTypeComboBox.Items.AddRange(new object[] {
            "支出",
            "存入"});
            this.transactionTypeComboBox.Location = new System.Drawing.Point(363, 39);
            this.transactionTypeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.transactionTypeComboBox.Name = "transactionTypeComboBox";
            this.transactionTypeComboBox.Size = new System.Drawing.Size(102, 27);
            this.transactionTypeComboBox.TabIndex = 3;
            this.transactionTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.transactionTypeComboBox_SelectedIndexChanged);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "飲食",
            "交通",
            "娛樂",
            "工資",
            "其他"});
            this.categoryComboBox.Location = new System.Drawing.Point(492, 39);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(153, 27);
            this.categoryComboBox.TabIndex = 4;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(671, 38);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(96, 29);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "新增";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "交易日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "交易金額";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "交易金額";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(530, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "交易金額";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "支出/收入";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(530, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "消費類型";
            // 
            // amountError
            // 
            this.amountError.AutoSize = true;
            this.amountError.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.amountError.ForeColor = System.Drawing.Color.Crimson;
            this.amountError.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.amountError.Location = new System.Drawing.Point(206, 70);
            this.amountError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.amountError.Name = "amountError";
            this.amountError.Size = new System.Drawing.Size(67, 15);
            this.amountError.TabIndex = 7;
            this.amountError.Text = "*請輸入金額";
            this.amountError.Visible = false;
            // 
            // typeError
            // 
            this.typeError.AutoSize = true;
            this.typeError.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.typeError.ForeColor = System.Drawing.Color.Crimson;
            this.typeError.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.typeError.Location = new System.Drawing.Point(363, 70);
            this.typeError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.typeError.Name = "typeError";
            this.typeError.Size = new System.Drawing.Size(67, 15);
            this.typeError.TabIndex = 7;
            this.typeError.Text = "*請選擇類別";
            this.typeError.Visible = false;
            // 
            // costTyprError
            // 
            this.costTyprError.AutoSize = true;
            this.costTyprError.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.costTyprError.ForeColor = System.Drawing.Color.Crimson;
            this.costTyprError.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.costTyprError.Location = new System.Drawing.Point(492, 70);
            this.costTyprError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.costTyprError.Name = "costTyprError";
            this.costTyprError.Size = new System.Drawing.Size(67, 15);
            this.costTyprError.TabIndex = 7;
            this.costTyprError.Text = "*請選擇類型";
            this.costTyprError.Visible = false;
            // 
            // addAccDate
            // 
            this.AcceptButton = this.addButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 88);
            this.Controls.Add(this.costTyprError);
            this.Controls.Add(this.typeError);
            this.Controls.Add(this.amountError);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.transactionTypeComboBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.addButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "addAccDate";
            this.Text = "新增資料";
            this.Load += new System.EventHandler(this.addAccDate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label amountError;
        private System.Windows.Forms.Label typeError;
        private System.Windows.Forms.Label costTyprError;
    }
}
