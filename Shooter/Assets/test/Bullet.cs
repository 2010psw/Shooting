﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Vector2 moveDirection;
    public float moveSpeed;

    private void Update()
    {
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
        Vector3 p = Camera.main.WorldToViewportPoint(transform.position);
        if (p.x < -0.04f) Destroy();
        if (p.x > 1.04f) Destroy();
        if (p.y < -0.04f) Destroy();
        if (p.y > 1.04f) Destroy();
    }
    public void SetMoveDirection(Vector2 dir)
    {
        moveDirection = dir;
    }

    private void Destroy()
    {
        gameObject.SetActive(false);
    }
    private void OnDisable()
    {
        CancelInvoke();
    }
}
