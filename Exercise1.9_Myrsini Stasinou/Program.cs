namespace Exercise1._9_Myrsini_Stasinou
{

    /*
     * Άσκηση 1.9
        Δημιουργήστε μια κλάση με όνομα “Book”. Προσθέστε μια μέθοδο στη κλάση, η οποία θα λέγεται 
        “GetPageCount” χωρίς παραμέτρους. 
        Η μέθοδος αυτή στην Book θα επιστρέφει έναν ακέραιο αριθμό “1”. 
        Φτιάξτε άλλες 2 κλάσεις που να κληρονομούν από την Book, 
        και ονομάστε τις με κάποιον τίτλο βιβλίου. Η κάθε κλάση που κληρονομεί από την Book, 
        θα πρέπει να επιστρέφει διαφορετικό αριθμό σελίδων, 
        προσθέτοντας επίσης το αποτέλεσμα από την “GetPageCount” της βάσης.
     */

    class Program
    {
        static void Main(string[] args)
        {
            Book originalBook = new Book();
            Book paperTown = new BookPaperTown();
            Book blaze = new BookBlaze();

            Console.WriteLine($"The pages of the original Book are {originalBook.GetPageCount()}");
            Console.WriteLine($"The pages of the Paper Town Book are {paperTown.GetPageCount()}");
            Console.WriteLine($"The pages of the Blaze Book are {blaze.GetPageCount()}");

        }

    }

    class Book
    {
        public virtual int GetPageCount()
        {
            int pages = 1;
            return pages;
        }
    }

    class BookPaperTown : Book
    {
        public override int GetPageCount()
        {
            Console.WriteLine("This is from the Book Paper Town");
            int pages = 298;
            pages = pages + base.GetPageCount();
            return pages;

        }
    }

    class BookBlaze : Book
    {
        public override int GetPageCount()
        {
            Console.WriteLine("This is from the Book Blaze");
            int pages = 350;
            pages = pages + base.GetPageCount();
            return pages;
        }

    }
}
