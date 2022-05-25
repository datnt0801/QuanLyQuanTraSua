using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            LoadAccountList();
        }

        void LoadAccountList()
        {
            string connectionSTR = @"Data Source=DESKTOP-1L1IVTL\SQLEXPRESS\SQLEXPRESS;Initial Catalog=QuanLyQuanTraSua;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionSTR);

            string query = "select DisplayName as [Tên hiển thị] from dbo.Account";

            connection.Open();

            SqlCommand sqlCommand = new SqlCommand(query, connection);

            DataTable dataTable = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

            adapter.Fill(dataTable);

            connection.Close();

            dataGridViewAccount.DataSource = dataTable;

            
        }

    }
}
