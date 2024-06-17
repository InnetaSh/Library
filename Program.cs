using Library;
using System.Collections.Generic;


//Дополнительные Требования:

//Создайте массив или список объектов типа LibraryItem, включающий несколько книг, журналов и дисков.
//Напишите метод для поиска ресурсов по названию и вывода их информации.
//Напишите метод для выдачи ресурса и возвращения ресурса, используя его название.

Book book1 = new Book("песнь льда и пламени.Игра престолов.", "Джордж Мартин", 1996, "роман в жанре фэнтези ", 864);
Book book2 = new Book("песнь льда и пламени.Битва королей.", "Джордж Мартин", 1998, "роман в жанре фэнтези ", 835);
Book book5 = new Book("песнь льда и пламени.Танец с драконами.", "Джордж Мартин", 2011, "роман в жанре фэнтези ", 845);

Book book7 = new Book("Ведьмак. ", "Анджей Сапковский", 1986, "фэнтези ", 1344);

Magazine magazine1 = new Magazine("Forbes Ukraine", "Берти Чарльз Форбс", 2024, 2, "Forbes");
Magazine magazine2 = new Magazine("Vogue Ukraine", "Анна Винтур", 2023, 3, "Condé Nast");

CD cd1 = new CD("Single Deutschland Du Hast", "Rammstein", 1997, 25, "индастриал-метал");

List<LibraryItem> Library = new List<LibraryItem>() { book1, book2, book5, book7 };
Library.Add(magazine1);
Library.Add(magazine2);
Library.Add(cd1);



PrintInfo(FindByName(Library, "песнь льда и пламени"));

CheckOutByName(Library, "Single Deutschland Du Hast");
ReturnByName(Library, "Vogue Ukraine");
CheckOutByName(Library, "песнь льда и пламени");
ReturnByName(Library, "песнь льда и пламени.Танец с драконами.");
PrintInfo(FindByName(Library, "Война и мир."));

List<LibraryItem> FindByName(List <LibraryItem> Library, string name)
{
    var result = new List<LibraryItem>();
    foreach ( var item in Library)
    {
        if (item.Title.Contains(name))
            result.Add(item);  
    }
    if (result.Count == 0)
    {
        Console.WriteLine($"Ресурса с названием \'{name}\' не найдено.");
    }
    return result;
}
void PrintInfo(List<LibraryItem> Library)
{
    
    foreach (var item in Library)
    {
        item.DisplayInfo();
        Console.WriteLine();
    }
}

void CheckOutByName(List<LibraryItem> Library, string name)
{
    var result = FindByName(Library, name);
    foreach (var item in result)
    {
        item.CheckOut();
    }
}
void ReturnByName(List<LibraryItem> Library, string name)
{
    var result = FindByName(Library, name);
    foreach (var item in result)
    {
        item.Return();
    }
}

