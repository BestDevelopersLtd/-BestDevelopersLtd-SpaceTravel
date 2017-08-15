using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceTravel.Assets.Enemies
{
    public class Enemy
    {
        public int Health { get; set; }
        public int Damage { get; set; }
        public int Speed  { get; set; }
        public int Armor  { get; set; } // Броня
        //public int Abilities { get; set; } //Способности
        public Texture2D TextureEnemy { get; set; }
        public Enemy(int health, int damage,int speed, int armor)
        {
            Health = health;
            Damage = damage;
            Speed = speed;
            Armor = armor;
        }
    }

}