using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreTDDbyjsb
{
    public class Checkout
    {
        //public double returnPrice;

        public double calculatedPrice(List<Book> listOfBooks)//Book bookToClaculate
        {
            double totalPrice = 0.0;

            foreach (Book book in listOfBooks)
            {
                totalPrice += book.price;
            }

            if (listOfBooks.Count >= 3 && listOfBooks.Count < 10)
            {
                double discountMultiplier = Math.Floor((double)listOfBooks.Count / 3);//Casted as double.
                return totalPrice - (totalPrice * 0.01) * discountMultiplier;
            }
            else if (listOfBooks.Count >= 10)
            {
                double discountMultiplier = Math.Floor((double)listOfBooks.Count / 3);
                return totalPrice - (totalPrice * 0.01) * discountMultiplier - (totalPrice * 0.1);
            }
            else
            {
                return totalPrice;
            }
            


            #region redundant code
            //for (int i = 0; i <= listOfBooks.Count; i++)
            //{
            //    if (listOfBooks[i] == null)
            //    {
            //        return 0.0;
            //    }
            //    else
            //    {
            //        return listOfBooks[i].price;
            //    }
            //}
            //return bookToClaculate.price; 
            #endregion
        }
    }
}
