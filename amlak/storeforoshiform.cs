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
    public partial class storeforoshiform : Form
    {
        public storeforoshiform()
        {
            InitializeComponent();
        }

        private void storeforoshiform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'amlakDataSet6.foroshimaghaze' table. You can move, or remove it, as needed.
          //  this.foroshimaghazeTableAdapter.Fill(this.amlakDataSet6.foroshimaghaze);
            BindData();

        }
        private void BindData()
        {
            //Connection1.ConnectionString = ConfigurationSettings.AppSettings["connectionstring"].ToString();
            Connection1.ConnectionString = "Data Source=(local);Initial Catalog=amlak;Integrated Security=True";

            Adapter1.SelectCommand.Connection = Connection1;
            Adapter1.SelectCommand.CommandText = "SELECT * FROM  foroshimaghaze";

            DataTable dt = new DataTable();
            Adapter1.Fill(dt);
            grid1.DataSource = dt;

        }

        private void cmdadd_Click(object sender, EventArgs e)
        {
            newstoreforoshiform  ggf = new newstoreforoshiform (0);
            ggf.ShowDialog();
            BindData();
        }

        private void cmddelete_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)grid1.SelectedRows[0].DataBoundItem;
            int id = int.Parse(drv.Row["id"].ToString());

            Command1.Connection = Connection1;
            Command1.CommandText = "DELETE FROM foroshimaghaze WHERE ID = " + id.ToString();

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
                newstoreforoshiform  ggf = new newstoreforoshiform (1);

                ggf.id = (int)drv.Row["id"];
                ggf.adress = (drv.Row["adress"] != System.DBNull.Value ? (string)drv.Row["adress"] : "");
                
                ggf.gheymat = (drv.Row["gheymat"] != System.DBNull.Value ? (string)drv.Row["gheymat"] : "");
               ggf.kharidar = (drv.Row["namekharidar"] != System.DBNull.Value ? (string)drv.Row["namekharidar"] : "");
               ggf.saheb = (drv.Row["namesaheb"] != System.DBNull.Value ? (string)drv.Row["namesaheb"] : "");
                ggf.tarikh = (drv.Row["tarikh"] != System.DBNull.Value ? (string)drv.Row["tarikh"] : "");
                ggf.ShowDialog();

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
