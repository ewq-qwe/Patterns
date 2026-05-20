using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Console.OutputEncoding = System.Text.Encoding.UTF8;

namespace lab5
{

    public abstract class Pet { }
    public class Dog : Pet { }
    public class Cat : Pet { }

    public interface IPerson
    {
        Pet GetPet();

        void Play()
        {
            Console.WriteLine($"Граюся з {GetPet().GetType().Name}");
        }
    }

    public class DogPerson : IPerson
    {
        private readonly Pet _dog = new Dog();
        public Pet GetPet() => _dog;
    }

    public class CatLover : IPerson
    {
        private readonly Pet _cat = new Cat();
        public Pet GetPet() => _cat;
    }

    public class factory_method
    {
        public static void Call(IPerson person)
        {
            person.Play();
        }

        public static void Main()
        {
            Call(new DogPerson());
            Call(new CatLover());
        }
    }
}

