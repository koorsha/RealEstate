using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace amlak
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void cmdlogin_Click(object sender, EventArgs e)
        {
              mainform  f = new mainform ();
            string s = "select count(*) from login where name='" + this.txtuser .Text  + "' and pass='" + this.txtpass .Text  + "'";
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
            con.ConnectionString = "Data source=.;Initial catalog =amlak;Integrated security=true";
            con.Open();
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(s, con);
            int d = Convert.ToInt16(cmd.ExecuteScalar());
            if (d == 0) { MessageBox.Show("نام کاربری یا کلمه عبور شما معتبر نیست"); txtuser .Text = ""; txtpass .Text  = ""; }
            else
            {

                f.Show();
                this.Hide();
            }

                
             
        }

        private void loginform_Load(object sender, EventArgs e)
        {

        }

    }
}
