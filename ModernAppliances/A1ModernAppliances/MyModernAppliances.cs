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

                else if (foundAppliance.IsAvailable)
                {
                    // Checkout found appliance
                    foundAppliance.Checkout();

                    // Write "Appliance has been checked out."
                    Console.WriteLine($"Appliance {itemNumber} has been checked out.");
                }
                else
                {
                    // Write "The appliance is not available to be checked out."
                    Console.WriteLine("The appliance is not available to be checked out.");
                }
        }
        public override void Find()
        {
            // Write "Enter brand to search for:"
            Console.WriteLine("Enter brand to search for: ");
        
            // Create string variable to hold entered brand
            // Get user input as string and assign to variable.
            string userInput = Console.ReadLine();
        
            // Create list to hold found Appliance objects
            List<Appliance> found = new List<Appliance>();
        
            // Iterate through loaded appliances
            foreach (Appliance appliance in found)
            {
                // Test current appliance brand matches what user entered
                if (userInput == appliance.Brand)
                {
                    // Add current appliance in list to found list
                    found.Add(appliance);
                }
            }
            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(found, 0);
        }
        public override void DisplayRefrigerators()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");
        
            // Write "0 - Any"
            Console.WriteLine("0 - Any");
        
            // Write "2 - Double doors"
            Console.WriteLine("2 - Double doors");
        
            // Write "3 - Three doors"
            Console.WriteLine("3 - Three doors");
        
            // Write "4 - Four doors"
            Console.WriteLine("4 - Four doors");
        
            // Write "Enter number of doors: "
            Console.WriteLine("Enter number of doors: ");
        
            // Create variable to hold entered number of doors
            int numDoors;
        
            // Get user input as string and assign to variable
            string? userinput = Console.ReadLine();
        
            // Create list to hold found Appliance objects
            List<Appliance> found = new List<Appliance>();
        
            // Convert user input from string to int and store as number of doors variable.
            if (!int.TryParse(userinput, out numDoors))
            {
                Console.WriteLine("Please enter a valid input.");
                return;
            }
        
            // Iterate/loop through Appliances
            foreach (Appliance appliance in found)
            {
                // Test that current appliance is a refrigerator
                if (appliance is Refrigerator)
                {
                    // Down cast Appliance to Refrigerator
                    Refrigerator refrigerator = (Refrigerator)appliance;
        
                    // Test user entered 0 or refrigerator doors equals what user entered.
                    if (numDoors == 0 || refrigerator.Doors == numDoors)
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
        
             // Get user input as string and assign to variable
             string? userInput = Console.ReadLine();
        
             // Create grade variable to hold grade to find (Any, Residential, or Commercial)
             string? grade;
        
             // Test input is "0"
             if (userInput == "0")
             {
                 // Assign "Any" to grade
                 grade = "Any";
             }
             // Test input is "1"
             else if (userInput == "1")
             {
                 // Assign "Residential" to grade
                 grade = "Residential";
             }
             // Test input is "2"
             else if (userInput == "2")
             {
                 // Assign "Commercial" to grade
                 grade = "Commercial";
             }
             // Otherwise (input is something else)
             else
             {
                 // Write "Invalid option."
                 Console.WriteLine("Invalid option.");
                 // Return to calling method
                 return;
             }
        
             // Write "Possible options:"
             Console.WriteLine("Possible options:");
        
             // Write "0 - Any"
             Console.WriteLine("0 - Any");
        
             // Write "1 - 18 Volt"
             Console.WriteLine("1 - 18 Volt");
        
             // Write "2 - 24 Volt"
             Console.WriteLine("2 - 24 Volt");
        
             // Write "Enter voltage:"
             Console.WriteLine("Enter voltage:");
        
             // Get user input as string
             string? userInput1 = Console.ReadLine();
        
             // Create variable to hold voltage
             int voltage;
        
             // Test input is "0"
             if (userInput1 == "0")
             {
                 // Assign 0 to voltage
                 voltage = 0;
             }
             // Test input is "1"
             else if (userInput1 == "1")
             {
                 // Assign 18 to voltage
                 voltage = 18;
             }
             // Test input is "2"
             else if (userInput1 == "2")
             {
                 // Assign 24 to voltage
                 voltage = 20;
             }
             // Otherwise
             else
             {
                 // Write "Invalid option."
                 Console.WriteLine("Invalid Option");
                 // Return to calling method
                 return;
             }
             
             // Create found variable to hold list of found appliances
             List<Appliance> found = new List<Appliance>();
        
             // Loop through Appliances
             foreach (Appliance appliance in Appliances) 
             {
                 // Check if current appliance is vacuum
                 if (appliance is Vacuum vacuum)
                 {
                     // Down cast current Appliance to Vacuum object
                     Vacuum vaccum = (Vacuum)appliance;
        
                     // Test grade is "Any" or grade is equal to current vacuum grade and voltage is 0 or voltage is equal to current vacuum voltage
                     if ((voltage == 0 || voltage == vacuum.BatteryVoltage) && (grade == "Any" || grade == vacuum.Grade))
                     {
                         // Add current appliance in list to found list
                         found.Add(vacuum);
                     }
                 }
             }
             // Display found appliances
             DisplayAppliancesFromList(found, 0);
        }
        public override void DisplayMicrowaves()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options: ");
        
            // Write "0 - Any"
            Console.WriteLine("0 - Any");
        
            // Write "1 - Kitchen"
            Console.WriteLine("1 - Kitchen");
        
            // Write "2 - Work site"
            Console.WriteLine("2 - Work site");
        
            // Write "Enter room type:"
            Console.WriteLine("Enter room type: ");
        
            // Get user input as string and assign to variable
            string userInput = Console.ReadLine();
        
            // Create character variable that holds room type
            char? roomType = null;
        
            // Test input is "0"
            if (userInput == "0")
            {
                // Assign 'A' to room type variable
                roomType = 'A';
            }
            // Test input is "1"
            else if (userInput == "1")
            {
                // Assign 'K' to room type variable
                roomType = 'K';
        
            }
            // Test input is "2"
            else if(userInput == "2")
            {
                // Assign 'W' to room type variable
                roomType = 'W';
        
            }
            // Otherwise (input is something else)
            else
            {
                // Write "Invalid option."
                Console.WriteLine("Invalid option.");
                // Return to calling method
                // return;
                return;
            }
            // Create variable that holds list of 'found' appliances
            List<Appliance> found = Appliances;
        
            // Loop through Appliances
            foreach (Appliance appliance in found)
            {
                // Test current appliance is Microwave
                if (appliance is Microwave)
                {
                    // Down cast Appliance to Microwave
                    Microwave microwave = (Microwave)appliance;
        
                    // Test room type equals 'A' or microwave room type
                    if (roomType == 'A' | roomType == microwave.RoomType)
                    {
                        // Add current appliance in list to found list
                        found.Add(appliance);
                    }
                }
            }
            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(found, 0);
        }
        /// <summary>
        /// Displays dishwashers
        /// </summary>
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
            Console.WriteLine("Appliance Types");

            // Write "0 - Any"
            Console.WriteLine("0 - Any");

            // Write "1 – Refrigerators"
            Console.WriteLine("1 - Refrigerators");

            // Write "2 – Vacuums"
            Console.WriteLine("2 - Vacuums");

            // Write "3 – Microwaves"
            Console.WriteLine("3 - Microwaves");

            // Write "4 – Dishwashers"
            Console.WriteLine("4 - Dishwashers");

            // Write "Enter type of appliance:"
            Console.WriteLine("Enter type of appliance");

            // Get user input as string and assign to appliance type variable
            string applianceType = Console.ReadLine();

            // Convert user input from string to int
            if (!int.TryParse(applianceType, out int num))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            // Create variable to hold list of found appliances
            List<Appliance> found = Appliances;

            // Loop through appliances
            foreach (var appliance in Appliances)
            {
                switch (applianceType)
                {
                    case "0":
                        found.Add(appliance);
                        break;
                    case "1":
                        if (appliance is Refrigerator)
                            found.Add(appliance);
                        break;
                    case "2":
                        if (appliance is Vacuum)
                            found.Add(appliance);
                        break;
                    case "3":
                        if (appliance is Microwave)
                            found.Add(appliance);
                        break;
                    case "4":
                        if (appliance is Dishwasher)
                            found.Add(appliance);
                        break;
                }
            }

            // Randomize list of found appliances
            Random rnd = new Random();
            found = found.OrderBy(x => rnd.Next()).ToList();

            // Display found appliances (up to max. number inputted)
            DisplayAppliancesFromList(found, num);
        }
    }
}
