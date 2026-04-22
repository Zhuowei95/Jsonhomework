using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "special_users.json";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found: " + filePath);
            return;
        }

        string jsonData = File.ReadAllText(filePath);

        JArray jsonArray = JArray.Parse(jsonData);
        List<User> users = new List<User>();

        foreach (JObject item in jsonArray)
        {
            string? userType = item["UserType"]?.ToString();

            if (userType == "Admin")
            {
                Admin? admin = item.ToObject<Admin>();
                if (admin != null)
                {
                    users.Add(admin);
                }
            }
            else if (userType == "RegularUser")
            {
                RegularUser? regularUser = item.ToObject<RegularUser>();
                if (regularUser != null)
                {
                    users.Add(regularUser);
                }
            }
        }

        Console.WriteLine("Task 5: Deserialize specialized user types from JSON");
        Console.WriteLine();

        foreach (User user in users)
        {
            if (user is Admin admin)
            {
                Console.WriteLine("Admin");
                Console.WriteLine("Name: " + admin.Name);
                Console.WriteLine("Age: " + admin.Age);
                Console.WriteLine("City: " + admin.City);
                Console.WriteLine("Access Level: " + admin.AccessLevel);
            }
            else if (user is RegularUser regularUser)
            {
                Console.WriteLine("Regular User");
                Console.WriteLine("Name: " + regularUser.Name);
                Console.WriteLine("Age: " + regularUser.Age);
                Console.WriteLine("City: " + regularUser.City);
                Console.WriteLine("Membership Type: " + regularUser.MembershipType);
            }

            Console.WriteLine("----------------------");
        }
    }
}