namespace amlak
{
    partial class newapartementrahniform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newapartementrahniform));
            this.cmdok = new System.Windows.Forms.Button();
            this.txtsaheb = new System.Windows.Forms.TextBox();
            this.txtkharidar = new System.Windows.Forms.TextBox();
            this.txtcost = new System.Windows.Forms.TextBox();
            this.txtadress = new System.Windows.Forms.TextBox();
            this.lbldata = new System.Windows.Forms.Label();
            this.lblsaheb = new System.Windows.Forms.Label();
            this.lblkharidar = new System.Windows.Forms.Label();
            this.lblcost = new System.Windows.Forms.Label();
            this.lbladress = new System.Windows.Forms.Label();
            this.txtdata = new System.Windows.Forms.MaskedTextBox();
            this.cmdcancle = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblcode = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdok
            // 
            this.cmdok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdok.BackgroundImage")));
            this.cmdok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmdok.Location = new System.Drawing.Point(207, 230);
            this.cmdok.Name = "cmdok";
            this.cmdok.Size = new System.Drawing.Size(45, 43);
            this.cmdok.TabIndex = 88;
            this.cmdok.UseVisualStyleBackColor = true;
            this.cmdok.Click += new System.EventHandler(this.cmdok_Click);
            // 
            // txtsaheb
            // 
            this.txtsaheb.Location = new System.Drawing.Point(97, 146);
            this.txtsaheb.Name = "txtsaheb";
            this.txtsaheb.Size = new System.Drawing.Size(125, 20);
            this.txtsaheb.TabIndex = 86;
            // 
            // txtkharidar
            // 
            this.txtkharidar.Location = new System.Drawing.Point(97, 120);
            this.txtkharidar.Name = "txtkharidar";
            this.txtkharidar.Size = new System.Drawing.Size(125, 20);
            this.txtkharidar.TabIndex = 85;
            // 
            // txtcost
            // 
            this.txtcost.Location = new System.Drawing.Point(97, 94);
            this.txtcost.Name = "txtcost";
            this.txtcost.Size = new System.Drawing.Size(125, 20);
            this.txtcost.TabIndex = 84;
            // 
            // txtadress
            // 
            this.txtadress.Location = new System.Drawing.Point(97, 68);
            this.txtadress.Name = "txtadress";
            this.txtadress.Size = new System.Drawing.Size(125, 20);
            this.txtadress.TabIndex = 82;
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.BackColor = System.Drawing.Color.Transparent;
            this.lbldata.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldata.Location = new System.Drawing.Point(276, 176);
            this.lbldata.Name = "lbldata";
            this.lbldata.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbldata.Size = new System.Drawing.Size(34, 16);
            this.lbldata.TabIndex = 80;
            this.lbldata.Text = "تاریخ";
            this.lbldata.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblsaheb
            // 
            this.lblsaheb.AutoSize = true;
            this.lblsaheb.BackColor = System.Drawing.Color.Transparent;
            this.lblsaheb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsaheb.Location = new System.Drawing.Point(234, 150);
            this.lblsaheb.Name = "lblsaheb";
            this.lblsaheb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblsaheb.Size = new System.Drawing.Size(92, 16);
            this.lblsaheb.TabIndex = 79;
            this.lblsaheb.Text = "نام صاحب ملک";
            this.lblsaheb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblkharidar
            // 
            this.lblkharidar.AutoSize = true;
            this.lblkharidar.BackColor = System.Drawing.Color.Transparent;
            this.lblkharidar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkharidar.Location = new System.Drawing.Point(258, 120);
            this.lblkharidar.Name = "lblkharidar";
            this.lblkharidar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblkharidar.Size = new System.Drawing.Size(61, 16);
            this.lblkharidar.TabIndex = 78;
            this.lblkharidar.Text = "نام خریدار";
            this.lblkharidar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblcost
            // 
            this.lblcost.AutoSize = true;
            this.lblcost.BackColor = System.Drawing.Color.Transparent;
            this.lblcost.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcost.Location = new System.Drawing.Point(258, 94);
            this.lblcost.Name = "lblcost";
            this.lblcost.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblcost.Size = new System.Drawing.Size(68, 16);
            this.lblcost.TabIndex = 77;
            this.lblcost.Text = "قیمت پیش";
            this.lblcost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbladress
            // 
            this.lbladress.AutoSize = true;
            this.lbladress.BackColor = System.Drawing.Color.Transparent;
            this.lbladress.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladress.Location = new System.Drawing.Point(280, 68);
            this.lbladress.Name = "lbladress";
            this.lbladress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbladress.Size = new System.Drawing.Size(38, 16);
            this.lbladress.TabIndex = 75;
            this.lbladress.Text = "آدرس";
            this.lbladress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtdata
            // 
            this.txtdata.Location = new System.Drawing.Point(100, 172);
            this.txtdata.Mask = " 13##/##/##";
            this.txtdata.Name = "txtdata";
            this.txtdata.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtdata.Size = new System.Drawing.Size(122, 20);
            this.txtdata.TabIndex = 105;
            // 
            // cmdcancle
            // 
            this.cmdcancle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdcancle.BackgroundImage")));
            this.cmdcancle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdcancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmdcancle.Location = new System.Drawing.Point(146, 230);
            this.cmdcancle.Name = "cmdcancle";
            this.cmdcancle.Size = new System.Drawing.Size(43, 43);
            this.cmdcancle.TabIndex = 106;
            this.cmdcancle.Text = "  ";
            this.cmdcancle.UseVisualStyleBackColor = true;
            this.cmdcancle.Click += new System.EventHandler(this.cmdcancle_Click_1);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(97, 42);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(125, 20);
            this.txtid.TabIndex = 116;
            // 
            // lblcode
            // 
            this.lblcode.AutoSize = true;
            this.lblcode.BackColor = System.Drawing.Color.Transparent;
            this.lblcode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblcode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblcode.Location = new System.Drawing.Point(284, 34);
            this.lblcode.Name = "lblcode";
            this.lblcode.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.lblcode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblcode.Size = new System.Drawing.Size(26, 16);
            this.lblcode.TabIndex = 119;
            this.lblcode.Text = "کد ";
            this.lblcode.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblcode);
            this.groupBox1.Controls.Add(this.lblsaheb);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.cmdcancle);
            this.groupBox1.Controls.Add(this.txtdata);
            this.groupBox1.Controls.Add(this.cmdok);
            this.groupBox1.Controls.Add(this.txtsaheb);
            this.groupBox1.Controls.Add(this.txtkharidar);
            this.groupBox1.Controls.Add(this.txtcost);
            this.groupBox1.Controls.Add(this.txtadress);
            this.groupBox1.Controls.Add(this.lbldata);
            this.groupBox1.Controls.Add(this.lblkharidar);
            this.groupBox1.Controls.Add(this.lblcost);
            this.groupBox1.Controls.Add(this.lbladress);
            this.groupBox1.Location = new System.Drawing.Point(200, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 345);
            this.groupBox1.TabIndex = 120;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "آپارتمان رهنی";
            // 
            // newapartementrahniform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(559, 390);
            this.Controls.Add(this.groupBox1);
            this.Name = "newapartementrahniform";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "آپارتمان جدید_رهنی";
            this.Load += new System.EventHandler(this.newapartementrahniform_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button cmdok;
        internal System.Windows.Forms.TextBox txtsaheb;
        internal System.Windows.Forms.TextBox txtkharidar;
        internal System.Windows.Forms.TextBox txtcost;
        internal System.Windows.Forms.TextBox txtadress;
        internal System.Windows.Forms.Label lbldata;
        internal System.Windows.Forms.Label lblsaheb;
        internal System.Windows.Forms.Label lblkharidar;
        internal System.Windows.Forms.Label lblcost;
        internal System.Windows.Forms.Label lbladress;
        internal System.Windows.Forms.MaskedTextBox txtdata;
        internal System.Windows.Forms.Button cmdcancle;
        private System.Windows.Forms.TextBox txtid;
        internal System.Windows.Forms.Label lblcode;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}