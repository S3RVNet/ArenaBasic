using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena_Basic
{
    public enum PlayerName
    {
        God,
        None,
    }

    class PlayerBaseModifiers : CombatEngine
    {
       // Sets Default Player Base Modifiers
        public double Health = 50;
        public float Strength = 1f;
        public float HealingSpeed = 1f;
        public int Armour = 1;
        public String Player;


        // Case Table that sets modifiers of Player Types
        public void PlayerBuffs()
        {
            PlayerName PlayerName = (PlayerName) (1);
            switch (PlayerName)
            {

                case PlayerName.God:
                    Name = "God";
                    Health = Health * 999f;
                    Strength = Strength * 999f;
                    Armour = Armour * 999;

                    break;
                case PlayerName.None:
                    Player = "Null";
                    Health = 1;
                    Strength = 0;
                    Armour = 0;
                    break;
                default:
                   Console.WriteLine("Default Player Modifiers Active");
                    break;


               
            }






        }
    }
}

