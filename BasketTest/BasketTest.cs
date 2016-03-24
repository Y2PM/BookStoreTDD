using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BookStoreTDDbyjsb;

namespace BasketTest
{
    [TestClass]
    public class BasketTest
    {
        [TestMethod]
        public void Test_GetBooksInBasket_ReturnsEmptyBookList_IfNoBooksHaveBeenAdded()
        {
            //Arrange
            Basket basket = new Basket();
            basket.listOfBooks = new List<Book>();
            //Act
            List<Book> listOfBooks = basket.getBooksInBasket();
            //Assert
            Assert.AreEqual(0, listOfBooks.Count);
        }

        [TestMethod]
        public void Test_GetBooksInBasket_ReturnsArrayOfLengthOne_AfterAddMethodIsCalledWithOneBook()
        {
            //Arrange
            Basket basket = new Basket();
            basket.listOfBooks = new List<Book>();
            //Act
            List<Book> listOfBooks = basket.addBook();
            //Assert
            Assert.AreEqual(1, listOfBooks.Count);
        }

        [TestMethod]
        public void Test_GetBooksInBasket_ReturnsArrayOfLengthTwo_AfterAddMethodIsCalledWithTwoBooks()
        {
            //Arrange
            Basket basket = new Basket();
            basket.listOfBooks = new List<Book>();
            //Act
            List<Book> listOfBooks = basket.addBook();
            listOfBooks = basket.addBook();
            //Assert
            Assert.AreEqual(2, listOfBooks.Count);
        }


    }
}
