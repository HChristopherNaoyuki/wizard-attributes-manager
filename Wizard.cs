using System;

namespace wizard_attributes_manager
{
    public class Wizard
    {
        // Instance variables for Wizard attributes using camelCase for C# compatibility
        private string wand;
        private string name;
        private string house;
        private int age;
        private double magicPower;

        // Constructor to initialize a Wizard object
        public Wizard(string wizardName, string wizardHouse, string wizardWand, int wizardAge, double wizardMagicPower)
        {
            this.name = wizardName;
            this.house = wizardHouse;
            this.wand = wizardWand;
            this.age = wizardAge;
            this.magicPower = wizardMagicPower;
        }

        // Indexer to get and set wizard attributes by index
        public object this[int index]
        {
            get
            {
                // Return the corresponding value based on the index
                switch (index)
                {
                    case 0: return this.name;
                    case 1: return this.house;
                    case 2: return this.wand;
                    case 3: return this.age;
                    case 4: return this.magicPower;
                    default: return null; // Return null if index is invalid
                }
            }
            set
            {
                // Set the corresponding attribute based on the index
                switch (index)
                {
                    case 0: this.name = (string)value; break;
                    case 1: this.house = (string)value; break;
                    case 2: this.wand = (string)value; break;
                    case 3: this.age = (int)value; break;
                    case 4: this.magicPower = (double)value; break;
                    default: throw new ArgumentOutOfRangeException("Invalid index for wizard attribute");
                }
            }
        }

        // Indexer to get and set wizard attributes by string name
        public object this[string attrName]
        {
            get
            {
                // Handling attribute retrieval by name, case-insensitive
                switch (attrName.ToLower())
                {
                    case "name": return this.name;
                    case "house": return this.house;
                    case "wand": return this.wand;
                    case "age": return this.age;
                    case "magicpower": return this.magicPower;
                    default: return null; // Return null if attribute name is invalid
                }
            }
            set
            {
                // Set the corresponding attribute based on the string name
                switch (attrName.ToLower())
                {
                    case "name": this.name = (string)value; break;
                    case "house": this.house = (string)value; break;
                    case "wand": this.wand = (string)value; break;
                    case "age": this.age = (int)value; break;
                    case "magicpower": this.magicPower = (double)value; break;
                    default: throw new ArgumentException("Invalid attribute name");
                }
            }
        }
    }
}
