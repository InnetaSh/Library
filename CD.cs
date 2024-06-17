using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class CD : LibraryItem
    {
        public int Duration { get; private set; } //продолжительность диска в минутах.
        public string Genre { get; private set; } // жанр диска.

        public CD(string title, string author, int publicationYear, int duration, string genre) : base(title, author, publicationYear)
        {
            Duration = duration;
            Genre = genre;
        }
        public override void DisplayInfo()   //переопределенный метод, который выводит информацию о диске.
        {
            Console.WriteLine($"название: {Title},\nавтор: {Author},\nгод публикации: {PublicationYear},\nпродолжительность диска в минутах: {Duration},\nжанр диска: {Genre}.");
        }
    }
}

