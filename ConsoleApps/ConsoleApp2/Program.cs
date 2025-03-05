// See https://aka.ms/new-console-template for more information

string content = File.ReadAllText("/app/shared/test.txt");
Console.WriteLine($"Read from shared volume: {content}. From ConsoleApp2!");