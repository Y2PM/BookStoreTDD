using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreTDDbyjsb
{
    public class DataBaseReader
    {
        public virtual List<Book> ReadDatabase()
        {
            List<Book> listOfBooks = new List<Book>();  
            return listOfBooks;
        }

        //public virtual List<Book> InsertItem()
        //{
        //    return null;
        //}
    }
}
