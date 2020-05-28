using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learningC
{
    public class Profile : Program
    {

        public static void CallMe()
        {

            Profile sam = new Profile("Sam Drakilla", 30, "New York", "USA", "he/him");
            sam.SetHobbies(new string[] {
            "listening to audiobooks and podcasts",
            "playing rec sports like bowling and kickball",
            "writing a speculative fiction novel",
            "reading advice columns" });
            Console.WriteLine(sam.ViewProfile());
        }


        private string name;
        private int age;
        private string city;
        private string country;
        private string pronouns;
        private string[] hobbies;
        public Profile(
            string name, 
            int age, 
            string city, 
            string country,
            string pronouns = "they/them"
            )
        {
            this.name = name;
            this.age = age;
            this.city = city;
            this.country = country;
            this.pronouns = pronouns;
            this.hobbies = new string[0];
            
        }

        public string ViewProfile()
        {
            
            string userInfo;
            userInfo = $"Name: {name}, \nAge: {age}, \nCity: {city}, \nCountry: {country}, \nPronouns: {pronouns}";

            userInfo += "\nHobbies:\n";
            foreach (string hobby in hobbies)
            {
                userInfo += $"- {hobby}\n";
            }
            return userInfo;
        }

        public void SetHobbies(string[] hobbies)
        {
            this.hobbies = hobbies;
        }

    }
}
