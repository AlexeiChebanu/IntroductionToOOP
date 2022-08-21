using System;

namespace LibraryOOP
{
    public class Library
    {
        private int libraryID;
        private string userName;
        private string bookName;

        public Library(int libraryID, string userName, string bookName)
        {
            this.libraryID = libraryID;
            this.userName = userName;
            this.bookName = bookName;
        }

        public void print()
        {
            Console.WriteLine($"ID {libraryID}\nName: {userName}\tBook: {bookName}");

        }
    }
}
