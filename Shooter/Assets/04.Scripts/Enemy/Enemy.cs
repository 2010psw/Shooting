using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public static Enemy Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<Enemy>();
                if (Instance == null)
                {
                    var instanceContainer = new GameObject("Enemy");
                    instance = instanceContainer.AddComponent<Enemy>();
                }
            }
            return instance;
        }
    }
    private static Enemy instance;

    Rigidbody2D rb;
    Transform tr;
    public int hp;
    

    void Start()
    {
        tr = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.layer == 9))
        {
            hp -= PB_Ctrl.Instance.damage;
            if (hp<=0)
            {
                Debug.Log("몬스터 사망");
                if (Random.Range(0,100)>90f)//드랍 트루(템 드랍하는놈이면)
                {
                    
                }
            }
        }
    }
}
