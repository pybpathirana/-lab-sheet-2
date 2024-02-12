using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace lab_sheet_2_q1
{
    
    internal class Book
    {
        public string Title;
        public string Author;
        public Book( string Title,string Author) 
        {
           this.Title = Title;
            this.Author = Author;
        
        }
        public void Display()
        {
            Console.WriteLine($"Title: {Title}\nAuthor: {Author}");
        }
    }
}
