using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketManagementSystem.DAL;
using TicketManagementSystem.Helpers;

namespace TicketManagementSystem.BLL
{
    class MovieService
    {
        MovieDAL movie;
        public MovieService()
        {
            movie = new MovieDAL();
        }
        public DataTable GetMovie()
        {
            var dt = movie.GetMovies();
            if (RunHelper.CheckValue(RunHelper.ComparisonType.ALL, dt.Columns.Count))
            {
                return dt;
            }
            else
            {
                throw new Exception(); 
            }
            
        }
        public int AddMovie(string title, string genre,double imdb)
        {
            if (RunHelper.CheckValue(RunHelper.ComparisonType.ALL,title,genre,imdb))
            {
                return movie.InsertMovies(new Entities.Movie { MovieTitle = title, Genre = genre, IMDb = imdb });
            }
            else
            {
                return -1;
            }
        }
        public int UpdateMovie(string title, string genre, double imdb, int id)
        {
            if (RunHelper.CheckValue(RunHelper.ComparisonType.ALL, title, genre, imdb))
            {
                return movie.UpdateMovies(new Entities.Movie { MovieTitle = title, Genre = genre, IMDb = imdb },id);
            }
            else
            {
                return -1;
            }
        }
        public int DeleteMovie(int id)
        {
            if (RunHelper.CheckValue(RunHelper.ComparisonType.ALL,id))
            {
                return movie.DeleteMovie(id);
            }
            else
            {
                return -1;
            }
        }
    }
}
