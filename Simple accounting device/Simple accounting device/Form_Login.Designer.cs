
namespace Simple_accounting_device
{
    partial class LoginFrame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFrame));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.accLable = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passLable = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.userError = new System.Windows.Forms.Label();
            this.passError = new System.Windows.Forms.Label();
            this.userExLabel = new System.Windows.Forms.Label();
            this.passEXLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::Simple_accounting_device.Properties.Resources.free_user_icon_3296_2_0_thumb;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // accLable
            // 
            resources.ApplyResources(this.accLable, "accLable");
            this.accLable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.accLable.Name = "accLable";
            // 
            // usernameTextBox
            // 
            resources.ApplyResources(this.usernameTextBox, "usernameTextBox");
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // passLable
            // 
            resources.ApplyResources(this.passLable, "passLable");
            this.passLable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passLable.Name = "passLable";
            // 
            // passwordTextBox
            // 
            resources.ApplyResources(this.passwordTextBox, "passwordTextBox");
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // loginButton
            // 
            resources.ApplyResources(this.loginButton, "loginButton");
            this.loginButton.Name = "loginButton";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // userError
            // 
            resources.ApplyResources(this.userError, "userError");
            this.userError.ForeColor = System.Drawing.Color.Yellow;
            this.userError.Name = "userError";
            // 
            // passError
            // 
            resources.ApplyResources(this.passError, "passError");
            this.passError.ForeColor = System.Drawing.Color.Yellow;
            this.passError.Name = "passError";
            // 
            // userExLabel
            // 
            resources.ApplyResources(this.userExLabel, "userExLabel");
            this.userExLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userExLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.userExLabel.Name = "userExLabel";
            // 
            // passEXLabel
            // 
            resources.ApplyResources(this.passEXLabel, "passEXLabel");
            this.passEXLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passEXLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.passEXLabel.Name = "passEXLabel";
            // 
            // LoginFrame
            // 
            this.AcceptButton = this.loginButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.Controls.Add(this.passEXLabel);
            this.Controls.Add(this.userExLabel);
            this.Controls.Add(this.passError);
            this.Controls.Add(this.userError);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passLable);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.accLable);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LoginFrame";
            this.Load += new System.EventHandler(this.LoginFrame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label accLable;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label passLable;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label userError;
        private System.Windows.Forms.Label passError;
        private System.Windows.Forms.Label userExLabel;
        private System.Windows.Forms.Label passEXLabel;
    }
}

