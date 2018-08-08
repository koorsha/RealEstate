namespace amlak
{
    partial class foroshandeform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(foroshandeform));
            this.فروشنده = new System.Windows.Forms.GroupBox();
            this.grid1 = new System.Windows.Forms.DataGridView();
            this.amlakDataSet4 = new amlak.AmlakDataSet4();
            this.foroshandeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foroshandeTableAdapter = new amlak.AmlakDataSet4TableAdapters.foroshandeTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shshDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nfatherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tellsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tellhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressmanzelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressworkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Connection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.Adapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.Command1 = new System.Data.SqlClient.SqlCommand();
            this.cmdhome = new System.Windows.Forms.Button();
            this.cmddelete = new System.Windows.Forms.Button();
            this.cmdedit = new System.Windows.Forms.Button();
            this.cmdadd = new System.Windows.Forms.Button();
            this.فروشنده.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amlakDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foroshandeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // فروشنده
            // 
            this.فروشنده.BackColor = System.Drawing.Color.Transparent;
            this.فروشنده.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.فروشنده.Controls.Add(this.cmdhome);
            this.فروشنده.Controls.Add(this.cmddelete);
            this.فروشنده.Controls.Add(this.cmdedit);
            this.فروشنده.Controls.Add(this.cmdadd);
            this.فروشنده.Controls.Add(this.grid1);
            this.فروشنده.Location = new System.Drawing.Point(24, 26);
            this.فروشنده.Name = "فروشنده";
            this.فروشنده.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.فروشنده.Size = new System.Drawing.Size(562, 252);
            this.فروشنده.TabIndex = 0;
            this.فروشنده.TabStop = false;
            this.فروشنده.Text = "فروشنده";
            // 
            // grid1
            // 
            this.grid1.AutoGenerateColumns = false;
            this.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.familyDataGridViewTextBoxColumn,
            this.shshDataGridViewTextBoxColumn,
            this.nfatherDataGridViewTextBoxColumn,
            this.tellsDataGridViewTextBoxColumn,
            this.tellhDataGridViewTextBoxColumn,
            this.adressmanzelDataGridViewTextBoxColumn,
            this.adressworkDataGridViewTextBoxColumn});
            this.grid1.DataSource = this.foroshandeBindingSource;
            this.grid1.Location = new System.Drawing.Point(31, 26);
            this.grid1.Name = "grid1";
            this.grid1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grid1.Size = new System.Drawing.Size(492, 153);
            this.grid1.TabIndex = 0;
            // 
            // amlakDataSet4
            // 
            this.amlakDataSet4.DataSetName = "AmlakDataSet4";
            this.amlakDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // foroshandeBindingSource
            // 
            this.foroshandeBindingSource.DataMember = "foroshande";
            this.foroshandeBindingSource.DataSource = this.amlakDataSet4;
            // 
            // foroshandeTableAdapter
            // 
            this.foroshandeTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // familyDataGridViewTextBoxColumn
            // 
            this.familyDataGridViewTextBoxColumn.DataPropertyName = "family";
            this.familyDataGridViewTextBoxColumn.HeaderText = "family";
            this.familyDataGridViewTextBoxColumn.Name = "familyDataGridViewTextBoxColumn";
            // 
            // shshDataGridViewTextBoxColumn
            // 
            this.shshDataGridViewTextBoxColumn.DataPropertyName = "shsh";
            this.shshDataGridViewTextBoxColumn.HeaderText = "shsh";
            this.shshDataGridViewTextBoxColumn.Name = "shshDataGridViewTextBoxColumn";
            // 
            // nfatherDataGridViewTextBoxColumn
            // 
            this.nfatherDataGridViewTextBoxColumn.DataPropertyName = "nfather";
            this.nfatherDataGridViewTextBoxColumn.HeaderText = "nfather";
            this.nfatherDataGridViewTextBoxColumn.Name = "nfatherDataGridViewTextBoxColumn";
            // 
            // tellsDataGridViewTextBoxColumn
            // 
            this.tellsDataGridViewTextBoxColumn.DataPropertyName = "tells";
            this.tellsDataGridViewTextBoxColumn.HeaderText = "tells";
            this.tellsDataGridViewTextBoxColumn.Name = "tellsDataGridViewTextBoxColumn";
            // 
            // tellhDataGridViewTextBoxColumn
            // 
            this.tellhDataGridViewTextBoxColumn.DataPropertyName = "tellh";
            this.tellhDataGridViewTextBoxColumn.HeaderText = "tellh";
            this.tellhDataGridViewTextBoxColumn.Name = "tellhDataGridViewTextBoxColumn";
            // 
            // adressmanzelDataGridViewTextBoxColumn
            // 
            this.adressmanzelDataGridViewTextBoxColumn.DataPropertyName = "adressmanzel";
            this.adressmanzelDataGridViewTextBoxColumn.HeaderText = "adressmanzel";
            this.adressmanzelDataGridViewTextBoxColumn.Name = "adressmanzelDataGridViewTextBoxColumn";
            // 
            // adressworkDataGridViewTextBoxColumn
            // 
            this.adressworkDataGridViewTextBoxColumn.DataPropertyName = "adresswork";
            this.adressworkDataGridViewTextBoxColumn.HeaderText = "adresswork";
            this.adressworkDataGridViewTextBoxColumn.Name = "adressworkDataGridViewTextBoxColumn";
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
            // cmdhome
            // 
            this.cmdhome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdhome.BackgroundImage")));
            this.cmdhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmdhome.Location = new System.Drawing.Point(44, 196);
            this.cmdhome.Name = "cmdhome";
            this.cmdhome.Size = new System.Drawing.Size(92, 41);
            this.cmdhome.TabIndex = 31;
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
            this.cmddelete.Location = new System.Drawing.Point(169, 196);
            this.cmddelete.Name = "cmddelete";
            this.cmddelete.Size = new System.Drawing.Size(84, 41);
            this.cmddelete.TabIndex = 30;
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
            this.cmdedit.Location = new System.Drawing.Point(295, 196);
            this.cmdedit.Name = "cmdedit";
            this.cmdedit.Size = new System.Drawing.Size(86, 41);
            this.cmdedit.TabIndex = 29;
            this.cmdedit.Text = "Edit";
            this.cmdedit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdedit.UseVisualStyleBackColor = true;
            // 
            // cmdadd
            // 
            this.cmdadd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdadd.BackgroundImage")));
            this.cmdadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmdadd.Location = new System.Drawing.Point(420, 196);
            this.cmdadd.Name = "cmdadd";
            this.cmdadd.Size = new System.Drawing.Size(77, 41);
            this.cmdadd.TabIndex = 28;
            this.cmdadd.Text = "Add";
            this.cmdadd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdadd.UseVisualStyleBackColor = true;
            this.cmdadd.Click += new System.EventHandler(this.cmdadd_Click);
            // 
            // foroshandeform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(617, 307);
            this.Controls.Add(this.فروشنده);
            this.Name = "foroshandeform";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "فروشنده";
            this.Load += new System.EventHandler(this.foroshandeform_Load);
            this.فروشنده.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amlakDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foroshandeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid1;
        private AmlakDataSet4 amlakDataSet4;
        private System.Windows.Forms.BindingSource foroshandeBindingSource;
        private amlak.AmlakDataSet4TableAdapters.foroshandeTableAdapter foroshandeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shshDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nfatherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tellsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tellhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressmanzelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressworkDataGridViewTextBoxColumn;
        private System.Data.SqlClient.SqlConnection Connection1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter Adapter1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand Command1;
        internal System.Windows.Forms.Button cmdhome;
        internal System.Windows.Forms.Button cmddelete;
        internal System.Windows.Forms.Button cmdedit;
        internal System.Windows.Forms.Button cmdadd;
        private System.Windows.Forms.GroupBox فروشنده;
    }
}