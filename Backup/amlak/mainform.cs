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
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

       

        private void foroshande_Click(object sender, EventArgs e)
        {
            foroshandeform af = new foroshandeform();
            af.MdiParent = this;
            af.Show();

        }

        private void kharidar_Click(object sender, EventArgs e)
        {
            kharidarform bf = new kharidarform();
            bf.MdiParent = this;
            bf.Show();  
        }

       

        private void آپارتمانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            apartementejareiform   df = new apartementejareiform  ();
            df.MdiParent = this;
            df.Show(); 
        }

        private void ویلاییToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vilaejareiform  lef = new vilaejareiform ();
            lef.MdiParent = this;
            lef.Show(); 
        }

        private void مغازهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            storeejareiform   gf = new storeejareiform  ();
            gf.MdiParent = this;
            gf.Show(); 
        }

        private void آپارتمانToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            apartementrahniform   hf = new apartementrahniform  ();
            hf.MdiParent = this;
            hf.Show(); 
        }

        private void ویلاییToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            vilairahniform   jf = new vilairahniform  ();
            jf.MdiParent = this;
            jf.Show(); 
        }

        private void مغازهToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            storerahniform   kf = new storerahniform  ();
            kf.MdiParent = this;
            kf.Show(); 
        }

        private void apartement_Click(object sender, EventArgs e)
        {
            apartementmelkform lf = new apartementmelkform();
            lf.MdiParent = this;
            lf.Show(); 
        }

        private void zamin_Click(object sender, EventArgs e)
        {
            zaminmelkform   mf = new zaminmelkform  ();
            mf.MdiParent = this;
            mf.Show(); 
        }

        private void vila_Click(object sender, EventArgs e)
        {
           vilamelkform   nf = new vilamelkform  ();
            nf.MdiParent = this;
            nf.Show(); 
        }

        private void store_Click(object sender, EventArgs e)
        {
            storemelkform   of = new storemelkform  ();
            of.MdiParent = this;
            of.Show(); 
        }

        private void آپارتمانToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            apartementforoshiform  pf = new apartementforoshiform ();
            pf.MdiParent = this;
            pf.Show(); 
        }

        private void زمینToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zaminforoshiform   qf = new zaminforoshiform  ();
            qf.MdiParent = this;
            qf.Show(); 
        }

        private void ویلاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vilaforoshiform  rf = new vilaforoshiform ();
            rf.MdiParent = this;
            rf.Show(); 
        }

        private void مغازهToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            storeforoshiform  sf = new storeforoshiform ();
            sf.MdiParent = this;
            sf.Show(); 
        }

        private void ویلاToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            searchvilla  tf = new  searchvilla ();
            tf.MdiParent = this;
            tf.Show();
        }

        private void فروشندهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchforoshande  uf = new searchforoshande ();
            uf.MdiParent = this;
            uf.Show();
        }

        private void خریدارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchkharidar  vf = new  searchkharidar ();
            vf.MdiParent = this;
           vf.Show();
        }

        private void آپارتمانToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            searchaparteman  wf = new  searchaparteman ();
            wf.MdiParent = this;
            wf.Show();
        }

        private void مغازهToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            searchmaghaze  xf = new searchmaghaze ();
            xf.MdiParent = this;
            xf.Show();
        }

        private void زمینToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            searchzamin  zf = new searchzamin ();
            zf.MdiParent = this;
            zf.Show();
        }

        private void mainform_Load(object sender, EventArgs e)
        {

        }

        private void دریارهماToolStripMenuItem_Click(object sender, EventArgs e)
        {
            we fdfd = new we();
            fdfd.MdiParent = this;
            fdfd.Show();
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
     Application.Exit();
        }
    }
}
