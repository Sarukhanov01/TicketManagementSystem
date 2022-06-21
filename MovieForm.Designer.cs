
namespace TicketManagementSystem
{
    partial class MovieForm
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
            this.Update_Btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_IMDb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Genre = new System.Windows.Forms.TextBox();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MovieName = new System.Windows.Forms.TextBox();
            this.gridw_Movie = new System.Windows.Forms.DataGridView();
            this.btn_Chart = new System.Windows.Forms.Button();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridw_Movie)).BeginInit();
            this.SuspendLayout();
            // 
            // Update_Btn
            // 
            this.Update_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(155)))), ((int)(((byte)(154)))));
            this.Update_Btn.FlatAppearance.BorderSize = 0;
            this.Update_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_Btn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Btn.ForeColor = System.Drawing.Color.White;
            this.Update_Btn.Location = new System.Drawing.Point(531, 554);
            this.Update_Btn.Name = "Update_Btn";
            this.Update_Btn.Size = new System.Drawing.Size(422, 95);
            this.Update_Btn.TabIndex = 11;
            this.Update_Btn.Text = "Update";
            this.Update_Btn.UseVisualStyleBackColor = false;
            this.Update_Btn.Click += new System.EventHandler(this.Update_Btn_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(155)))), ((int)(((byte)(154)))));
            this.Delete_btn.FlatAppearance.BorderSize = 0;
            this.Delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_btn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_btn.ForeColor = System.Drawing.Color.White;
            this.Delete_btn.Location = new System.Drawing.Point(12, 554);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(422, 95);
            this.Delete_btn.TabIndex = 10;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = false;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_IMDb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Genre);
            this.groupBox1.Controls.Add(this.Btn_Clear);
            this.groupBox1.Controls.Add(this.Btn_Add);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_MovieName);
            this.groupBox1.Location = new System.Drawing.Point(1442, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1062, 668);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(79, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 51);
            this.label2.TabIndex = 9;
            this.label2.Text = "IMDbScore";
            // 
            // txt_IMDb
            // 
            this.txt_IMDb.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IMDb.Location = new System.Drawing.Point(88, 449);
            this.txt_IMDb.Name = "txt_IMDb";
            this.txt_IMDb.Size = new System.Drawing.Size(840, 56);
            this.txt_IMDb.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 51);
            this.label1.TabIndex = 7;
            this.label1.Text = "Genre";
            // 
            // txt_Genre
            // 
            this.txt_Genre.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Genre.Location = new System.Drawing.Point(88, 286);
            this.txt_Genre.Name = "txt_Genre";
            this.txt_Genre.Size = new System.Drawing.Size(840, 56);
            this.txt_Genre.TabIndex = 6;
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(155)))), ((int)(((byte)(154)))));
            this.Btn_Clear.Cursor = System.Windows.Forms.Cursors.Default;
            this.Btn_Clear.FlatAppearance.BorderSize = 0;
            this.Btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Clear.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Clear.ForeColor = System.Drawing.Color.White;
            this.Btn_Clear.Location = new System.Drawing.Point(549, 553);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(422, 95);
            this.Btn_Clear.TabIndex = 4;
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(79, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 51);
            this.label3.TabIndex = 5;
            this.label3.Text = "MovieTitle";
            // 
            // txt_MovieName
            // 
            this.txt_MovieName.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MovieName.Location = new System.Drawing.Point(88, 123);
            this.txt_MovieName.Name = "txt_MovieName";
            this.txt_MovieName.Size = new System.Drawing.Size(840, 56);
            this.txt_MovieName.TabIndex = 1;
            // 
            // gridw_Movie
            // 
            this.gridw_Movie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridw_Movie.Location = new System.Drawing.Point(-6, 1);
            this.gridw_Movie.Name = "gridw_Movie";
            this.gridw_Movie.RowHeadersWidth = 92;
            this.gridw_Movie.RowTemplate.Height = 37;
            this.gridw_Movie.Size = new System.Drawing.Size(1452, 532);
            this.gridw_Movie.TabIndex = 8;
            this.gridw_Movie.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridw_Movie_CellContentDoubleClick);
            // 
            // btn_Chart
            // 
            this.btn_Chart.AutoSize = true;
            this.btn_Chart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btn_Chart.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Chart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Chart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_Chart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Chart.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Chart.ForeColor = System.Drawing.Color.White;
            this.btn_Chart.Location = new System.Drawing.Point(1156, 554);
            this.btn_Chart.Name = "btn_Chart";
            this.btn_Chart.Size = new System.Drawing.Size(201, 75);
            this.btn_Chart.TabIndex = 12;
            this.btn_Chart.Text = "Chart";
            this.btn_Chart.UseVisualStyleBackColor = false;
            this.btn_Chart.Click += new System.EventHandler(this.btn_Chart_Click);
            // 
            // Btn_Add
            // 
            this.Btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(155)))), ((int)(((byte)(154)))));
            this.Btn_Add.Cursor = System.Windows.Forms.Cursors.Default;
            this.Btn_Add.FlatAppearance.BorderSize = 0;
            this.Btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Add.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add.ForeColor = System.Drawing.Color.White;
            this.Btn_Add.Location = new System.Drawing.Point(74, 553);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(422, 95);
            this.Btn_Add.TabIndex = 5;
            this.Btn_Add.Text = "ADD";
            this.Btn_Add.UseVisualStyleBackColor = false;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(95)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(2510, 664);
            this.Controls.Add(this.btn_Chart);
            this.Controls.Add(this.Update_Btn);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridw_Movie);
            this.Name = "MovieForm";
            this.Text = "MovieForm";
            this.Load += new System.EventHandler(this.MovieForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridw_Movie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Update_Btn;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MovieName;
        private System.Windows.Forms.DataGridView gridw_Movie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_IMDb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Genre;
        private System.Windows.Forms.Button btn_Chart;
        private System.Windows.Forms.Button Btn_Add;
    }
}