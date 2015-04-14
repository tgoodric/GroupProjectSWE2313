using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookstorePage
{
    public class BookOrder
        {
            public Book Book { get; set; }
            private byte qtyNew;
            public byte QuantityNew
            {
                get
                {
                    return qtyNew;
                }
                set
                {
                    if (value > Book.QtyNew)
                    {
                        throw new Exception();
                    }
                    else qtyNew = value;
                }
            } //contains logic to check for values larger than available books
            private byte qtyUsed;
            public byte QuantityUsed   //as above
            {
                get
                {
                    return qtyUsed;
                }
                set
                {
                    if (value > Book.QtyNew)
                    {
                        throw new Exception();
                    }
                    else qtyUsed = value;
                }
            }
            private byte qtyRental;
            public byte QuantityRental //likewise
            {
                get
                {
                    return qtyRental;
                }
                set
                {
                    if (value > Book.QtyNew)
                    {
                        throw new Exception();
                    }
                    else qtyRental = value;
                }
            }
            public bool EBookPurchased { get; set; }
            public BookOrder(Book book, byte qtyN, byte qtyU, byte qtyR, bool eBook)
            {
                Book = book;
                QuantityNew = qtyN;
                QuantityUsed = qtyU;
                QuantityRental = qtyR;
                EBookPurchased = eBook;
            }
            public float getTotal()
            {
                float total = 0.0F;
                total += (qtyNew * Book.PriceNew);
                total += (qtyUsed * Book.PriceUsed);
                total += (qtyRental * Book.PriceRental);
                if (EBookPurchased)
                {
                    total += Book.PriceEBook;
                }
                return total;
            }
        }
    }
