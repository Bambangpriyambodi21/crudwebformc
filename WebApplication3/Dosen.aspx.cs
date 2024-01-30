using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient; 

namespace WebApplication3
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadRecord();
            }
        }

        string connstring = "server=localhost;uid=root;pwd=1m2h3b4y5W&;database=kuliah";

        protected void Button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            con.Open();
            String sql = "insert into dosen values ('"+int.Parse(TextBox1.Text)+"','"+TextBox2.Text+"')";
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
            String sql = "update dosen set Nama_Dosen = '"+TextBox2.Text+"' where Nip = '"+ int.Parse(TextBox1.Text)+ "'";
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
            String sql = "delete from dosen where Nip = '" + int.Parse(TextBox1.Text) + "'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('successfull deleted');", true);
            LoadRecord();
        }

        void LoadRecord()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            String sql = "select * from dosen ";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter d = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            String sql = "";
            if(TextBox1.Text.Length > 0)
            {
                sql = "select * from dosen where Nip like '%" + TextBox1.Text + "%' limit 0, 5";
            }else if(TextBox2.Text.Length > 0)
            {
                sql = "select * from dosen where Nama_Dosen like '%" + TextBox2.Text + "%' limit 0, 5";
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