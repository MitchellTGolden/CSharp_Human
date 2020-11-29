using System;

namespace Human
{
    public class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;

        // add a public "getter" property to access health
        public int Health
        {
            get
            {
                return health;
            }
        }
        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        public Human(string val)
        {
            Name = val;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }
        // Add a constructor to assign custom values to all fields
        public Human(string val, int strn, int intel, int dex, int hp)
        {
            Name = val;
            Strength = strn;
            Intelligence = intel;
            Dexterity = dex;
            health = hp;
        }
        // Build Attack method
        public int Attack(Human target)
        {
            target.health -= (this.Strength * 5);
            return target.health;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Human mitchell = new Human("Mitchell",10,5,5,100);
            Human adrien  = new Human("Adrien");
            Console.WriteLine(adrien.Health);
            Console.WriteLine(mitchell.Attack(adrien));
            



            }

        }
    }

