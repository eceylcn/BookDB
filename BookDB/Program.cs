using BookDB;
using BookDB.Models;
BookDataContext db = new BookDataContext();
//*********************- insert -**************************

Book book = new Book();
{
    book.Name = "Momo";
    book.author = "Michael Ende";
};

db.Books.Add(book);
db.SaveChanges();
//*********************- get all books -**************************

List<Book> books = db.Books.ToList();

foreach (Book book in books)
{
    Console.WriteLine($"Name : {book.Name} Author : {book.author}");
}

//*********************- get book with Id -**************************

var book = db.Books.Where(a => a.ID == 2).FirstOrDefault();
Console.WriteLine($"Name : {book.Name} Author : {book.author}");

//*********************- update book -**************************

var book = db.Books.Where(n => n.Name == "Satranç").FirstOrDefault();
book.author = "Ece Yalçın";
db.SaveChanges();