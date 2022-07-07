using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public Rigidbody2D player;
    public Vector3 horizontal;
    public Vector3 vertical;
    


    
    void Update()
    {
        var position = GameObject.Find("Player").transform.position;

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            horizontal = horizontal * 2;
            vertical = vertical * 2;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            horizontal = horizontal / 2;
            vertical = vertical / 2;
        }

        if (Input.GetKey(KeyCode.W)){
            transform.position += vertical * Time.deltaTime;
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= vertical * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= horizontal * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += horizontal * Time.deltaTime;
        }

        

    }
}
