using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateFood : MonoBehaviour
{
    [SerializeField] public GameObject aplle;

    public BoxCollider2D boundary;

    // Start is called before the first frame update
    void Start()
    {
        Bounds bounds = boundary.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        Instantiate(aplle);
        aplle.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FoodRandomize()
    {
        Bounds bounds = boundary.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        aplle.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0f);
    }
    
  

}
