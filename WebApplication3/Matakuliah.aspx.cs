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
    public partial class WebForm1 : System.Web.UI.Page
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
            String sql = "select * from matakuliah";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter d = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();

        }

        protected void Btn_insert_MK(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            con.Open();
            String sql = "insert into matakuliah values ('" + int.Parse(TextBox1.Text) + "','" + TextBox2.Text + "','" + TextBox3.Text + "')";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('successfull inserted');", true);
            LoadRecord();
        }

        protected void Btn_update_MK(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            con.Open();
            String sql = "update matakuliah set Nama_MK = '" + TextBox2.Text + "', sks = '"+TextBox3.Text+"' where Kode_MK= '" + int.Parse(TextBox1.Text) + "'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('successfull update');", true);
            LoadRecord();
        }

        protected void Btn_delete_MK(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            con.Open();
            String sql = "delete from matakuliah where Kode_MK = '" + int.Parse(TextBox1.Text) + "'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('successfull deleted');", true);
            LoadRecord();
        }

        protected void Btn_search_sks_MK(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            String sql = "";


            if(TextBox1.Text.Length > 0)
            {
              sql = "select * from matakuliah where Kode_MK like '%" + TextBox1.Text + "%' limit 0, 5";
            }
            else if (TextBox2.Text.Length > 0)
            {
                sql = "select * from matakuliah where Nama_MK like '%" + TextBox2.Text + "%' limit 0, 5";

            }
            else if(TextBox3.Text.Length > 0)
            {
              sql = "select * from matakuliah where sks like '%" + TextBox3.Text + "%' limit 0, 5";
                
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