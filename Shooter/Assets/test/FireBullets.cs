using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullets : MonoBehaviour
{
    [SerializeField]
    private int bulletsAmount;

    [SerializeField]
    private float startAngle = 0f, endAngle = 360f, DelayTime = 0.5f, sa1, ea1;

    [SerializeField]
    public int Pattern;

    private Vector2 bulletMoveDirection;


    private void Start()
    {
        sa1 = startAngle;
        ea1 = endAngle;
        pattern(Pattern);
    }


    private void pattern(int pNum)
    {
        switch (pNum)
        {
            case 1: //그냥 원
                InvokeRepeating("Fire1", 0f, DelayTime);
                break;
            case 2: //그냥 원 + 크로스
                InvokeRepeating("Fire2", 0f,0.6f    );
                break;
            case 3: //꽃 bulletamount = 꽃잎 개수
                InvokeRepeating("Fire3", 0f, 0.1f);
                break;
            case 4: //회전
                InvokeRepeating("Fire4", 0f, DelayTime);
                break;

        }
    }

    private void Fire1()
    {
        float angleStep = (endAngle - startAngle) / bulletsAmount;
        float angle = startAngle;

        for (int i = 0; i < bulletsAmount + 1; i++)
        {
            float bulDirY = transform.position.y + Mathf.Cos((angle * Mathf.PI) / 180f);
            float bulDirX = transform.position.x + Mathf.Sin((angle * Mathf.PI) / 180f);

            Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 0f);
            Vector2 bulDir = (bulMoveVector - transform.position).normalized;

            GameObject bul = BulletPool.bulletPoolInstance.GetBullet();
            bul.transform.position = transform.position;
            bul.transform.rotation = transform.rotation;
            bul.SetActive(true);
            bul.GetComponent<Bullet>().SetMoveDirection(bulDir);

            angle += angleStep;
        }

    }

    private void Fire2()
    {
        float angleStep = (endAngle - startAngle) / bulletsAmount;
        float angle = startAngle;

        for (int i = 0; i < bulletsAmount + 1; i++)
        {
            float bulDirY = transform.position.y + Mathf.Cos((angle * Mathf.PI) / 180f);
            float bulDirX = transform.position.x + Mathf.Sin((angle * Mathf.PI) / 180f);

            Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 0f);
            Vector2 bulDir = (bulMoveVector - transform.position).normalized;

            GameObject bul = BulletPool.bulletPoolInstance.GetBullet();
            bul.transform.position = transform.position;
            bul.transform.rotation = transform.rotation;
            bul.SetActive(true);
            bul.GetComponent<Bullet>().SetMoveDirection(bulDir);

            angle += angleStep;
        }
        Invoke("Fire2_1", 0.3f);
    }
    private void Fire2_1()
    {
        float angleStep = (endAngle - startAngle) / bulletsAmount;
        float angle = startAngle + angleStep/2;

        for (int i = 0; i < bulletsAmount + 1; i++)
        {
            float bulDirY = transform.position.y + Mathf.Cos((angle * Mathf.PI) / 180f);
            float bulDirX = transform.position.x + Mathf.Sin((angle * Mathf.PI) / 180f);

            Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 0f);
            Vector2 bulDir = (bulMoveVector - transform.position).normalized;

            GameObject bul = BulletPool.bulletPoolInstance.GetBullet();
            bul.transform.position = transform.position;
            bul.transform.rotation = transform.rotation;
            bul.SetActive(true);
            bul.GetComponent<Bullet>().SetMoveDirection(bulDir);

            angle += angleStep;
        }
    }


    private void Fire3()
    {
        int bulletsAmount = 7;//꽃잎 수, 지역변수로 선언
        float angleStep = 360 / bulletsAmount;
        float angle = startAngle;
        startAngle += 5f;
        endAngle += 5f;
        for (int i = 0; i < bulletsAmount + 1; i++)
        {
            float bulDirY = transform.position.y + Mathf.Cos((angle * Mathf.PI) / 180f);
            float bulDirX = transform.position.x + Mathf.Sin((angle * Mathf.PI) / 180f);

            Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 0f);
            Vector2 bulDir = (bulMoveVector - transform.position).normalized;

            GameObject bul = BulletPool.bulletPoolInstance.GetBullet();
            bul.transform.position = transform.position;
            bul.transform.rotation = transform.rotation;
            bul.SetActive(true);
            bul.GetComponent<Bullet>().SetMoveDirection(bulDir);

            angle += angleStep;
        }
        float as1 = 360 / bulletsAmount;
        float ag1 = sa1;
        sa1 -= 5f;
        ea1 -= 5f;
        for (int i = 0; i < bulletsAmount + 1; i++)
        {
            float bulDirY = transform.position.y + Mathf.Cos((ag1 * Mathf.PI) / 180f);
            float bulDirX = transform.position.x + Mathf.Sin((ag1 * Mathf.PI) / 180f);

            Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 0f);
            Vector2 bulDir = (bulMoveVector - transform.position).normalized;

            GameObject bul = BulletPool.bulletPoolInstance.GetBullet();
            bul.transform.position = transform.position;
            bul.transform.rotation = transform.rotation;
            bul.SetActive(true);
            bul.GetComponent<Bullet>().SetMoveDirection(bulDir);

            ag1 += as1;
        }
    }

    private void Fire4()
    {
       
        float angleStep = (endAngle - startAngle) / bulletsAmount;
        float angle = startAngle;
        
        for (int i = 0; i < bulletsAmount + 1; i++)
        {
            float bulDirY = transform.position.y + Mathf.Cos((angle * Mathf.PI) / 180f);
            float bulDirX = transform.position.x + Mathf.Sin((angle * Mathf.PI) / 180f);

            Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 0f);
            Vector2 bulDir = (bulMoveVector - transform.position).normalized;

            GameObject bul = BulletPool.bulletPoolInstance.GetBullet();
            bul.transform.position = transform.position;
            bul.transform.rotation = transform.rotation;
            bul.SetActive(true);
            bul.GetComponent<Bullet>().SetMoveDirection(bulDir);

            angle += angleStep;
        }

        startAngle += 17f;
        endAngle += 17f;
    }
}
