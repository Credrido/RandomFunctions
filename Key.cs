using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Key
    {
        public event Action<string> KeyPress;

        public string Name { get; set; }

        public Key(string name)
        {
            Name = name;
        }

        public void Press()
        {
            KeyPress?.Invoke(Name);
        }
    }
    public class Computer
    {
        public void ReactToPressedKey(string name)
        {
            Console.WriteLine($" Это не та клавиша");

            Console.WriteLine();
        }
    }
}
