using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookStoreTDDbyjsb;
using System.Collections.Generic;
using Moq;

namespace BasketTest
{
    [TestClass]
    public class CatalogueTest
    {
        
        #region MyRegion
        //[TestMethod]//****Redundant test****
        //public void Test_GetAllBooks_ReturnsEmptyBookList_IfNoBooksAreInTheCatalogue()
        //{
        //    //Arrange
        //    Mock<DataBaseReader> mockDataBaseReader = new Mock<DataBaseReader>();
        //    Catalogue catalogue = new Catalogue(mockDataBaseReader.Object);
        //    catalogue.Books = new List<Book>();
        //    //Act
        //    List<Book> Books = catalogue.getAllBooks();
        //    //Assert
        //    Assert.AreEqual(catalogue.Books, Books);
        //} 
        #endregion
        
        [TestMethod]
        public void Test_getAllBooks_CallsReadDatabaseMethodOfDatabaseReaderClass_WhenCalled()
        {
            //Arrange
            Mock<DataBaseWriter> mockDataBaseWriter = new Mock<DataBaseWriter>();
            Mock<DataBaseReader> mockDataBaseReader = new Mock<DataBaseReader>();
            Catalogue catalouge = new Catalogue(mockDataBaseReader.Object, mockDataBaseWriter.Object);
            catalouge.Books = new List<Book>();

            Book book1 = new Book();
            catalouge.Books.Add(book1);
            //Act
            catalouge.getAllBooks();
            //Assert
            mockDataBaseReader.Verify(r => r.ReadDatabase());
        }

        [TestMethod]
        public void Test_getAllBooks_ReturnsListOfBooksItReceivesFromReadDatabaseMethodOfDatabaseReaderCommand_WhenCalled()
        {
            //Arrange
            Mock<List<Book>> mockBookList = new Mock<List<Book>>();
            Mock<DataBaseWriter> mockDataBaseWriter = new Mock<DataBaseWriter>();
            Mock<DataBaseReader> mockDataBaseReader = new Mock<DataBaseReader>();
            //---Stub---
            mockDataBaseReader.Setup(r => r.ReadDatabase()).Returns(mockBookList.Object);//return of type mock list book

            Catalogue catalouge = new Catalogue(mockDataBaseReader.Object, mockDataBaseWriter.Object);//Type databasereader
            catalouge.Books = new List<Book>();
            
            //Act
            List<Book> bookList = catalouge.getAllBooks();
            //Assert
            CollectionAssert.AreEqual(catalouge.Books, bookList);
        }

        [TestMethod]
        public void Test_AddBook_CallsInserttItemMethodOfInsertItemClass_WhenCalled()
        {
            //Arrange
            Mock<DataBaseWriter> mockDataBaseWriter = new Mock<DataBaseWriter>();
            Mock<DataBaseReader> mockDataBaseReader = new Mock<DataBaseReader>();
            Catalogue catalogue = new Catalogue(mockDataBaseReader.Object ,mockDataBaseWriter.Object);
            catalogue.Books = new List<Book>();

            Book bookToAdd = new Book();

            //Act
            catalogue.AddBook(bookToAdd);

            //Assert
            mockDataBaseWriter.Verify(r => r.InsertItem(bookToAdd));
        }

        [TestMethod]
        public void Test_AddBook_PassBookGivenToIntertItemMethodOfDataBaseWriterClass_WhenCalled()
        {
            //Arrange
            Mock<DataBaseWriter> mockDataBaseWriter = new Mock<DataBaseWriter>();//needed
            Mock<DataBaseReader> mockDataBaseReader = new Mock<DataBaseReader>();
            Catalogue catalogue = new Catalogue(mockDataBaseReader.Object, mockDataBaseWriter.Object);//Only real object, this is the one being isolated for test.

            Book bookToAdd = new Book();
            bookToAdd.id = 1;

            //Act
            catalogue.AddBook(bookToAdd);//This is the method being tested.
            //Assert
            //Verify that the InsertItem method was called - and it was given a book to add - and that book had an id of 1
            mockDataBaseWriter.Verify(r => r.InsertItem(It.Is<Book>(b => b.id == 1)));
            //*****Equivalent to mockDataBaseWriter.InsertItem(bookToAdd);*****
        }
    }
}
