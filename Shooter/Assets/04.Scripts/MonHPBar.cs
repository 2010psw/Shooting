using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonHPBar : MonoBehaviour
{
    public Slider HP;

    void Update()
    {
        if (Input.GetKey(KeyCode.H))
        {
            HP.value -= 0.1f;
        }
    }
}
