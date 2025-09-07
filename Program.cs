using System;

namespace wizard_attributes_manager
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Creating instance of Solution to manage the logic
                Solution solution = new Solution();

                // Calling method to display wizard information
                solution.DisplayWizardInfo(1, "Harry Potter", "Gryffindor", "Holly, Phoenix Feather, 11 inches", 17, 100);
                solution.DisplayWizardInfo(2, "Ron Weasley", "Gryffindor", "Willow, Unicorn Hair, 14 inches", 16, 90);
                solution.DisplayWizardInfo(3, "Hermione Granger", "Gryffindor", "Vine, Dragon Heartstring, 10 3/4 inches", 17, 110);
                solution.DisplayWizardInfo(4, "Albus Dumbledore", "Gryffindor", "Elder, Thestral Hair, 15 inches", 115, 150);
            }
            catch (Exception ex)
            {
                // Catching and displaying any unhandled exceptions
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
