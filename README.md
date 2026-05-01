# Json Homework

## Project Description

This project is made in C# console application.  
It shows how to work with JSON data by using Newtonsoft.Json package.

In this project I did these tasks:

- create manual JSON file
- read JSON file
- add new entries to JSON object
- deserialize all entries with loop
- use inheritance with User class
- create special user types like Admin and RegularUser
- create new JSON file with user types data
- deserialize special user types data and print to console

## Technologies Used

- C#
- .NET Console Application
- Newtonsoft.Json

## Files in Project

- Program.cs
- User.cs
- Admin.cs
- RegularUser.cs
- users.json
- users_updated.json
- special_users.json

## Version History

### Task 1
Created manual JSON file and basic JSON reader.  
Program reads one user from JSON file and prints data to console.

### Task 2
Added new entries to JSON object in program.  
Program saves updated data into new file `users_updated.json`.

### Task 3
Deserialized all JSON entries into C# objects.  
Used loop to print all users to console.

### Task 4
Used inheritance to extend `User` class.  
Created `Admin` and `RegularUser` classes.

### Task 5
Created new JSON file with special user types data.  
Deserialized this file and printed all special users to console.

## How to Run

1. Open project in Visual Studio Code or Visual Studio.
2. Make sure Newtonsoft.Json package is installed.
3. Open terminal in project folder.
4. Run command:

```bash
dotnet run