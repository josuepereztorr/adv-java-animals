using System;
using advancejavaanimals.Abstract;
using advancejavaanimals.Interfaces;

namespace advancejavaanimals.Models
{
	public class Teacher : Person, ITalkable
	{
		private int _age; 

		public Teacher(int age, string name) : base(name)
		{
			this._age = age;
		}

		public int Age
		{
			get => _age;
			set => _age = value;
		}

        public string Talk()
        {
			return "Don't forget to do the assiged reading!";
        }
    }
}

