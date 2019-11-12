using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Round : MonoBehaviour
{
    public float angle;
    public float distance;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float bulDirY = PlayerCtrl.Instance.transform.position.y + Mathf.Cos((angle * Mathf.PI) * distance / 180f);
        float bulDirX = PlayerCtrl.Instance.transform.position.x + Mathf.Sin((angle * Mathf.PI) * distance / 180f);
        Vector3 a = new Vector3(bulDirX, bulDirY, 0);
        this.transform.position = a;
        angle += 10;
    }
}
