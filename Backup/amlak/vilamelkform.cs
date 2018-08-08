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
    public partial class vilamelkform : Form
    {
        public vilamelkform()
        {
            InitializeComponent();
        }

       private void vilamelkform_Load(object sender, EventArgs e)
       {
           // TODO: This line of code loads data into the 'amlakDataSet12.jadidvilla' table. You can move, or remove it, as needed.
           this.jadidvillaTableAdapter.Fill(this.amlakDataSet12.jadidvilla);
            BindData();
        }
        private void BindData()
        {
            //Connection1.ConnectionString = ConfigurationSettings.AppSettings["connectionstring"].ToString();
            Connection1.ConnectionString = "Data Source=.;Initial Catalog=amlak;Integrated Security=True";

            Adapter1.SelectCommand.Connection = Connection1;
            Adapter1.SelectCommand.CommandText = "SELECT * FROM  jadidvilla";

            DataTable dt = new DataTable();
            Adapter1.Fill(dt);
            grid1.DataSource = dt;

        }

       

        private void cmddelete_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)grid1.SelectedRows[0].DataBoundItem;
            int id = int.Parse(drv.Row["id"].ToString());

            Command1.Connection = Connection1;
            Command1.CommandText = "DELETE FROM jadidvilla WHERE ID = " + id.ToString();

            Connection1.Open();
            Command1.ExecuteNonQuery();
            Connection1.Close();

            BindData();
        }

        private void cmdadd_Click(object sender, EventArgs e)
        {
            newvilamelkform uf = new newvilamelkform(0);
            uf.ShowDialog();
            BindData();
        }

        private void cmdedit_Click(object sender, EventArgs e)
        {
            if (grid1.SelectedRows.Count == 0)
                MessageBox.Show("یک سطر را انتخاب کنید");
            else
            {

                DataRowView drv = (DataRowView)grid1.SelectedRows[0].DataBoundItem;
               newvilamelkform  uf = new newvilamelkform  (1);

                uf.id = (int)drv.Row["id"];
                uf.adress = (drv.Row["adress"] != System.DBNull.Value ? (string)drv.Row["adress"] : "");
                uf.metraj = (drv.Row["metraj"] != System.DBNull.Value ? (string)drv.Row["metraj"] : "");
              uf.gheymat = (drv.Row["pish"] != System.DBNull.Value ? (string)drv.Row["pish"] : "");
                uf.keraye = (drv.Row["keraye"] != System.DBNull.Value ? (string)drv.Row["keraye"] : "");
               uf.forosh = (drv.Row["forosh"] != System.DBNull.Value ? (string)drv.Row["forosh"] : "");
                uf.rahni = (drv.Row["rahn"] != System.DBNull.Value ? (string)drv.Row["rahn"] : "");
              uf.ShowDialog();

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
