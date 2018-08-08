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
    public partial class newapartementrahniform : Form
    {
        public int statusForm;
        public int id;
        public string adress;
        public string gheymat;
        public string kharidar;
        public string saheb;
        public string tarikh;
        public newapartementrahniform(int status)
        {
            InitializeComponent();
            statusForm = status;
            if (statusForm == 1)
                this.Text = "ويرايش";
        }

        private void newapartementrahniform_Load(object sender, EventArgs e)
        {

            txtadress.Text = adress;
            txtcost.Text = gheymat;
            txtkharidar.Text = kharidar;
            txtsaheb.Text = saheb;
            txtdata.Text = tarikh;

        }

        private void cmdok_Click(object sender, EventArgs e)
        {
            string constr;
            constr = "data source=.;initial catalog=amlak;integrated security=true";
            SqlConnection con = new SqlConnection(constr);
            con.Open();

            SqlCommand selectcom = con.CreateCommand();
            selectcom.CommandText = "select * from rahniaparteman";

            SqlCommand insertcom = con.CreateCommand();
            insertcom.CommandText = "insert into rahniaparteman(id,adress,gheymat,namekharidar,namesaheb,tarikh)values(@i,@a,@b,@c,@d,@e)";
            insertcom.Parameters.Add(new SqlParameter("@i", SqlDbType.Int, 4, "id"));
            insertcom.Parameters.Add(new SqlParameter("@a", SqlDbType.NVarChar, 50, "adress"));
            insertcom.Parameters.Add(new SqlParameter("@b", SqlDbType.NVarChar, 50, "gheymat"));
            insertcom.Parameters.Add(new SqlParameter("@c", SqlDbType.NVarChar, 50, "namekharidar"));
            insertcom.Parameters.Add(new SqlParameter("@d", SqlDbType.NVarChar, 50, "namesaheb"));
            insertcom.Parameters.Add(new SqlParameter("@e", SqlDbType.NVarChar, 50, "tarikh"));





            SqlDataAdapter da = new SqlDataAdapter();
            da.InsertCommand = insertcom;
            da.SelectCommand = selectcom;


            DataSet ds = new DataSet();
            da.Fill(ds);

            DataTable dt = ds.Tables[0];

            DataRow dr = dt.NewRow();
            dr[0] = System.Convert.ToInt32(txtid.Text);
            dr[1] = txtadress.Text;
            dr[2] = txtcost.Text;
            dr[3] = txtkharidar.Text;
            dr[4] = txtsaheb.Text;
            dr[5] = txtdata.Text;

            dt.Rows.Add(dr);
            da.Update(ds);

            txtid.Text = "";
            txtadress.Text = "";
            txtcost.Text = "";
            txtkharidar.Text = "";
            txtsaheb.Text = "";
            txtdata.Text = "";
            con.Close();

        }

        private void cmdcancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdcancle_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
