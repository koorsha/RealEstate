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
    public partial class storerahniform : Form
    {
        public storerahniform()
        {
            InitializeComponent();
        }

       private void storerahniform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'amlakDataSet8.rahnimaghaze' table. You can move, or remove it, as needed.
            //this.rahnimaghazeTableAdapter.Fill(this.amlakDataSet8.rahnimaghaze);
            BindData();

        }
        private void BindData()
        {
            //Connection1.ConnectionString = ConfigurationSettings.AppSettings["connectionstring"].ToString();
            Connection1.ConnectionString = "Data Source=(local);Initial Catalog=amlak;Integrated Security=True";

            Adapter1.SelectCommand.Connection = Connection1;
            Adapter1.SelectCommand.CommandText = "SELECT * FROM  rahnimaghaze";

            DataTable dt = new DataTable();
            Adapter1.Fill(dt);
            grid1.DataSource = dt;

        }

        private void cmdadd_Click(object sender, EventArgs e)
        {
            newstorerahniform  ckf = new newstorerahniform (0);
            ckf.ShowDialog();
            BindData();
        }

        private void cmddelete_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)grid1.SelectedRows[0].DataBoundItem;
            int id = int.Parse(drv.Row["id"].ToString());

            Command1.Connection = Connection1;
            Command1.CommandText = "DELETE FROM rahnimaghaze WHERE ID = " + id.ToString();

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
               newstorerahniform  ckf = new newstorerahniform (1);

                ckf.id = (int)drv.Row["id"];
                ckf.adress = (drv.Row["adress"] != System.DBNull.Value ? (string)drv.Row["adress"] : "");
                ckf.gheymat = (drv.Row["gheymat"] != System.DBNull.Value ? (string)drv.Row["gheymat"] : "");
                ckf.kharidar = (drv.Row["namekharidar"] != System.DBNull.Value ? (string)drv.Row["namekharidar"] : "");
                ckf.saheb = (drv.Row["namesaheb"] != System.DBNull.Value ? (string)drv.Row["namesaheb"] : "");
                ckf.tarikh = (drv.Row["tarikh"] != System.DBNull.Value ? (string)drv.Row["tarikh"] : "");
                ckf.ShowDialog();
              
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
