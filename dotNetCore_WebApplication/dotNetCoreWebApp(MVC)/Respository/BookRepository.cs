using dotNetCoreWebApp_MVC_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNetCoreWebApp_MVC_.Respository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBook()
        {
            return DataSource();
        }
        public BookModel GetBookById(int id) 
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        } 
        private List<BookModel> DataSource() 
        {
            return new List<BookModel>()
            {
                new BookModel(){ Id=1,Author="author1",Title="title1"},
                new BookModel(){ Id=2,Author="author2",Title="title2"},
                new BookModel(){ Id=3,Author="author3",Title="title3"},
            };
        }
    }
}
