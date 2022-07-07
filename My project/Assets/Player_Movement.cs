using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public Rigidbody2D player;

    

    // Start is called before the first frame update
    void Start()
    {
        var position = GameObject.Find("Player").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
     //transform.position += 
    }
}
