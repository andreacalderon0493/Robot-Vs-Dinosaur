using System;
namespace Robot_VS_Dinosaur
{
	public class Robot
    {
        // member variables
        public string name;
        public int health;
        public Weapon gunWeapon = new Weapon("Laser Weapon", 15);

        public Robot(string roboName, int health)
		{
            this.name = roboName;
            this.health = health;
        }
        public void takeDamage(int damageTaken)
        {
            this.health -= damageTaken;
        }

        

    }

}

