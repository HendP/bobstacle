 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    float moveSpeed = 10f;

    // Start is called before the first frame update
    // type whatever you like
    void Start()
    {
        
    }

    // update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate( xValue, 0, zValue);
    }
}
