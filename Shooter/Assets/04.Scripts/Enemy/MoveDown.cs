using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public Transform tr;
    public float speed = 10f;


    void Update()
    {
        tr.Translate(Vector3.down * speed * Time.deltaTime);
    }
}
