/* DOC BOX
 * 
 * Class: CSCI 473
 * Section: 1
 * TA:Jennifer Ho, Sridivya Pagadala
 * Assignment #: 1
 * Due Date: January 30, 2020
 * Programmers: Carly Dobie, Cory Stojan
 * File: House.cs
 * Description of file: Contains the House subclass.
 * */

using System;
using System.Text;

namespace myGroupName_Assign1
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
        public virtual string ToString()
        {
            string Thegarage;
            if (Garage == false)
            {
                Thegarage = "... with no garage";
            }
            else
                Thegarage = "with an attached garage";
            StringBuilder result = new StringBuilder(String.Format("{0} : {1} floors\n", Thegarage, Floors));
            return result.ToString();
        }

        
    }
}
