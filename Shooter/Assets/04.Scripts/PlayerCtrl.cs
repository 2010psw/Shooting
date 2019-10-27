using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerCtrl : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 0.5f;

    void Start()
    {
        
    }

    
    void Update()
    {
        MoveControl();
    }
    
    void MoveControl()
    {
        float moveX = speed * Time.deltaTime * Input.GetAxis("Horizontal");
        float moveY = speed * Time.deltaTime * Input.GetAxis("Vertical");
        transform.Translate(moveX, moveY, 0);
    }



}