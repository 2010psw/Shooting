using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMove : MonoBehaviour
{
    public Transform tr;
    SpriteRenderer sr;
    private AudioSource Sound;
    public AudioClip Sound2;
    Vector3 a;
    float speed = 1.3f;
    public GameObject obj;
    void Start()
    {
        a = (Vector3.up + Vector3.right)*speed;

        this.Sound = this.gameObject.AddComponent<AudioSource>();
        this.Sound.clip = this.Sound2;
        this.Sound.loop = false;

        sr = GetComponent<SpriteRenderer> ();
    }
    void Update()
    {
        Vector3 p = Camera.main.WorldToViewportPoint(tr.position);
        if (p.x < 0.04f) a.x = -a.x;
        if (p.x > 0.96f) a.x = -a.x;
        if (p.y < 0.03f) a.y = -a.y;
        if (p.y > 0.96f) a.y = -a.y;
        transform.Translate(a * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.layer == 8))
        {
            
            Instantiate(obj, tr.position, Quaternion.identity);
            delete();
            
        }

    }

    void delete()
    {
        Destroy(this.gameObject);

    }
}
