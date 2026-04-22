using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "users_updated.json";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found: " + filePath);
            return;
        }

        string jsonData = File.ReadAllText(filePath);

        List<User>? users = JsonConvert.DeserializeObject<List<User>>(jsonData);

        if (users == null || users.Count == 0)
        {
            Console.WriteLine("No users found in JSON file.");
            return;
        }

        Console.WriteLine("Task 3: Deserialize all entries with LOOP");
        Console.WriteLine();

        foreach (User user in users)
        {
            Console.WriteLine("Name: " + user.Name);
            Console.WriteLine("Age: " + user.Age);
            Console.WriteLine("City: " + user.City);
            Console.WriteLine("----------------------");
        }
    }
}