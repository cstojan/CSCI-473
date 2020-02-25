/* DOC BOX
 * 
 * Class: CSCI 473
 * Section: 1
 * TA:Jennifer Ho, Sridivya Pagadala
 * Assignment #: 1
 * Due Date: January 30, 2020
 * Programmers: Carly Dobie, Cory Stojan
 * File: Property.cs
 * Description of File: Contains the Property superclass.
 * */

using System;
using System.Text;

namespace myGroupName_Assign1
{
    class Property : IComparable
    {
        // attributes
        protected readonly uint id;
        protected uint ownerID;
        protected readonly uint x;
        protected readonly uint y;
        protected string streetAddr;
        protected string city;
        protected string state;
        protected string zip;
        protected bool forSale;

        // get/set methods
        public uint Id //readonly
        {
            get { return id; }
        }

        public uint OwnerID
        {
            get { return ownerID; }
            set { ownerID = value; }
        }

        public uint X //readonly
        {
            get { return x; }
        }

        public uint Y //readonly
        {
            get { return y; }
        }

        public string StreetAddr
        {
            get { return streetAddr; }
            set { streetAddr = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }

        }

        public string Zip
        {
            get { return zip; }
            set { zip = value; }
        }

        public bool ForSale
        {
            get { return forSale; }
            set { forSale = value; }
        }

        // default constructor
        public Property()
        {
            id = 0;
            ownerID = 0;
            x = 0;
            y = 0;
            streetAddr = "";
            city = "";
            state = "";
            zip = "";
            forSale = false;
        }

        // secondary constructor
        public Property(string[] propAttribute)
        {
            id = Convert.ToUInt32(propAttribute[0]);
            ownerID = Convert.ToUInt32(propAttribute[1]);
            x = Convert.ToUInt32(propAttribute[2]);
            y = Convert.ToUInt32(propAttribute[3]);
            streetAddr = Convert.ToString(propAttribute[4]);
            city = propAttribute[5];
            state = propAttribute[6];
            zip = propAttribute[7];
            if (propAttribute[8] == "f" || propAttribute[8] == "F")
            {
                forSale = false;
            }
            else
            {
                forSale = true;
            }
        }

        // compare to for property class
        public virtual int CompareTo(Object alpha) //virtual so that derived class Apartment can also compare units
        {
            // Always check for null
            if (alpha == null) 
                throw new Exception("ERROR: CompareTo argument is null.");

            Property rightOp = alpha as Property;

            // Next, check if the typecast was successful or not
            if (rightOp != null)
            {
                string[] splitSting;
                string nameStreetleft;
                string houseNumleft;
                string nameStreetright;
                string houseNumright;

                // split address to find street name and number of house for both right and left objects
                //     left side
                splitSting = StreetAddr.Split();
                houseNumleft = splitSting[0];
                nameStreetleft = String.Join(" ", splitSting, 1, splitSting.Length - 1);
                //     right side
                splitSting = rightOp.StreetAddr.Split();
                houseNumright = splitSting[0];
                nameStreetright = String.Join(" ", splitSting, 1, splitSting.Length - 1);

                // compare state
                if (State.CompareTo(rightOp.State) < 0)
                {
                    return -1;
                }
                else if (State.CompareTo(rightOp.State) > 0)
                {
                    return 1;
                }
                // compare city
                else if (City.CompareTo(rightOp.City) < 0)
                {
                    return -1;
                }
                else if (City.CompareTo(rightOp.City) > 0)
                {
                    return 1;
                }
                // compare street name
                else if (nameStreetleft.CompareTo(nameStreetright) < 0)
                {
                    return -1;
                }
                else if (nameStreetleft.CompareTo(nameStreetright) > 0)
                {
                    return 1;
                }
                // compare street house number
                else if (houseNumleft.CompareTo(houseNumright) < 0)
                {
                    return -1;
                }
                else if (houseNumleft.CompareTo(houseNumright) > 0)
                {
                    return 1;
                }
                else if (this is House)
                {
                    // ensoure there are no duplicate house addresses that have diffrent amount of floors
                    return 0;
                }
                else
                    return 1;
                // compare subclasses next

            }
            // else they are not a Property object
            else
                throw new Exception("ERROR: Property object compared to non-Property object."); 
        }
        public virtual string ToString()
        {
            StringBuilder result = new StringBuilder(String.Format("Property Address : {0}, / {1} / {2} / {3}",StreetAddr, City, State, Zip));
            return result.ToString();
        }
    }
}
