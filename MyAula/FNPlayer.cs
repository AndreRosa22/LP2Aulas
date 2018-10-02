using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFortnite
{
    class FNPlayer
    {
        string equipedWeapon;
        double hitPoints;
        double shield;

        void Attack(FNPlayer enemy)
        {
            enemy.TakeDamage(10);
        }

        void TakeDamage(double damage)
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
                    Die();
                }
            }

        }

    }
}
