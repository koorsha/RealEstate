namespace amlak
{
    partial class apartementmelkform
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(apartementmelkform));
            this.cmdhome = new System.Windows.Forms.Button();
            this.cmddelete = new System.Windows.Forms.Button();
            this.cmdedit = new System.Windows.Forms.Button();
            this.cmdadd = new System.Windows.Forms.Button();
            this.grid1 = new System.Windows.Forms.DataGridView();
            this.jadidapartemanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.amlakDataSet2 = new amlak.AmlakDataSet2();
            this.jadidapartemanTableAdapter = new amlak.AmlakDataSet2TableAdapters.jadidapartemanTableAdapter();
            this.Connection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.Adapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.Command1 = new System.Data.SqlClient.SqlCommand();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metrajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kerayeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foroshDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rahnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabagheDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otaghDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barghDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gazDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jadidapartemanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amlakDataSet2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdhome
            // 
            this.cmdhome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdhome.BackgroundImage")));
            this.cmdhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmdhome.Location = new System.Drawing.Point(24, 227);
            this.cmdhome.Name = "cmdhome";
            this.cmdhome.Size = new System.Drawing.Size(95, 40);
            this.cmdhome.TabIndex = 37;
            this.cmdhome.Text = "Home";
            this.cmdhome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdhome.UseVisualStyleBackColor = true;
            this.cmdhome.Click += new System.EventHandler(this.cmdhome_Click);
            // 
            // cmddelete
            // 
            this.cmddelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmddelete.BackgroundImage")));
            this.cmddelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmddelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmddelete.Location = new System.Drawing.Point(148, 227);
            this.cmddelete.Name = "cmddelete";
            this.cmddelete.Size = new System.Drawing.Size(87, 40);
            this.cmddelete.TabIndex = 36;
            this.cmddelete.Text = "delete";
            this.cmddelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmddelete.UseVisualStyleBackColor = true;
            this.cmddelete.Click += new System.EventHandler(this.cmddelete_Click);
            // 
            // cmdedit
            // 
            this.cmdedit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdedit.BackgroundImage")));
            this.cmdedit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmdedit.Location = new System.Drawing.Point(286, 227);
            this.cmdedit.Name = "cmdedit";
            this.cmdedit.Size = new System.Drawing.Size(83, 40);
            this.cmdedit.TabIndex = 35;
            this.cmdedit.Text = "Edit";
            this.cmdedit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdedit.UseVisualStyleBackColor = true;
            this.cmdedit.Click += new System.EventHandler(this.cmdedit_Click);
            // 
            // cmdadd
            // 
            this.cmdadd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdadd.BackgroundImage")));
            this.cmdadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmdadd.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.cmdadd.Location = new System.Drawing.Point(401, 227);
            this.cmdadd.Name = "cmdadd";
            this.cmdadd.Size = new System.Drawing.Size(90, 40);
            this.cmdadd.TabIndex = 34;
            this.cmdadd.Text = "Add";
            this.cmdadd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdadd.UseVisualStyleBackColor = true;
            this.cmdadd.Click += new System.EventHandler(this.cmdadd_Click);
            // 
            // grid1
            // 
            this.grid1.AutoGenerateColumns = false;
            this.grid1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.adressDataGridViewTextBoxColumn,
            this.metrajDataGridViewTextBoxColumn,
            this.pishDataGridViewTextBoxColumn,
            this.kerayeDataGridViewTextBoxColumn,
            this.foroshDataGridViewTextBoxColumn,
            this.rahnDataGridViewTextBoxColumn,
            this.tabagheDataGridViewTextBoxColumn,
            this.otaghDataGridViewTextBoxColumn,
            this.abDataGridViewTextBoxColumn,
            this.barghDataGridViewTextBoxColumn,
            this.gazDataGridViewTextBoxColumn,
            this.tellDataGridViewTextBoxColumn});
            this.grid1.DataSource = this.jadidapartemanBindingSource;
            this.grid1.Location = new System.Drawing.Point(17, 15);
            this.grid1.Name = "grid1";
            this.grid1.Size = new System.Drawing.Size(498, 197);
            this.grid1.TabIndex = 33;
            // 
            // jadidapartemanBindingSource
            // 
            this.jadidapartemanBindingSource.DataMember = "jadidaparteman";
            this.jadidapartemanBindingSource.DataSource = this.amlakDataSet2;
            // 
            // amlakDataSet2
            // 
            this.amlakDataSet2.DataSetName = "AmlakDataSet2";
            this.amlakDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jadidapartemanTableAdapter
            // 
            this.jadidapartemanTableAdapter.ClearBeforeFill = true;
            // 
            // Connection1
            // 
            this.Connection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // Adapter1
            // 
            this.Adapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.Adapter1.InsertCommand = this.sqlInsertCommand1;
            this.Adapter1.SelectCommand = this.sqlSelectCommand1;
            this.Adapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "کد";
            this.Column1.Name = "Column1";
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "آدرس";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            // 
            // metrajDataGridViewTextBoxColumn
            // 
            this.metrajDataGridViewTextBoxColumn.DataPropertyName = "metraj";
            this.metrajDataGridViewTextBoxColumn.HeaderText = "متراژ";
            this.metrajDataGridViewTextBoxColumn.Name = "metrajDataGridViewTextBoxColumn";
            // 
            // pishDataGridViewTextBoxColumn
            // 
            this.pishDataGridViewTextBoxColumn.DataPropertyName = "pish";
            this.pishDataGridViewTextBoxColumn.HeaderText = "قیمت پیش";
            this.pishDataGridViewTextBoxColumn.Name = "pishDataGridViewTextBoxColumn";
            // 
            // kerayeDataGridViewTextBoxColumn
            // 
            this.kerayeDataGridViewTextBoxColumn.DataPropertyName = "keraye";
            this.kerayeDataGridViewTextBoxColumn.HeaderText = "کرایه";
            this.kerayeDataGridViewTextBoxColumn.Name = "kerayeDataGridViewTextBoxColumn";
            // 
            // foroshDataGridViewTextBoxColumn
            // 
            this.foroshDataGridViewTextBoxColumn.DataPropertyName = "forosh";
            this.foroshDataGridViewTextBoxColumn.HeaderText = "قیمت فروش";
            this.foroshDataGridViewTextBoxColumn.Name = "foroshDataGridViewTextBoxColumn";
            // 
            // rahnDataGridViewTextBoxColumn
            // 
            this.rahnDataGridViewTextBoxColumn.DataPropertyName = "rahn";
            this.rahnDataGridViewTextBoxColumn.HeaderText = "قیمت رهن";
            this.rahnDataGridViewTextBoxColumn.Name = "rahnDataGridViewTextBoxColumn";
            // 
            // tabagheDataGridViewTextBoxColumn
            // 
            this.tabagheDataGridViewTextBoxColumn.DataPropertyName = "tabaghe";
            this.tabagheDataGridViewTextBoxColumn.HeaderText = "تعدادطبقات";
            this.tabagheDataGridViewTextBoxColumn.Name = "tabagheDataGridViewTextBoxColumn";
            // 
            // otaghDataGridViewTextBoxColumn
            // 
            this.otaghDataGridViewTextBoxColumn.DataPropertyName = "otagh";
            this.otaghDataGridViewTextBoxColumn.HeaderText = "تعداداتاق";
            this.otaghDataGridViewTextBoxColumn.Name = "otaghDataGridViewTextBoxColumn";
            // 
            // abDataGridViewTextBoxColumn
            // 
            this.abDataGridViewTextBoxColumn.DataPropertyName = "ab";
            this.abDataGridViewTextBoxColumn.HeaderText = "آب";
            this.abDataGridViewTextBoxColumn.Name = "abDataGridViewTextBoxColumn";
            // 
            // barghDataGridViewTextBoxColumn
            // 
            this.barghDataGridViewTextBoxColumn.DataPropertyName = "bargh";
            this.barghDataGridViewTextBoxColumn.HeaderText = "برق";
            this.barghDataGridViewTextBoxColumn.Name = "barghDataGridViewTextBoxColumn";
            // 
            // gazDataGridViewTextBoxColumn
            // 
            this.gazDataGridViewTextBoxColumn.DataPropertyName = "gaz";
            this.gazDataGridViewTextBoxColumn.HeaderText = "گاز";
            this.gazDataGridViewTextBoxColumn.Name = "gazDataGridViewTextBoxColumn";
            // 
            // tellDataGridViewTextBoxColumn
            // 
            this.tellDataGridViewTextBoxColumn.DataPropertyName = "tell";
            this.tellDataGridViewTextBoxColumn.HeaderText = "تلفن";
            this.tellDataGridViewTextBoxColumn.Name = "tellDataGridViewTextBoxColumn";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmdhome);
            this.groupBox1.Controls.Add(this.cmddelete);
            this.groupBox1.Controls.Add(this.cmdedit);
            this.groupBox1.Controls.Add(this.cmdadd);
            this.groupBox1.Controls.Add(this.grid1);
            this.groupBox1.Location = new System.Drawing.Point(18, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 283);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "آپارتمان";
            // 
            // apartementmelkform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(569, 321);
            this.Controls.Add(this.groupBox1);
            this.Name = "apartementmelkform";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "آپارتمان";
            this.Load += new System.EventHandler(this.apartementmelkform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jadidapartemanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amlakDataSet2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button cmdhome;
        internal System.Windows.Forms.Button cmddelete;
        internal System.Windows.Forms.Button cmdedit;
        internal System.Windows.Forms.Button cmdadd;
        internal System.Windows.Forms.DataGridView grid1;
        private AmlakDataSet2 amlakDataSet2;
        private System.Windows.Forms.BindingSource jadidapartemanBindingSource;
        private amlak.AmlakDataSet2TableAdapters.jadidapartemanTableAdapter jadidapartemanTableAdapter;
        private System.Data.SqlClient.SqlConnection Connection1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter Adapter1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand Command1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metrajDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pishDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kerayeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foroshDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rahnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabagheDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otaghDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn abDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barghDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gazDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tellDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}