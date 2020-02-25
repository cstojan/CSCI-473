/* DOC BOX
 * 
 * Class: CSCI 473
 * Section: 1
 * TA:Jennifer Ho, Sridivya Pagadala
 * Assignment #: 1
 * Due Date: January 30, 2020
 * Programmers: Carly Dobie, Cory Stojan
 * File: Community.cs
 * Description of file: Contains the Community Class
 * */

using System;
using System.Collections;
using System.Collections.Generic;

namespace a2
{
    //will implement both the IComparable and IEnumerable interfaces
    class Community : IComparable, IEnumerable
    {
        // attributes
        public SortedSet<Property> props;
        public SortedSet<Person> residents;
        private readonly uint id;
        private readonly string name;
        private uint mayorID;
        public Person[] _people; //IEnumerable

        // get/set methods
        public int Poplation
        {
            get { return residents.Count; }
        }
        public uint Id
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
        }

        public uint MayorID
        {
            get { return mayorID; }
            set { mayorID = value; }
        }

        // default constructor (sets attributes to 0 or "" as approperiate)
        public Community()
        {
            id = 0;
            name = "";
            mayorID = 0;
            props = new SortedSet<Property>();
            residents = new SortedSet<Person>();
        }

        // constructor with attributes (sets attributes to given values)
        public Community(String[] args)
        {
            id = Convert.ToUInt32(args[0]);
            name = args[1];
            mayorID = Convert.ToUInt32(args[2]);
            props = new SortedSet<Property>();
            residents = new SortedSet<Person>();
        }

        // population method (returns the count of residents in the community)
        public uint Population()
        {
            // count people in the resident and return count
            uint count = 0;
            foreach (Person people in residents)
            {
                count++;
            }
            return count;
        }

        // compare to function for the community class
        public int CompareTo(Object alpha) // sort by name
        {
            // Always check for null
            if (alpha == null)
                throw new Exception("ERROR: CompareTo argument is null.");

            Community rightOp = alpha as Community;

            // Next, check if the typecast was successful or not
            if (rightOp != null)
                return Name.CompareTo(rightOp.Name);
            else
                throw new Exception("ERROR: Community object compared to non-Community object.");


        }

        //IEnumerator method
        public Community(Person[] pArray)
        {
            _people = new Person[pArray.Length];

            for (int i = 0; i < pArray.Length; i++)
            {
                _people[i] = pArray[i];
            }
        }
        //IEnumerator method
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
        //GetEnumerator
        public CommEnum GetEnumerator()
        {
            return new CommEnum(_people);
        }
        //CommEnum
        public class CommEnum : IEnumerator
        {
            public Person[] _people;
            // Enumerators are positioned before the first element
            // until the first MoveNext() call.
            int position = -1;
            // CommEnum Constructor
            public CommEnum(Person[] list)
            {
                _people = list;
            }
            // MoveNext
            public bool MoveNext()
            {
                position++;
                return (position < _people.Length);
            }
            // Reset
            public void Reset()
            {
                position = -1;
            }
            // Current
            object IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }
            // Current Object
            public Person Current
            {
                get
                {
                    try
                    {
                        return _people[position];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        throw new InvalidOperationException();
                    }
                }
            }
        }
    }
}
