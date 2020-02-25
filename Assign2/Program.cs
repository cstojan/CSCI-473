using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace a2
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            /*
           

            // menu
            string command = "";
            while (command != "10")
            {
                // display all options
                //optionList();
                command = Console.ReadLine(); // read input line
                Console.Write("\nOption: ");// display what user chose
                // what user can type in order to tell the program to exit
                if (command == "q" || command == "Q" || command == "e" || command == "exit" || command == "E" ||
                    command == "quit")
                {
                    command = "10";
                }
                // handle user input
                switch (command)
                {
                    case ("1"):
                        option1(); //full property list
                        break;
                    case ("2"):
                        option2(); //list addresses
                        break;
                    case ("3"):
                        option3(); //addresses of all for-sale properties
                        break;
                    case ("4"):
                        option4(); //all residents in community
                        break;
                    case ("5"):
                        option5(); //all residents at a property
                        break;
                    case ("6"):
                        option6(); //for-sale
                        break;
                    case ("7"):
                        option7(); //buy a for-sale property
                        break;
                    case ("8"):
                        option8(); //add self as an occupant
                        break;
                    case ("9"):
                        option9(); //remove self as an occupant
                        break;
                    default:
                        Console.WriteLine("{0} is not an option.", command); // input that isn't handled by a case
                        break;
                }
            }

            // list of all options
            /*void optionList()
            {
                Console.WriteLine("\n\nMain Menu");
                Console.WriteLine("Enter an option (1-10).");
                Console.WriteLine("___________________________________________________________________");
                Console.WriteLine("1. Full property list.");
                Console.WriteLine("2. List addresses of either House or Apartment-type properties.");
                Console.WriteLine("3. List addresses of all for-sale properties.");
                Console.WriteLine("4. List all residents of a community.");
                Console.WriteLine("5. List all residents of a property, by street address.");
                Console.WriteLine("6. Toggle a property, by street address, as being for-sale or not.");
                Console.WriteLine("7. Buy a for-sale property, by the property's street address.");
                Console.WriteLine("8. Add yourself as an occupant to a property.");
                Console.WriteLine("9. Remove yourself as an occupant from a property.");
                Console.WriteLine("10. quit.\n");
            }*/
            /*
            // option 1
            void option1()
            {
                Console.WriteLine("1. Full property list.");
                // display community id, name, population
                Console.Write("<{0}> {1}. Population ({2}). Mayor: ", community1.Id, community1.Name, community1.Population());
                foreach (Person person in community1.residents)
                {
                    if (person.Id == community1.MayorID)
                    {
                        Console.WriteLine("{0}", person.FullName());
                        break;
                    }
                }
                Console.WriteLine("____________________________________________________________________");
                // display all properties
                foreach (Property property in community1.props) //for every property in the community
                {
                    //displays information on each property
                    foreach (Person person in community1.residents)
                    {
                        // find person living at property
                        if (person.Id == property.OwnerID)
                        {
                            Residential resToString = property as Residential;
                            House houseToString = property as House;
                            Apartment appToString = property as Apartment;
                            // display owner info and property info
                            Console.Write("{0}", property.ToString());
                            Console.Write("\n\tOwned by {0}", person.ToString());
                            Console.Write("\n\t{0}", resToString.ToString());
                            if (property is House)
                                Console.WriteLine("\n\t{0}", houseToString.ToString());

                            else
                                Console.WriteLine("{0}\n", appToString.ToString());
                        }
                    }
                }
            }

            // option 2
            void option2()
            {
                Console.WriteLine("List addresses of either House or Apartment-type properties.");
                Console.WriteLine("____________________________________________________________________");
                Console.WriteLine("Enter Property Type (House/Apartment)");
                string input = Console.ReadLine();
                switch (input.ToLower()) //make sure user's input is all lower case for comparison purposes
                {
                    case ("house"): //if user enters "House"
                        Console.WriteLine("\nHouses:");
                        foreach (Property i in community1.props) //display information on each house in community
                        {
                            if (i is House)
                            {
                                Console.WriteLine("{0} {1}, {2}, {3}", i.StreetAddr, i.City, i.State, i.Zip);
                            }
                        }
                        break;

                    case ("apartment"): //if user enters "Apartment"
                        Console.WriteLine("\nApartments:");
                        foreach (Property i in community1.props)
                        {
                            if (i is Apartment)
                            {
                                Apartment j = i as Apartment;
                                Console.WriteLine("{0} Apt.# {1} {2}, {3}, {4}", j.StreetAddr, j.Unit, j.City, j.State, j.Zip);
                            }
                        }
                        break;

                    default: //if user enters something other than "House" or "Apartment"
                        Console.WriteLine("Invalid option, returning to main menu.\n"); //error message
                        break;
                }
            }

            // option 3
            void option3()
            {
                Console.WriteLine("3. List address of all for-sale properties.");
                Console.WriteLine("____________________________________________________________________");
                Console.WriteLine("For Sale Properties:");
                // display all for-sale propeties addresses
                foreach (Property forSaleProp in community1.props) //look through properties
                {
                    if (forSaleProp.ForSale == true) //if the property is for sale
                    {
                        if (forSaleProp is Apartment) //if the for-sale property is an apartment
                        {
                            Apartment forSaleaP = forSaleProp as Apartment;
                            //display address of for-// close filesale apartment
                            Console.WriteLine("{0} Apt.# {1} {2}, {3}, {4}", forSaleaP.StreetAddr, forSaleaP.Unit, forSaleaP.City, forSaleaP.State, forSaleaP.Zip);
                        }
                        else if (forSaleProp is House) //if the for-sale property is a house
                        {
                            //display address of for-sale house
                            Console.WriteLine("{0} {1}, {2}, {3}", forSaleProp.StreetAddr, forSaleProp.City, forSaleProp.State, forSaleProp.Zip);
                        }
                        // if for some reason the property is not an house or appartment display error message
                        else
                            Console.WriteLine("Something went wrong.");
                    }
                }
            }

            // option 4
            void option4()
            {
                Console.WriteLine("4. List of all residents of the {0} community.", community1.Name);
                Console.WriteLine("______________________________________________");
                // display each person
                foreach (Person person in community1.residents)
                {
                    Console.WriteLine("{0}", person.ToString());
                }
            }

            // option 5
            void option5()
            {
                string streetAddr;
                Console.WriteLine("5. List all residents of a property, by the property's street address.");
                Console.WriteLine("____________________________________________________________________");
                Console.Write("Enter the address of the property: ");
                streetAddr = Console.ReadLine();
                // Find the street inputted
                bool flagEnd = false;
                foreach (Property prop in community1.props)
                {
                    if (prop.StreetAddr == streetAddr)
                    {
                        flagEnd = true;
                        Console.WriteLine("List of residents living at " + streetAddr + ":\n");

                        // find the matching person ID for the person living there
                        foreach (Person person in community1.residents)
                        {
                            for (int i = 0; i < person.ResidenceIds.Length; i++)
                            {
                                if (person.ResidenceIds[i] == prop.Id)
                                {
                                    Console.WriteLine(person.ToString());
                                }
                            }
                        }

                    }
                }
                // if bad input for street addresse is entered
                if (flagEnd == false)
                {
                    Console.WriteLine("No Address Matched Your Input. Returning to main menu.\n");
                }
            }

            // option 6
            void option6()
            {
                string streetAddr;
                Console.WriteLine("6. Toggle a property, by street address, as being for-sale or not.");
                Console.WriteLine("____________________________________________________________________");
                Console.WriteLine("Enter the street address of the property:");
                streetAddr = Console.ReadLine();
                // find and display the address
                bool flagEnd = false;
                foreach (Property prop in community1.props)
                {
                    if (prop.StreetAddr == streetAddr)
                    {
                        // change for sale value if found
                        flagEnd = true;
                        if (prop.ForSale == false)
                        {
                            prop.ForSale = true;
                        }
                        else
                        {
                            prop.ForSale = false;
                        }
                        // display output message of result
                        Console.Write("\n{0} is now ", prop.StreetAddr);
                        if (prop.ForSale == false)
                        {
                            Console.Write("NOT ");
                        }
                        Console.WriteLine("For Sale!");
                        break;
                    }
                }
                // if bad input for street addresse is entered
                if (flagEnd == false)
                {
                    Console.WriteLine("No Address Matched Your Input. Returning to main menu.\n");
                }
            }

            // option 7
            void option7()
            {
                string input;
                Console.WriteLine("7. Buy a for-sale property, by street address.");
                Console.WriteLine("____________________________________________________________________");
                // find the address to buy
                Console.WriteLine("Enter the street address of the property you would like to purchase:");
                input = Console.ReadLine();
                bool flagEnd = false;
                foreach (Property property in community1.props)
                {
                    if (property.StreetAddr == input)
                    {
                        flagEnd = true;
                        // ensure it is for sale
                        if (property.ForSale == false)
                        {
                            Console.WriteLine("Property Is Not For Sale.");
                        }
                        // set property owner to mayor (us)
                        else
                        {
                            // check to see if you alrady own the property
                            if (property.OwnerID == 0)
                            {
                                Console.WriteLine("You already own this property.");
                            }
                            // change ownership and write success message
                            else
                            {
                                property.OwnerID = 0;
                                property.ForSale = false;
                                Console.WriteLine("Congratuation, You Succussfully Purchased {0}", input);
                            }
                        }
                        break;
                    }
                }
                // if bad input for street addresse is entered
                if (flagEnd == false)
                {
                    Console.WriteLine("No Address Matched Your Input. Returning to main menu.\n");
                }
            }

            // option 8 
            void option8()
            {
                string input;
                Console.WriteLine("8. Add yourself as an occupent to a property.");
                Console.WriteLine("____________________________________________________________________");
                // find the address to occupy
                Console.WriteLine("Enter the street address of the property you would like to be added to as a resident:");
                input = Console.ReadLine();
                bool flagEnd = false;
                foreach (Property property in community1.props)
                {
                    if (property.StreetAddr == input)
                    {
                        flagEnd = true;
                        // find the mayor (we are the mayor)
                        foreach (Person person in community1.residents)
                        {
                            if (person.Id == 0)
                            {
                                bool flag = false; //<- used to see if the mayor already lives at the residence
                                // check to see if you are already living there
                                for (int i = 0; i < person.ResidenceIds.Length; i++)
                                {
                                    // set flag if last entry in list of places you live
                                    if (i == person.ResidenceIds.Length - 1)
                                        flag = true;
                                    // if you already live there
                                    if (person.ResidenceIds[i] == property.Id)
                                    {
                                        Console.WriteLine("You Already Live Here.");
                                        break;
                                    }

                                    // otherwise add person to the residence
                                    else if (flag == true)
                                    {
                                        Console.WriteLine(person.addResidence(property.Id));
                                        Console.WriteLine("Congratulations! You were succussfully added as a resident to this property!");
                                        break;
                                    }
                                }
                                break;
                            }
                        }
                        break;
                    }
                }
                // if bad input for street addresse is entered
                if (flagEnd == false)
                {
                    Console.WriteLine("No Address Matched Your Input. Returning to main menu.\n");
                }
            }

            // option 9
            void option9()
            {
                string input;
                Console.WriteLine("9. Remove yourself as an occupent from a property.");
                Console.WriteLine("____________________________________________________________________");
                // find the address to buy
                Console.WriteLine("Enter the street address of the property you would like to be removed from as a residenint:");
                input = Console.ReadLine();
                bool flagEnd = false;
                foreach (Property property in community1.props)
                {
                    if (property.StreetAddr == input)
                    {
                        flagEnd = true;
                        // find the mayor (we are the mayor)
                        foreach (Person person in community1.residents)
                        {
                            if (person.Id == 0)
                            {
                                bool flag = false; //<- used to see if the mayor already lives at the residence
                                // check to see if you are already living there
                                for (int i = 0; i < person.ResidenceIds.Length; i++)
                                {
                                    // flag set if no person is found
                                    if (i == person.ResidenceIds.Length - 1)
                                        flag = true;
                                    // if person is found, remove from residence
                                    if (person.ResidenceIds[i] == property.Id)
                                    {
                                        Console.WriteLine(person.removeResidence(property.Id));
                                        Console.WriteLine("Congratulations! You were succussfully removed as a resident to this property!");
                                        break;
                                    }
                                    // check to see if they live at the property
                                    else if (flag == true)
                                    {
                                        Console.WriteLine("You do not currently live at this property.");
                                        break;
                                    }
                                }
                                break;
                            }
                        }
                        break;
                    }
                }
                // if bad input for street addresse is entered
                if (flagEnd == false)
                {
                    Console.WriteLine("No Address Matched Your Input. Returning to main menu.\n");
                }
            }
        */
        }
    }
}
