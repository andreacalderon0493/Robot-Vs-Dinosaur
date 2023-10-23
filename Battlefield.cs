using System;
namespace Robot_VS_Dinosaur
{
	public class Battlefield
	{
        //member variables
        //constructor 

        Robot silverRobot = new Robot("Loco Robo", 100);
        Dinosaur rexTheDino = new Dinosaur("Rex", 100);


        public void Attacks()
        {
            int robotDamage = silverRobot.gunWeapon.attackPower;
            int dinosaurDamage = rexTheDino.attackPower;
            int dinosaurHealth = rexTheDino.health;
            int robotHealth = silverRobot.health;
            

            while (silverRobot.health >= 0 && rexTheDino.health >= 0)
            {
                rexTheDino.takeDamage(robotDamage);
                Console.WriteLine($"{silverRobot.name} attacks with {silverRobot.gunWeapon.type} causing {robotDamage} damage to {rexTheDino.name} this round and is now left with {rexTheDino.health} health.");

                if (rexTheDino.health > 0)
                {
                    silverRobot.takeDamage(dinosaurDamage);
                    Console.WriteLine($"{rexTheDino.name} attacks {silverRobot.name} with {dinosaurDamage} damage and is now left with {silverRobot.health} health");
                    Console.WriteLine(" ");
                }

                if (dinosaurHealth <= 0 && robotHealth <= 0)
                {
                    Console.WriteLine($"{rexTheDino.name} has died");
                }



            }

           
        }
        public void DisplayWelcome()
        { 
            Console.WriteLine("Welcome to the gates of inferno!!");
        }

        public void DisplayWinner()
        {
            Console.WriteLine($"The winner is {silverRobot.name} ");
        }
        public void Rungame()
        {
            DisplayWelcome();
            Console.WriteLine(" ");
            Attacks();
            
            DisplayWinner();

        }
        

    }


}

