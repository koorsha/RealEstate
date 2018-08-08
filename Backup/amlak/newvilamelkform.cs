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
    public partial class newvilamelkform : Form
    {
        public int statusForm;
        public int id;
        public string adress;
        public string metraj;
        public string gheymat;
        public string keraye;
        public string forosh;
        public string rahni;
        public string otagh;

        public newvilamelkform(int status)
        {
            InitializeComponent();
            statusForm = status;
            if (statusForm == 1)
                this.Text = "ويرايش";
        }

        private void newvilamelkform_Load(object sender, EventArgs e)
        {
            txtid.Text =System.Convert .ToString (id);
            txtadress.Text = adress;
            txtmetraj.Text = metraj;
            txtpish.Text = gheymat;
            txtkeraye.Text = keraye;
            txtforosh.Text = forosh;
            txtrahn.Text = rahni;
            txtotagh.Text = otagh;



        }

        private void cmdok_Click(object sender, EventArgs e)
        {
            string constr;
            constr = "data source=.;initial catalog=amlak;integrated security=true";
            SqlConnection con = new SqlConnection(constr);
            con.Open();

            SqlCommand selectcom = con.CreateCommand();
            selectcom.CommandText = "select * from jadidvilla";

            SqlCommand insertcom = con.CreateCommand();
            insertcom.CommandText = "insert into jadidvilla(id,adress,metraj,pish,keraye,forosh,rahn,otagh)values(@i,@a,@b,@c,@d,@e,@f,@g)";
            insertcom.Parameters.Add(new SqlParameter("@i", SqlDbType.Int, 4, "id"));
            insertcom.Parameters.Add(new SqlParameter("@a", SqlDbType.NVarChar, 50, "adress"));
            insertcom.Parameters.Add(new SqlParameter("@b", SqlDbType.NVarChar, 50, "metraj"));
            insertcom.Parameters.Add(new SqlParameter("@c", SqlDbType.NVarChar, 50, "pish"));
            insertcom.Parameters.Add(new SqlParameter("@d", SqlDbType.NVarChar, 50, "keraye"));
            insertcom.Parameters.Add(new SqlParameter("@e", SqlDbType.NVarChar, 50, "forosh"));
            insertcom.Parameters.Add(new SqlParameter("@f", SqlDbType.NVarChar, 50, "rahn"));
            insertcom.Parameters.Add(new SqlParameter("@g", SqlDbType.NVarChar, 50, "otagh"));



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
            dr[7] = txtotagh.Text;







            dt.Rows.Add(dr);
            da.Update(ds);

            txtid.Text = "";
            txtadress.Text = "";
            txtmetraj.Text = "";

            txtpish.Text = "";
            txtkeraye.Text = "";
            txtforosh.Text = "";
            txtrahn.Text = "";

            txtotagh.Text = "";


            con.Close();

        }

        

        private void cmdcancle_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
