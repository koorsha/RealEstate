namespace amlak
{
    partial class zaminmelkform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(zaminmelkform));
            this.cmdhome = new System.Windows.Forms.Button();
            this.cmddelete = new System.Windows.Forms.Button();
            this.cmdedit = new System.Windows.Forms.Button();
            this.cmdadd = new System.Windows.Forms.Button();
            this.jadidzaminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.amlakDataSet14 = new amlak.AmlakDataSet14();
            this.jadidzaminTableAdapter = new amlak.AmlakDataSet14TableAdapters.jadidzaminTableAdapter();
            this.Command1 = new System.Data.SqlClient.SqlCommand();
            this.Connection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.Adapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.grid1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metrajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foroshDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.jadidzaminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amlakDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdhome
            // 
            this.cmdhome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdhome.BackgroundImage")));
            this.cmdhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmdhome.Location = new System.Drawing.Point(39, 210);
            this.cmdhome.Name = "cmdhome";
            this.cmdhome.Size = new System.Drawing.Size(91, 41);
            this.cmdhome.TabIndex = 32;
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
            this.cmddelete.Location = new System.Drawing.Point(150, 210);
            this.cmddelete.Name = "cmddelete";
            this.cmddelete.Size = new System.Drawing.Size(85, 41);
            this.cmddelete.TabIndex = 31;
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
            this.cmdedit.Location = new System.Drawing.Point(270, 210);
            this.cmdedit.Name = "cmdedit";
            this.cmdedit.Size = new System.Drawing.Size(76, 41);
            this.cmdedit.TabIndex = 30;
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
            this.cmdadd.Location = new System.Drawing.Point(381, 210);
            this.cmdadd.Name = "cmdadd";
            this.cmdadd.Size = new System.Drawing.Size(77, 41);
            this.cmdadd.TabIndex = 29;
            this.cmdadd.Text = "Add";
            this.cmdadd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdadd.UseVisualStyleBackColor = true;
            this.cmdadd.Click += new System.EventHandler(this.cmdadd_Click);
            // 
            // jadidzaminBindingSource
            // 
            this.jadidzaminBindingSource.DataMember = "jadidzamin";
            this.jadidzaminBindingSource.DataSource = this.amlakDataSet14;
            // 
            // amlakDataSet14
            // 
            this.amlakDataSet14.DataSetName = "AmlakDataSet14";
            this.amlakDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jadidzaminTableAdapter
            // 
            this.jadidzaminTableAdapter.ClearBeforeFill = true;
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
            // grid1
            // 
            this.grid1.AutoGenerateColumns = false;
            this.grid1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.adressDataGridViewTextBoxColumn,
            this.metrajDataGridViewTextBoxColumn,
            this.foroshDataGridViewTextBoxColumn});
            this.grid1.DataSource = this.jadidzaminBindingSource;
            this.grid1.Location = new System.Drawing.Point(23, 36);
            this.grid1.Name = "grid1";
            this.grid1.Size = new System.Drawing.Size(466, 155);
            this.grid1.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmdhome);
            this.groupBox1.Controls.Add(this.cmddelete);
            this.groupBox1.Controls.Add(this.cmdedit);
            this.groupBox1.Controls.Add(this.cmdadd);
            this.groupBox1.Controls.Add(this.grid1);
            this.groupBox1.Location = new System.Drawing.Point(26, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 266);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " زمین";
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
            this.adressDataGridViewTextBoxColumn.HeaderText = "آدرس ملک";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            // 
            // metrajDataGridViewTextBoxColumn
            // 
            this.metrajDataGridViewTextBoxColumn.DataPropertyName = "metraj";
            this.metrajDataGridViewTextBoxColumn.HeaderText = "متراژ";
            this.metrajDataGridViewTextBoxColumn.Name = "metrajDataGridViewTextBoxColumn";
            // 
            // foroshDataGridViewTextBoxColumn
            // 
            this.foroshDataGridViewTextBoxColumn.DataPropertyName = "forosh";
            this.foroshDataGridViewTextBoxColumn.HeaderText = "قیمت فروش";
            this.foroshDataGridViewTextBoxColumn.Name = "foroshDataGridViewTextBoxColumn";
            // 
            // zaminmelkform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(569, 321);
            this.Controls.Add(this.groupBox1);
            this.Name = "zaminmelkform";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "زمین";
            this.Load += new System.EventHandler(this.zaminmelkform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jadidzaminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amlakDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button cmdhome;
        internal System.Windows.Forms.Button cmddelete;
        internal System.Windows.Forms.Button cmdedit;
        internal System.Windows.Forms.Button cmdadd;
        private AmlakDataSet14 amlakDataSet14;
        private System.Windows.Forms.BindingSource jadidzaminBindingSource;
        private amlak.AmlakDataSet14TableAdapters.jadidzaminTableAdapter jadidzaminTableAdapter;
        private System.Data.SqlClient.SqlCommand Command1;
        private System.Data.SqlClient.SqlConnection Connection1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter Adapter1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        internal System.Windows.Forms.DataGridView grid1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metrajDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foroshDataGridViewTextBoxColumn;

    }
}