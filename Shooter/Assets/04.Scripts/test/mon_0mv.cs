using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mon_0mv : MonoBehaviour
{
    private float moveSpeed;
    Vector3 a;
    private void Start()
    {
        moveSpeed = 2f;
        a = Vector3.right;
    }

    private void Update()
    {
        
        Vector3 p = Camera.main.WorldToViewportPoint(transform.position);
        if (p.x < 0.3f) a.x = -a.x;
        if (p.x > 0.7f) a.x = -a.x;

        transform.Translate(a * Time.deltaTime);
    }
}
