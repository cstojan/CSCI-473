/* DOC BOX
 * 
 * Class: CSCI 473
 * Section: 1
 * TA:Jennifer Ho, Sridivya Pagadala
 * Assignment #: 2
 * Due Date: February 13, 2020
 * Programmers: Carly Dobie, Cory Stojan
 * File: form1.cs
 * Description of file: Form event handlers. Application simulates multiple communities and the residents living inside the community.
 * */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace a2
{
    public partial class Form1 : Form
    {
        // variables for processing
        static SortedSet<Community> allCommunities;  // contains all the communites
        public static string communityType;  //for community toggle
        public static uint communityID; //for community toggle
        Community selectedCommunity = new Community(); // use for ease
        Person selectedPerson = new Person();          // use for ease
        Property selectedProperty = new Property();    // use for ease
        House selectedHouse = new House();             // use for ease
        Apartment selectedApartment = new Apartment(); // use for ease

        public Form1()
        {
            InitializeComponent();
            allCommunities = new SortedSet<Community>();
            AddCommunites();
        }

        //load all the information from the input files
        public void AddCommunites()
        {
            // add communities from input files
            string[] arglist = new string[3];
            // add dekalb community
            arglist[0] = "99999";
            arglist[1] = "Dekalb";
            arglist[2] = "0";
            allCommunities.Add(new Community(arglist));
            // add sycamore community
            arglist[0] = "99998";
            arglist[1] = "Sycamore";
            arglist[2] = "0";
            allCommunities.Add(new Community(arglist));

            // add sycamore community
            string fileLoc;
            string comName;
            comName = "Sycamore"; // communit Name
            fileLoc = "../../s_apartment_input.txt"; // File Location
            addAppartments(fileLoc, comName);
            fileLoc = "../../s_house_input.txt"; // ""
            addHouses(fileLoc, comName);
            fileLoc = "../../s_persons_input.txt"; // ""
            addPerson(fileLoc, comName);
            // add dekalb community
            comName = "Dekalb"; // Community Name
            fileLoc = "../../apartment_input.txt"; // File Location
            addAppartments(fileLoc, comName);
            fileLoc = "../../house_input.txt"; // ""
            addHouses(fileLoc, comName);
            fileLoc = "../../Persons_Input.txt"; // ""
            addPerson(fileLoc, comName);
            // output population of each community
            foreach (Community community in allCommunities)
            {
                Output_rtbox.Text += "There are " + community.Poplation + " people in " + community.Name + "\n";
            }


            /*
             * Function Name: Add Person
             * Function purpose: adds a new person object from an input file
             * input: string f (file) string c (community)
             * output: none
            */
            void addPerson(string f, string c)
            {
                String[] propIn;
                string fileInString;
                //read in Sycamore apartments
                using (StreamReader inFile = new StreamReader(f))
                {
                    fileInString = inFile.ReadLine();
                    while (fileInString != null)
                    {
                        propIn = fileInString.Split('\t');
                        foreach (Community communName in allCommunities)
                        {
                            if (communName.Name == comName)
                            {
                                communName.residents.Add(new Person(propIn));
                            }
                        }
                        fileInString = inFile.ReadLine();
                    }
                    // close file
                    inFile.Close();
                }
            }

            /*
             * Function Name: Add house
             * Function purpose: adds a new house object from an input file
             * input: string f (file) string c (community)
             * output: none
            */
            void addHouses(string f, string c)
            {
                String[] propIn;
                string fileInString;
                //read in Sycamore apartments
                using (StreamReader inFile = new StreamReader(f))
                {
                    fileInString = inFile.ReadLine();
                    while (fileInString != null)
                    {
                        propIn = fileInString.Split('\t');
                        foreach (Community communName in allCommunities)
                        {
                            if (communName.Name == comName)
                            {
                                communName.props.Add(new House(propIn));
                            }
                        }
                        fileInString = inFile.ReadLine();
                    }
                    // close file
                    inFile.Close();
                }
            }

            /*
             * Function Name: Add Apartment
             * Function purpose: adds a new apartment object from an input file
             * input: string f (file) string c (community)
             * output: none
            */
            void addAppartments(string f, string c)
            {
                String[] propIn;
                string fileInString;
                //read in Sycamore apartments
                using (StreamReader inFile = new StreamReader(f))
                {
                    fileInString = inFile.ReadLine();
                    while (fileInString != null)
                    {
                        propIn = fileInString.Split('\t');
                        foreach (Community communName in allCommunities)
                        {
                            if (communName.Name == comName)
                            {
                                communName.props.Add(new Apartment(propIn));
                            }
                        }
                        fileInString = inFile.ReadLine();
                    }
                    // close file
                    inFile.Close();
                }
            }
        }

        /*
         * Function Name: refresh
         * Function purpose: refreshes the community
         * input: uint community id
         * output: none
        */
        private void Refresh(uint communityID) //good :)
        {
            foreach (Community comm in allCommunities)
            {
                if (comm.Id == communityID)
                {
                    selectedCommunity = comm;
                    Residence_listbox.BeginUpdate();
                    Person_listbox.BeginUpdate();
                    Residence_listbox.Items.Clear();
                    Person_listbox.Items.Clear();
                    Residence_comboBox.Items.Clear();
                    DisplayCommunity(comm);
                    Residence_listbox.EndUpdate();
                    Person_listbox.EndUpdate();
                }
            }
        }

        //check which community was selected
        private void Community_button_CheckedChanged(object sender, EventArgs e) //good :)
        {
            Output_rtbox.Clear(); //clear anything in the output box
            // set the selected community to whichever is checked
            foreach (Community comm in allCommunities)
            {
                if (DeKalb_button.Checked == true && DeKalb_button.Text == comm.Name) //if dekalb is selected and dekalb community is found
                {
                    selectedCommunity = comm; //set selected community
                    communityID = comm.Id; //set community id
                }
                else if (Sycamore_button.Checked == true && Sycamore_button.Text == comm.Name) //if sycamore is selected and sycamore community is found
                {
                    selectedCommunity = comm; //set selected community
                    communityID = comm.Id; //set community id
                }
            }
            Output_rtbox.Text += selectedCommunity.Name + " displayed.\n" +
             "Population: " + selectedCommunity.Poplation + "\n"; //tell user which town is being displayed
            Refresh(communityID);
        }

        /*
             * Function Name: display community
             * Function purpose: displayes community
             * input: comm (community)
             * output: none
            */
        void DisplayCommunity(Community comm) //good :)
        {
            //house heading for listbox
            Residence_listbox.Items.Add(" ");
            Residence_listbox.Items.Add("Houses");
            Residence_listbox.Items.Add("----------------");
            //house heading for combobox
            Residence_comboBox.Items.Add(" ");
            Residence_comboBox.Items.Add("Houses");
            Residence_comboBox.Items.Add("----------------");
            foreach (Property prop in comm.props) //go through all properties
            {
                if (prop is House)
                {
                    Residence_listbox.Items.Add(prop); //populate listbox
                    Residence_comboBox.Items.Add(prop); //populate comboBox
                }
            }
            //apartments heading for listbox
            Residence_listbox.Items.Add(" ");
            Residence_listbox.Items.Add("Apartments");
            Residence_listbox.Items.Add("----------------");
            //apartments heading for combobox
            Residence_comboBox.Items.Add(" ");
            Residence_comboBox.Items.Add("Apartments");
            Residence_comboBox.Items.Add("----------------");
            foreach (Property prop in comm.props) //go through all properties
            {
                if (prop is Apartment)
                {
                    Residence_listbox.Items.Add(prop); //populate listbox
                    Residence_comboBox.Items.Add(prop); //populate combobox
                }
            }
            //populate people
            foreach (Person person in comm.residents)
            {
                Person_listbox.Items.Add(person); //add person's info to the listbox
            }
        }

        // residence mouse click action event
        private void Residence_listbox_MouseClick(object sender, MouseEventArgs e)
        {
            // clear output box
            Output_rtbox.Clear();
            // output which residence it is
            selectedProperty = Residence_listbox.SelectedItem as Property;

            Output_rtbox.Text += "Residents Living at ";
            if (Residence_listbox.SelectedItem is House) //if the selected property is a house
            {
                // who is owned by
                selectedHouse = Residence_listbox.SelectedItem as House;
                Output_rtbox.Text += selectedHouse.StreetAddr + " ";
                Output_rtbox.Text += "Owned by ";
                foreach (Person person in selectedCommunity.residents)
                {
                    if (person.Id == selectedHouse.OwnerID)
                    {
                        Output_rtbox.Text += person.FullName() + ":\n";
                        Output_rtbox.Text += "------------------------------------\n";
                        break;
                    }
                }
                // list people living there
                foreach (Person person in selectedCommunity.residents) //go through all residents in selected community
                {
                    for (int i = 0; i < person.ResidenceIds.Length; i++)
                    {
                        if (person.ResidenceIds[i] == selectedHouse.Id)
                        {
                            Output_rtbox.Text += person.FullName() + "\n";
                            break;
                        }
                    }
                }
            }
            else if (Residence_listbox.SelectedItem is Apartment) //if selected property is an apartment
            {
                // who owns the apartment
                selectedApartment = Residence_listbox.SelectedItem as Apartment;
                Output_rtbox.Text += selectedApartment.StreetAddr + " # " + selectedApartment.Unit + " ";
                Output_rtbox.Text += "Owned by ";
                foreach (Person person in selectedCommunity.residents) //go through all the people in the selected community
                {
                    if (person.Id == selectedApartment.OwnerID) //if person owns the property
                    {
                        Output_rtbox.Text += person.FullName() + ":\n";
                        Output_rtbox.Text += "------------------------------------\n";
                        break;
                    }
                }
                // output residents
                foreach (Person person in selectedCommunity.residents) //go through all the people in the selected community
                {
                    for (int i = 0; i < person.ResidenceIds.Length; i++)
                    {
                        if (person.ResidenceIds[i] == selectedApartment.Id)
                        {
                            Output_rtbox.Text += person.FullName() + "\n";
                            break;
                        }
                    }
                }
            }
            Output_rtbox.Text += "###End Output###\n\n";
            return;
        }

        //when the user selects a resident in the person listbox
        private void Person_listbox_MouseClick(object sender, MouseEventArgs e)
        {
            Output_rtbox.Clear(); //clear output box
            selectedPerson = Person_listbox.SelectedItem as Person; //set selected person
            Output_rtbox.Text += selectedPerson.ToString() + " who resides at:\n"; //ouput person's info
            for (int i = 0; i < selectedPerson.ResidenceIds.Length; i++)
            {
                foreach (Property property in selectedCommunity.props)
                {
                    if (selectedPerson.ResidenceIds[i] == property.Id)
                    {
                        Output_rtbox.Text += "     " + property.StreetAddr + "\n"; //display where person lives
                        break;
                    }
                }
            }
            Output_rtbox.Text += "###END OUTPUT###\n";
        }

        //changes the selected property's for-sale attribute
        private void ToggleForSale_Click(object sender, EventArgs e) //good
        {
            //make sure that a property has been selected
            if (Residence_listbox.SelectedIndex == -1)
                Output_rtbox.Text += "Please select a property first.\n";
            else //set the for-sale flag for the property
            {
                if (selectedProperty.ForSale == false) //if the selected property is not for-sale
                {
                    selectedProperty.ForSale = true; //set selected property to for-sale
                    Output_rtbox.Text += selectedProperty.StreetAddr + " is now for-sale.\n";
                }
                else if (selectedProperty.ForSale == true) //if the selected property is for-sale
                {
                    selectedProperty.ForSale = false; //set selected property to not for-sale
                    Output_rtbox.Text += selectedProperty.StreetAddr + " is no longer for-sale.\n";
                }
                Refresh(selectedCommunity.Id); //refresh properties list
            }
        }

        //set a selected resident as the owner of a selected property
        private void BuyProperty_Click(object sender, EventArgs e) //good
        {
            //check to make sure a community has been selected first
            if (selectedCommunity.Id == 0)
            {
                Output_rtbox.Text += "Please select a community first.\n";
                return;
            }
            //check to make sure a resident and a property have been selected otherwise, "Must select a resident and a for-sale property"
            if ((Residence_listbox.SelectedIndex == -1) || (Person_listbox.SelectedIndex == -1))
            {
                Output_rtbox.Text += "Please select a for-sale property and the person who is purchasing the property.\n";
                return;
            }
            //check to make sure the property is for sale otherwise, "Sorry, that property is not for-sale"
            if (selectedProperty.ForSale == false)
            {
                Output_rtbox.Text += "Sorry, that property is not for-sale at this time.\n";
                return;
            }
            //check to make sure that the selected resident does not live at the selected property already otherwise, "Sorry, you already live here"
            if (selectedPerson.Id == selectedProperty.OwnerID)
            {
                Output_rtbox.Text += "You already own that property.\n";
                return;
            }
            //set the selected resident as the owner of the selected property
            Output_rtbox.Clear();
            selectedProperty.OwnerID = selectedPerson.Id; //set selected person as the owner for selected property
            selectedProperty.ForSale = false; //property is no longer for-sale
            Refresh(selectedCommunity.Id);
            Output_rtbox.Text += selectedPerson.FirstName + " " + selectedPerson.LastName + " is now the owner of " +
                                 selectedProperty.StreetAddr + ".\n";
        }

        //add a selected resident to a selected property
        private void AddResident_Click(object sender, EventArgs e)
        {
            //make sure user has selected a community for the new resident to live in
            if (selectedCommunity.Id == 0)
            {
                Output_rtbox.Text += "Please select a community first.\n";
                return;
            }
            //make sure the user selects a property
            if (selectedProperty.Id == 0)
            {
                Output_rtbox.Text += "Please select a property.\n";
                return;
            }
            //make sure the user selects a resident in the community
            if (selectedPerson.Id == 0 && selectedPerson.FirstName == "") // mayors id is 0
            {
                Output_rtbox.Text += "Please select a person.\n";
                return;
            }
            //add resident

            foreach (Person person in selectedCommunity.residents) //go through all the residents
            {
                if (person.Id == selectedPerson.Id) //if the selected resident is found
                {
                    for (int i = 0; i < person.ResidenceIds.Length; i++) //?
                    {
                        if (person.ResidenceIds[i] == selectedProperty.Id) //if the selected resident already lives at the selected property
                        {
                            Output_rtbox.Text += person.FirstName + person.LastName + " already lives at " + selectedProperty.StreetAddr + ".\n";
                            return;
                        }
                        else if (i == person.ResidenceIds.Length - 1)
                        {
                            // add the resident
                            person.addResidence(selectedProperty.Id); //add a residence for the person
                            Refresh(selectedCommunity.Id); //refresh properties list
                            Output_rtbox.Text += person.FirstName + person.LastName + " is now a resident of " + selectedProperty + ".\n"; //output updated info
                            return;
                        }
                    }
                }
            }
        }

        //remove a selected resident from a selected property
        private void RemoveResident_Click(object sender, EventArgs e) //good :)_
        {
            //if user doesn't select a community
            if (selectedCommunity.Id == 0)
            {
                Output_rtbox.Text += "Please select a community first.\n";
                return;
            }
            //if user selects the mayor or doesn't select a person                   
            if (selectedPerson.Id == 0 && selectedPerson.FirstName == "")
            {
                Output_rtbox.Text += "Please select a person.\n";
                return;
            }
            //if user doesn't select a property
            if (selectedProperty.Id == 0)
            {
                Output_rtbox.Text += "Please selecte a property.\n";
                return;
            }

            //remove residence function
            foreach (Community community in allCommunities)
            {
                if (selectedCommunity.Id == community.Id)
                {
                    foreach (Property property in community.props) //go through every property in community
                    {
                        if (property.Id == selectedProperty.Id) //if a property matching the selected property is found
                        {

                            foreach (Person person in community.residents) //go through every person in community
                            {

                                if (person.Id == selectedPerson.Id) //if person matching the selected person is found
                                {

                                    for (int i = 0; i < person.ResidenceIds.Length; i++)
                                    {
                                        if (person.ResidenceIds[i] == property.Id) //if person does live at the property
                                        {
                                            person.removeResidence(property.Id); //remove person from property
                                            Output_rtbox.Text += person.FullName() + " was successfully removed from " + property + ".\n";
                                            Refresh(community.Id); //refresh list
                                            return; //return to form
                                        }
                                        else if (i == person.ResidenceIds.Length - 1) //person does not live at the property
                                        {
                                            Output_rtbox.Text += person.FullName() + " does not live at " + property + ".\n";
                                            return; //return to form
                                        }
                                    }
                                    break;
                                }
                            }
                            break;
                        }

                    }
                    break;
                }
            }
        }

        //when "Garage?" is checked, reveals "Attached" checkbox and vice versa
        private void Garage_exists(object sender, EventArgs e)  //good :)
        {
            if (Garage_checkbox.Checked == true) //if the property has a garage
            {
                Attached_checkbox.Show(); //reveal "Attached?" checkbox
                Apartment_textBox.Hide(); //hide the "Apt. #" textbox
                Apt_label.Hide(); //hide the label for the "Apt. #" textbox
                Floors_NUD.Maximum = 10; //set max floors to 10
            }
            else if (Garage_checkbox.Checked == false) //if the property does not have a garage
            {
                Attached_checkbox.Checked = false; //for when "Garage?" is unchecked, "Attached?" also becomes unchecked
                Attached_checkbox.Hide(); //hide "Attached?" checkbox                 
                Apartment_textBox.Show(); //show the "Apt. #" textbox
                Apt_label.Show(); //show the label for the "Apt. #" textbox
                Floors_NUD.Maximum = 10; //set max floors to 10
            }
        }

        //if something is entered into the "Apt. #" textbox, "Garage?" checkbox becomes hidden and floors are locked at 1
        private void Is_apartment(object sender, EventArgs e) //good :)
        {
            if (Apartment_textBox.Text != "") //if something is entered into the "Apt. #" textbox
            {
                Garage_checkbox.Hide(); //hide "Garage?" checkbox
                Floors_NUD.Maximum = 1; //set max floors to 1
            }
            else //if "Apt. #" textbox is blank
            {
                Garage_checkbox.Show(); //reveal the "Garage?" checkbox
                Floors_NUD.Maximum = 10; //set max floors to 10
            }
        }

        //adds a new property to the list of properties
        private void AddProperty_Click(object sender, EventArgs e) //good :)
        {
            //make sure community is selected and street address is entered (others have default values)
            if (selectedCommunity.Name == "") //no community was selected
            {
                Output_rtbox.Text = "Please select a community first.\n";
                return; //go back to form1`  7
            }
            else if (StreetAddr_textBox.Text == "") //no street address was entered
            {
                Output_rtbox.Text = "Please enter the street address for the new property.\n";
                return; //go back to form
            }
            Output_rtbox.Clear();
            // ensure that the property that user wants to add doesn't already exist
            foreach (Property prop in selectedCommunity.props) //go through all properties in selected community
            {
                // check street #
                if (StreetAddr_textBox.Text.ToLower() == prop.StreetAddr.ToLower()) //if property at the address user entered is found
                {
                    // street # and unit number for apartment
                    if (prop is Apartment) //check if property is an apartment
                    {
                        Apartment apartment = prop as Apartment;
                        if (Apartment_textBox.Text == "") //if user doesn't enter anything for the unit #
                        {
                            Output_rtbox.Text = "Please enter a unit number for " + apartment.StreetAddr + ".\n";
                            return; //go back to form
                        }
                        if (Apartment_textBox.Text.ToLower() == apartment.Unit.ToLower()) //apartment with same unit entered already exists
                        {
                            Output_rtbox.Text = "Sorry, " + apartment.StreetAddr + " apt# " + apartment.Unit + " already exists in " + selectedCommunity + ".\n";
                            return; //go back to form
                        }
                        //string message = StreetAddr_textBox.Text + Apartment_textBox.Text + "\n\nIs this correct?";
                    }
                    //same street address, not an apartment = duplicate property
                    else
                    {
                        Output_rtbox.Text = "Sorry, " + prop.StreetAddr + " already exists in " + selectedCommunity + ".\n";
                        return; //go back to form
                    }
                }

                //ask user to confirm their input
                string message = StreetAddr_textBox.Text + Apartment_textBox.Text +
                    "\nSquare Footage: " + Squarefootage_NUD.Value +
                    "\nBedrooms: " + Bedrooms_NUD.Value + "\nBaths: " + Baths_NUD.Value + "\nFloors: " + Floors_NUD.Value +
                    "\nGarage: " + Garage_checkbox.Checked + " Attached: " + Attached_checkbox.Checked +
                    "\n\nIs this correct?"; //display user's input for them to confirm
                string caption = "Add Property"; //title of message box
                MessageBoxButtons buttons = MessageBoxButtons.YesNo; //yes and no buttons
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons); //display message box
                if (result == DialogResult.No) //if user says information is not correct
                {
                    return; //go back so user can correct it
                }
                else if (result == DialogResult.Yes) //if user says the information is correct
                {
                    break; //continue to adding the property
                }
            }

            string[] argIn = new string[15]; // argument list for adding the property
            string zip = ""; // zip
            string state = ""; // state
            uint i = 1; // for unique id
            bool found = false; // found unique id

            // find uniqe id for new property & fill in state and zip attributes
            foreach (Property property in selectedCommunity.props)
            {
                // not sure if theres another way to do this because we need the state and zip from the community selected
                //     we could hard code it to be only illiniois and a default zip
                state = property.State; // state attribute
                zip = property.Zip; // zip attribute
                // fine unique id
                if (property.Id != i)
                {
                    found = true;
                    break;
                }
                i++;
            }
            // if we went through all properties and did not find a unique id we can just add 1 to get a id
            if (!found)
                i++;

            //add property to selected community
            try //try-catch in case anything goes wrong with adding the property
            {
                // append values to argument list
                argIn[0] = i.ToString(); // id 
                argIn[1] = "0"; // owner id
                argIn[2] = "0"; // x
                argIn[3] = "0"; // y
                argIn[4] = StreetAddr_textBox.Text; // street addr
                argIn[5] = selectedCommunity.Name; // city
                argIn[6] = state; // state
                argIn[7] = zip; // zip
                argIn[8] = "true"; // for sale
                argIn[9] = Bedrooms_NUD.Value.ToString(); // bedrooms
                argIn[10] = Baths_NUD.Value.ToString(); // baths
                argIn[11] = Squarefootage_NUD.Value.ToString(); // sqft

                // if property is an house
                if (Apartment_textBox.Text == "")// is a house
                {
                    // is garage there and if so, is it attached?
                    if (Garage_checkbox.Checked) // checked garage
                    {
                        argIn[12] = "T"; // value must be t or f (cannot be true or false)
                        if (Attached_checkbox.Checked)
                        {
                            argIn[13] = "T"; // attached garage
                        }
                        else
                        {
                            argIn[13] = "F"; //unattached garage
                        }
                    }
                    else
                    {
                        argIn[12] = "F"; //no garage
                    }

                    argIn[14] = Floors_NUD.Value.ToString();// floors

                    selectedCommunity.props.Add(new House(argIn)); //add the house

                    foreach (Property property in selectedCommunity.props) //check that the house has been added
                    {
                        if (property.Id == i)
                        {
                            Output_rtbox.Text += property.StreetAddr + " has been successfully added to " + selectedCommunity.Name + ".\n";
                            break; //break out so refresh happens at the end
                        }
                    }
                }
                // if it is an apartment
                else
                {
                    argIn[12] = Apartment_textBox.Text; // unit value

                    selectedCommunity.props.Add(new Apartment(argIn)); //add apartment

                    foreach (Property property in selectedCommunity.props) //check that apartment has been added
                    {
                        if (property.Id == i)
                        {
                            Output_rtbox.Text += property.StreetAddr + " has been successfully added to " + selectedCommunity.Name + ".\n";
                            break; //break out so refresh happens at the end
                        }
                    }
                }

                Refresh(communityID); //refresh list to show new property

                //clear input
                StreetAddr_textBox.Clear(); //clear street address input box
                Apartment_textBox.Clear(); //clear apt # input box
                Squarefootage_NUD.Value = 500; //reset the sqare footage value
                Bedrooms_NUD.Value = 1; //reset the bedrooms value
                Baths_NUD.Value = 1; //reset the baths value
                Floors_NUD.Value = 1; //reset the floors value
                Garage_checkbox.Checked = false; //reset the garage checkbox
                Attached_checkbox.Checked = false; //reset the attached checkbox
            }
            // catch all errors so program doesnt crash
            catch
            {
                Output_rtbox.Text += "There was an error adding the property.\n"; //error message
                return;
            }
        }

        //adds a new resident to the community
        private void AddNewResident_Click(object sender, EventArgs e) //having a hard time following this
        {
            //make sure user has selected a community
            if (selectedCommunity.Name == "")
            {
                Output_rtbox.Text += "Please select a community first.\n";
                return;
            }
            //if user doesn't enter a name
            if (Name_textBox.Text == "")
            {
                Output_rtbox.Text += "Please enter a name for the person you would like to add.\n"; //error message
                return;
            }
            //if user enters a name without a space separating the first and last
            if (Name_textBox.Text.Split()[0] == Name_textBox.Text) //if split doesn't do anything
            {
                Output_rtbox.Text = "Please enter the person's first name and last name separated by a space.\n";
                return;
            }
            //if user doesn't enter an occupation
            if (Occupation_textBox.Text == "")
            {
                Output_rtbox.Text += "Please enter an occupation for the person you would like to add.\n"; //error message
                return;
            }
            // if selected item = null
            if (Residence_comboBox.SelectedItem == null)
            {
                Output_rtbox.Text += "Please select a residence for the person to live at.\n";
                return;
            }

            // used for input
            string newOccupation = Occupation_textBox.Text;
            string newFullName = Name_textBox.Text.Split()[0] + " " + Name_textBox.Text.Split()[1];
            string[] arglist = new string[8];
            int day = Birthday_dateTimePicker.Value.Day;
            int month = Birthday_dateTimePicker.Value.Month;
            int year = Birthday_dateTimePicker.Value.Year;
            uint newId = 0;
            bool idFound;

            //check to see if person exists already
            foreach (Person person in selectedCommunity.residents) //go through everyone in community
            {
                if (newFullName.ToLower() == (person.FirstName + " " + person.LastName).ToLower()) //if a matching name is found
                {
                    Output_rtbox.Text += newFullName + " already exists in " + selectedCommunity.Name + ".\n"; //person already exists in community
                    //clear inputs
                    Name_textBox.Text = "";
                    Occupation_textBox.Text = "";
                    Residence_comboBox.Text = "";
                    break; //return to form
                }
            }

            //try adding person to community
            try //works
            {
                // get a unique id
                foreach (Community community in allCommunities)
                {
                    if (selectedCommunity.Id == community.Id)
                    {
                        // find a unique id
                        do
                        {
                            newId++;
                            idFound = false;
                            foreach (Person person in community.residents)
                            {
                                if (person.Id == newId)
                                {
                                    idFound = true;
                                    break;
                                }
                            }
                        } while (idFound);
                    }
                }

                //convert inputs to a string and place in array
                arglist[0] = newId.ToString(); //id 
                arglist[1] = newFullName.Split()[0]; //lastname
                arglist[2] = newFullName.Split()[1]; //firstname
                arglist[3] = newOccupation; //occupation
                arglist[4] = year.ToString(); //birthday
                arglist[5] = month.ToString(); // birthday
                arglist[6] = day.ToString(); //birthday
                //arglist[7] = newResidenceID.ToString(); 

                // if they select an invalid property set property residence to default (0)
                if (Residence_comboBox.Text == "" || Residence_comboBox.Text == "Apartments" || Residence_comboBox.Text == "----------------")
                {
                    Output_rtbox.Text += "You Selected an invalid property. You craeted a person with no residence id.\n" +
                                         "You can add a residence by selecting the property and selecting the person and click add residence.\n";
                    arglist[7] = "0";
                }
                else
                {
                    foreach (Property prop in selectedCommunity.props) //go through all the properties in the selected community
                    {
                        if (Residence_comboBox.SelectedItem.Equals(prop)) //if the selected residence is found
                        {
                            arglist[7] = prop.Id.ToString(); //save that residence as somewhere the person lives
                        }
                    }
                }

                foreach (Community community in allCommunities) //for all communities
                {
                    if (community.Id == selectedCommunity.Id) //if matching community is found
                    {
                        community.residents.Add(new Person(arglist)); //add the new person to the resident
                        break;
                    }
                }
                //refresh resident list
                Refresh(communityID);
                //check if person has been added to the community
                foreach (Person person in selectedCommunity.residents) //go through all the people
                {
                    if (person.Id == Convert.ToUInt32(arglist[0])) //check if person is in the population
                    {
                        Output_rtbox.Text += person.FirstName + " " + person.LastName + " has been successfully added to " + selectedCommunity.Name + ".\n";

                        //clear inputs
                        Name_textBox.Text = ""; //clear name input box
                        Occupation_textBox.Text = ""; //clear occupation input box
                        Residence_comboBox.Text = ""; //clear residence box selection
                        break; //return to form
                    }
                }
            }
            catch
            {
                // catch errors so program doesnt crash
                Output_rtbox.Text += "Something went wrong.\n";
                return; //go back to form
            }
        }
    }
}