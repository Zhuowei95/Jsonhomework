using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<User> users = new List<User>();

        users.Add(new Admin
        {
            Name = "Admin Alice",
            Age = 35,
            City = "Vilnius",
            AccessLevel = "Full"
        });

        users.Add(new RegularUser
        {
            Name = "User Bob",
            Age = 24,
            City = "Siauliai",
            MembershipType = "Gold"
        });

        Console.WriteLine("Task 4: Inheritance with specialized user types");
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