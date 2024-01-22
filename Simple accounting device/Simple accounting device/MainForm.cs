using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Simple_accounting_device
{
    public partial class MainForm : Form
    {
        private const string ApiUrl = "http://localhost/api/amount/amountData.php"; // 替換成你的 PHP API URL

        public MainForm()
        {
            InitializeComponent();
           
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();
            UpdateTotalLabels(); // 在 MainForm 載入時更新 Label
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private async Task LoadDataAsync()
        {

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // 發送 GET 請求
                    var response = await client.GetAsync(ApiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        // 解析 JSON 資料
                        string responseBody = await response.Content.ReadAsStringAsync();
                        List<AccountingData> accountingDataList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<AccountingData>>(responseBody);

                        // 將資料繫結到 DataGridView
                        dataGridView1.DataSource = ConvertToDataTable(accountingDataList);
                        UpdateTotalLabels();

                    }
                    else
                    {
                        MessageBox.Show("發生錯誤：" + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("發生錯誤：" + ex.Message);
                }
            }
        }

        private DataTable ConvertToDataTable(List<AccountingData> accountingDataList)
        {
            // 將 List<AccountingData> 轉換為 DataTable
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int)); // 將id 列設定隱藏
            dataTable.Columns.Add("交易日", typeof(DateTime));
            dataTable.Columns.Add("金額", typeof(int));
            //dataTable.Columns.Add("Balance", typeof(int));
            dataTable.Columns.Add("類型", typeof(string));
            dataTable.Columns.Add("支出/存入", typeof(string));
            dataTable.Columns.Add("記帳日期", typeof(DateTime));

            
            foreach (var accountingData in accountingDataList)
            {
                dataTable.Rows.Add(accountingData.Id,accountingData.CostDate, accountingData.Amount, accountingData.Category, accountingData.Type, accountingData.WriteDate);
            }

            

            return dataTable;
        }

        private void RefreshTableData()
        {
            LoadDataAsync();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 建立 addAccDate 窗體實例
            addAccDate addForm = new addAccDate();

            // 訂閱事件，新增資料時會刷新表格數據
            addForm.OnDataAdded += RefreshTableData;

            // 顯示新增視窗
            addForm.ShowDialog();

            
        }
        // 获取总支出的方法，你需要根据你的数据结构和字段名称进行调整

        // 根据交易类型获取总金额的通用方法
        private int GetTotalAmountByType(string transactionType)
        {
            int totalAmount = 0;

            // 檢查 dataGridView1.DataSource 是否為 DataTable
            if (dataGridView1.DataSource is DataTable dataTable)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    // 使用 row["Type"] 取得資料表中的 Type 欄位值
                    if (row["支出/存入"].ToString() == transactionType)
                    {
                        // 使用 Convert.ToInt32 將資料表中的 Amount 欄位值轉換為整數
                        totalAmount += Convert.ToInt32(row["金額"]);
                    }
                }
            }

            return totalAmount;
        }

private void UpdateTotalLabels()
{
    int totalExpense = GetTotalAmountByType("支出");
    int totalIncome = GetTotalAmountByType("存入");
    int currentBalance = totalIncome - totalExpense;

    this.Invoke((MethodInvoker)delegate
    {
        totalExpenseLabel.Text = $"總支出: {totalExpense}";
        totalIncomeLabel.Text = $"總收入: {totalIncome}";
        currentBalanceLabel.Text = $"目前餘額: {currentBalance}";
    });
}





        private async void delButton_Click(object sender, EventArgs e)
        {
            // 获取选中行的 ID
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                int idToDelete = (int)dataGridView1.Rows[selectedRowIndex].Cells["Id"].Value;

                // 发送 DELETE 请求
                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        // 构建删除数据的 URL
                        string deleteUrl = $"http://localhost/api/amount/amountData.php?id={idToDelete}";

                        // 发送 DELETE 请求
                        var response = await client.DeleteAsync(deleteUrl);

                        if (response.IsSuccessStatusCode)
                        {
                            // 删除成功后刷新表格数据和总支出、总收入
                            await LoadDataAsync();
                            UpdateTotalLabels();
                        }
                        else
                        {
                            MessageBox.Show("删除失败：" + response.StatusCode);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("发生错误：" + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择要删除的行");
            }
        }

    }


    public class AccountingData
    {
        public int Id { get; set; }
        public DateTime CostDate { get; set; }
        public int Amount { get; set; }
        public int Balance { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public DateTime WriteDate { get; set; }
    }
}
