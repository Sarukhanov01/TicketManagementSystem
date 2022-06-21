using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketManagementSystem.BLL;

namespace TicketManagementSystem
{
    public partial class MovieForm : Form
    {
        MovieService movieService = new MovieService();
        int id;


        public MovieForm()
        {
            InitializeComponent();
        }
        public void GetMovies()
        {
            gridw_Movie.DataSource = movieService.GetMovie();
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            int result = movieService.DeleteMovie(id);
            CheckResult("Movie Removed", result);
        }

        private void MovieForm_Load(object sender, EventArgs e)
        {
            GetMovies();
            gridw_Movie.Columns[0].Visible = false;
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            int result = movieService.AddMovie(txt_MovieName.Text, txt_Genre.Text, Convert.ToDouble(txt_IMDb.Text));
            CheckResult("Movie Added", result);
        }

        private void gridw_Movie_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = gridw_Movie.SelectedCells[0].RowIndex;
            var row = gridw_Movie.Rows[index];
            id = (int)row.Cells[0].Value;
            txt_MovieName.Text = row.Cells[1].Value.ToString();
            txt_Genre.Text = row.Cells[2].Value.ToString();
            txt_IMDb.Text = row.Cells[3].Value.ToString();
        }

        public void CheckResult(string message, params int[] results)
        {
            bool checkTrue = false;
            for (int i = 0; i < results.Length; i++)
            {
                if (results[i] > 0)
                {
                    checkTrue = true;
                }
            }
            if (checkTrue)
            {
                MessageBox.Show(message);
                GetMovies();
                // Clear();
            }
            else
            {
                MessageBox.Show("Her hansisa xeta bash verdi!!");
            }
        }

        private void Update_Btn_Click(object sender, EventArgs e)
        {
            int result = movieService.UpdateMovie(txt_MovieName.Text, txt_Genre.Text, Convert.ToDouble(txt_IMDb.Text), id);
            CheckResult("Movie Updated", result);
            
        }

        private void btn_Chart_Click(object sender, EventArgs e)
        {
            MovieStatistics movieStatistics = new MovieStatistics();
            movieStatistics.Show();
        }
    }
}
