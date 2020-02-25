﻿/* DOC BOX
 * 
 * Class: CSCI 473
 * Section: 1
 * TA:Jennifer Ho, Sridivya Pagadala
 * Assignment #: 1
 * Due Date: January 30, 2020
 * Programmers: Carly Dobie, Cory Stojan
 * File: Apartment.cs
 * Description of file: Contains the Apartment subclass.
 * */

using System;
using System.Text;

namespace a2
{

    class Apartment : Residential, IComparable
    {
        // attributes
        private string unit;

        // get set methods
        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }

        // default constructor
        public Apartment()
        {
            unit = "";
        }

        // constructor with attributes (sets attributes to values given)
        public Apartment(string[] propAttribute) : base(propAttribute)
        {
            unit = propAttribute[12];
        }

        // to string method
        public override string ToString()
        {
            string sale;
            if (ForSale)
            {
                sale = "*";
            }
            else
                sale = "";
            StringBuilder result = new StringBuilder(String.Format("{0, 23} Apt.# {1, 5}\t{2,2}",StreetAddr, Unit, sale));
            return result.ToString();
        }

        //CompareTo
        public int CompareTo(Property beta)
        {
            // Always check for null
            if (beta == null)
                throw new Exception("ERROR: CompareTo argument is null.");

            Apartment rightOp = beta as Apartment;

            // Next, check if the typecast was successful or not
            if (rightOp != null)
            {
                return Unit.CompareTo(rightOp.Unit);
            }
            // else they are not a Property object
            else
                throw new Exception("ERROR: Apartment object compared to non-Apartment object."); 
        }
    }
}


