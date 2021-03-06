﻿using System;
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
    public partial class newapartementejarei : Form
    {
        public int statusForm;
        public int id;
        public string adress;
        public string  gheymat;
        public string   keraye;
        public string kharidar;
        public string saheb;
        public string tarikh;

        public newapartementejarei(int status)
        {
            InitializeComponent();
            statusForm = status;
            if (statusForm == 1)
                this.Text = "ويرايش";
        }

        private void newapartementejareiform_Load(object sender, EventArgs e)
        {

            txtid.Text = System.Convert.ToString(id);
            txtadress.Text = adress;
            txtkeraye.Text = keraye;
           txtcost.Text = gheymat ;
  
            txtkharidar.Text = kharidar ;
            txtsaheb.Text = saheb ;
            txtdata.Text =tarikh  ;
           
        }

        private void cmdcancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdok_Click(object sender, EventArgs e)
        {

            if (this.statusForm == 1)   ////  ویرایش مشترک
            {


                string constr;
                constr = "data source=.;initial catalog=amlak;integrated security=true";
                SqlConnection con = new SqlConnection(constr);
                con.Open();

                SqlCommand selectcom = con.CreateCommand();
                selectcom.CommandText = "select * from jadidzamin";

                SqlCommand objCommand = con.CreateCommand();
                objCommand.CommandText = "UPDATE jadidzamin SET (id= @i, adress= @a,gheymat=@b,keraye=@c,namekharidar=@d,namesaheb=@e,tarikh=@f) WHERE id= = @i";
                objCommand.Parameters.AddWithValue("@i ", txtid);
                objCommand.Parameters.AddWithValue("@a ", txtadress);
                objCommand.Parameters.AddWithValue("@b ", txtcost );
                objCommand.Parameters.AddWithValue("@c ", txtkeraye );
                objCommand.Parameters.AddWithValue("@d ",txtkharidar );
                objCommand.Parameters.AddWithValue("@e ",txtsaheb );
                objCommand.Parameters.AddWithValue("@f ",txtdata  );

                SqlDataAdapter da = new SqlDataAdapter();
                da.InsertCommand = objCommand;
                da.SelectCommand = selectcom;


                DataSet ds = new DataSet();
                da.Fill(ds);

                DataTable dt = ds.Tables[0];

                DataRow dr = dt.NewRow();
                dr[0] = System.Convert.ToInt32(txtid.Text);
                dr[1] = txtadress.Text;
                dr[2] = txtcost.Text;
                dr[3] = txtkeraye.Text;
                dr[4] = txtkharidar.Text;
                dr[5] = txtsaheb.Text;
                dr[6] = txtdata.Text;

                dt.Rows.Add(dr);
                da.Update(ds);

                txtid.Text="";
                 txtadress.Text="";
               txtcost.Text="";
               txtkeraye.Text="";
                 txtkharidar.Text="";
                txtsaheb.Text="";
                 txtdata.Text="";
                objCommand.CommandType = CommandType.Text;



                con.Close();



            }

            else
            {
                string constr;
                constr = "data source=.;initial catalog=amlak;integrated security=true";
                SqlConnection con = new SqlConnection(constr);
                con.Open();

                SqlCommand selectcom = con.CreateCommand();
                selectcom.CommandText = "select * from ejareaparteman";

                SqlCommand insertcom = con.CreateCommand();
                insertcom.CommandText = "insert into ejareaparteman(id,adress,keraye,gheymat,namekharidar,namesaheb,tarikh)values(@i,@a,@b,@c,@d,@e,@f)";
                insertcom.Parameters.Add(new SqlParameter("@i", SqlDbType.Int, 4, "id"));
                insertcom.Parameters.Add(new SqlParameter("@a", SqlDbType.NVarChar, 50, "adress"));
                insertcom.Parameters.Add(new SqlParameter("@b", SqlDbType.NVarChar, 50, "keraye"));
                insertcom.Parameters.Add(new SqlParameter("@c", SqlDbType.NVarChar, 50, "gheymat"));
                insertcom.Parameters.Add(new SqlParameter("@d", SqlDbType.NVarChar, 50, "namekharidar"));
                insertcom.Parameters.Add(new SqlParameter("@e", SqlDbType.NVarChar, 50, "namesaheb"));
                insertcom.Parameters.Add(new SqlParameter("@f", SqlDbType.NVarChar, 50, "tarikh"));
               

               


                SqlDataAdapter da = new SqlDataAdapter();
                da.InsertCommand = insertcom;
                da.SelectCommand = selectcom;


                DataSet ds = new DataSet();
                da.Fill(ds);

                DataTable dt = ds.Tables[0];

                DataRow dr = dt.NewRow();
                dr[0] = System.Convert.ToInt32(txtid.Text);
                dr[1] = txtadress.Text;
                dr[2] = txtkeraye.Text;
                dr[3] = txtcost.Text;
                dr[4] = txtkharidar.Text;
                dr[5] = txtsaheb.Text;
                dr[6] = txtdata.Text;
                dt.Rows.Add(dr);
                da.Update(ds);

                txtid.Text = "";
                txtadress.Text = "";
                txtkeraye.Text = "";
                txtcost.Text = "";
                txtkharidar.Text = "";
                txtsaheb.Text = "";
                txtdata.Text = "";
                con.Close();

            }
        }

        private void txtdata_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
