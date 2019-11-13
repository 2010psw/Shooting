using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public Transform tr;
    public float speed = 10f;
    public GameObject obj;
    Vector3 a = Vector3.down;

    void Update()
    {
        tr.Translate(a * speed * Time.deltaTime);
        Vector3 p = Camera.main.WorldToViewportPoint(tr.position);
        
        if (p.y < -0.3f) Destroy(this.gameObject);
        

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Vector3 p = Camera.main.WorldToViewportPoint(tr.position);

        if (p.y < 0.95f)
        {
            if ((collision.gameObject.layer == 9))//
            {
                if (Random.Range(0f, 11f)>8f)//아이템 드랍 확률
                {
                    Instantiate(obj, this.gameObject.transform.position, Quaternion.identity);

                }
                Destroy(this.gameObject);
            }


        }
    }
}
