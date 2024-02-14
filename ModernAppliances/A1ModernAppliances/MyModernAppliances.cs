using ModernAppliances.Entities;
using ModernAppliances.Entities.Abstract;
using ModernAppliances.Helpers;
using System.Runtime.CompilerServices;

namespace ModernAppliances
{
    /// <summary>
    /// Manager class for Modern Appliances
    /// </summary>
    /// <remarks>Author: </remarks>
    /// <remarks>Date: </remarks>
    internal class MyModernAppliances : ModernAppliances
    {
        /// <summary>
        /// Option 1: Performs a checkout
        /// </summary>
        public override void Checkout()
        {
            // Write "Enter the item number of an appliance: "
            Console.WriteLine("Enter the item number of an appliance");
        
            // Get user input as string and assign to variable.
            string userInput = Console.ReadLine();
        
            // Create long variable to hold item number
            // Convert user input from string to long and store as item number variable.
            if (!long.TryParse(userInput, out long itemNumber))
            {
                Console.WriteLine("Invalid input. Please enter a valid item number.\n");
                return;
            }
            // Create 'foundAppliance' variable to hold appliance with item number
            Appliance? foundAppliance;
        
            // Assign null to foundAppliance (foundAppliance may need to be set as nullable)
            foundAppliance = null;
        
            // Loop through Appliances
            foreach (Appliance appliance in Appliances)
            {
                // Test appliance item number equals entered item number
                if (appliance.ItemNumber == itemNumber)
                {
                    // Assign appliance in list to foundAppliance variable
                    foundAppliance = appliance;
        
                    // Break out of loop (since we found what we need to)
                    break;
                }
            }
        
            // Test appliance was not found (foundAppliance is null)
            if (foundAppliance == null)
            {
                // Write "No appliances found with that item number."
                Console.WriteLine("No appliances found with that item number.");
            }
            else
            {
                // Otherwise (appliance was found)
                // Test found appliance is available
                if (foundAppliance != null)
                {
                    // Otherwise (appliance isn't available)
                    // Write "Appliance has been checked out."
                    Console.WriteLine("Appliance has been checked out.");
        
                    // Checkout found appliance
                    foundAppliance.Checkout();
                }
        
                else
                {
                    // Otherwise (appliance isn't available)
                    // Write "The appliance is not available to be checked out."
                    Console.WriteLine("The appliance is not available to be checked out.");
        
                }
            }
        }
        public override void Find()
        {
            // Write "Enter brand to search for:"

            // Create string variable to hold entered brand
            // Get user input as string and assign to variable.

            // Create list to hold found Appliance objects

            // Iterate through loaded appliances
                // Test current appliance brand matches what user entered
                    // Add current appliance in list to found list


            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays Refridgerators
        /// </summary>
        public override void DisplayRefrigerators()
        {
            // Write "Possible options:"

            // Write "0 - Any"
            // Write "2 - Double doors"
            // Write "3 - Three doors"
            // Write "4 - Four doors"
            Console.WriteLine("Possible Options\n0 - Any\n2 - Double Doors\n3 - Three Doors\n4 - Four Doors");
            // Write "Enter number of doors: "
            Console.WriteLine("Enter number of doors: ")
            // Create variable to hold entered number of doors
            int numberOfDoors;
            // Get user input as string and assign to variable
            string userInput = Console.ReadLine();
            // Convert user input from string to int and store as number of doors variable.
            if (!int.TryParse(userInput, out numberOfDoors))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            // Create list to hold found Appliance objects
            List<Appliance> found = new List<Appliance>();

            // Iterate/loop through Appliances
            foreach(Appliance appliance in Appliance)
            {
                // Test that current appliance is a refrigerator
                if(appliance is Refrigerator)
                {
                    // Down cast Appliance to Refrigerator
                    // Refrigerator refrigerator = (Refrigerator) appliance;
                    Refrigerator refrigerator = (Refrigerator)appliance;

                    // Test user entered 0 or refrigerator doors equals what user entered.
                    if (numberOfDoors == 0 || refrigerator.NumberofDoors == numberOfDoors)
                    {
                        // Add current appliance in list to found list
                        found.Add(appliance);
                    }
                }
            }
            // Display found appliances

            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays Vacuums
        /// </summary>
        /// <param name="grade">Grade of vacuum to find (or null for any grade)</param>
        /// <param name="voltage">Vacuum voltage (or 0 for any voltage)</param>
        public override void DisplayVacuums()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options: ");
         
            // Write "0 - Any"
            // Write "1 - Residential"
            // Write "2 - Commercial"
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 - Residential");
            Console.WriteLine("2 - Commericial");
         
            // Write "Enter grade:"
            Console.WriteLine("Enter grade: ");
            string grade = Console.ReadLine();
            Console.WriteLine("Your entered grade is: " + grade);
         
            // Get user input as string and assign to variable
         
            // Create grade variable to hold grade to find (Any, Residential, or Commercial)
         
            // Test input is "0"
            // Assign "Any" to grade
            // Test input is "1"
            // Assign "Residential" to grade
            // Test input is "2"
            // Assign "Commercial" to grade
            // Otherwise (input is something else)
            // Write "Invalid option."
         
         
            if (grade = 0)
            {
                grade = "Any";
            }
            else if (grade = 1)
            {
                grade = "Residential";
            }
            else if (grade = 2)
            {
                grade = "Commercial";
            }
            else
            {
                Console.WriteLine("Invalid opition");
            }
         
            // Return to calling (previous) method
         
            return;
         
            // Write "Possible options:"
         
            Console.WriteLine("Possible options:");
         
            // Write "0 - Any"
            // Write "1 - 18 Volt"
            // Write "2 - 24 Volt"
         
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 - 18 Volt");
            Console.WriteLine("2 - 24 Volt");
         
            // Write "Enter voltage:"
            // Get user input as string
            // Create variable to hold voltage
         
            Console.WriteLine("Enter voltage:");
            string voltage = Console.ReadLine();
            Console.WriteLine("Your inputed voltage is:" + voltage);
         
         
            // Test input is "0"
            // Assign 0 to voltage
            // Test input is "1"
            // Assign 18 to voltage
            // Test input is "2"
            // Assign 24 to voltage
            // Otherwise
            // Write "Invalid option."
            // Return to calling (previous) method
         
            if (voltage = 0);
            {
                voltage = "Any";
            }
            else if (voltage = 1);
            {
                voltage = 18;
            }
            else if (voltage = 2);
            {
                voltage = 24;
            }
            else
            {
                Console.WriteLine("Invalid option");
            }
            return;
         
            // Create found variable to hold list of found appliances.
         
            string[] found = { };
         
            // Loop through Appliances
            // Check if current appliance is vacuum
            // Down cast current Appliance to Vacuum object
            string[] Appliances = {"Refigerator", "Vacuum", "Microwave", "Dishwasher" };
            for (int i = 0;  i < Appliances.Length; i++)
            {
                Console.WriteLine(Appliances[i]);
            }
            Vacuum vacuum = (Vacuum)Appliances;
         
            // Test grade is "Any" or grade is equal to current vacuum grade and voltage is 0 or voltage is equal to current vacuum voltage
            // Add current appliance in list to found list
         
            
         
            // Display found appliances
            DisplayAppliancesFromList(found, 0);
        }
        public override void DisplayMicrowaves()
        {
            // Write "Possible options:"

            // Write "0 - Any"
            // Write "1 - Kitchen"
            // Write "2 - Work site"
            Console.WriteLine("Possible options:\n0 - Any\n1 - Kitchen\n2 - Work site");

            // Write "Enter room type:"
            Console.WriteLine("Enter room type: ");
            

            // Get user input as string and assign to variable


            // Create character variable that holds room type
            string roomType = Console.ReadLine();

            // Test input is "0"
                // Assign 'A' to room type variable
            // Test input is "1"
                // Assign 'K' to room type variable
            // Test input is "2"
                // Assign 'W' to room type variable
            // Otherwise (input is something else)
                // Write "Invalid option."
                // Return to calling method
                // return;
                if (roomType == "0")
                {
                    roomType = "A";
                }
                else if (roomType == "1")
                {
                    roomType = "K";
                }
                else if (roomType == "2")
                {
                    roomType = "W";
                }
                else
                {
                    Console.WriteLine("Invalid option.");
                
                    return;
                }
                

            // Create variable that holds list of 'found' appliances
            List<Appliance> foundAppliances = Appliances;
            
            // Loop through Appliances
                // Test current appliance is Microwave
                    // Down cast Appliance to Microwave
            foreach (var appliance in foundAppliances)
            {
                if (appliance is Microwave)
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
                        
            }

                    // Test room type equals 'A' or microwave room type
                        // Add current appliance in list to found list

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
        public override void DisplayDishwashers()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options: ");
            // Write "0 - Any"
            Console.WriteLine("0 - Any");
            // Write "1 - Quietest"
            Console.WriteLine("1 - Quietest");
            // Write "2 - Quieter"
            Console.WriteLine("2 - Quieter");
            // Write "3 - Quiet"
            Console.WriteLine("3 - Quiet");
            // Write "4 - Moderate"
            Console.WriteLine("4 - Moderate");
        
            // Write "Enter sound rating:"
            Console.WriteLine("Enter sound rating: ");
        
            // Get user input as string and assign to variable
            string soundRating = Console.ReadLine();
        
            // Create variable that holds sound rating
            string rating;
        
            // Test input is "0"
            if (soundRating == "0")
            {
                // Assign "Any" to sound rating variable
                rating = "Any";
            }
            // Test input is "1"
            else if (soundRating == "1")
            {
                // Assign "Qt" to sound rating variable
                rating = "Qt";
            }
            // Test input is "2"
            else if (soundRating == "2")
            {
                // Assign "Qr" to sound rating variable
                rating = "Qr";
            }
            // Test input is "3"
            else if (soundRating == "3")
            {
                // Assign "Qu" to sound rating variable
                rating = "Qu";
            }
            // Test input is "4"
            else if (soundRating == "4")
            {
                // Assign "M" to sound rating variable
                rating = "M";
        
            }
            else
            {
                Console.WriteLine("Invaild option.");
                return;
            }
            // Create variable that holds list of found appliances
            List<Appliance> found = Appliances;
            int i = 0;
            // Loop through Appliances
            foreach (Appliance appliance in Appliances)
            {
                // Test if current appliance is dishwasher
                if (appliance is Dishwasher)
                {
                    // Down cast current Appliance to Dishwasher
                    Dishwasher dishwasher = (Dishwasher)appliance;
        
                    // Test sound rating is "Any" or equals soundrating for current dishwasher
                    if (soundRating == "Any" || dishwasher.SoundRating == rating)
                    {
                        // Add current appliance in list to found list
                        found.Add(dishwasher);
                    }
                    i++;
                }
            }
            // Display found appliances (up to max. number inputted)
            Console.WriteLine($"Found {i} appliances: ");
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(found, 0);
        }
        public override void RandomList()
        {
            // Write "Appliance Types"

            // Write "0 - Any"
            // Write "1 – Refrigerators"
            // Write "2 – Vacuums"
            // Write "3 – Microwaves"
            // Write "4 – Dishwashers"

            // Write "Enter type of appliance:"

            // Get user input as string and assign to appliance type variable

            // Write "Enter number of appliances: "

            // Get user input as string and assign to variable

            // Convert user input from string to int

            // Create variable to hold list of found appliances

            // Loop through appliances
                // Test inputted appliance type is "0"
                    // Add current appliance in list to found list
                // Test inputted appliance type is "1"
                    // Test current appliance type is Refrigerator
                        // Add current appliance in list to found list
                // Test inputted appliance type is "2"
                    // Test current appliance type is Vacuum
                        // Add current appliance in list to found list
                // Test inputted appliance type is "3"
                    // Test current appliance type is Microwave
                        // Add current appliance in list to found list
                // Test inputted appliance type is "4"
                    // Test current appliance type is Dishwasher
                        // Add current appliance in list to found list

            // Randomize list of found appliances
            // found.Sort(new RandomComparer());

            // Display found appliances (up to max. number inputted)
            // DisplayAppliancesFromList(found, num);
        }
    }
}
