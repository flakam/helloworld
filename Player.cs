using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    abstract class Player
    {
        public string name { get; set; }//get the name 
        public Player(string Name)//constructor
        {
            this.name = Name;
        }
        public abstract string GetRPS();//abstract method( children have to fill out this method)
    }
}
