﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFortnite
{
    class FNPlayer
    {
        private string equipedWeapon;
        private double hitPoints;
        private double shield;

        public static double MaxHitPoints { get; } = 100;

        // Construtor vazio
        public FNPlayer()
        {
            equipedWeapon = "pickaxe";
            hitPoints = 100;
            shield = 0;
        }

        // Construtor com parâmetros
        public FNPlayer(string equipedWeapon, double hitPoints, double shield)
        {
            this.equipedWeapon = equipedWeapon;
            this.hitPoints = hitPoints;
            this.shield = shield;
        }

        public double GetShield()
        {
            return shield;
        }

        public double SetShield(double shield)
        {
            if (shield >= 0)
            {
                this.shield = shield;

            }
            return shield;
        }
        public void Attack(FNPlayer enemy)
        {
            enemy.TakeDamage(10);
        }

        public void TakeDamage(double damage)
        {
            if (shield > 0)
            {
                shield -= damage;
                if (shield < 0)
                {
                    shield = 0;
                }
            }
            else
            {
                hitPoints -= damage;
                if (hitPoints <= 0)
                {
                    /* Die();*/
                }
            }

        }

    }
}
