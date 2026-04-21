using Newtonsoft.Json;
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "users.json";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found: " + filePath);
            return;
        }

        string jsonData = File.ReadAllText(filePath);

User? user = JsonConvert.DeserializeObject<User>(jsonData);

if (user != null)
{
    Console.WriteLine("Task 1: Read JSON file");
    Console.WriteLine("Name: " + user.Name);
    Console.WriteLine("Age: " + user.Age);
    Console.WriteLine("City: " + user.City);
}
else
{
    Console.WriteLine("Failed to deserialize JSON data.");
}
    }
}