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
    public partial class WebForm2 : System.Web.UI.Page
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
            String sql = "select * from perkuliahan";
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
            String sql = "insert into perkuliahan values ('" + int.Parse(TextBox1.Text) + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')";
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
            String sql = "update perkuliahan set Kode_MK = '" + TextBox2.Text + "', Nip='"+ TextBox3.Text +"', Nilai = '"+ TextBox4.Text+"' where Nim = '" + int.Parse(TextBox1.Text) + "'";
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
            String sql = "delete from perkuliahan where Nim = '" + int.Parse(TextBox1.Text) + "'";
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
                sql = "select * from perkuliahan where Nim like '%" + TextBox1.Text + "%' limit 0, 5";
            }
            else if (TextBox2.Text.Length > 0)
            {
                sql = "select * from perkuliahan where Kode_MK like '%" + TextBox2.Text + "%' limit 0, 5";
            }
            else if (TextBox3.Text.Length > 0)
            {
                sql = "select * from perkuliahan where Nip like '%" + TextBox3.Text + "%' limit 0, 5";
            }
            else if (TextBox4.Text.Length > 0)
            {
                sql = "select * from perkuliahan where Nilai like '%" + TextBox4.Text + "%' limit 0, 5";
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