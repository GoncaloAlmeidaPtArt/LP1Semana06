

namespace MyGame
{
    public class Enemy
    {
        private string name = "no name";
        private float vida = 50;
        private float shield = 0;
        static int numeropowers;

        public Enemy(string name)
        {
            if (name.Length > 8)
            {
                this.name = name.Substring(0,8);
            }
            else
            {
                this.name = name;
            }

        }

        static Enemy()
        {
            numeropowers = 0;
        }

        public int getStatic()
        {
            return numeropowers;
        }
        public string GetName()
        {
            return name;   
        }

        public float GetVida()
        {
            return vida;   
        }

        public void SetName(string nome2)
        {
            name = nome2.Substring(0, 8);
        }

        public void PickupPowerUp(PowerUp poua, float floto)
        {
            if (vida < 100)
            {
                if (poua == PowerUp.Health)
                {
                    vida += floto;
                }
            }
            

            if (shield < 100)
            {
                if (poua == PowerUp.Shield)
                {
                    shield += floto;
                }
            }

            numeropowers += 1;
            
        }
    }
}