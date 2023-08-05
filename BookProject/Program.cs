using BookProject;

int chosen = 0; 
Console.WriteLine("Hi, Ener what you Want from The Libarary");
BookOperation bookOpertation = new BookOperation();
while (true)
{
    Console.WriteLine("1 - Add book\n2 - Update book\n3 - Display Book\n4 - Delete Book\n5 - Search Book");
    while (!int.TryParse(Console.ReadLine(), out chosen))
    {
        Console.WriteLine("Enter Number");
    }
    Book book = new Book("Alkhemyai", "Ahmed Khaled Tawfik", 2001);
    switch (chosen)
    {
        case 1:
            bookOpertation.Add(book);
            break;
        case 2:
            bookOpertation.Edit(book.BookName , "awalem");
            break;
        case 3:
            bookOpertation.DisplayAll();
            break;
        case 4:
            bookOpertation.Delete(book.BookName);
            break;
        case 5:
            bookOpertation.Search(book.BookName);
            break;
        default:
            Console.WriteLine("No Good Choose");
            break;
    }
}