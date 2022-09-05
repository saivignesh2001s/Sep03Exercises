using Sep03;

namespace Sep03Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book(1,"Two leaves",200.00f,"MGR");
            Console.WriteLine("Ques 1,2");
            book.Display();
            Book b2 = new Book();
            b2.InsertBook(2, "Rising", 200.0f);
            Console.WriteLine("Ques 3");
            b2.Display();
            Book b3 = new Book();
            b3.InsertBook(12, "add", 100.00f, "proc");
            Console.WriteLine("Ques 4");
            b3.Display();
            Console.WriteLine("Ques 5,6");
            Book b4 = new Book();
            b4.InsertBook(1, "emblem");
            b4.Display();
            Bookcategory b1 = new Bookcategory(1, "Politics", "Popular");
            Console.WriteLine("Ques 7");
            b1.Display();
            Console.WriteLine("Ques 8,9");
            Novels n1 = new Novels();
            n1.InsertBook(1, "Shilpi", 200.0f);
            n1.Display();
            Novels n2=new Novels();
            n2.InsertBook(2, "Manliness", 200.6f, "Rudyard kipling");
            n2.Display();
            Cart c1=new Cart();
            c1.CustomerId = 12;
            c1.BookingId = 123;
            c1.Addtocart(1, "Manliness", 200.0f);
            c1.Addtocart(2,"Pongal", 201.0f);
            Console.WriteLine("Ques10");
            c1.dis();
            Console.WriteLine("Ques11");
            c1.bookdis();
            Cart c2 = new Cart();
            c2.CustomerId = 13;
            c2.BookingId = 1232;
            c2.Addtocart(1, "Psalm of life", 200.0f);
            c2.Addtocart(2, "Going for water", 201.0f);
            c2.dis();
            c2.bookdis();

            Console.ReadLine();
       

        }
    }
}