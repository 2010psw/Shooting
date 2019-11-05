using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireControl : MonoBehaviour
{
    public GameObject[] pos;
    public GameObject[] bullet;

    
    float timeSpan;  //경과 시간을 갖는 변수
    float checkTime;  // 특정 시간을 갖는 변수

    void Start()
    {
        timeSpan = 0.0f;
        checkTime = 0.1f;  //공격속도 제한
    }

   
    void Update()
    {
        timeSpan += Time.deltaTime;  // 경과 시간을 계속 등록
        if (timeSpan > checkTime)  // 경과 시간이 특정 시간이 보다 커졋을 경우
        {
            if (PlayerCtrl.Instance.ctrl==true)
            {
                fire();
                timeSpan = 0;

            }
        }

    }
    private void fire()
    {
        if (JoyStickMovement.Instance.touchNow)
        {
           
            for (int i = 0; i<pos.Length; i++)
            {
                Instantiate(bullet[PlayerCtrl.Instance.level], pos[i].transform.position, pos[i].transform.rotation);
            }
        }
        
    }
   


}
