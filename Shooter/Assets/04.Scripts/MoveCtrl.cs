using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCtrl : MonoBehaviour
{
    
    public Transform tr;
    public float speed = 10f;
    Rigidbody2D rb;
    
    // Update is called once per frame
    void Update()
    {
        tr.Translate(Vector3.up * speed * Time.deltaTime);
        
        Vector3 p = Camera.main.WorldToViewportPoint(tr.position);

        if (p.y > 1.1f) Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.layer == 9)) {

        }
    }
}
