using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerCtrl : MonoBehaviour
{
    public static PlayerCtrl Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<PlayerCtrl>();
                if (Instance == null)
                {
                    var instanceContainer = new GameObject("PlayerCtrl");
                    instance = instanceContainer.AddComponent<PlayerCtrl>();
                }
            }
            return instance;
        }
    }
    private static PlayerCtrl instance;

    public int hp = 10;
    public int inithp = 10;
    Rigidbody2D rb;
    public float speed = 10.0f;
    public Transform tr;
    public Vector3 now;
    public int level;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        tr = GetComponent<Transform>();
        
    }
    void Awake()
    {
        hp = inithp;
        level = 1;
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

        if (JoyStickMovement.Instance.touchNow)
            //화면 터치중이면 총알 발사
        {
            shot();
        }

    }
    void shot()
    {
        //Debug.Log("발사!");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ENEMY"))
        {
            hp--;
            if (hp<=0)
            {
                Debug.Log("사망");
            }
        }
    }
}