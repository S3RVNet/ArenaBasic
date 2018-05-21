using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Arena_Basic
{
    //Lists all available enemies
    public enum CurrentEnemy
    {
        VoidKnight,
        Prince,
        Overlord,
        Brother,
        None
    }

    public class EnemybaseModifiers : CombatEngine
    {

        
        public string EnemyName;
        public double Enemyhealth = 100;
        public float EnemyStrength = 1f;
        public float EnemyHealingSpeed = 1f;
        public int EnemyArmour = 50;


        /// /////////////CUSTOM CONSTRUCTORS FOR NPCs

        //Sets the Data Config for a selected enemy
        public void EnemyMultiplier()
        {
            CurrentEnemy enemy = (CurrentEnemy) (5);

            switch (enemy)
            {
                case CurrentEnemy.VoidKnight:
                    EnemyName = "Void Knight";
                    Enemyhealth = Enemyhealth * 2.5f;
                    EnemyStrength = EnemyStrength * 3f;
                    EnemyArmour = EnemyArmour + 30;

                    break;
                case CurrentEnemy.Prince:
                    EnemyName = "Prince";
                    Enemyhealth = Enemyhealth * 1.5f;
                    EnemyStrength = EnemyStrength * 1.2f;
                    EnemyArmour = EnemyArmour + 10;
                    break;
                case CurrentEnemy.Overlord:
                    EnemyName = "Overlord";
                    Enemyhealth = Enemyhealth * 5.5f;
                    EnemyStrength = EnemyStrength * 3f;
                    EnemyArmour = EnemyArmour + 100;

                    break;
                case CurrentEnemy.Brother:
                    EnemyName = "Brother";
                    Enemyhealth = Enemyhealth * 0.8;
                    EnemyStrength = EnemyStrength * 0.6f;
                    EnemyArmour = EnemyArmour / 2;

                    break;

                default:
                    Console.WriteLine("The Current Enemy Multiplier in the combat engine returned a null value!");
                    break;




            }
        }

        public void EnemyStats()
        {
            FmCAS CAS = new FmCAS();

            


                Console.WriteLine("Enemy Name :  " + EnemyName);
                Console.WriteLine("Enemy Health : " + Enemyhealth.ToString());
                Console.WriteLine("Enemy Strength : " + EnemyStrength.ToString());
                Console.WriteLine("Enemy Armour : " + EnemyArmour.ToString());



            }
        }

     
    }


