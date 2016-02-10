using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Library
{
    public class Book
    {
        // Instance fields 
        private string _isbnCode;
        private string _title;
        private string _author;
        private double _price;
        private bool _bookIsLoanedOut;
        private int _noOfLoans; 
        
        // Step 3a 
        // Constructor with some parameters values 
        // this keyword represent the instance fields values 
        public Book(string isbnCode, string title, string author, double price)
        {
            this._isbnCode = isbnCode;
            this._title = title;
            this._author = author;
            this._price = price;
            this._bookIsLoanedOut = false;
            this._noOfLoans = 0; // Step 3b 
        }
        // Just some standard Get.. methods 
        // 
        public string GetIsbnCode()
        {
            return _isbnCode;
        }
        public string GetTitle()
        {
            return _title;
        }
        public string GetAuthor()
        {
            return _author;
        }
        public double GetPrice()
        {
            return _price;
        }
        public bool GetBookIsLoanedOut()
        {
            return _bookIsLoanedOut;
        }
        // Step 3d 
        public int GetNumberOfLoans()
        {
            return _noOfLoans;
        }
        // The below two methods are supposed to be called when a user 
        // loans the book from the library, and returns the book to the library. 
        // 
        public void BorrowFromLibrary()
        {
            _bookIsLoanedOut = true;
            _noOfLoans++; // Step 3c 
        }
        public void ReturnToLibrary()
        {
            _bookIsLoanedOut = false;
        }
        // Prints out complete information about the book 
        public void PrintInformation()
        {
            // Step 3e 
            Console.WriteLine("ISBN {0} : {1}, by {2} (price {3}), {4}, times loaned out: {5}", _isbnCode, _title, _author, _price, LoanStatus(), GetNumberOfLoans());
            Console.WriteLine();
        }
        // Just a little helper method to make sure the book loan status before to printing the book 
        // Don't worry about how this method works... 
        private string LoanStatus()
        {
            if (_bookIsLoanedOut)
            {
                return "book is loaned out";
            }
            else
            {
                return "book is NOT loaned out";
            }
        }
    }
}
