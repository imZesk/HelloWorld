using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string name;
    private int healthPoints = 1;
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
    }

}
