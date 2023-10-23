// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Xml.Linq;

namespace Robot_VS_Dinosaur
{

    internal class Program
    {

        static void Main(string[] args)
        {   //instatiating the battlefeild!!
            Battlefield battlefeild = new Battlefield();
            //Calling the RunGame() Method
            battlefeild.Rungame();

        }

    }

}