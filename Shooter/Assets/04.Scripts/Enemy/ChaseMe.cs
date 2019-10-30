using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseMe : MonoBehaviour
{
    
    public Transform tr;
    public float speed = 10f;
    Vector3 a;
    
    void Start()
    {
        /*
        a = this.gameObject.transform.position;
        Vector3 b = PlayerCtrl.Instance.transform.position;
        a = b - a;
        */
        var heading = PlayerCtrl.Instance.transform.position - this.gameObject.transform.position;

        var distance = heading.magnitude;
        var direction = heading / distance;
        a = direction;
    }
    
    // Update is called once per frame
    void Update()
    {
        tr.Translate(a * speed * Time.deltaTime);
    }

}
