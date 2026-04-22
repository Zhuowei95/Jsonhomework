using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string inputFile = "users.json";
        string outputFile = "users_updated.json";

        if (!File.Exists(inputFile))
        {
            Console.WriteLine("File not found: " + inputFile);
            return;
        }

        string jsonData = File.ReadAllText(inputFile);
        User? originalUser = JsonConvert.DeserializeObject<User>(jsonData);

        if (originalUser == null)
        {
            Console.WriteLine("Failed to read original user.");
            return;
        }

        List<User> users = new List<User>();
        users.Add(originalUser);

        users.Add(new User
        {
            Name = "Alice Brown",
            Age = 25,
            City = "Vilnius"
        });

        users.Add(new User
        {
            Name = "Michael Green",
            Age = 28,
            City = "Kaunas"
        });

        string updatedJson = JsonConvert.SerializeObject(users, Formatting.Indented);
        File.WriteAllText(outputFile, updatedJson);

        Console.WriteLine("Task 2: Added new entries to JSON object");
        Console.WriteLine("Updated data saved to: " + outputFile);
        Console.WriteLine(updatedJson);
    }
}