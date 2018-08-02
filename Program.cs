using System;


namespace learning 
{
class Program 
{
    public static Main(string[] args)
    {
        string Name = null; // string is a class type, so it can be set as a nullable value type. String is a reference type.
        // int i = null // int is a value type, so the default value is in the form of a zero (0)
        int? i = null;
        Console.WriteLine($"hi {i} {Name}");
    }
}}