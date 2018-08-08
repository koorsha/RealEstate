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
    public partial class apartementejareiform : Form
    {
        public apartementejareiform()
        {
            InitializeComponent();
        }
        private void apartementejareiform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'amlakDataSet.ejareaparteman' table. You can move, or remove it, as needed.
            this.ejareapartemanTableAdapter.Fill(this.amlakDataSet.ejareaparteman);
            // TODO: This line of code loads data into the 'amlakDataSet.ejareaparteman' table. You can move, or remove it, as needed.
            //this.ejareapartemanTableAdapter.Fill(this.amlakDataSet.ejareaparteman);
            BindData();

        }

        private void BindData()
        {
            //Connection1.ConnectionString = ConfigurationSettings.AppSettings["connectionstring"].ToString();
            Connection1.ConnectionString = "Data Source=.;Initial Catalog=Amlak;Integrated Security=True";

            Adapter1.SelectCommand.Connection = Connection1;
            Adapter1.SelectCommand.CommandText = "SELECT * FROM  ejareaparteman";

            DataTable dt = new DataTable();
            Adapter1.Fill(dt);
            grid1.DataSource = dt;

        }

        private void cmdadd_Click(object sender, EventArgs e)
        {
            newapartementejarei aaf = new newapartementejarei(0);
            aaf.ShowDialog();
            BindData();
        }

        private void cmddelete_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)grid1.SelectedRows[0].DataBoundItem;
            int id = int.Parse(drv.Row["id"].ToString());

            Command1.Connection = Connection1;
            Command1.CommandText = "DELETE FROM ejareaparteman WHERE ID = " + id.ToString();

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
                newapartementejarei  aaf = new newapartementejarei (1);

                aaf.id = (int)drv.Row["id"];
                aaf.adress = (drv.Row["adress"] != System.DBNull.Value ? (string)drv.Row["adress"] : "");
                aaf.keraye = (drv.Row["keraye"] != System.DBNull.Value ? (string  )drv.Row["keraye"] : "");
                aaf.gheymat = (drv.Row["gheymat"] != System.DBNull.Value ? (string  )drv.Row["gheymat"] : "");
                aaf.kharidar = (drv.Row["namekharidar"] != System.DBNull.Value ? (string)drv.Row["namekharidar"] : "");
                aaf.saheb = (drv.Row["namesaheb"] != System.DBNull.Value ? (string)drv.Row["namesaheb"] : "");
                aaf.tarikh = (drv.Row["tarikh"] != System.DBNull.Value ? (string)drv.Row["tarikh"] : "");
                aaf.ShowDialog();

                BindData();
            }


        }

        private void cmdhome_Click(object sender, EventArgs e)
        {
            mainform  b = new mainform();
            b.ShowDialog();
            BindData();
        }
    }
}