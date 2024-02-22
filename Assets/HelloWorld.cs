using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayableCharacter;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Enemy enemy = new Enemy("Orco", 50);
        Player player = new Player("Caballero", 90);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
