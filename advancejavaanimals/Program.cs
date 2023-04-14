using System.Collections;
using advancejavaanimals.Interfaces;
using advancejavaanimals.Models;
using advancejavaanimals.Services;

string path = "animals.txt";

FileOutputService outputFileService = new FileOutputService(path);
FileInputService inputFileService = new FileInputService(path);

List<ITalkable> zoo = new List<ITalkable>();

// Lines to Replace Begin Here
zoo.Add(new Dog(true, "Bean"));
zoo.Add(new Cat(9, "Charlie"));
zoo.Add(new Teacher(44, "Stacy Read"));
// End Lines to Replace

zoo.ForEach((ITalkable thing) => PrintOut(thing));

outputFileService.FileClose();
inputFileService.FileRead();
inputFileService.FileClose();

FileInputService inputData = new FileInputService(path);
string? line;

 while ((line = inputData.FileReadLine()) != null)
{
    Console.WriteLine(line);
}

void PrintOut(ITalkable p)
{
    Console.WriteLine($"{p.GetName()} says={p.Talk()}");
    outputFileService.FileWrite($"{p.GetName()} | {p.Talk()}");
}