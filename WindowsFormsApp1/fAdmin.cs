using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;

namespace WindowsFormsApp1
{    
    public partial class fAdmin : Form
    {

        public fAdmin()
        {
            InitializeComponent();
            LoadAccountList();
            LoadFoodList();
            LoadTableFood();
        }


        void LoadFoodList()
        {
            string query = "SELECT id AS [ID], name AS [Tên món], idCategory AS [Danh mục], price AS [Giá] FROM dbo.Food";

            dataGridViewFood.DataSource = DataProvider.Instance.ExecuteQuery(query);

        }

        void LoadAccountList()
        {

            string query = "select * from dbo.Account";

            
            dataGridViewAccount.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        void LoadTableFood()
        {
            string query = "select * from dbo.tablefood";

            dataGridTableFood.DataSource = DataProvider.Instance.ExecuteQuery(query);   
        }

        private void dataGridViewFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxFoodID.Text = dataGridViewFood.CurrentRow.Cells[0].Value.ToString();
            textBoxFoodName.Text = dataGridViewFood.CurrentRow.Cells[1].Value.ToString();
            comboBoxFoodCategory.Items.Add(dataGridViewFood.CurrentRow.Cells[2].Value.ToString());
            numericUpDownFoodPrice.Value.Equals(dataGridViewFood.CurrentRow.Cells[3]);
        }
    }
}
