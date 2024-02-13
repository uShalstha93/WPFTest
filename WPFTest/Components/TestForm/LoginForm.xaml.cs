using System.Data.SqlClient;
using System.Windows;

namespace WPFTest.Components.TestForm
{
    /// <summary>
    /// Interaction logic for LoginForm.xaml
    /// </summary>
    public partial class LoginForm : Window
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {

            string username = txtUsername.Text;
            string password = txtPassword.Password;

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please Enter Username!!", "Username Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please Enter Password!!", "Password Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            else
            {
                string sqlCon = "Data Source=uShal;Initial Catalog=TestData;Integrated Security=True;Encrypt=False";
                SqlConnection con = new SqlConnection(sqlCon);
                try
                {
                    if (con.State == System.Data.ConnectionState.Closed)
                    {
                        con.Open();
                        string sqlQuery = @"Select * from Users where username=@username";
                        using (SqlCommand sqlCmd = new SqlCommand(sqlQuery, con))
                        {
                            sqlCmd.Parameters.AddWithValue("@username", txtUsername.Text);
                            using (SqlDataReader dr = sqlCmd.ExecuteReader())
                            {
                                if (dr.Read())
                                {
                                    string storedPassword = dr["password"].ToString();

                                    if (storedPassword == txtPassword.Password)
                                    {
                                        //MessageBox.Show($"Logged In As: {username}","success",MessageBoxButton.OK, MessageBoxImage.Warning);
                                        //MainWindow mainWindow = new MainWindow();
                                        //mainWindow.Show();
                                        //DashboardHome dashboardHome = new DashboardHome();
                                        //dashboardHome.Show();
                                        Homepage homepage = new Homepage();
                                        homepage.Show();
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Incorrect Password!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Username Not Found!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                                }
                            }
                        }
                        //SqlDataAdapter sqlCmd = new SqlDataAdapter(sqlQuery, con);
                        //DataTable dTable = new DataTable();
                        //sqlCmd.Fill(dTable);
                        //if(dTable.Rows.Count > 0)
                        //{
                        //    username = txtUsername.Text;
                        //    password = txtPassword.Password;

                        //    MessageBox.Show("Login by Anu", "Success", MessageBoxButton.OK);

                        //    MainWindow mainWindow = new MainWindow();
                        //    mainWindow.Show();
                        //    this.Close();
                        //}
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //private void txtUsername_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        //{
        //    if(!string.IsNullOrEmpty(txtUsername.Text))
        //    {
        //        btnLogin.IsEnabled = true;
        //    }
        //    else
        //    {
        //        btnLogin.IsEnabled = false;
        //    }
        //}
    }
}
