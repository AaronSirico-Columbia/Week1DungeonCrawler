using CaveOfEnviorments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCompLibrary
{
    public class Enemy
    {
        Player Player = new Player();

        public List<Player> Enemies;

        public int PowerLevel {  get; set; }

        public Enemy()
        {
            Enemies = new List<Player>();
            this.PowerLevel = 10;
        }

        public void SpawnEnemy(Player x)
        {
            Enemies.Add(x);
            x.OnLevelUp += E_OnLevelUp;

        }

        public void EliminateEnemy(Player x)
        {
            Enemies.Remove(x);
            x.OnLevelUp -= E_OnLevelUp;

        }


        private void E_OnLevelUp(object sender, EventArgs e)
        {
            Player x = (Player)sender;
            this.PowerLevel -= x.XP;
        }

        public void LevelAllEnemies()
        {
            foreach (Player enemy in Enemies)
            {

                enemy.LevelUp();

            }
        }
    }
}
