using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerCtrl : MonoBehaviour
{
    
    Rigidbody2D rb;
    public float speed = 10.0f;
    public Transform tr;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        tr = GetComponent<Transform>();
    }
    
    void Update()
    {
        //조이스틱 이동
        move();
    }
    
    void move()
    {
        
        //조이스틱 이동
        rb.velocity = new Vector2(JoyStickMovement.Instance.joyVec.x * speed * Time.deltaTime, JoyStickMovement.Instance.joyVec.y * speed * Time.deltaTime);
        
        //화면밖으로 안나가게
        Vector3 p = Camera.main.WorldToViewportPoint(tr.position);
        if (p.x < 0.04f) p.x = 0.04f;
        if (p.x > 0.96f) p.x = 0.96f;
        if (p.y < 0.03f) p.y = 0.03f;
        if (p.y > 0.96f) p.y = 0.96f;
        tr.position = Camera.main.ViewportToWorldPoint(p);
        

    }
    void shot()
    {

    }
}