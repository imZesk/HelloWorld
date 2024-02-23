using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    Enemy enemy;

    void Start()
    {
        Debug.Log("Hello world");
        enemy = new Enemy("Enemigo");
        Player player = new Player("Jugador");
    }

    // Update is called once per frame 
    void Update()
    {
        Debug.Log("Nombre: "+enemy.name + "; Vida: " + enemy.HealthPoints);
        Character.takeDmg(enemy);
    }
}
