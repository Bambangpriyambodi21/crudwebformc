using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadRecord();
            }
        }

        string connstring = "server=localhost;uid=root;pwd=1m2h3b4y5W&;database=kuliah";

        void LoadRecord()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            String sql = "select * from mahasiswa";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter d = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            con.Open();
            String sql = "insert into mahasiswa values ('" + int.Parse(TextBox1.Text) + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + DropDownList1.Text + "')";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('successfull inserted');", true);
            LoadRecord();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            con.Open();
            String sql = "update mahasiswa set Nama_Mhs = '" + TextBox2.Text + "', Tgl_Lahir = '"+TextBox3.Text+"', Alamat = '"+TextBox4.Text+"', Jenis_Kelamin = '"+DropDownList1.Text+"' where Nim = '" + int.Parse(TextBox1.Text) + "'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('successfull update');", true);
            LoadRecord();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            con.Open();
            String sql = "delete from mahasiswa where Nim = '" + int.Parse(TextBox1.Text) + "'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('successfull deleted');", true);
            LoadRecord();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            String sql = "";
            if (TextBox1.Text.Length > 0)
            {
                sql = "select * from mahasiswa where Nim like '%" + TextBox1.Text + "%' limit 0, 5";
            }
            else if (TextBox2.Text.Length > 0)
            {
                sql = "select * from mahasiswa where Nama_Mhs like '%" + TextBox2.Text + "%' limit 0, 5";
            }
            else if (TextBox3.Text.Length > 0)
            {
                sql = "select * from mahasiswa where Tgl_Lahir like '%" + TextBox3.Text + "%' limit 0, 5";
            }
            else if (TextBox4.Text.Length > 0)
            {
                sql = "select * from mahasiswa where Alamat like '%" + TextBox4.Text + "%' limit 0, 5";
            }
            else if (DropDownList1.Text.Length > 0)
            {
                sql = "select * from mahasiswa where Jenis_Kelamin like '%" + DropDownList1.Text + "%' limit 0, 5";
            }

            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter d = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}