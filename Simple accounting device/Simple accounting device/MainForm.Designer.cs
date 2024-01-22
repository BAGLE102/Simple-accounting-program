
namespace Simple_accounting_device
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.addButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.delButton = new System.Windows.Forms.Button();
            this.reButton = new System.Windows.Forms.Button();
            this.totalExpenseLabel = new System.Windows.Forms.Label();
            this.totalIncomeLabel = new System.Windows.Forms.Label();
            this.currentBalanceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            resources.ApplyResources(this.addButton, "addButton");
            this.addButton.Name = "addButton";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // delButton
            // 
            resources.ApplyResources(this.delButton, "delButton");
            this.delButton.Name = "delButton";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // reButton
            // 
            resources.ApplyResources(this.reButton, "reButton");
            this.reButton.Name = "reButton";
            this.reButton.UseVisualStyleBackColor = true;
            // 
            // totalExpenseLabel
            // 
            resources.ApplyResources(this.totalExpenseLabel, "totalExpenseLabel");
            this.totalExpenseLabel.Name = "totalExpenseLabel";
            // 
            // totalIncomeLabel
            // 
            resources.ApplyResources(this.totalIncomeLabel, "totalIncomeLabel");
            this.totalIncomeLabel.Name = "totalIncomeLabel";
            // 
            // currentBalanceLabel
            // 
            resources.ApplyResources(this.currentBalanceLabel, "currentBalanceLabel");
            this.currentBalanceLabel.Name = "currentBalanceLabel";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.currentBalanceLabel);
            this.Controls.Add(this.totalIncomeLabel);
            this.Controls.Add(this.totalExpenseLabel);
            this.Controls.Add(this.reButton);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button reButton;
        private System.Windows.Forms.Label totalExpenseLabel;
        private System.Windows.Forms.Label totalIncomeLabel;
        private System.Windows.Forms.Label currentBalanceLabel;
    }
}