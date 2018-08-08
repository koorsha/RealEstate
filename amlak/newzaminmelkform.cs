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
    public partial class newzaminmelkform : Form
    {
        public int statusForm;
        public int id;
        public string adress;
        public string metraj;
        
        public string forosh;
       
        public newzaminmelkform(int status)
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
            selectcom.CommandText = "select * from jadidzamin";

            SqlCommand insertcom = con.CreateCommand();
            insertcom.CommandText = "insert into jadidzamin(id,adress,metraj,forosh)values(@k,@n,@f,@h)";
            insertcom.Parameters.Add(new SqlParameter("@k", SqlDbType.Int, 4, "id"));
            insertcom.Parameters.Add(new SqlParameter("@n", SqlDbType.NVarChar, 50, "adress"));
            insertcom.Parameters.Add(new SqlParameter("@f", SqlDbType.NVarChar, 50, "metraj"));
            insertcom.Parameters.Add(new SqlParameter("@h", SqlDbType.NVarChar, 50, "forosh"));


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
            dr[3] = txtforosh.Text;

            dt.Rows.Add(dr);
            da.Update(ds);

            txtid.Text = "";
            txtadress.Text = "";
            txtmetraj.Text = "";
            txtforosh.Text = "";
            con.Close();



        }

        private void newzaminmelkform_Load(object sender, EventArgs e)
        {
            txtid.Text = System.Convert.ToString(id);
            txtadress.Text = adress;
            txtmetraj.Text = metraj;

            txtforosh.Text = forosh;
            
         
        }

       

        private void cmdcancle_Click_1(object sender, EventArgs e)
        {
           this.Close();
        }

       

       
    }
}
