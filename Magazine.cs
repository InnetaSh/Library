using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Magazine : LibraryItem
    {
        public int IssueNumber { get; private set; } //номер выпуска журнала
        public string Publisher { get; private set; } // издатель журнала.

        public Magazine(string title, string author, int publicationYear, int issueNumber, string publisher) : base(title, author, publicationYear)
        {
            IssueNumber = issueNumber;
            Publisher = publisher;
        }
        public override void DisplayInfo()   //переопределенный метод, который выводит информацию о журнале.
        {
            Console.WriteLine($"название: {Title},\nавтор: {Author},\nгод публикации: {PublicationYear},\nномер выпуска журнала: {IssueNumber},\nиздатель: {Publisher}.");
        }
    }
}
