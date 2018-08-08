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
    public partial class kharidarform : Form
    {
        public kharidarform()
        {
            InitializeComponent();
        }

        private void kharidarform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'amlakDataSet.kharidar' table. You can move, or remove it, as needed.
            this.kharidarTableAdapter.Fill(this.amlakDataSet15.kharidar);
            BindData();
        }
        private void BindData()
        {
            //Connection1.ConnectionString = ConfigurationSettings.AppSettings["connectionstring"].ToString();
            Connection1.ConnectionString = "Data Source=(local);Initial Catalog=amlak;Integrated Security=True";

            Adapter1.SelectCommand.Connection = Connection1;
            Adapter1.SelectCommand.CommandText = "SELECT * FROM  kharidar";

            DataTable dt = new DataTable();
            Adapter1.Fill(dt);
            grid1.DataSource = dt;

        }

        private void cmdadd_Click(object sender, EventArgs e)
        {
            newkharidarform  eef = new newkharidarform(0) ;
            eef.ShowDialog();
            BindData();
        }

        private void cmddelete_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)grid1.SelectedRows[0].DataBoundItem;
            int id = int.Parse(drv.Row["id"].ToString());

            Command1.Connection = Connection1;
            Command1.CommandText = "DELETE FROM kharidar WHERE ID = " + id.ToString();

            Connection1.Open();
            Command1.ExecuteNonQuery();
            Connection1.Close();

            BindData();
        }

        private void cmdedit_Click(object sender, EventArgs e)
        {
            if (grid1.SelectedRows.Count == 0)
                MessageBox.Show("یک سطر را انتخاب کنید");
            else
            {

                DataRowView drv = (DataRowView)grid1.SelectedRows[0].DataBoundItem;
                newforoshandeform eef = new newforoshandeform(1);

                eef.id = (int)drv.Row["id"];
                eef.name = (drv.Row["name"] != System.DBNull.Value ? (string)drv.Row["name"] : "");
                eef.family = (drv.Row["family"] != System.DBNull.Value ? (string)drv.Row["family"] : "");
                eef.shenasname = (drv.Row["shsh"] != System.DBNull.Value ? (string)drv.Row["shsh"] : "");
                eef.father = (drv.Row["nfather"] != System.DBNull.Value ? (string)drv.Row["nfather"] : "");
                eef.tells = (drv.Row["tells"] != System.DBNull.Value ? (string)drv.Row["tells"] : "");
                eef.tellh = (drv.Row["tellh"] != System.DBNull.Value ? (string)drv.Row["tellh"] : "");
                eef.adressm = (drv.Row["adressmanzel"] != System.DBNull.Value ? (string)drv.Row["adressmanzel"] : "");
                eef.adressw = (drv.Row["adresswork"] != System.DBNull.Value ? (string)drv.Row["adresswork"] : "");
                eef.ShowDialog();

                BindData();
            }

        }

        private void cmdhome_Click(object sender, EventArgs e)
        {
            mainform b = new mainform();
            b.ShowDialog();
            BindData();
        }

    }
}
