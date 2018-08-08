using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
 
namespace amlak
{
    public partial class newforoshandeform : Form
    {
        public int statusForm;
        public int id;
        public string name;
        public string family;
        public string shenasname;
        public string father;
        public string tells;
        public string tellh;
        public string adressm;
        public string adressw;

        public newforoshandeform(int status)
        {
            InitializeComponent();
       
            statusForm = status;
            if (statusForm == 1)
                this.Text = "ويرايش";
        }

        private void cmdok_Click(object sender, EventArgs e)
        {

           
        }

        private void cmdcancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newforoshandeform_Load(object sender, EventArgs e)
        {
            txtname.Text = name;
            txtfamily.Text = family;
            txtshenasname.Text = shenasname;
            txtfather.Text = father;
            txttell.Text = tells;
            txtmob.Text = tellh;
            txtadress.Text = adressm;
            txtkar.Text = adressw;
        }

        private void cmdok_Click_1(object sender, EventArgs e)
        {
            string constr;
            constr = "data source=.;initial catalog=amlak;integrated security=true";
            SqlConnection con = new SqlConnection(constr);
            con.Open();

            SqlCommand selectcom = con.CreateCommand();
            selectcom.CommandText = "select * from foroshande";
            SqlCommand insertcom = con.CreateCommand();
            insertcom.CommandText = "insert into foroshande(id,name,family,shsh,nfather,tells,tellh,adressmanzel,adresswork)values(@i,@a,@b,@c,@d,@e,@f,@g,@h)";
            insertcom.Parameters.Add(new SqlParameter("@i", SqlDbType.Int, 4, "id"));
            insertcom.Parameters.Add(new SqlParameter("@a", SqlDbType.NVarChar, 50, "name"));
            insertcom.Parameters.Add(new SqlParameter("@b", SqlDbType.NVarChar, 50, "family"));
            insertcom.Parameters.Add(new SqlParameter("@c", SqlDbType.NVarChar, 50, "shsh"));
            insertcom.Parameters.Add(new SqlParameter("@d", SqlDbType.NVarChar, 50, "nfather"));
            insertcom.Parameters.Add(new SqlParameter("@e", SqlDbType.NVarChar, 50, "tells"));
            insertcom.Parameters.Add(new SqlParameter("@f", SqlDbType.NVarChar, 50, "tellh"));
            insertcom.Parameters.Add(new SqlParameter("@g", SqlDbType.NVarChar, 50, "adressmanzel"));
            insertcom.Parameters.Add(new SqlParameter("@h", SqlDbType.NVarChar, 50, "adresswork"));



            SqlDataAdapter da = new SqlDataAdapter();
            da.InsertCommand = insertcom;
            da.SelectCommand = selectcom;


            DataSet ds = new DataSet();
            da.Fill(ds);

            DataTable dt = ds.Tables[0];

            DataRow dr = dt.NewRow();
            dr[0] = System.Convert.ToInt32(txtid.Text);
            dr[1] = txtname.Text;

            dr[2] = txtfamily.Text;
            dr[3] = txtshenasname.Text;
            dr[4] = txtfather.Text;
            dr[5] = txttell.Text;
            dr[6] = txtmob.Text;
            dr[7] = txtadress.Text;
            dr[8] = txtkar.Text;

            dt.Rows.Add(dr);
            da.Update(ds);

            txtid.Text = "";
            txtname.Text = "";

            txtfamily.Text = "";
            txtshenasname.Text = "";
            txtfather.Text = "";
            txttell.Text = "";
            txtmob.Text = "";
            txtadress.Text = "";
            txtkar.Text = "";

            con.Close();
        }

        private void cmdcancle_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
