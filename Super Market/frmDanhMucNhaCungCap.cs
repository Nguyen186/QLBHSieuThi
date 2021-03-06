using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Super_Market
{
    public partial class frmDanhMucNhaCungCap : Form
    {
        private static SqlConnection conn;// = new SqlConnection(@"Data Source=SP-47C50C180EE0\DUONGDX;AttachDbFilename=D:\c#\project\Super Market Management\Super Market Management\spMarketmgmt.mdf;Integrated Security=True");
        public frmDanhMucNhaCungCap()
        {
            InitializeComponent();
            conn = new SqlConnection(ConnectionString.getConnect());
            GetListProvider();
            GetProviderInfo();
        }
        private void GetListProvider()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                conn.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Providers", conn);
                da.Fill(ds, "Providers");
                LstTenNCC.DataSource = ds.Tables[0];
                LstTenNCC.DisplayMember = "Name";
                LstTenNCC.ValueMember = "ProviderID";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Norther says", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void GetProviderInfo()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                conn.Open();
                int ProviderID = Convert.ToInt32(LstTenNCC.SelectedValue.ToString());
                SqlCommand commnand = new SqlCommand("Select * From Providers Where ProviderID =" + ProviderID + "", conn);
                SqlDataAdapter da = new SqlDataAdapter(commnand);
                DataSet ds = new DataSet();
                da.Fill(ds, "Providers");
                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    TxtName.Text = ds.Tables[0].Rows[i - 1]["Name"].ToString();
                    TxtDiachi.Text = ds.Tables[0].Rows[i - 1]["Address"].ToString();
                    TxtDienThoai.Text = ds.Tables[0].Rows[i - 1]["Tel"].ToString();
                    TxtMatHangCC.Text = ds.Tables[0].Rows[i - 1]["TypeName"].ToString();
                }
                conn.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

        }
        private void frmDanhMucNhaCungCap_Load(object sender, EventArgs e)
        {
            GetListProvider();
        }
        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            DialogResult = MessageBox.Show("Are you sure want to delete", "Norther says", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("Delete from Providers where ProviderID = @pro", conn);
                    command.Parameters.Add("@pro", SqlDbType.Int).Value = int.Parse(LstTenNCC.SelectedValue.ToString());
                    command.ExecuteNonQuery();
                    conn.Close();
                    GetListProvider();
                    LstTenNCC.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Norther says", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("Update Providers set Name = @p1,Address =@p2,Tel=@p3,TypeName=@p4 where ProviderID = " + Int32.Parse(LstTenNCC.SelectedValue.ToString()) + "", conn);
                command.Parameters.Add("@p1", SqlDbType.NVarChar, 50).Value = TxtName.Text.ToString();
                command.Parameters.Add("@p2", SqlDbType.NVarChar, 50).Value = TxtDiachi.Text.ToString();
                command.Parameters.Add("@p3", SqlDbType.NVarChar, 10).Value = TxtDienThoai.Text.ToString();
                command.Parameters.Add("@p4", SqlDbType.NVarChar, 50).Value = TxtMatHangCC.Text.ToString();
                int i = command.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Cập nhật thay đổi thành công", "Norther says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                GetListProvider();
                GetProviderInfo();
                LstTenNCC.Refresh();
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Norther says", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                conn.Close();
            }
        }

        private void BtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            frmThemNhaCC frm = new frmThemNhaCC();
            frm.Show();
        }

        private void LstTenNCC_SelectedValueChanged(object sender, EventArgs e)
        {
            GetProviderInfo();
        }
    }
}