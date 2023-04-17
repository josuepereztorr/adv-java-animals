using System;
using advancejavaanimals.Abstract;
using advancejavaanimals.Interfaces;
using advancejavaanimals.Models;

namespace advancejavaanimals
{
    public class AnimalBuilder
    {
        private List<ITalkable> _zooList = new List<ITalkable>();

        private List<string> animals = new List<string>() { "Dog", "Cat" };

        public AnimalBuilder(List<ITalkable> zooList)
        {
            this._zooList = zooList;
        }

        public void CreateAnimalFromPrompt()
        {

            Console.WriteLine("What time time of animal would you like to create? (type the option below and press enter)");

            for (var i = 0; i < animals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {animals[i]}");
            }

            Console.WriteLine();

            int choice = Int32.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("What is your pet's name?");

            string petName = Console.ReadLine();

            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    Dog dog = new Dog(petName);
                    Console.WriteLine("Is your dog friendly? (type the option below and press enter)");
                    Console.WriteLine("true\nfalse");
                    Console.WriteLine();
                    bool isFriendly = Boolean.Parse(Console.ReadLine());
                    if (!isFriendly)
                    {
                        dog.SetFriendly(false);
                    }
                    dog.SetFriendly(true);
                    _zooList.Add(dog);
                    break;
                case 2:
                    Cat cat = new Cat(petName);
                    Console.WriteLine("How many mice has your cat killed? (enter a number)");
                    int mousesKilled = Int32.Parse(Console.ReadLine());
                    Console.WriteLine();
                    cat.SetMousesKilled(mousesKilled);
                    break;
            }

            Console.WriteLine();
        }

    }
}

