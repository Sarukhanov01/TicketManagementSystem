
namespace TicketManagementSystem
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Movies_Btn = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_ADD = new System.Windows.Forms.Button();
            this.cmb_Theatres = new System.Windows.Forms.ComboBox();
            this.tblTheatreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_TicketSalesDataSet = new TicketManagementSystem.DB_TicketSalesDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.Cmb_Movies = new System.Windows.Forms.ComboBox();
            this.tblMovieBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dB_TicketSalesDataSet2 = new TicketManagementSystem.DB_TicketSalesDataSet2();
            this.txt_LName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_FName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.tblMovieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_MovieTableAdapter = new TicketManagementSystem.DB_TicketSalesDataSetTableAdapters.tbl_MovieTableAdapter();
            this.tbl_TheatreTableAdapter = new TicketManagementSystem.DB_TicketSalesDataSetTableAdapters.tbl_TheatreTableAdapter();
            this.tblMovieBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_MovieTableAdapter1 = new TicketManagementSystem.DB_TicketSalesDataSet2TableAdapters.tbl_MovieTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.cmb_Paging = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblTheatreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TicketSalesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMovieBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TicketSalesDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMovieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMovieBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(138)))));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(2616, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 1025);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Movies_Btn);
            this.groupBox1.Controls.Add(this.btn_Clear);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Btn_ADD);
            this.groupBox1.Controls.Add(this.cmb_Theatres);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Cmb_Movies);
            this.groupBox1.Controls.Add(this.txt_LName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_FName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(916, 829);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // Movies_Btn
            // 
            this.Movies_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(185)))), ((int)(((byte)(168)))));
            this.Movies_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Movies_Btn.Image = ((System.Drawing.Image)(resources.GetObject("Movies_Btn.Image")));
            this.Movies_Btn.Location = new System.Drawing.Point(605, 410);
            this.Movies_Btn.Margin = new System.Windows.Forms.Padding(0);
            this.Movies_Btn.Name = "Movies_Btn";
            this.Movies_Btn.Size = new System.Drawing.Size(120, 93);
            this.Movies_Btn.TabIndex = 10;
            this.Movies_Btn.UseVisualStyleBackColor = false;
            this.Movies_Btn.Click += new System.EventHandler(this.Movies_Btn_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(155)))), ((int)(((byte)(154)))));
            this.btn_Clear.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Clear.FlatAppearance.BorderSize = 0;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(623, 705);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(259, 85);
            this.btn_Clear.TabIndex = 9;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(185)))), ((int)(((byte)(168)))));
            this.label4.Location = new System.Drawing.Point(45, 509);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 52);
            this.label4.TabIndex = 8;
            this.label4.Text = "Theatres";
            // 
            // Btn_ADD
            // 
            this.Btn_ADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(155)))), ((int)(((byte)(154)))));
            this.Btn_ADD.Cursor = System.Windows.Forms.Cursors.Default;
            this.Btn_ADD.FlatAppearance.BorderSize = 0;
            this.Btn_ADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ADD.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ADD.ForeColor = System.Drawing.Color.White;
            this.Btn_ADD.Location = new System.Drawing.Point(42, 705);
            this.Btn_ADD.Name = "Btn_ADD";
            this.Btn_ADD.Size = new System.Drawing.Size(259, 85);
            this.Btn_ADD.TabIndex = 3;
            this.Btn_ADD.Text = "ADD";
            this.Btn_ADD.UseVisualStyleBackColor = false;
            this.Btn_ADD.Click += new System.EventHandler(this.Btn_ADD_Click);
            // 
            // cmb_Theatres
            // 
            this.cmb_Theatres.DataSource = this.tblTheatreBindingSource;
            this.cmb_Theatres.DisplayMember = "TheatreName";
            this.cmb_Theatres.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Theatres.FormattingEnabled = true;
            this.cmb_Theatres.Location = new System.Drawing.Point(41, 578);
            this.cmb_Theatres.Name = "cmb_Theatres";
            this.cmb_Theatres.Size = new System.Drawing.Size(517, 51);
            this.cmb_Theatres.TabIndex = 7;
            this.cmb_Theatres.ValueMember = "TheatreID";
            // 
            // tblTheatreBindingSource
            // 
            this.tblTheatreBindingSource.DataMember = "tbl_Theatre";
            this.tblTheatreBindingSource.DataSource = this.dB_TicketSalesDataSet;
            // 
            // dB_TicketSalesDataSet
            // 
            this.dB_TicketSalesDataSet.DataSetName = "DB_TicketSalesDataSet";
            this.dB_TicketSalesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(185)))), ((int)(((byte)(168)))));
            this.label3.Location = new System.Drawing.Point(45, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 52);
            this.label3.TabIndex = 6;
            this.label3.Text = "Movies";
            // 
            // Cmb_Movies
            // 
            this.Cmb_Movies.DataSource = this.tblMovieBindingSource2;
            this.Cmb_Movies.DisplayMember = "Title";
            this.Cmb_Movies.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Movies.FormattingEnabled = true;
            this.Cmb_Movies.Location = new System.Drawing.Point(41, 426);
            this.Cmb_Movies.Name = "Cmb_Movies";
            this.Cmb_Movies.Size = new System.Drawing.Size(518, 51);
            this.Cmb_Movies.TabIndex = 5;
            this.Cmb_Movies.ValueMember = "MovieID";
            // 
            // tblMovieBindingSource2
            // 
            this.tblMovieBindingSource2.DataMember = "tbl_Movie";
            this.tblMovieBindingSource2.DataSource = this.dB_TicketSalesDataSet2;
            // 
            // dB_TicketSalesDataSet2
            // 
            this.dB_TicketSalesDataSet2.DataSetName = "DB_TicketSalesDataSet2";
            this.dB_TicketSalesDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_LName
            // 
            this.txt_LName.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LName.Location = new System.Drawing.Point(41, 277);
            this.txt_LName.Name = "txt_LName";
            this.txt_LName.Size = new System.Drawing.Size(840, 56);
            this.txt_LName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(185)))), ((int)(((byte)(168)))));
            this.label2.Location = new System.Drawing.Point(45, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 52);
            this.label2.TabIndex = 3;
            this.label2.Text = "LastName";
            // 
            // txt_FName
            // 
            this.txt_FName.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FName.Location = new System.Drawing.Point(41, 125);
            this.txt_FName.Name = "txt_FName";
            this.txt_FName.Size = new System.Drawing.Size(840, 56);
            this.txt_FName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(185)))), ((int)(((byte)(168)))));
            this.label1.Location = new System.Drawing.Point(45, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "FirstName";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 92;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(2598, 871);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(155)))), ((int)(((byte)(154)))));
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Update.FlatAppearance.BorderSize = 0;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Location = new System.Drawing.Point(503, 924);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(422, 95);
            this.btn_Update.TabIndex = 5;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(155)))), ((int)(((byte)(154)))));
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(23, 924);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(422, 95);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // tblMovieBindingSource
            // 
            this.tblMovieBindingSource.DataMember = "tbl_Movie";
            this.tblMovieBindingSource.DataSource = this.dB_TicketSalesDataSet;
            // 
            // tbl_MovieTableAdapter
            // 
            this.tbl_MovieTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_TheatreTableAdapter
            // 
            this.tbl_TheatreTableAdapter.ClearBeforeFill = true;
            // 
            // tblMovieBindingSource1
            // 
            this.tblMovieBindingSource1.DataMember = "tbl_Movie";
            this.tblMovieBindingSource1.DataSource = this.dB_TicketSalesDataSet;
            // 
            // tbl_MovieTableAdapter1
            // 
            this.tbl_MovieTableAdapter1.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(185)))), ((int)(((byte)(168)))));
            this.label6.Location = new System.Drawing.Point(1542, 910);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 51);
            this.label6.TabIndex = 12;
            this.label6.Text = "Search:";
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(1710, 909);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(891, 56);
            this.txt_Search.TabIndex = 13;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // cmb_Paging
            // 
            this.cmb_Paging.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Paging.FormattingEnabled = true;
            this.cmb_Paging.Location = new System.Drawing.Point(1148, 924);
            this.cmb_Paging.Name = "cmb_Paging";
            this.cmb_Paging.Size = new System.Drawing.Size(132, 37);
            this.cmb_Paging.TabIndex = 14;
            this.cmb_Paging.Text = "Pages";
            this.cmb_Paging.SelectedIndexChanged += new System.EventHandler(this.cmb_Paging_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(95)))), ((int)(((byte)(193)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1048, 909);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(95)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(3544, 1049);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmb_Paging);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblTheatreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TicketSalesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMovieBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TicketSalesDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMovieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMovieBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_ADD;
        private System.Windows.Forms.ComboBox cmb_Theatres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cmb_Movies;
        private System.Windows.Forms.TextBox txt_LName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_FName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private DB_TicketSalesDataSet dB_TicketSalesDataSet;
        private System.Windows.Forms.BindingSource tblMovieBindingSource;
        private DB_TicketSalesDataSetTableAdapters.tbl_MovieTableAdapter tbl_MovieTableAdapter;
        private System.Windows.Forms.BindingSource tblTheatreBindingSource;
        private DB_TicketSalesDataSetTableAdapters.tbl_TheatreTableAdapter tbl_TheatreTableAdapter;
        private System.Windows.Forms.BindingSource tblMovieBindingSource1;
        private DB_TicketSalesDataSet2 dB_TicketSalesDataSet2;
        private System.Windows.Forms.BindingSource tblMovieBindingSource2;
        private DB_TicketSalesDataSet2TableAdapters.tbl_MovieTableAdapter tbl_MovieTableAdapter1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button Movies_Btn;
        private System.Windows.Forms.ComboBox cmb_Paging;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

