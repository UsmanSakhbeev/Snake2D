using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaleGrowing : MonoBehaviour
{
    // Start is called before the first frame update
    public Queue<GameObject> tale = new Queue<GameObject>() ;
    private Queue<GameObject> enableColliderTale = new Queue<GameObject>();
    public GameObject talePrefab;
    GameObject _taleFragment;
    //[SerializeField] public GameObject head;
    
    
    void Awake()
    {
        tale.Enqueue(Instantiate(talePrefab, this.transform.position,this.transform.rotation));
        InvokeRepeating("TMover", 0.1f, 0.1f);
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Food")
        {
            tale.Enqueue(Instantiate(talePrefab, this.transform.position,this.transform.rotation));
            //Debug.Log("Triggered");
        }
        else if(other.tag == "Tale")
        {
            Debug.Log("Tale Collision");
            int tAmount = tale.Count;
            for (int i = 1; i <= tAmount; i++)
            {
                Destroy(tale.Dequeue());
                Debug.Log("iteration");
            }
            tale.Clear();
            tale.Enqueue(Instantiate(talePrefab, this.transform.position,this.transform.rotation));
            this.transform.position = Vector3.zero;
        }
        else if (other.tag == "Boundary")
        {
            Debug.Log("Boundary collision");
            Debug.Log(tale.Count);
            int tAmount = tale.Count;
            for (int i = 1; i <= tAmount; i++)
            {
                Destroy(tale.Dequeue());
                Debug.Log("iteration");
            }
            tale.Clear();
            tale.Enqueue(Instantiate(talePrefab, this.transform.position,this.transform.rotation));
            this.transform.position = Vector3.zero;
        }

    }

    void Update()
    {
    }

    void TMover()
    {
        _taleFragment = tale.Dequeue();
        _taleFragment.GetComponent<Collider2D>().enabled = false;
        _taleFragment.transform.position = this.transform.position;
        tale.Enqueue(_taleFragment);
        if (tale.Count > 2)
            enableColliderTale.Enqueue(_taleFragment);


        if (enableColliderTale.Count > 2)
            enableColliderTale.Dequeue().GetComponent<Collider2D>().enabled = true;



    }
}
