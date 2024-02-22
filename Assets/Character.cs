using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayableCharacter
{
    public class Character
    {
        public string name;
        private int hp;


        public Character(string name, int hp)
        {
            this.name = name;
        }

        protected string GetName()
        {
            return this.name;
        }

        protected string GetHp()
        {
            return this.hp;
        }

    }

    public class Enemy : Character
    {
        public Enemy(string name, int hp) : base(name)
        {
            Debug.Log("Enemigo creado: " + GetName());
        }
    }

    public class Player : Character
    {
        public Player(string name, int hp) : base(name)
        {
            Debug.Log("Jugador creador: " + GetName());
        }
    }
}