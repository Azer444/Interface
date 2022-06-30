using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Sound();

            Bird bird = new Bird();
            bird.Sound();
        }
    }
}
