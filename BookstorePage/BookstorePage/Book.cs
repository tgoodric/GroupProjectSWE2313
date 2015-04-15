using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
#pragma warning disable 0168, 0659

namespace BookstorePage
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBNNumber { get; set; }
        public string Professor { get; set; }
        public string Use { get; set; }//required/recommended
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

        public Book(string isbn, string title, string author, string semest, string cour, string sect, 
                    string prof, string crn, string use, int qtyN, int qtyU, int qtyR,
                    bool eBookAvail, float priceN, float priceU, float priceR, float priceE,
                    string descr) //massive constructor for a not-terribly-complex object
        {
            Title = title;
            Author = author;
            ISBNNumber = isbn;
            Professor = prof;
            Use = use;
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
            this.Use = other.Use;
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
        public Book(string[] components)    //workaround for a nasty constructor call
        {                                   //components is a string[] with the components in the above
            this.ISBNNumber=components[0];  //constructor
            this.Title=components[1];
            this.Author=components[2];
            this.Semester=components[3];
            this.Course=components[4];
            this.Section=components[5];
            this.Professor=components[6];
            this.CRNNumber=components[7];
            this.Use=components[8];
            this.QtyNew = Convert.ToInt32(components[9]);
            this.QtyUsed = Convert.ToInt32(components[10]);
            this.QtyRental = Convert.ToInt32(components[11]);
            this.EBookAvailable = (Convert.ToInt32(components[12]) != 0); //don't ask
            this.PriceNew = Convert.ToSingle(components[13]);
            this.PriceUsed = Convert.ToSingle(components[14]);
            this.PriceRental = Convert.ToSingle(components[15]);
            this.PriceEBook = Convert.ToSingle(components[16]);
            this.Description = components[17];
        }
        
        public void display()
        {
            //
        }

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

        public override string ToString()
        {
            string retVal = "";
            retVal += (ISBNNumber + "\t");
            retVal += (Title +"\t");
            retVal += (Author + "\t");
            retVal += (Semester + "\t");
            retVal += (Course + "\t");
            retVal += (Section + "\t");
            retVal += (Professor + "\t");
            retVal += (CRNNumber + "\t");
            retVal += (Use + "\t");
            retVal += (QtyNew + "\t");
            retVal += (QtyUsed + "\t");
            retVal += (QtyRental + "\t");
            if (EBookAvailable)
            {
                retVal += (999999 + "\t");
            }
            else
            {
                retVal += (0 + "\t");
            }
            retVal += (PriceNew + "\t");
            retVal += (PriceUsed + "\t");
            retVal += (PriceRental + "\t");
            retVal += (PriceEBook + "\t");
            retVal += Description;
            return retVal;
        }
    }

}