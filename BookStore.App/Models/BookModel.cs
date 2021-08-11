using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.App.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; } = "Category";
        public string Language { get; set; }
        public int? TotalPages { get; set; }

        //public int Id { get; set; }
        //[Required(ErrorMessage = "Please enter the book title")]
        //[StringLength(15, MinimumLength = 5)]
        //public string Title { get; set; }
        //[Required(ErrorMessage = "Please enter the book author")]
        //public string Author { get; set; }
        //public string Description { get; set; }
        //public string Category { get; set; } = "Category";
        //[Required(ErrorMessage = "Please choose the book language")]
        //public string Language { get; set; }
        //[Required(ErrorMessage = "Please enter the total no. of pages")]
        //[Display(Name = "Total Page Number")]
        //public int? TotalPages { get; set; }
    }
}
