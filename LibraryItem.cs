using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal abstract class LibraryItem
    {
        public string Title { get;private set; } //название ресурса.
        public string Author { get;private set; } //автор ресурса.
        public int PublicationYear { get; private set; } // год публикации ресурса.
        public bool IsCheckedOut;  //флаг, показывающий, выдан ли ресурс.
        public void CheckOut() //метод, который помечает ресурс как выданный.
        {
            IsCheckedOut = true;
            Console.WriteLine($"ресурс {Title} выдан.");
        }

        public void Return() //метод, который помечает ресурс как возвращённый.
        {
            IsCheckedOut = false;
            Console.WriteLine($"ресурс {Title} возвращен.");
        }

        public LibraryItem(string title, string author, int publicationYear)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
        }
        public abstract void DisplayInfo();  //абстрактный метод, который выводит информацию о ресурсе.
    }
}
