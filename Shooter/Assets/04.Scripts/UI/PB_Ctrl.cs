using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PB_Ctrl : MonoBehaviour
{
    public static PB_Ctrl Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<PB_Ctrl>();
                if (Instance == null)
                {
                    var instanceContainer = new GameObject("PB_Ctrl");
                    instance = instanceContainer.AddComponent<PB_Ctrl>();
                }
            }
            return instance;
        }
    }
    private static PB_Ctrl instance;
    public int damage;
    
    Rigidbody2D rb;
    public Transform tr;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        tr = GetComponent<Transform>();
        setDamage();
        Invoke("Destroy", 1.2f);
    }
    void setDamage()
    {
        switch (PlayerCtrl.Instance.level)
        {
            case 0:
                damage = 100;
                break;
            case 1:
                damage = 130;
                break;
            case 2:
                damage = 160;
                break;
            case 3:
                damage = 190;
                break;
            case 4:
                damage = 230;
                break;
            default:
                damage = 100;
                break;

        }
    }
    void Destroy()
    {
        Destroy(this.gameObject);
    }
}
