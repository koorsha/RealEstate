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
    public partial class apartementmelkform : Form
    {
        public apartementmelkform()
        {
            InitializeComponent();
        }

        private void apartementmelkform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'amlakDataSet2.jadidaparteman' table. You can move, or remove it, as needed.
        //   this.jadidapartemanTableAdapter.Fill(this.amlakDataSet2.jadidaparteman);
            BindData();

        }
        private void BindData()
        {
            //Connection1.ConnectionString = ConfigurationSettings.AppSettings["connectionstring"].ToString();
            Connection1.ConnectionString = "Data Source=.;Initial Catalog=amlak;Integrated Security=True";

            Adapter1.SelectCommand.Connection = Connection1;
            Adapter1.SelectCommand.CommandText = "SELECT * FROM  jadidaparteman";

            DataTable dt = new DataTable();
            Adapter1.Fill(dt);
            grid1.DataSource = dt;

        }

       

        private void cmddelete_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)grid1.SelectedRows[0].DataBoundItem;
            int id = int.Parse(drv.Row["id"].ToString());

            Command1.Connection = Connection1;
            Command1.CommandText = "DELETE FROM jadidaparteman WHERE ID = " + id.ToString();

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
                newapartementmelkform  wwf = new newapartementmelkform (1);

                wwf.id = (int)drv.Row["id"];
                wwf.adress  = (drv.Row["adress"] != System.DBNull.Value ? (string)drv.Row["adress"] : "");
                wwf.metraj  = (drv.Row["metraj"] != System.DBNull.Value ? (string)drv.Row["metraj"] : "");
                wwf.gheymat  = (drv.Row["pish"] != System.DBNull.Value ? (string)drv.Row["pish"] : "");
               wwf.keraye  = (drv.Row["keraye"] != System.DBNull.Value ? (string)drv.Row["keraye"] : "");
                wwf.forosh  = (drv.Row["forosh"] != System.DBNull.Value ? (string)drv.Row["forosh"] : "");
                wwf.rahni  = (drv.Row["rahn"] != System.DBNull.Value ? (string)drv.Row["rahn"] : "");
                wwf.tabaghe  = (drv.Row["tabaghe"] != System.DBNull.Value ? (string)drv.Row["tabaghe"] : "");
               wwf.otagh  = (drv.Row["otagh"] != System.DBNull.Value ? (string)drv.Row["otagh"] : "");
             
              
                wwf.ShowDialog();

                BindData();
            }
        }

        private void cmdadd_Click(object sender, EventArgs e)
        {
           newapartementmelkform  wwf = new newapartementmelkform (0);
            wwf.ShowDialog();
            BindData();
        }

        private void cmdhome_Click(object sender, EventArgs e)
        {
            mainform b = new mainform();
            b.ShowDialog();
            BindData();
        }

        
    }
}
