using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookstorePage
{
    public class Cart //List<BookOrder> with a couple extra functions
    {
        List<BookOrder> books;
        public Cart()
        {
            books = new List<BookOrder>();
        }

        public void addNewBook(Book book, byte numNew, byte numUsed, byte numRental, bool eBook) //overwrites duplicates
        {
            bool duplicate = false;
            for (int i = 0; i < books.Count; i++)
            {
                if (book.Equals(books[i].Book))
                {
                    books[i].QuantityNew = numNew;
                    books[i].QuantityUsed = numUsed;
                    books[i].QuantityRental = numRental;
                    books[i].EBookPurchased = eBook;
                    duplicate = true;
                }
            }
            if (!duplicate)
            {
                books.Add(new BookOrder(book, numNew, numUsed, numRental, eBook));
            }
        }
        //Since duplicates of an order for a book are overwritten, only one order can exist per book
        public void removeBook(Book book)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Book.Equals(book))
                {
                    books.RemoveAt(i);
                    return;
                }
            }
        }//does nothing if no matching book found

        public float getOrderTotal()//calls getTotal() for each item in list, adds to grand total
        {
            BookOrder current = null;
            float total = 0.0F;
            for (int i = 0; i < books.Count; i++)
            {
                current = books[i];
                total += current.getTotal();
            }
            return total;
        }
    }
}