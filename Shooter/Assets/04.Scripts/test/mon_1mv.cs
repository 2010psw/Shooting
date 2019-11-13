using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mon_1mv : MonoBehaviour
{
    public float angle;
    public float distance;
    private void Start()
    {
     
    }

    private void Update()
    {
        float bulDirY = mon_mv.Instance.transform.position.y + Mathf.Cos((angle * Mathf.PI) * distance / 180f);
        float bulDirX = mon_mv.Instance.transform.position.x + Mathf.Sin((angle * Mathf.PI) * distance / 180f);
        Vector3 a = new Vector3(bulDirX, bulDirY, 0);
        this.transform.position = a;
        angle += 10;
    }
}
