﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFortnite
{
    class Program
    {
        static void Main(string[] args)
        {
            FNPlayer player1 = new FNPlayer();
            FNPlayer player2 = new FNPlayer("MachineGun", 100, 100);

            Console.WriteLine("Shield Before: " + player2.GetShield());
            Console.WriteLine("HP Before: " + player2.GetShield());

            player1.Attack(player2);

            Console.WriteLine("P1 PICKAXED P2");

            Console.WriteLine("Shield after: " + player2.GetShield());
            Console.WriteLine("HP after: " + player2.GetShield());


            Console.WriteLine("P1 Shield after: " + player1.GetShield());
            player1.SetShield(50);
            Console.WriteLine("P2 Shield after: " + player1.GetShield());
        }
    }
}

