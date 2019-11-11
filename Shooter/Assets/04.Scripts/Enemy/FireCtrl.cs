using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCtrl : MonoBehaviour
{
    public GameObject[] pos;
    public GameObject bullet;

    public float delayTime;
    void Start()
    {
        InvokeRepeating("fire", 1.0f, delayTime);
    }

    // Update is called once per frame
    void Update()
    {
       //fire
    }

    void fire()
    {
        for (int i=0; i<pos.Length; i++)
        {
            Instantiate(bullet, pos[i].transform.position, pos[i].transform.rotation);
        }
    }
}
