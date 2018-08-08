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
    public partial class zaminmelkform : Form
    {
        public zaminmelkform()
        {
            InitializeComponent();
        }

    private void zaminmelkform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'amlakDataSet14.jadidzamin' table. You can move, or remove it, as needed.
          //  this.jadidzaminTableAdapter.Fill(this.amlakDataSet14.jadidzamin);
            BindData();

        }
        private void BindData()
        {
            //Connection1.ConnectionString = ConfigurationSettings.AppSettings["connectionstring"].ToString();
            Connection1.ConnectionString = "Data Source=.;Initial Catalog=amlak;Integrated Security=True";
            Connection1.Open();
            Adapter1.SelectCommand.Connection = Connection1;
            Adapter1.SelectCommand.CommandText = "SELECT * FROM  jadidzamin";

            DataTable dt = new DataTable();
            Adapter1.Fill(dt);
            grid1.DataSource = dt;
            Connection1.Close();

        }

        

        private void cmddelete_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)grid1.SelectedRows[0].DataBoundItem;
            int id = int.Parse(drv.Row["id"].ToString());

            Command1.Connection = Connection1;
            Command1.CommandText = "DELETE FROM jadidzamin WHERE ID = " + id.ToString();

            Connection1.Open();
            Command1.ExecuteNonQuery();
            Connection1.Close();

            BindData();
        }

        private void cmdadd_Click(object sender, EventArgs e)
        {
            newzaminmelkform  rrf = new newzaminmelkform (0);
            rrf.ShowDialog();
            BindData();
        }

        private void cmdedit_Click(object sender, EventArgs e)
        {
            if (grid1.SelectedRows.Count == 0)
                MessageBox.Show("یک سطر را انتخاب کنید");
            else
            {

                DataRowView drv = (DataRowView)grid1.SelectedRows[0].DataBoundItem;
                newzaminmelkform  rrf = new newzaminmelkform  (1);

               rrf.id = (int)drv.Row["id"];
                rrf.adress = (drv.Row["adress"] != System.DBNull.Value ? (string)drv.Row["adress"] : "");
                rrf.metraj = (drv.Row["metraj"] != System.DBNull.Value ? (string)drv.Row["metraj"] : "");
                rrf.forosh = (drv.Row["forosh"] != System.DBNull.Value ? (string)drv.Row["forosh"] : ""); 
                rrf.ShowDialog();

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
