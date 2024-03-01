using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    MonoBehaviour[] allObjects;

    int lastDestroyedIndex = -1;

    void Start()
    {
        allObjects = FindObjectsOfType<MonoBehaviour>(); 
    }

    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        if (Input.GetKeyDown(KeyCode.Space))
        {

            Debug.Log("Has pulsado espacio");
            int randomNum;
            do
            {
                randomNum = Random.Range(0, allObjects.Length);
            } while (randomNum == lastDestroyedIndex);
            lastDestroyedIndex = randomNum;
            Destroy(allObjects[randomNum].gameObject);

        }
        
    }
}
