using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace amlak
{
    public partial class storemelkform : Form
    {
        public storemelkform()
        {
            InitializeComponent();
        }

        private void storemelkform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'amlakDataSet7.jadidmaghaze' table. You can move, or remove it, as needed.
            this.jadidmaghazeTableAdapter.Fill(this.amlakDataSet7.jadidmaghaze);
            BindData();

        }
        private void BindData()
        {
            //Connection1.ConnectionString = ConfigurationSettings.AppSettings["connectionstring"].ToString();
            Connection1.ConnectionString = "Data Source=.;Initial Catalog=amlak;Integrated Security=True";

            Adapter1.SelectCommand.Connection = Connection1;
            Adapter1.SelectCommand.CommandText = "SELECT * FROM  jadidmaghaze";

            DataTable dt = new DataTable();
            Adapter1.Fill(dt);
            grid1.DataSource = dt;

        }

        private void cmdadd_Click(object sender, EventArgs e)
        {
            newstoremelkform trf = new newstoremelkform(0);
            trf.ShowDialog();
            BindData();
        }

        private void cmddelete_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)grid1.SelectedRows[0].DataBoundItem;
            int id = int.Parse(drv.Row["id"].ToString());

            Command1.Connection = Connection1;
            Command1.CommandText = "DELETE FROM jadidmaghaze WHERE ID = " + id.ToString();

            Connection1.Open();
            Command1.ExecuteNonQuery();
            Connection1.Close();

            BindData();
        }

        private void cmdhome_Click(object sender, EventArgs e)
        {
            mainform uy= new mainform();
            uy.ShowDialog();
            BindData();
        }
    }
}
