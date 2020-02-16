﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DojoTemplateConsoleApp
{
    public class Player
    {
        public string Name { get; private set; }
        public int Balance { get; private set;  }
        public List<Land> Properties { get; set; }
        public Land Position { get; set; }
        public int ConsecutiveDoubles { get; set; }

        public Player(string name)
        {
            Balance = 1500;
            Name = name;
            Position = new Land("Go");
        }

        internal void Act()
        {
            if (Position.GetType() == typeof(Property))
            {
                Balance = ((Property)Position).Owned
                    ? Balance - 100
                    : Balance;
            }
        }

        internal void Pay(int amount)
        {
            this.Balance += amount;
        }
    }
}
