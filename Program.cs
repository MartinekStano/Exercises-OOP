using System;
using System.Collections.Generic;

namespace Objektove_programovanie_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = "Hobit";
            int pages = 1000;
            string author = "J.R.R. Tolkien";
            int releasedate = 2000;

            Book.CategoryList.Add("náučné");
            Book.CategoryList.Add("dobrodružné");

            string category = Book.ChooseAGenre();

            Book HOBIT = new Book(title, pages, category, author, releasedate);
        }
    }
    class Book
    {
        private string Title { get; set; }
        private int Pages { get; set; }
        public string Category { private get; set; }
        public string Author { get; set; }
        public int ReleaseDate { get; set; }
        public static List<string> CategoryList;
        public Book(string title, int pages, string categoty, string author, int releasedate)
        {
            Title = title;
            Pages = pages;
            Category = categoty;
            Author = author;
            ReleaseDate = releasedate;
        }
        
        
        public override string ToString()
        {
            return $"{Title}\n{Pages}\n{Category}\n{Author}\n{ReleaseDate}";
        }
        
        public void DiscribeBook()
        {
            Console.WriteLine($"{Title} {Pages} {Category} {Author} {ReleaseDate}");
        }
        public static string ChooseAGenre()
        {
            int i = 1;
            foreach (string genre in Book.CategoryList)
            {

                Console.WriteLine("{0} {1}", i, genre);
                i += 1;
            }
            Console.WriteLine("Tvoj vyber: ");
            string category = Book.CategoryList[int.Parse(Console.ReadLine()) - 1];
            return category;
        }


    }
}
        
        
        
        


           

        
