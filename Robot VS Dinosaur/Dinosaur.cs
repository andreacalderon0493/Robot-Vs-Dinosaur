using System;
namespace Robot_VS_Dinosaur
{
	public class Dinosaur
	{
        // member variables
        public string name;
        public int health;
		public int attackPower = 12;

        public Dinosaur(string firstName, int health)
		{
			this.name = firstName;
			this.health = health;
		
	    }

		public void takeDamage (int damageTaken)
		{
			this.health -= damageTaken; 
		}
	}


}

