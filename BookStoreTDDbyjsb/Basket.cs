using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookStoreTDDbyjsb
{
    public class Basket
    {
        public List<Book> listOfBooks;

        public List<Book> getBooksInBasket()
        {
            return listOfBooks;
        }

        public List<Book> addBook()
        {
            listOfBooks.Add(new Book());
            /*
            for (int i = 0; i < numBooks; i++)
            {
                listOfBooks.Add(new Book());
            }
            */
            return listOfBooks;
        }
    }
}
