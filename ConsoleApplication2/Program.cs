using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        public class Dog
        {
            public string name;
            public string color;

            //constructor
            public Dog(string namein, string colorin)
            {
                name = namein;
                color = colorin;
            }

            //method
            public void bark()
            {
                Console.WriteLine("bark!");
            }
        }

        //dragons are a type of dog and inherit from dog
        public class Dragon : Dog
        {
            public Dragon(string namein, string colorin) : base(namein, colorin) //basically just same constructor as parent
            {
                
            }
            public new void bark() //new overloads the previous bark method. Cna also use the word "override"
            {
                Console.WriteLine("<fire>");
            }
        }

        static void Main(string[] args)
        {

            Dog mydog = new Dog("Lucy", "orange");
            Dragon evildog = new Dragon("Snarl", "black");
            Dog naomidog = new Dog("Penny", "blackandwhite");
            

            Console.WriteLine("Dog name is: " + evildog.name);
            Console.WriteLine("Dog color is: " + evildog.color);
            Console.WriteLine("Speak.");
            evildog.bark();
            string myvar = Console.ReadLine();
        }
    }
}
