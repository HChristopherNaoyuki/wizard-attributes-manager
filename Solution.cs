using System;

namespace wizard_attributes_manager
{
    // Solution class handles all the logic related to wizard attributes
    class Solution
    {
        // Constructor
        public Solution()
        {
            
        }

        // Method to display the wizard's information
        public void DisplayWizardInfo(int wizardNumber, string wizardName, string wizardHouse, string wizardWand, int wizardAge, double wizardMagicPower)
        {
            try
            {
                // Creating the Wizard object with provided details
                Wizard wizard = new Wizard(wizardName, wizardHouse, wizardWand, wizardAge, wizardMagicPower);

                // Displaying wizard information in the specified format
                Console.WriteLine($"Wizard {wizardNumber}");
                Console.WriteLine("===================================================");

                // Displaying wizard's attributes
                Console.WriteLine($"Name: {wizard[0]}");
                Console.WriteLine($"House: {wizard[1]}");
                Console.WriteLine($"Wand: {wizard[2]}");
                Console.WriteLine($"Age: {wizard[3]}");
                Console.WriteLine($"Magic Power: {wizard[4]}");

                // Ending the section with line separator
                Console.WriteLine("===================================================\n");
            }
            catch (Exception ex)
            {
                // Handle any issues with displaying wizard information
                Console.WriteLine($"Error displaying wizard info for {wizardName}: {ex.Message}");
            }
        }
    }
}
