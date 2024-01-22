using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_accounting_device
{
    public partial class LoginFrame : Form
    {
        private const string ApiUrl = "http://localhost/api/login.php"; // PHP API URL
        public LoginFrame()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            userExLabel.Visible = false;
            if(usernameTextBox.Text == string.Empty)
            {
                userExLabel.Visible = true;
            }
        }

        private void LoginFrame_Load(object sender, EventArgs e)
        {


        }
        private void LoginFrame_FormClosed(object sender, FormClosedEventArgs e)
        {
            // 這是在表單關閉時結束應用程式的標準做法
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            passEXLabel.Visible = false;
            if(passwordTextBox.Text == string.Empty)
            {
                passEXLabel.Visible = true;
            }
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            string enteredUsername = usernameTextBox.Text;
            string enteredPassword = passwordTextBox.Text;
            userError.Visible = false;
            passError.Visible = false;
            if (usernameTextBox.Text == string.Empty || passwordTextBox.Text == string.Empty)
            {
                if(usernameTextBox.Text == string.Empty)
                    userError.Visible = true;
                if (passwordTextBox.Text == string.Empty)
                    passError.Visible = true;

            }
            else
            {
                if (IsValidUser(enteredUsername, enteredPassword))
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide(); // 隱藏登入視窗
                }
                else
                {
                    using (HttpClient client = new HttpClient())
                    {
                        // 準備 POST 資料
                        var postData = new System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, string>>();
                        postData.Add(new System.Collections.Generic.KeyValuePair<string, string>("account", enteredUsername));
                        postData.Add(new System.Collections.Generic.KeyValuePair<string, string>("password", enteredPassword));

                        // 發送 POST 請求
                        var response = await client.PostAsync(ApiUrl, new FormUrlEncodedContent(postData));

                        // 處理 API 回應
                        if (response.IsSuccessStatusCode)
                        {
                            string responseBody = await response.Content.ReadAsStringAsync();
                            // 在這裡處理從 PHP 回傳的 JSON 資料

                            dynamic jsonResponse = Newtonsoft.Json.JsonConvert.DeserializeObject(responseBody);

                            // 根據回應中的 status 做相應處理
                            if (jsonResponse.status == "success")
                            {
                                //MessageBox.Show("登入成功！權限: " + jsonResponse.permissions);
                                MainForm mainForm = new MainForm();
                                mainForm.Show();
                                this.Hide(); // 隱藏登入視窗
                            }
                            else
                            {
                                MessageBox.Show("登入失敗：" + jsonResponse.message);
                            }
                        }
                        else
                        {
                            string responseBody = await response.Content.ReadAsStringAsync();
                            // 在這裡處理從 PHP 回傳的 JSON 資料

                            dynamic jsonResponse = Newtonsoft.Json.JsonConvert.DeserializeObject(responseBody);
                            //  MessageBox.Show("登入失敗：" + jsonResponse.message);
                            MessageBox.Show("請檢查帳號或密碼是否錯誤!", "登入錯誤",MessageBoxButtons.OK, MessageBoxIcon.Error);
                            passwordTextBox.Text = "";
                        }
                    }
                }
            }
        }
        private bool IsValidUser(string username, string password)//test用
        {
            // Hardcoded validation (replace with actual authentication logic)
            return username == "1" && password == "1";
        }

    }
}
