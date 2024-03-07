using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getPosition : MonoBehaviour
{

    public float speedMultiplier = 0.001f;
    float smooth = 50.0f;
    float tiltAngle = 60.0f;
    // Start is called before the first frame update
    void Start()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.SetParent(this.transform);
        cube.transform.position += Vector3.left * 10;
    }

    // Update is called once per frame
        void Update()
    {
        checkMovement();

        scaleSize();

        if (Input.GetKey(KeyCode.G))
        {
            this.transform.localScale += new Vector3(speedMultiplier, speedMultiplier, 0);
            Debug.Log("Clesio");
        }
        if (Input.GetKey(KeyCode.H))
        {
            this.transform.localScale -= new Vector3(speedMultiplier, speedMultiplier, 0);
            Debug.Log("Declesio");
        }
        transform.Rotate(Vector3.up * smooth * Time.fixedDeltaTime); // Eje Y
        //transform.Rotate(Vector3.right * smooth * Time.fixedDeltaTime); // Eje X
        //transform.Rotate(Vector3.forward * smooth * Time.fixedDeltaTime); // Eje Z
    }

    private void scaleSize()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            this.transform.localScale += new Vector3(1, 1, 0);
            Debug.Log("Clesio");
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            this.transform.localScale -= new Vector3(1,1,0);
            Debug.Log("Declesio");
        }
    }

    private void checkMovement()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.position += Vector3.up * speedMultiplier;
            Debug.Log("Position Z" + this.transform.position.y);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.position -= Vector3.up * speedMultiplier;
            Debug.Log("Position Z" + this.transform.position.y);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.position -= Vector3.right * speedMultiplier;
            Debug.Log("Position X" + this.transform.position.x);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.position -= Vector3.left * speedMultiplier;
            Debug.Log("Position X" + this.transform.position.x);
        }
    }
}
