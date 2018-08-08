namespace amlak
{
    partial class storemelkform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(storemelkform));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdhome = new System.Windows.Forms.Button();
            this.cmdadd = new System.Windows.Forms.Button();
            this.cmddelete = new System.Windows.Forms.Button();
            this.cmdedit = new System.Windows.Forms.Button();
            this.grid1 = new System.Windows.Forms.DataGridView();
            this.Command1 = new System.Data.SqlClient.SqlCommand();
            this.Connection1 = new System.Data.SqlClient.SqlConnection();
            this.Adapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metrajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kerayeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foroshDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rahnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jadidmaghazeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.amlakDataSet7 = new amlak.AmlakDataSet7();
            this.jadidmaghazeTableAdapter = new amlak.AmlakDataSet7TableAdapters.jadidmaghazeTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jadidmaghazeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amlakDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.grid1);
            this.groupBox1.Controls.Add(this.cmdhome);
            this.groupBox1.Controls.Add(this.cmdadd);
            this.groupBox1.Controls.Add(this.cmddelete);
            this.groupBox1.Controls.Add(this.cmdedit);
            this.groupBox1.Location = new System.Drawing.Point(38, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(533, 242);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مغازه";
            // 
            // cmdhome
            // 
            this.cmdhome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdhome.BackgroundImage")));
            this.cmdhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmdhome.Location = new System.Drawing.Point(65, 188);
            this.cmdhome.Name = "cmdhome";
            this.cmdhome.Size = new System.Drawing.Size(94, 38);
            this.cmdhome.TabIndex = 36;
            this.cmdhome.Text = "Home";
            this.cmdhome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdhome.UseVisualStyleBackColor = true;
            this.cmdhome.Click += new System.EventHandler(this.cmdhome_Click);
            // 
            // cmdadd
            // 
            this.cmdadd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdadd.BackgroundImage")));
            this.cmdadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmdadd.Location = new System.Drawing.Point(413, 188);
            this.cmdadd.Name = "cmdadd";
            this.cmdadd.Size = new System.Drawing.Size(77, 38);
            this.cmdadd.TabIndex = 33;
            this.cmdadd.Text = "Add";
            this.cmdadd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdadd.UseVisualStyleBackColor = true;
            this.cmdadd.Click += new System.EventHandler(this.cmdadd_Click);
            // 
            // cmddelete
            // 
            this.cmddelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmddelete.BackgroundImage")));
            this.cmddelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmddelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmddelete.Location = new System.Drawing.Point(193, 188);
            this.cmddelete.Name = "cmddelete";
            this.cmddelete.Size = new System.Drawing.Size(82, 38);
            this.cmddelete.TabIndex = 35;
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
            this.cmdedit.Location = new System.Drawing.Point(316, 188);
            this.cmdedit.Name = "cmdedit";
            this.cmdedit.Size = new System.Drawing.Size(76, 38);
            this.cmdedit.TabIndex = 34;
            this.cmdedit.Text = "Edit";
            this.cmdedit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdedit.UseVisualStyleBackColor = true;
            // 
            // grid1
            // 
            this.grid1.AutoGenerateColumns = false;
            this.grid1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.metrajDataGridViewTextBoxColumn,
            this.pishDataGridViewTextBoxColumn,
            this.kerayeDataGridViewTextBoxColumn,
            this.foroshDataGridViewTextBoxColumn,
            this.rahnDataGridViewTextBoxColumn});
            this.grid1.DataSource = this.jadidmaghazeBindingSource;
            this.grid1.Location = new System.Drawing.Point(38, 30);
            this.grid1.Name = "grid1";
            this.grid1.Size = new System.Drawing.Size(451, 142);
            this.grid1.TabIndex = 37;
            // 
            // Connection1
            // 
            this.Connection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // Adapter1
            // 
            this.Adapter1.InsertCommand = this.sqlInsertCommand1;
            this.Adapter1.SelectCommand = this.sqlSelectCommand1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "کد";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
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
            this.foroshDataGridViewTextBoxColumn.HeaderText = "فروش";
            this.foroshDataGridViewTextBoxColumn.Name = "foroshDataGridViewTextBoxColumn";
            // 
            // rahnDataGridViewTextBoxColumn
            // 
            this.rahnDataGridViewTextBoxColumn.DataPropertyName = "rahn";
            this.rahnDataGridViewTextBoxColumn.HeaderText = "رهن";
            this.rahnDataGridViewTextBoxColumn.Name = "rahnDataGridViewTextBoxColumn";
            // 
            // jadidmaghazeBindingSource
            // 
            this.jadidmaghazeBindingSource.DataMember = "jadidmaghaze";
            this.jadidmaghazeBindingSource.DataSource = this.amlakDataSet7;
            // 
            // amlakDataSet7
            // 
            this.amlakDataSet7.DataSetName = "AmlakDataSet7";
            this.amlakDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jadidmaghazeTableAdapter
            // 
            this.jadidmaghazeTableAdapter.ClearBeforeFill = true;
            // 
            // storemelkform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(608, 292);
            this.Controls.Add(this.groupBox1);
            this.Name = "storemelkform";
            this.Text = "مغازه";
            this.Load += new System.EventHandler(this.storemelkform_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jadidmaghazeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amlakDataSet7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grid1;
        internal System.Windows.Forms.Button cmdhome;
        internal System.Windows.Forms.Button cmdadd;
        internal System.Windows.Forms.Button cmddelete;
        internal System.Windows.Forms.Button cmdedit;
        private System.Data.SqlClient.SqlCommand Command1;
        private System.Data.SqlClient.SqlConnection Connection1;
        private System.Data.SqlClient.SqlDataAdapter Adapter1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private AmlakDataSet7 amlakDataSet7;
        private System.Windows.Forms.BindingSource jadidmaghazeBindingSource;
        private amlak.AmlakDataSet7TableAdapters.jadidmaghazeTableAdapter jadidmaghazeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metrajDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pishDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kerayeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foroshDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rahnDataGridViewTextBoxColumn;
    }
}