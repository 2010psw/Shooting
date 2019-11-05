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
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if ((collision.gameObject.layer == 14))//벽 터치
        {
            Destroy(this.gameObject);
        }

    }
}
