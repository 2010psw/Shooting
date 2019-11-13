using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int hp;
    public Slider HP;
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
    public GameObject clr;

    Rigidbody2D rb;
    Transform tr;



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
            HP.value -= PB_Ctrl.Instance.damage;
            if (hp <= 0)
            {
                Debug.Log("죽음");
                clr.SetActive(true);
                Time.timeScale = 0;

            }

        }
        
    }
}

