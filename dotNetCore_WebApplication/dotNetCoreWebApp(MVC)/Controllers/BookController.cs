using dotNetCoreWebApp_MVC_.Models;
using dotNetCoreWebApp_MVC_.Respository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNetCoreWebApp_MVC_.Controllers
{
    public class BookController : Controller
    {
        private BookRepository _bookRepository = null;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public IActionResult Index()
        {
            return View();
        }
        public List<BookModel> GetAllBook()
        {
            return _bookRepository.GetAllBook();
        }
        public BookModel GetBookById(int id)
        {
            return _bookRepository.GetBookById(id);
        }
    }
}
