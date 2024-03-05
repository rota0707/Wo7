using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // animal
            Animal[] animals = new Animal[2];
            animals[0] = new Tiger();
            animals[1] = new Chicken();

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.MakeSound());
                if (animal is Chicken)
                {
                    Edible edibler = (Chicken)animal;
                    Console.WriteLine(edibler.HowToEat());
                }
            }


            // fruit
            Console.WriteLine();
            Console.WriteLine();
            Fruit[] fruits = new Fruit[2];
            fruits[0] = new Orange();
            fruits[1] = new Apple();
            foreach (Fruit fruit in fruits)
            {
                Console.WriteLine(fruit.HowToEat());
            }
            Console.ReadKey();
        }
    }
    // inter face
    interface Edible
    {
        string HowToEat();
    }
    // lop animal
    public abstract class Animal
    {
        public abstract string MakeSound();
    }
    // lop tiger
    public class Tiger : Animal
    {
        public override string MakeSound()
        {
            return "Tiger : Gừ Gừ";
        }
    }
    // lop chicken
    public class Chicken : Animal,Edible
    {
        public override string MakeSound()
        {
            return "Chicken : Chíp chíp";
        }
        public string HowToEat()
        {
            return "You can make grilled chicken";
        }
    }
    // lơp Fruit
    public abstract class Fruit : Edible
    {
        public abstract string HowToEat();
    }
    // liop Tao
    public class Apple : Fruit
    {
        public override string HowToEat()
        {
            return "Apple Cound be cut";
        }
    }
    // lơp cam
    public class Orange : Fruit
    {
        public override string HowToEat()
        {
            return "Orange Could be juiced";
        }
    }


}
