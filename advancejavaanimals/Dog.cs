using System;
using advancejavaanimals.Abstract;
using advancejavaanimals.Interfaces;

namespace advancejavaanimals.Models
{
	public class Dog : Pet, ITalkable
	{
		private bool _friendly;

		public Dog(bool friendly, string name) : base(name)
		{
			this._friendly = friendly;
		}

        public Dog(string name) : base(name) { }

		public bool IsFriendly()
        {
            return _friendly;
        }

        public void SetFriendly(bool friendly)
        {
            this._friendly = friendly;
        }

        public string Talk()
        {
            return "Bark";
        }

        public override string ToString()
        {
            return $"Dog: name={name} friendly={_friendly}";
        }
    }
}

