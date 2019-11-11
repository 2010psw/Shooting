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

    
    Rigidbody2D rb;
    public float speed = 10.0f;
    public Transform tr;
    public Vector3 now;
    public bool alive;      //true면 살아있는상태
    public bool ctrl;       //true면 컨트롤 가능
    bool show;              //true면 보이는 상태
    SpriteRenderer sr;
    Animator anim;
    int life = 3;
    public int level = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        tr = GetComponent<Transform>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        alive = true;
        ctrl = true;
        show = true;
        
    }
   
    void Update()
    {
        //조이스틱 이동
        if (ctrl==true)
        {
            move();
        }
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


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (alive)
        {
            if ((collision.gameObject.layer==12))//enemyBullet 레이어 충돌(총알맞음)
            {
                this.gameObject.SetActive(false);
                this.gameObject.SetActive(true);
                die();
                anim.SetTrigger("PlayerDie");
                Invoke("MF_Visible", 45 * Time.deltaTime);
                Invoke("revive", 60 * Time.deltaTime);
                level = 0;
            }
            if ((collision.gameObject.layer == 13))//아이템먹음
            {
                levelUP();
            }
        }
    }
    void MF_Visible()
    {//캐릭터 보이게/안보이게
        if (show)
        {
            show = false;
            sr.color = new Color(1, 1, 1, 0);
        }
        else
        {
            show = true;
            sr.color = new Color(1, 1, 1, 1);
        }
    }
    void die()
    {
        //죽으면 타겟 off
        if (alive)
        {
            setCtrl();
            alive = false;
        }
        else
        {
            alive = true;
        }
            
    }
    void setCtrl()
    {
        //죽으면 발동, 타겟 불가
        if (ctrl)
        {
            ctrl = false;
        }
        else
        {
            ctrl = true;
        }
    }
    void revive()
    {
        if (life>0)
        {

        }
        //살아날 포지션으로 재 지정(화면 비율로 구분)
        Vector3 p = Camera.main.WorldToViewportPoint(tr.position);
        p.x = 0.5f;
        p.y = 0.15f;

        //지정 포지션으로 이동
        this.gameObject.transform.position = Camera.main.ViewportToWorldPoint(p);

        //움직임 초기화
        
        
        //캐릭터 깜빡깜빡 효과
        int time = 10;
        for (int i =0; i<15;i++)
        {
            Invoke("MF_Visible", time * Time.deltaTime);
            time+=10;
        }
        
        //캐릭터 컨트롤기능 복구
        Invoke("setCtrl", 50 *Time.deltaTime);

        //살아있는상태로 복구(타겟 on)
        Invoke("die", 160 * Time.deltaTime);
    }
    void levelUP()
    {
        if (level<4)
        {
            level++;
        }

    }

}