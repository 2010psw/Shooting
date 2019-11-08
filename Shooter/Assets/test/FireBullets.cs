using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullets : MonoBehaviour
{
    [SerializeField]
    private int bulletsAmount;

    [SerializeField]
    private float startAngle = 0f, endAngle = 360f, DelayTime = 0.5f;

    private Vector2 bulletMoveDirection;

    public int Pattern;
    private void Start()
    {
        pattern(Pattern);
    }


    private void pattern(int pNum)
    {
        if (pNum == 1)
        {
            InvokeRepeating("Fire", 0f, DelayTime);
        }
        switch (pNum)
        {
            case 1:
                InvokeRepeating("Fire", 0f, DelayTime);
                break;
            case 2:
                InvokeRepeating("Fire1", 0f, DelayTime);
                break;
            case 3:
                InvokeRepeating("Fire3", 0f, DelayTime);
                break;
            case 4:
                InvokeRepeating("Fire4", 0f, DelayTime);
                break;
            case 5:
                InvokeRepeating("Fire5", 0f, DelayTime);
                break;

        }
    }

    private void Fire()
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

    private void Fire1()
    {
        float angleStep = (endAngle - startAngle) / bulletsAmount;
        float angle = startAngle;

        for (int i = 0; i < bulletsAmount + 1; i++)
        {
            float bulDirX = transform.position.x + Mathf.Sin((angle * Mathf.PI) / 180f);
            float bulDirY = transform.position.y + Mathf.Cos((angle * Mathf.PI) / 180f);

            Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 0f);
            Vector2 bulDir = (bulMoveVector - transform.position).normalized;

            GameObject bul = BulletPool.bulletPoolInstance.GetBullet();
            bul.transform.position = transform.position;
            bul.transform.rotation = transform.rotation;
            bul.SetActive(true);
            bul.GetComponent<Bullet>().SetMoveDirection(bulDir);

            angle += angleStep;
        }
        Invoke("Fire2", DelayTime / 2);

    }



    private void Fire2()
    {
        float angleStep = (endAngle - startAngle) / bulletsAmount;
        float test = angleStep / 2;
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
            if (i == 0)
            {
                angle += test;
            }
            else
            {

                angle += angleStep;
            }
        }


    }


    
    private void Fire3()
    {
        float angleStep = (endAngle - startAngle) / bulletsAmount;
        float angle = startAngle;
        startAngle += 20;
        endAngle += 20;
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
    private void Fire4()
    {
        float angleStep = (endAngle - startAngle) / bulletsAmount;
        float angle = startAngle;
        startAngle += 147;
        endAngle += 147;
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
        startAngle += 27;
        endAngle += 27;
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
    private void Fire5()
    {
        float angleStep = (endAngle - startAngle) / bulletsAmount;
        float angle = startAngle;
        startAngle += 44f;
        endAngle += 44f;
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
        startAngle += 44f;
        endAngle += 44f;
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
        startAngle += 44f;
        endAngle += 44f;
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
        startAngle += 44f;
        endAngle += 44f;
    }
}
