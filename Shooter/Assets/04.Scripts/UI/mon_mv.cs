using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mon_mv : MonoBehaviour
{
    private float moveSpeed;
    Vector3 a;
    public static mon_mv Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<mon_mv>();
                if (Instance == null)
                {
                    var instanceContainer = new GameObject("mon_mv");
                    instance = instanceContainer.AddComponent<mon_mv>();
                }
            }
            return instance;
        }
    }
    private static mon_mv instance;
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 2f;
        a = Vector3.right;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 p = Camera.main.WorldToViewportPoint(transform.position);
        if (p.x < 0.3f) a.x = -a.x;
        if (p.x > 0.7f) a.x = -a.x;

        transform.Translate(a * Time.deltaTime);
    }
}
