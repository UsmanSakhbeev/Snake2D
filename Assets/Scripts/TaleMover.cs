using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaleMover : MonoBehaviour
{
    [SerializeField] public GameObject head;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("TMover", 0, 0.2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TMover ()
    {
        transform.position = head.transform.position;
    }


}
