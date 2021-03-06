using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Super_Market
{
    public partial class frmDangNhap : Form
    {
        private static SqlConnection conn;
        public frmDangNhap()
        {


            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

            conn = new SqlConnection(ConnectionString.getConnect());
            CBChucVuBinding();

        }

        private void CBChucVuBinding()
        {

            try
            {
                conn.Open();
                DataSet ds = new DataSet("Employees");
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT distinct Title FROM Employees", conn);
                adapter.Fill(ds);
                CBChucvu.DataSource = ds.Tables[0];
                CBChucvu.DisplayMember = "Title";
                CBChucvu.ValueMember = "Title";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "errors", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            }
        }

        private bool ValidateLogin(string Username, string Password, string Title)
        {
            bool rv = false;
            try

            {
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "ValidateUserLogin";
                command.Parameters.Add("@Username", SqlDbType.NChar, 10).Value = Username;
                command.Parameters.Add("@Password", SqlDbType.NChar, 10).Value = Password;
                command.Parameters.Add("@Title", SqlDbType.NVarChar, 50).Value = Title;
                rv = Convert.ToBoolean(command.ExecuteScalar());
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "errors", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            return rv;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản", "Norther says", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else if (txtPassword.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập Mật khẩu", "Norther says", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else
            {
                bool isValid = this.ValidateLogin(this.txtUsername.Text, this.txtPassword.Text, (string)this.CBChucvu.SelectedValue);
                if (isValid)
                {
                    this.Hide();

                    try
                    {
                        conn.Open();
                        SqlCommand Command = new SqlCommand("Select EmployeeID,EmployeeName,Title,Sex,Username from Employees where Username = @Username", conn);
                        Command.Parameters.Add("@Username", SqlDbType.NChar, 10).Value = txtUsername.Text;
                        SqlDataReader reader = Command.ExecuteReader();
                        if (reader.Read())
                        {
                            Session.set(int.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString());
                        }
                        reader.Close();
                        conn.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Norther says", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Tên hoặc mật khẩu không đúng", "Norther says", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    txtPassword.Text = "";
                    txtUsername.Text = "";
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }




    }
}
