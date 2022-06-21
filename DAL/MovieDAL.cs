using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketManagementSystem.Entities;
using TicketManagementSystem.Helpers;

namespace TicketManagementSystem.DAL
{
    class MovieDAL
    {
        public string tableName => "tbl_Movie";
        public  DataTable GetMovies()
        {
           return  DBHelper.ExecuteNonQuery($"SELECT * FROM {tableName}");
        }
        public int InsertMovies(Movie movie)
        {
            var parameters = new List<DBParameter>
            {
                new DBParameter{ParameterName = "Title",ParameterValue = movie.MovieTitle.ToString()},
                new DBParameter{ParameterName = "Genre",ParameterValue = movie.Genre.ToString()},
                new DBParameter{ParameterName= "IMDbScore", ParameterValue =(double)movie.IMDb}
            };
           return DBHelper.ExecuteNonQuery(DBHelper.OperationTypes.Insert, tableName, parameters);
        }

        public int UpdateMovies(Movie movie,int id)
        {
            var parameters = new List<DBParameter>
            {
                new DBParameter{ParameterName = "Title",ParameterValue = movie.MovieTitle.ToString()},
                new DBParameter{ParameterName = "Genre",ParameterValue = movie.Genre.ToString()},
                new DBParameter{ParameterName= "IMDbScore", ParameterValue =(double)movie.IMDb}
            };
            return DBHelper.ExecuteNonQuery(DBHelper.OperationTypes.Update, tableName, parameters,"MovieID", id: id);
        }
        public int DeleteMovie(int id)
        {
            return DBHelper.ExecuteNonQuery(DBHelper.OperationTypes.Delete, tableName, new List<DBParameter>(), columnName: "MovieId", id: id) ;
        }


    }
}
