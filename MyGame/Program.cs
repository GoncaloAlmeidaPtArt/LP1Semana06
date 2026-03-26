using System;

namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int numeroinimigos = Convert.ToInt32(args[0]);

            Enemy[] inimigos = new Enemy[numeroinimigos];

            for(int x = 0; x < numeroinimigos; x++)
            {
                Console.Write($"Nome do inimigo {x + 1}: ");
                string newName = Console.ReadLine();
                inimigos[x] = new Enemy(newName);
                inimigos[x].PickupPowerUp(PowerUp.Health, 23);
            }
            


            foreach(Enemy y in inimigos)
            {
                Console.WriteLine($"{y.GetName()} {y.GetVida()} 0");
            }

            Console.WriteLine(inimigos[0].getStatic());

        }
    }
}
