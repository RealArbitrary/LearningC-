using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learningC
{
    class EmptyWorkSpaceForTesting
    {
        //How to define a field and property with validation
        #region
        public string biome;
        public string Biome
        {
            get { return biome; }
            set
            {
                if (value == "Tropical") { biome = value; }
            }
        }
        #endregion

        #region
        public int Trees { get; set; }
        //Field
        public int age;
        //Public proper with private setter
        //Private setter can be used within current class
        public int Age
        {
            get { return age; }
            private set { age = value; }
        }

        //Take zero arguments
        //Increase the Trees property by 30 and the Age property by 1
        //Return the updated number of trees
        public int Grow()
        {
            Trees += 30;
            Age += 1;
            return Trees;
        }

        //Take zero arguments
        //Decrease the Trees property by 20 and increase the Age property by 1
        //Return the updated number of trees
        public int Burn()
        {
            Trees -= 1;
            Age += 1;
            return Trees;
        }
        #endregion
    }
}
