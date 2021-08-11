using BookStore.App.Models;
using BookStore.App.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.App.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public IActionResult Index()
        {
            return View();
        }

        //public List<BookModel> GetAllBook()
        public ViewResult GetAllBook()
        {
            //return "All Books";
            var data = _bookRepository.GetAllBooks();
            return View(data);
        }

        [Route("book-details/{id}",Name ="BookDetails")]
        public ViewResult GetBook(int id)
        {
            //return $"Book with id = {id}";
            var data = _bookRepository.GetBookById(id);
            return View(data);
        }

        public List<BookModel> SearchBook(string bookName, string authorName)
        {
            //return $"Book with name = {bookName} and author name = {authorName}";
            return _bookRepository.SearchBook(bookName, authorName);
        }
    }
}
