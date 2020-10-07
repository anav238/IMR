using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject img; //ImageTarget-ul
    public GameObject duck; //Animated Object
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dist = img.transform.position; //position of target
        float z = dist[2];
        if (z < 50)
        {
            duck.GetComponent<Animator>().enabled = false;
        }
        else
        {
            duck.GetComponent<Animator>().enabled = true;
        }
    }
}
