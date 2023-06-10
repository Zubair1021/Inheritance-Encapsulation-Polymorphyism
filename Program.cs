using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8T3
{
    class Program
    {
        public class Animal
        {
            protected string name;
            public Animal(string name)
            {
                this.name = name;
            }
            public virtual string tostring()
            {
                return "Animal[ " + name +"]";
            }
            public virtual void greets()
            {
                Console.WriteLine("The Animal is Here!---");
            }
        }
        public class mammal : Animal
        {
            public mammal(string name) : base (name)
            {

            }
            public override string tostring()
            {
                return "Mammal [ Animal: " + name + "]]";
            }
            public override void greets()
            {
                Console.WriteLine("The Animal is Here!---");
            }
        }
        public class cat:mammal 
        {
            public cat(string name) : base(name)
            {

            }
            public override string tostring()
            {
                return "Cat [ Mammal [ Animal: " + name + "]]]";
            }
            public override void greets()
            {
                Console.WriteLine("Meow");
            }

        }
        public class dog : mammal
        {
            public dog(string name) : base(name)
            {

            }
            public override string tostring()
            {
                return "Dog[ Cat [ Mammal [ Animal: " + name + "]]]]";
            }
            public override void greets()
            {
                Console.WriteLine("Woof");
            }


        }
        static void Main(string[] args)
        {
            List<Animal> list = new List<Animal>();
            cat c1 = new cat("Kitty"); list.Add(c1);
            cat c2 = new cat("Litty"); list.Add(c2);
            dog d1 = new dog("Tommy"); list.Add(d1);
            dog d2 = new dog("Dogi"); list.Add(d2);

            foreach(Animal a in list)
            {
               
                
            }
            Console.ReadKey();
        }
    }
}
