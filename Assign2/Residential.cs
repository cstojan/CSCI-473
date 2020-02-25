/* DOC BOX
 * 
 * Class: CSCI 473
 * Section: 1
 * TA:Jennifer Ho, Sridivya Pagadala
 * Assignment #: 1
 * Due Date: January 30, 2020
 * Programmers: Carly Dobie, Cory Stojan
 * File: Residential.cs
 * Description of file: Contains the Residential subclass.
 * */

using System;
using System.Text;

namespace a2
{
    class Residential : Property
    {
        //properties
        protected uint bedrooms;
        protected uint baths;
        protected uint sqft;

        //get set methods
        public uint Bedrooms
        {
            get { return bedrooms; }
            set { bedrooms = value; }
        }

        public uint Baths
        {
            get { return baths; }
            set { baths = value; }
        }

        public uint Sqft
        {
            get { return sqft; }
            set { sqft = value; }
        }

        // default constructor (initializes values to 0)
        public Residential()
        {
            bedrooms = 0;
            baths = 0;
            sqft = 0;
        }

        // constructor with values (sets properteis to values given)
        public Residential(string[] propAttribute) : base (propAttribute)
        {
            bedrooms = Convert.ToUInt32(propAttribute[9]);
            baths = Convert.ToUInt32(propAttribute[10]);
            sqft = Convert.ToUInt32(propAttribute[11]);
        }
        // to string method
        
    }
}
