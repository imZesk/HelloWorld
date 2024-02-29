using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class train : MonoBehaviour
{

    private Transform  transformation;
    // Start is called before the first frame update
    void Start()
    {
        transformation = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("x: " + transformation.position.x + " y: " + transformation.position.y + " z: " + transformation.position.z);
    }
}
