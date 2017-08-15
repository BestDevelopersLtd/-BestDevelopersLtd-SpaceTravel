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
using Android.Graphics;

namespace SpaceTravel.Assets.Enemies
{
    public class Enemy
    {
        public Point Position { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public int Speed  { get; set; }
        public int Armor  { get; set; } // Броня
        //public int Abilities { get; set; } //Способности
        public Texture2D TextureEnemy { get; set; }
        public Enemy(int health, int damage,int speed, int armor,Point position, int height, int width )
        {
            Health = health;
            Damage = damage;
            Speed = speed;
            Armor = armor;
            Position = position;
            Height = height;
            Width = width;

        }
        public virtual void Move ()
        {

        }
    }

}