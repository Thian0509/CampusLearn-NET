using System;
using System.Collections.Generic;
using CampusLearn.Domain.Account;
using CampusLearn.Domain.TopicsNS;
namespace CampusLearn.Infrastructure.Account;


public class Tutor : User, IAccount
{
    public List<string> AssignedModules { get; set; } = new();
    public List<Topic> TutorTopics { get; set; } = new();
    public List<Resource> UploadedResources { get; set; } = new();

    public Tutor(string name, string subject)
    {
        Name = name;
        AssignedModules.Add(subject);
    }

    public string GetDetails()
    {
        return $"Tutor: {Name}, Subject: {AssignedModules[0]}";
    }
    public void Register()
    {
        Console.WriteLine($"User {Name} has registered.");
    }

    public void LogIn()
    {
        Console.WriteLine($"User {Name} has logged in.");
    }

    public void LogOut()
    {
        Console.WriteLine($"User {Name} has logged out.");
    }

    public void UpdateProfile(string name)
    {
        Name = name;
    }
}

