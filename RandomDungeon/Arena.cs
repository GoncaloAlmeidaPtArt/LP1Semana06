using System;
using System.Collections.Generic;

namespace RandomDungeon
{
    public class Arena
    {
        private List<Enemy> enemies;

        public Arena(List<Enemy> enemies)
        {
            this.enemies = enemies;
        }

        public List<Enemy> GetEnemies()
        {
            return enemies;
        }

        public void SetEnemies(List<Enemy> value)
        {
            enemies = value;
        }

        public void AddEnemy(Enemy enemy)
        {
            enemies.Add(enemy);
        }

        public void RemoveEnemy(Enemy enemy)
        {
            enemies.Remove(enemy);
        }

        // Método Para Mostrar Todos os Inimigos Atuais
        // Exemplo: "Arena: Troll, Skeleton, Ogre"
        public void ShowEnemies()
        {
            Console.Write("Arena: ");
            for(int x = 0; x < enemies.Count; x++)
            {
                Console.Write(enemies[x].GetName() + ", ");
            }
        }
        
        // Simula uma Batalha Entre Dois Inimigos
        public void Battle(Enemy attacker, Enemy defender)
        {
            // Subtrai o Ataque do Atacante à Vida do Defenso
            // Garante que a Vida Não Fique Negativa
            int vida = defender.GetHealth();
            int vidafinal = vida - attacker.GetAttack();
            if (vidafinal < 0) vidafinal = 0;
            defender.SetHealth(vidafinal);
            
            // Se a Vida do Defensor Chegar a 0, Remove-o da Arena
            if(vidafinal == 0)
            {
                RemoveEnemy(defender);
                
            }
        }
    }
}