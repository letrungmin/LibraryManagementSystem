using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Manufacturer { get; set; }
        public int PublicationYear { get; set; }
        public int Price { get; set; }
        public string Language { get; set; }
        public string Semester { get; set; }

        public Book(int id, string name, string author, string manu, int publish, int price, string lang, string semes)
        {
            this.ID = id;
            this.Title = name;
            this.Author = author;
            this.Manufacturer = manu;
            this.PublicationYear = publish;
            this.Price = price;
            this.Language = lang;
            this.Semester = semes;
        }
    }

    
}
