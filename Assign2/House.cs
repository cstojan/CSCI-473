/* DOC BOX
 * 
 * Class: CSCI 473
 * Section: 1
 * TA:Jennifer Ho, Sridivya Pagadala
 * Assignment #: 2
 * Due Date: February 13, 2020
 * Programmers: Carly Dobie, Cory Stojan
 * File: House.cs
 * Description of file: Contains the House subclass.
 * */

using System;
using System.Text;

namespace a2
{
    class House : Residential
    {
        // properties
        private bool garage;
        private string? attachedGarage;
        uint floors;

        // get set methods
        public bool Garage
        {
            get { return garage; }
            set { garage = value; }
        }

        public string? AttachedGarage
        {
            get { return attachedGarage; }
            set { attachedGarage = value; }
        }

        public uint Floors
        {
            get { return floors; }
            set { floors = value; }
        }

        // default constructor
        public House()
        {
            garage = false;
            attachedGarage = null;
            floors = 0;
        }

        // constructor with attributes (sets properteis to values given)
        public House(string[] propAttribute) : base (propAttribute)
        {
            if (propAttribute[12] == "F" || propAttribute[12] == "f")
            {
                garage = false;
            }
            else
            {
                garage = true;
            }
            
            if (Garage == false)
            {
                attachedGarage = null;
            }
            else
            {
                attachedGarage = propAttribute[13];
            }
            floors = Convert.ToUInt32(propAttribute[14]);
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
            StringBuilder result = new StringBuilder(String.Format("{0, 30}\t{1,2}", StreetAddr, sale));
            return result.ToString();
        }


    }
}
