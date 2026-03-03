namespace ObjectOrientationAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog();
            Animal cat = new Cat();


            dog.MakeSound (); // Output: Woof!
            cat.MakeSound (); // Output: Meow!
        }
    }


    public abstract class Animal : IAnimal
    {
        public string? Name { get; set; }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal Sound!");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
    }

    public interface IAnimal
    {
        string? Name { get; set; }
        void MakeSound();
    }


    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }


}

