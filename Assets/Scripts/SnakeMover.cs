using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMover : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector2 direction = Vector2.right;
    public float speed = 1;
    Vector2 lastDirection;


    void Start()
    {
        InvokeRepeating("Moving",0,0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && lastDirection != Vector2.right)
        {
            direction = Vector2.left;
        }
        else if (Input.GetKeyDown(KeyCode.D) && lastDirection != Vector2.left)
        {
            direction = Vector2.right;
        }
        else if (Input.GetKeyDown(KeyCode.W) && lastDirection != Vector2.down)
        {
            direction = Vector2.up;
        }
        else if (Input.GetKeyDown(KeyCode.S) && lastDirection != Vector2.up)
        {
            direction = Vector2.down;
        }

    }

    void Moving()
    {
        transform.position = new Vector3(Mathf.Round(transform.position.x+direction.x),Mathf.Round(transform.position.y+direction.y),0);
        lastDirection = direction;
    }

    void FixedUpdate()
    {
        //this.transform.position = new Vector3(this.transform.position+direction.x,);
        //transform.position += transform.right * Time.deltaTime;
        //transform.position = new Vector3(Mathf.Round(transform.position.x+direction.x)*Time.deltaTime,Mathf.Round(transform.position.y+direction.y)*Time.deltaTime,0);
        //transform.position = new Vector3(Mathf.Round(transform.position.x+direction.x)*speed,Mathf.Round(transform.position.y+direction.y)*speed,0);
    }
}
 