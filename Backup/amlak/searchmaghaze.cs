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
    public partial class searchmaghaze : Form
    {
        public searchmaghaze()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Connection1.ConnectionString = "Data Source=(local);Initial Catalog=amlak;Integrated Security=True";

            Adapter1.SelectCommand.Connection = Connection1;
            Adapter1.SelectCommand.CommandText = "SELECT * FROM  jadidmaghaze WHERE adress like '%" + txtadress.Text.Trim() + "%'";

            DataTable dt = new DataTable();
            Adapter1.Fill(dt);
            grid1.DataSource = dt;
          
        }

        private void searchmaghaze_Load(object sender, EventArgs e)
        {

        }
    }
}
