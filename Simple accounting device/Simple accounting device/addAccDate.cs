using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_accounting_device
{
    public partial class addAccDate : Form
    {
        public event Action OnDataAdded;
        public addAccDate()
        {
            InitializeComponent();
        }

        private void addAccDate_Load(object sender, EventArgs e)
        {
            
        }
        private async void addButton_Click(object sender, EventArgs e)
        {
            if (amountTextBox.Text == string.Empty || transactionTypeComboBox.SelectedItem == null 
                || categoryComboBox.SelectedItem == null)
            {
                if(amountTextBox.Text == string.Empty)
                {
                    amountError.Visible = true;
                }
                if(transactionTypeComboBox.SelectedItem == null)
                {
                    typeError.Visible = true;
                }
                if(categoryComboBox.SelectedItem == null)
                {
                    costTyprError.Visible = true;
                }
            }
            else 
            {
                // 取得使用者輸入的資料
                string costDate = dateDateTimePicker.Value.ToString("yyyy-MM-dd"); // 將日期格式轉換為 "yyyy-MM-dd"
                string amount = amountTextBox.Text;
                string transactionType = transactionTypeComboBox.SelectedItem.ToString();
                string category = categoryComboBox.SelectedItem.ToString();


                // 使用 HttpClient 進行 API 請求
                using (HttpClient client = new HttpClient())
                {
                    // API 的網址
                    string apiUrl = "http://localhost/api/amount/amountData.php";

                    // 準備要傳送的資料
                    var data = new
                    {
                        costDate,
                        amount,
                        type = transactionType,
                        category
                    };

                    // 將資料序列化為 JSON 字串
                    string jsonData = JsonConvert.SerializeObject(data);

                    // 設定要傳送的內容類型為 application/json
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    // 傳送 POST 請求
                    HttpResponseMessage response = await client.PostAsync(apiUrl, new StringContent(jsonData, Encoding.UTF8, "application/json"));

                    // 確認請求是否成功
                    if (response.IsSuccessStatusCode)
                    {
                        //關閉視窗
                        this.Close();

                        // 用於觸發MainFrom刷新
                        OnDataAdded?.Invoke();
                    }
                    else
                    {
                        MessageBox.Show("API 請求失敗", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void transactionTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (transactionTypeComboBox.SelectedItem.ToString() == "存入")
            {
                // 當選擇存入時， categoryComboBox 的選項
                categoryComboBox.Items.Clear();
                categoryComboBox.Items.AddRange(new object[] { "工資", "現金收入", "其他" });
            }
            else
            {
                // 當選則支出時， categoryComboBox 的選項
                categoryComboBox.Items.Clear();
                categoryComboBox.Items.AddRange(new object[] { "飲食", "娛樂", "交通","日常用品","其他" });
            }
        }
    }
}
