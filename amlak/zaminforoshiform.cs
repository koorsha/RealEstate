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
    public partial class zaminforoshiform : Form
    {
        public zaminforoshiform()
        {
            InitializeComponent();
        }

        private void zaminforoshiform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'amlakDataSet13.foroshizamin' table. You can move, or remove it, as needed.
         //   this.foroshizaminTableAdapter.Fill(this.amlakDataSet13.foroshizamin);
            BindData();

        }
        private void BindData()
        {
            //Connection1.ConnectionString = ConfigurationSettings.AppSettings["connectionstring"].ToString();
            Connection1.ConnectionString = "Data Source=(local);Initial Catalog=amlak;Integrated Security=True";

            Adapter1.SelectCommand.Connection = Connection1;
            Adapter1.SelectCommand.CommandText = "SELECT * FROM  foroshizamin";

            DataTable dt = new DataTable();
            Adapter1.Fill(dt);
            grid1.DataSource = dt;

        }

        private void cmdadd_Click(object sender, EventArgs e)
        {
            newzaminforoshiform qqf = new newzaminforoshiform(0);
            qqf.ShowDialog();
            BindData();
        }

        private void cmddelete_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)grid1.SelectedRows[0].DataBoundItem;
            int id = int.Parse(drv.Row["id"].ToString());

            Command1.Connection = Connection1;
            Command1.CommandText = "DELETE FROM foroshizamin WHERE ID = " + id.ToString();

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
                newzaminforoshiform qqf = new newzaminforoshiform(1);

                qqf.id = (int)drv.Row["id"];
                qqf.adress = (drv.Row["adress"] != System.DBNull.Value ? (string)drv.Row["adress"] : "");

                qqf.gheymat = (drv.Row["gheymat"] != System.DBNull.Value ? (string)drv.Row["gheymat"] : "");
                qqf.kharidar = (drv.Row["namekharidar"] != System.DBNull.Value ? (string)drv.Row["namekharidar"] : "");
                qqf.saheb = (drv.Row["namesaheb"] != System.DBNull.Value ? (string)drv.Row["namesaheb"] : "");
                qqf.tarikh = (drv.Row["tarikh"] != System.DBNull.Value ? (string)drv.Row["tarikh"] : "");
                qqf.ShowDialog();

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