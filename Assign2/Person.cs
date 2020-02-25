/* DOC BOX
 * 
 * Class: CSCI 473
 * Section: 1
 * TA:Jennifer Ho, Sridivya Pagadala
 * Assignment #: 2
 * Due Date: February 13, 2020
 * Programmers: Carly Dobie, Cory Stojan
 * File: Person.cs
 * Description of file: Contains the Person class
 * */

using System;
using System.Collections.Generic;
using System.Text;

namespace a2
{
    class Person : IComparable
    {
        // attributes
        private readonly uint id;
        private string lastName;
        private string firstName;
        private string occupation;
        private readonly DateTime birthday;
        private List<uint> residenceIds = new List<uint>();
        
        // Get/Set methods as applicable

        public string addResidence(uint addressId)
        {
            residenceIds.Add(addressId);
            return "Succussfully Added";
        }
        public string removeResidence(uint addressId)
        {
            residenceIds.Remove(addressId);
            return "Succussfully Removed";
        }

        public uint[] ResidenceIds
        {
            get { return residenceIds.ToArray(); }
        }

        public string Occupation
        {
            get { return occupation; }
            set { occupation = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public DateTime Birthday
        {
            get { return birthday; }
        }

        public uint Id //readonly
        {
            get { return id; }
        }

       
        // default constructor
        public Person()
        {
            id = 0;
            lastName = "";
            firstName = "";
            occupation = "";
            birthday = new DateTime();
            residenceIds = null;
        }

        // constructor with attributes
        public Person(string[] attributes)
        {
            //"Id, LastName, FirstName, Occupation, Year, Month, Day, Residence_ID"
            id = Convert.ToUInt32(attributes[0]);
            lastName = attributes[2];
            firstName = attributes[1];
            occupation = attributes[3];
            birthday = new DateTime(Convert.ToInt32(attributes[4]), Convert.ToInt32(attributes[5]), Convert.ToInt32(attributes[6]));
            residenceIds.Add(Convert.ToUInt32(attributes[7]));
        }

        // to string method
        public override string ToString()
        {
            // find age
            int age = DateTime.Now.Year - Birthday.Year;
            if (Birthday.DayOfYear > DateTime.Now.DayOfYear)
            {
                age -= 1;
            }
            // build the string and return value
            StringBuilder result = new StringBuilder(String.Format("{0,-20}\t{1,-3}\t{2,-20}", FullName(), age, Occupation));
            return result.ToString();
        }

        // full name method
        public string FullName()
        {
            // Last Name, First Name
            string result; 
            result = LastName;
            result += ", ";
            result += FirstName;
            return result;
        }

        // compare to
        public int CompareTo(Object alpha)
        {
            // Always check for null
            if (alpha == null) throw new Exception("ERROR: CompareTo argument is null.");
            // otherwise, the following code will crash the program

            Person rightOp = alpha as Person;

            // Next, check if the typecast was successful or not
            if (rightOp != null)
                return FullName().CompareTo(rightOp.FullName());
            else
                throw new Exception("ERROR: Person object compared to non-Person object.");
        }

    }
}
