using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaveOfEnviorments
{
    public class Player
    {
        public string name = "MAGE";
        public string input { get; set; }

        public EventHandler OnLevelUp;

        public int XP { get; set; }

        protected int powerLevel;
        public int PowerLevel { get => powerLevel; set => powerLevel = value; }

        public Player()
        {
            this.OnLevelUp += OnLevelUp;
            this.XP = 5;
        }

        protected void onFeed(object sender, EventArgs e)
        {
            this.XP++;
        }

        public void LevelUp()
        {
            //Invoke onFeed Handler
            this.OnLevelUp.Invoke(this, EventArgs.Empty);
        }



    }
}
