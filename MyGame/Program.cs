using System;

namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var aleatorio = new Random();

            for(int x = 0; x < 5; x++)
            {
                Console.WriteLine(aleatorio.Next());
            }

            
        }
    }
}
