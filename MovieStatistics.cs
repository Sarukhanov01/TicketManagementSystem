using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketManagementSystem.Helpers;

namespace TicketManagementSystem
{
    public partial class MovieStatistics : Form
    {
        public MovieStatistics()
        {
            InitializeComponent();
            chart1.Series["IMDbByGenre"].Points.AddXY("Action",DBHelper.GetMovieIMDbAverage("Action"));
            chart1.Series["IMDbByGenre"].Points.AddXY("Drama", DBHelper.GetMovieIMDbAverage("Drama"));
            chart1.Series["IMDbByGenre"].Points.AddXY("Thriller", DBHelper.GetMovieIMDbAverage("Thriller"));
            chart1.Series["IMDbByGenre"].Points.AddXY("Fantasy", DBHelper.GetMovieIMDbAverage("Fantasy"));
            chart1.Series["IMDbByGenre"].Points.AddXY("Adventure", DBHelper.GetMovieIMDbAverage("Adventure"));



        }
    }
}
