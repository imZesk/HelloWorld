using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorTheWorld : MonoBehaviour
{
    public bool findByTag = true; 
    public Color tagColor = Color.red;
    public string tagName;


//    private void Start()
//    {
//        GameObject[] redObjects = GameObject.FindGameObjectsWithTag(tagName);
//    }

    private void Update()
    {
        if (findByTag)
        {
            GameObject[] redObjects = GameObject.FindGameObjectsWithTag(tagName);
            foreach (GameObject obj in redObjects)
            {
                ChangeObjectColor(obj, tagColor);
            }
        }
    }

    private void ChangeObjectColor(GameObject obj, Color color)
    {
        Renderer renderer = obj.GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.material.color = color;
        }
    }
}