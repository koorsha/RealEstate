namespace amlak
{
    partial class apartementejareiform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(apartementejareiform));
            this.cmdhome = new System.Windows.Forms.Button();
            this.cmddelete = new System.Windows.Forms.Button();
            this.cmdedit = new System.Windows.Forms.Button();
            this.cmdadd = new System.Windows.Forms.Button();
            this.Connection1 = new System.Data.SqlClient.SqlConnection();
            this.Adapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.Command1 = new System.Data.SqlClient.SqlCommand();
            this.grid1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kerayeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gheymatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namekharidarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namesahebDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarikhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ejareapartemanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.amlakDataSet = new amlak.AmlakDataSet();
            this.ejareapartemanTableAdapter = new amlak.AmlakDataSetTableAdapters.ejareapartemanTableAdapter();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejareapartemanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amlakDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdhome
            // 
            this.cmdhome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdhome.BackgroundImage")));
            this.cmdhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmdhome.Location = new System.Drawing.Point(44, 254);
            this.cmdhome.Name = "cmdhome";
            this.cmdhome.Size = new System.Drawing.Size(93, 41);
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
            this.cmddelete.Location = new System.Drawing.Point(177, 254);
            this.cmddelete.Name = "cmddelete";
            this.cmddelete.Size = new System.Drawing.Size(87, 41);
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
            this.cmdedit.Location = new System.Drawing.Point(308, 254);
            this.cmdedit.Name = "cmdedit";
            this.cmdedit.Size = new System.Drawing.Size(81, 41);
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
            this.cmdadd.Location = new System.Drawing.Point(436, 254);
            this.cmdadd.Name = "cmdadd";
            this.cmdadd.Size = new System.Drawing.Size(77, 41);
            this.cmdadd.TabIndex = 34;
            this.cmdadd.Text = "Add";
            this.cmdadd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdadd.UseVisualStyleBackColor = true;
            this.cmdadd.Click += new System.EventHandler(this.cmdadd_Click);
            // 
            // Connection1
            // 
            this.Connection1.ConnectionString = "Data Source=.;Initial Catalog=Amlak;Integrated Security=True";
            this.Connection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // Adapter1
            // 
            this.Adapter1.InsertCommand = this.sqlInsertCommand1;
            this.Adapter1.SelectCommand = this.sqlSelectCommand1;
            this.Adapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // grid1
            // 
            this.grid1.AutoGenerateColumns = false;
            this.grid1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.kerayeDataGridViewTextBoxColumn,
            this.gheymatDataGridViewTextBoxColumn,
            this.namekharidarDataGridViewTextBoxColumn,
            this.namesahebDataGridViewTextBoxColumn,
            this.tarikhDataGridViewTextBoxColumn});
            this.grid1.DataSource = this.ejareapartemanBindingSource;
            this.grid1.Location = new System.Drawing.Point(32, 24);
            this.grid1.Name = "grid1";
            this.grid1.Size = new System.Drawing.Size(506, 199);
            this.grid1.TabIndex = 38;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "کدآپارتمان";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "آدرس";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            // 
            // kerayeDataGridViewTextBoxColumn
            // 
            this.kerayeDataGridViewTextBoxColumn.DataPropertyName = "keraye";
            this.kerayeDataGridViewTextBoxColumn.HeaderText = "کرایه";
            this.kerayeDataGridViewTextBoxColumn.Name = "kerayeDataGridViewTextBoxColumn";
            // 
            // gheymatDataGridViewTextBoxColumn
            // 
            this.gheymatDataGridViewTextBoxColumn.DataPropertyName = "gheymat";
            this.gheymatDataGridViewTextBoxColumn.HeaderText = "قیمت پیش";
            this.gheymatDataGridViewTextBoxColumn.Name = "gheymatDataGridViewTextBoxColumn";
            // 
            // namekharidarDataGridViewTextBoxColumn
            // 
            this.namekharidarDataGridViewTextBoxColumn.DataPropertyName = "namekharidar";
            this.namekharidarDataGridViewTextBoxColumn.HeaderText = "نام خریدار";
            this.namekharidarDataGridViewTextBoxColumn.Name = "namekharidarDataGridViewTextBoxColumn";
            // 
            // namesahebDataGridViewTextBoxColumn
            // 
            this.namesahebDataGridViewTextBoxColumn.DataPropertyName = "namesaheb";
            this.namesahebDataGridViewTextBoxColumn.HeaderText = "نام صاحب";
            this.namesahebDataGridViewTextBoxColumn.Name = "namesahebDataGridViewTextBoxColumn";
            // 
            // tarikhDataGridViewTextBoxColumn
            // 
            this.tarikhDataGridViewTextBoxColumn.DataPropertyName = "tarikh";
            this.tarikhDataGridViewTextBoxColumn.HeaderText = "تاریخ";
            this.tarikhDataGridViewTextBoxColumn.Name = "tarikhDataGridViewTextBoxColumn";
            // 
            // ejareapartemanBindingSource
            // 
            this.ejareapartemanBindingSource.DataMember = "ejareaparteman";
            this.ejareapartemanBindingSource.DataSource = this.amlakDataSet;
            // 
            // amlakDataSet
            // 
            this.amlakDataSet.DataSetName = "AmlakDataSet";
            this.amlakDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ejareapartemanTableAdapter
            // 
            this.ejareapartemanTableAdapter.ClearBeforeFill = true;
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlCommand2;
            this.sqlDataAdapter1.UpdateCommand = this.sqlCommand3;
            // 
            // apartementejareiform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(569, 321);
            this.Controls.Add(this.grid1);
            this.Controls.Add(this.cmdhome);
            this.Controls.Add(this.cmddelete);
            this.Controls.Add(this.cmdedit);
            this.Controls.Add(this.cmdadd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "apartementejareiform";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "آپارتمان_اجاره ای";
            this.Load += new System.EventHandler(this.apartementejareiform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejareapartemanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amlakDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button cmdhome;
        internal System.Windows.Forms.Button cmddelete;
        internal System.Windows.Forms.Button cmdedit;
        internal System.Windows.Forms.Button cmdadd;
        private System.Data.SqlClient.SqlConnection Connection1;
        private System.Data.SqlClient.SqlDataAdapter Adapter1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand Command1;
        private System.Windows.Forms.DataGridView grid1;
        private AmlakDataSet amlakDataSet;
        private System.Windows.Forms.BindingSource ejareapartemanBindingSource;
        private amlak.AmlakDataSetTableAdapters.ejareapartemanTableAdapter ejareapartemanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kerayeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gheymatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namekharidarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namesahebDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarikhDataGridViewTextBoxColumn;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Data.SqlClient.SqlCommand sqlCommand2;
        private System.Data.SqlClient.SqlCommand sqlCommand3;

    }
}