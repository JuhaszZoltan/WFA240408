using MySql.Data.MySqlClient;

namespace WFA240408
{
    public partial class MainForm : Form
    {
        private string _connectionString = "SERVER=localhost;DATABASE=dolgozat001;UID=root;";
        Dictionary<int, string> users = new();

        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
            btn.Click += Btn_Click;
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            if (cb.SelectedIndex < 0) return;
            int uid = users.Single(u => u.Value == cb.Text).Key;

            using MySqlConnection conn = new(_connectionString);
            conn.Open();

            MySqlDataAdapter adapter = new()
            {
                InsertCommand = new(
                    "INSERT INTO posts (user_id, title, content) VALUES " +
                    $"({uid}, '-', '{tb.Text}');", conn),
            };
            adapter.InsertCommand.ExecuteNonQuery();

            MessageBox.Show("sikeresen hozzáadva!");
            ReloadDGV();
        }

        private void MainForm_Load(object? sender, EventArgs e)
        {
            ReloadDGV();
            using MySqlConnection conn = new(_connectionString);
            conn.Open();

            MySqlDataReader reader = new MySqlCommand(
                "SELECT user_id, username FROM users",
                conn).ExecuteReader();

            while (reader.Read())
            {
                users.Add(reader.GetInt32(0), reader.GetString(1));
                cb.Items.Add(reader[1]);
            }
        }

        private void ReloadDGV()
        {
            using MySqlConnection conn = new(_connectionString);
            conn.Open();

            MySqlDataReader reader = new MySqlCommand(
                "SELECT post_id, username, content FROM " +
                "posts INNER JOIN users ON posts.user_id = users.user_id " +
                "ORDER BY post_id ASC;",
                conn).ExecuteReader();

            dgv.Rows.Clear();
            while (reader.Read())
            {
                dgv.Rows.Add(reader[0], reader[1], reader[2]);
            }
        }
    }
}
