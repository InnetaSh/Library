using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Book : LibraryItem
    {

        public string Genre { get; private set; } //жанр книги.
        public int PageCount { get; private set; } // количество страниц.

        public Book(string title, string author, int publicationYear, string genre, int pageCount) :base( title,  author,  publicationYear)
        {
            Genre = genre;
            PageCount = pageCount;
        }
        public override void DisplayInfo()   //переопределенный метод, который выводит информацию о книге.
        {
            Console.WriteLine($"название: {Title},\nавтор: {Author},\nгод публикации: {PublicationYear},\nжанр: {Genre},\nколичество страниц: {PageCount}.");
        }
    }
}
