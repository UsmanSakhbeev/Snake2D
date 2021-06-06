using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class FoodPlacement : MonoBehaviour
{

    public BoxCollider2D boundary;
    // Start is called before the first frame update
    void Start()
    {
        //FoodRandomize();
    }

    private void  FoodRandomize()
    {
        //Bounds bounds = boundary.bounds;
        //float x = Random.Range(bounds.min.x, bounds.max.x);
        //float y = Random.Range(bounds.min.y, bounds.max.y);
        
        float x = Random.Range(-16.5f, 16.5f);
        float y = Random.Range(-9.5f, 9.5f);
        
        transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0f);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        FoodRandomize();
    }
}
