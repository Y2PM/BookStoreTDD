using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreTDDbyjsb
{
    public class Catalogue
    {
        //Inject mock DataBaseReader
        DataBaseReader mockDataBaseReader;

        //Inject mock DataBaseWriter
        DataBaseWriter mockDataBaseWriter;

        public Catalogue(DataBaseReader givenMockDataBaseReader, DataBaseWriter givenMockDataBaseWriter)//ctor.
        {
            mockDataBaseReader = givenMockDataBaseReader;
            mockDataBaseWriter = givenMockDataBaseWriter;
        }

        public List<Book> Books;

        public List<Book> getAllBooks()
        {
            return mockDataBaseReader.ReadDatabase();
        }

        public void AddBook(Book bookToAdd)
        {
            mockDataBaseWriter.InsertItem(bookToAdd);
        }
    }
}
