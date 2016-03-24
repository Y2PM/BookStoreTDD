using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookStoreTDDbyjsb;
using System.Collections.Generic;

namespace BasketTest
{
    //[TestInitialize]


    [TestClass]
    public class CheckoutTest
    {
        [TestMethod]
        public void Test_CalculatedPrice_ReturnsDoubleZeroPointZero_WhenPassedAnEmptyBasket()
        {
            //Arrange
            Basket basket = new Basket();
            Checkout till = new Checkout();
            basket.listOfBooks = new List<Book>();//Make a list of books
            //Act
            double calcprice = till.calculatedPrice(basket.listOfBooks);
            //Assert
            Assert.AreEqual(0.0, calcprice);
        }

        [TestMethod]
        public void Test_CalculatedPrice_ReturnsPriceOfBookInBasket_WhenPassedBasketWithOneBook()
        {
            //Arrange
            Book book1 = new Book();//Instantiate a Book

            book1.price = 10;//Prices defined

            Basket basket = new Basket();//Instantiate a Basket & Checkout
            Checkout till = new Checkout();

            basket.listOfBooks = new List<Book>();//Make a list of books
            basket.listOfBooks.Add(book1);//Add book1
            //Act
            double priceOfBook = till.calculatedPrice(basket.listOfBooks);
            //Assert
            Assert.AreEqual(book1.price, priceOfBook);
        }

        [TestMethod]
        public void Test_calculatePrice_ReturnSumOfPriceOfBooksInBasket_CheckoutCalledWithBasketWithTwoBooksIn()
        {
            //Arrange
            Book book1 = new Book();
            Book book2 = new Book();

            book1.price = 10;
            book2.price = 20;

            Basket basket = new Basket();
            Checkout till = new Checkout();

            basket.listOfBooks = new List<Book>();
            basket.listOfBooks.Add(book1);
            basket.listOfBooks.Add(book2);
            //Act
            double booksprice = till.calculatedPrice(basket.listOfBooks);
            //Assert
            Assert.AreEqual(booksprice, book1.price + book2.price);
        }

        [TestMethod]
        public void Test_calculatePrice_ReturnSumOfPriceOfBooksInBasketMinus1Percent_CheckoutCalledWithBasketWithThreeBooksIn()
        {
            //Arrange
            Book book1 = new Book();
            Book book2 = new Book();
            Book book3 = new Book();

            book1.price = 10;
            book2.price = 20;
            book3.price = 30;

            double tot = (book1.price + book2.price + book3.price);
            double totdiscount = tot - (tot * 0.01);

            Basket basket = new Basket();
            Checkout till = new Checkout();

            basket.listOfBooks = new List<Book>();
            basket.listOfBooks.Add(book1);
            basket.listOfBooks.Add(book2);
            basket.listOfBooks.Add(book3);
            //Act
            double booksprice = till.calculatedPrice(basket.listOfBooks);
            //Assert
            Assert.AreEqual(booksprice, totdiscount);
        }

        [TestMethod]
        public void Test_calculatePrice_ReturnSumOfPriceOfBooksInBasketMinus2Percent_CheckoutCalledWithBasketWithSevenBooksIn()
        {
            //Arrange
            Book book1 = new Book();
            Book book2 = new Book();
            Book book3 = new Book();
            Book book4 = new Book();
            Book book5 = new Book();
            Book book6 = new Book();
            Book book7 = new Book();


            book1.price = 10;
            book2.price = 20;
            book3.price = 30;
            book4.price = 40;
            book5.price = 50;
            book6.price = 60;
            book7.price = 60;

            double tot = (book1.price + book2.price + book3.price + book4.price + book5.price + book6.price + book7.price);
            double totdiscount = tot - (tot * 0.02);

            Basket basket = new Basket();
            Checkout till = new Checkout();

            basket.listOfBooks = new List<Book>();
            basket.listOfBooks.Add(book1);
            basket.listOfBooks.Add(book2);
            basket.listOfBooks.Add(book3);
            basket.listOfBooks.Add(book4);
            basket.listOfBooks.Add(book5);
            basket.listOfBooks.Add(book6);
            basket.listOfBooks.Add(book7);
            //Act
            double booksprice = till.calculatedPrice(basket.listOfBooks);
            //Assert
            Assert.AreEqual(booksprice, totdiscount);
        }

        [TestMethod]
        public void Test_calculatePrice_ReturnSumOfPriceOfBooksMinus13PercentDiscount_WhenGiven10Books()
        {
            //Arange
            Book book1 = new Book();
            Book book2 = new Book();
            Book book3 = new Book();
            Book book4 = new Book();
            Book book5 = new Book();
            Book book6 = new Book();
            Book book7 = new Book();
            Book book8 = new Book();
            Book book9 = new Book();
            Book book10 = new Book();

#region Idea to make variables in a loop
            /*
		            int NumberOfBooks = 10;
            for (int i = 0; i < NumberOfBooks; i++)
            {
                Book book + "i" = new Book();
            } 
            */
	#endregion

            book1.price = 10;
            book2.price = 20;
            book3.price = 30;
            book4.price = 40;
            book5.price = 50;
            book6.price = 60;
            book7.price = 60;
            book8.price = 50;
            book9.price = 60;
            book10.price = 60;

            double tot = (book1.price + book2.price + book3.price + book4.price + book5.price + book6.price + book7.price + book8.price + book9.price + book10.price);
            double totdiscount = tot - (tot * (0.03+0.1));

            Basket basket = new Basket();
            Checkout till = new Checkout();

            basket.listOfBooks = new List<Book>();

            basket.listOfBooks.Add(book1);
            basket.listOfBooks.Add(book2);
            basket.listOfBooks.Add(book3);
            basket.listOfBooks.Add(book4);
            basket.listOfBooks.Add(book5);
            basket.listOfBooks.Add(book6);
            basket.listOfBooks.Add(book7);
            basket.listOfBooks.Add(book8);
            basket.listOfBooks.Add(book9);
            basket.listOfBooks.Add(book10);
            //Act
            double booksprice = till.calculatedPrice(basket.listOfBooks);
            //Assert
            Assert.AreEqual(booksprice, totdiscount);
        }
    }
}
