namespace LibraryOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var first = new Library( 121,"Alex", "M Twain");
            var second = new Library(122, "Anthony", "Formula");
            var third = new Library(32242, "Liza", "Time");
            
            first.print();
            second.print();
            third.print();
        }
    }    
}
//checked
