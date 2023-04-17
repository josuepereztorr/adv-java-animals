using System.Collections;
using advancejavaanimals;
using advancejavaanimals.Interfaces;
using advancejavaanimals.Models;
using advancejavaanimals.Services;

string path = "animals.txt";

FileOutputService outputFileService = new FileOutputService(path);
FileInputService inputFileService = new FileInputService(path);

List<ITalkable> zoo = new List<ITalkable>();

AnimalBuilder animalBuilder = new AnimalBuilder(zoo);

// Lines to Replace Begin Here
animalBuilder.CreateAnimalFromPrompt();
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