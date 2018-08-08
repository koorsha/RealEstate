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
    public partial class newstoremelkform : Form
    {
        public int statusForm;
        public int id;
        public string adress;
        public string metraj;
        public string gheymat;
        public string keraye;
        public string forosh;
        public string rahni;
  
        public newstoremelkform(int status)
        {
            InitializeComponent();
            statusForm = status;
            if (statusForm == 1)
                this.Text = "ويرايش";
        }

        private void cmdok_Click(object sender, EventArgs e)
        {
            string constr;
            constr = "data source=.;initial catalog=amlak;integrated security=true";
            SqlConnection con = new SqlConnection(constr);
            con.Open();

            SqlCommand selectcom = con.CreateCommand();
            selectcom.CommandText = "select * from jadidmaghaze";

            SqlCommand insertcom = con.CreateCommand();
            insertcom.CommandText = "insert into jadidmaghaze(id,adress,metraj,pish,keraye,forosh,rahn)values(@i,@a,@b,@c,@d,@e,@f)";
            insertcom.Parameters.Add(new SqlParameter("@i", SqlDbType.Int, 4, "id"));
            insertcom.Parameters.Add(new SqlParameter("@a", SqlDbType.NVarChar, 50, "adress"));
            insertcom.Parameters.Add(new SqlParameter("@b", SqlDbType.NVarChar, 50, "metraj"));
            insertcom.Parameters.Add(new SqlParameter("@c", SqlDbType.NVarChar, 50, "pish"));
            insertcom.Parameters.Add(new SqlParameter("@d", SqlDbType.NVarChar, 50, "keraye"));
            insertcom.Parameters.Add(new SqlParameter("@e", SqlDbType.NVarChar, 50, "forosh"));
            insertcom.Parameters.Add(new SqlParameter("@f", SqlDbType.NVarChar, 50, "rahn"));
            



            SqlDataAdapter da = new SqlDataAdapter();
            da.InsertCommand = insertcom;
            da.SelectCommand = selectcom;


            DataSet ds = new DataSet();
            da.Fill(ds);

            DataTable dt = ds.Tables[0];

            DataRow dr = dt.NewRow();
            dr[0] = System.Convert.ToInt32(txtid.Text);
            dr[1] = txtadress.Text;
            dr[2] = txtmetraj.Text;
            dr[3] = txtpish.Text;
            dr[4] = txtkeraye.Text;
            dr[5] = txtforosh.Text;
            dr[6] = txtrahn.Text;
          







            dt.Rows.Add(dr);
            da.Update(ds);

            txtid.Text = "";
            txtadress.Text = "";
            txtmetraj.Text = "";

            txtpish.Text = "";
            txtkeraye.Text = "";
            txtforosh.Text = "";
            txtrahn.Text = "";
           


            con.Close();


        }

        private void cmdcancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newstoremelkform_Load(object sender, EventArgs e)
        {
            txtadress.Text = adress;
            txtmetraj.Text = metraj;
            txtpish.Text = gheymat;
            txtkeraye.Text = keraye;
            txtforosh.Text = forosh;
            txtrahn.Text = rahni;
          
        ;
        }

        private void cmdcancle_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
