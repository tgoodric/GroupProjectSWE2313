using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookstorePage
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBNNumber { get; set; }
        public string Professor { get; set; }
        public string Edition { get; set; }
        public int QtyNew { get; set; }
        public int QtyUsed { get; set; }
        public int QtyRental { get; set; }
        public bool EBookAvailable { get; set; }
        public string Description { get; set; }
        public float PriceNew { get; set; }
        public float PriceUsed { get; set; }
        public float PriceRental { get; set; }
        public float PriceEBook { get; set; }
        public string CRNNumber { get; set; }
        public string Semester { get; set; }
        public string Course { get; set; }
        public string Section { get; set; }

        public Book(string title, string author, string isbn, string prof, string ed, int qtyN, int qtyU, int qtyR,
                    bool eBookAvail, string descr, float priceN, float priceU, float priceR, float priceE,
                    string crn, string semest, string cour, string sect) //massive constructor for a not-terribly-complex object
        {
            Title = title;
            Author = author;
            ISBNNumber = isbn;
            Professor = prof;
            Edition = ed;
            QtyNew = qtyN;
            QtyUsed = qtyU;
            QtyRental = qtyR;
            EBookAvailable = eBookAvail;
            Description = descr;
            PriceNew = priceN;
            PriceUsed = priceU;
            PriceRental = priceR;
            PriceEBook = priceE;
            CRNNumber = crn;
            Semester = semest;
            Course = cour;
            Section = sect;
        }

        public Book(Book other) //duplicates book to create a deep copy
        {
            this.Author = other.Author;
            this.Course = other.Course;
            this.ISBNNumber = other.ISBNNumber;
            this.Professor = other.Professor;
            this.Edition = other.Edition;
            this.QtyNew = other.QtyNew;
            this.QtyUsed = other.QtyUsed;
            this.QtyRental = other.QtyRental;
            this.EBookAvailable = other.EBookAvailable;
            this.Description = other.Description;
            this.PriceNew = other.PriceNew;
            this.PriceUsed = other.PriceUsed;
            this.PriceRental = other.PriceRental;
            this.PriceEBook = other.PriceEBook;
            this.CRNNumber = other.CRNNumber;
            this.Semester = other.Semester;
            this.Course = other.Course;
            this.Section = other.Section;
        }
        /*
         * Don't think we need anything other than the constructor here. 
         * Getters and setters have been implemented as properties.
         * Changes to object state come from webpage
         */
        public override bool Equals(Object other)
        {
            if (other is Book)
            {
                Book otherBook = (Book)other;
                if (this.ISBNNumber == otherBook.ISBNNumber)
                {
                    return true;
                }
            }
            return false;
        }

    }

}