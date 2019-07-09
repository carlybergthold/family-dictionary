using System;
using System.Collections.Generic;

namespace family_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
        // Define a Dictionary that contains information about several members of your family.
        var myFamily = new Dictionary<string, Dictionary<string, string>>();
        myFamily.Add("dad", new Dictionary<string, string>(){
            {"name", "Ron"},
            {"age", "59"}
        });
        myFamily.Add("mom", new Dictionary<string, string>(){
            {"name", "Gwyn"},
            {"age", "58"}
        });
        myFamily.Add("oldest sister", new Dictionary<string, string>(){
            {"name", "Cara"},
            {"age", "34"}
        });
        myFamily.Add("sister", new Dictionary<string, string>(){
            {"name", "Cali"},
            {"age", "31"}
        });
        myFamily.Add("brother", new Dictionary<string, string>(){
            {"name", "Caleb"},
            {"age", "23"}
        });
        // Next, iterate over each item in myFamily and produce the following output. Remember that you can use square bracket notation to get to the value of a key, and that a dictionary has a Key and a Value property.
        foreach(KeyValuePair<string, Dictionary<string, string>> familyMember in myFamily)
        {
            string name = familyMember.Value["name"];
            string age = familyMember.Value["age"];
            Console.WriteLine($"{name} is my {familyMember.Key} and is {age} years old.");
        }
        // Krista is my sister and is 42 years old
        }
    }
}
