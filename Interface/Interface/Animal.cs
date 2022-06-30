using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
   public class Animal
    {
        public string Name { get; set; }
        public virtual void Sound()
        {
            Console.WriteLine("Sound");
        }
    }
}
