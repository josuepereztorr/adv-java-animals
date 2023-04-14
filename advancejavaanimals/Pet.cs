using System;
using System.Xml.Linq;

namespace advancejavaanimals.Abstract
{
	public abstract class Pet
    {
        protected internal string name;

        public Pet(string name)
		{
			this.name = name;
		}
    
        public string GetName()
        {
            return name;
        }
    }
}

