using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("delete", 1.5f);
    }


    void delete()
    {
        Destroy(this.gameObject);
    }
}
