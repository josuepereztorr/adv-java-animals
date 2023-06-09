﻿using System;
using advancejavaanimals.Abstract;
using advancejavaanimals.Interfaces;

namespace advancejavaanimals.Models
{
	public class Cat : Pet, ITalkable
	{
		private int _mousesKilled; 

		public Cat(int mousesKilled, string name) : base(name)
		{
			this._mousesKilled = mousesKilled;
		}

		public Cat(string name) : base(name) { }

		public int MousesKilled => _mousesKilled;

		public void SetMousesKilled(int mousesKilled)
		{
			_mousesKilled = mousesKilled;
		}

		public void AddMouse()
		{
			_mousesKilled++;
		}

        public string Talk()
        {
            return "Meow";
        }

        public override string ToString()
        {
            return $"Cat: name={name} mousesKilled={_mousesKilled}";
        }
    }
}

