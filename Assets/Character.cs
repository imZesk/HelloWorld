using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string name;
    private int healthPoints = 100;
    //int vida { get; set; }
    //bool alive { get; set; }

    public Character(string s)
    {
        name = s;
        Debug.Log(name);
    }

    ~Character()
    {
        Debug.Log(name + " ha muerto");
    }

    public int HealthPoints { get => healthPoints; set => healthPoints = value; }

    public static void takeDmg(Character x)
    {
        x.healthPoints = x.healthPoints - 1;

        if (x. healthPoints <= 0) 
        {
             Debug.Log("murio bug");
        }
    }

}
