using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        public class Pet
        {
            public string name;
            public string type;
            public string owner;
            public double weight;
            static void Main(string[] args)
            {
                Pet pet1 = new Pet("dog", "Shadow", "Jose", 42.6);

                Console.WriteLine("Name: " + pet1.name);
                Console.WriteLine("Weight: " + pet1.weight);
                Console.WriteLine(pet1.getTag());

                Console.WriteLine("\n");

                Dog dog1 = new Dog("Dog", "Daisy", "Kent", 23.4);


                Console.WriteLine("Name: " + dog1.name);
                Console.WriteLine("Weight: " + dog1.weight);
                Console.WriteLine(dog1.getTag());
                Console.WriteLine(dog1.bark(4));

                Cat cat1 = new Cat("Cat", "Simba", "Maria", 5.2);

                Console.WriteLine("Name: " + cat1.name);
                Console.WriteLine("Weight: " + cat1.weight);
                Console.WriteLine(cat1.getTag());
                Console.WriteLine(cat1.meow(3));
                Console.ReadLine();
            }

            public Pet(string pettype, string petname, string ownername, double petweight)
            {
                name = petname;
                type = pettype;
                owner = ownername;
                weight = petweight;
            }
            public string getTag()
            {
                string tag = ("If lost, call " + owner);
                return tag;
            }
            public class Dog : Pet
            {
                public Dog(string pettype, string petname, string ownername, double petweight) : base(pettype, petname, ownername, petweight)
                {
                    pettype = "dog";
                    name = petname;
                    owner = ownername;
                    weight = petweight;
                }
                public string bark(int count)
                {
                    int i;
                    string woof = "";
                    for(i = 0; i < count; i++)
                    {
                        woof += "bark!";
                    }
                    woof = woof + "\n";
                    return woof;
                }
            }
            public class Cat : Pet
            {
                public Cat(string pettype, string petname, string ownername, double petweight) : base(pettype, petname, ownername, petweight)
                {
                    pettype = "Cat";
                    name = petname;
                    owner = ownername;
                    weight = petweight;
                }
                public string meow(int count)
                {
                    int i;
                    string woof = "";
                    for (i = 0; i < count; i++)
                    {
                        woof += "meow!";
                    }
                    woof = woof + "\n";
                    return woof;
                }
            }
        }
    }
}
