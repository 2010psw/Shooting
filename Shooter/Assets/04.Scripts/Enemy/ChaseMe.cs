using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseMe : MonoBehaviour
{
    
    public Transform tr;
    public float speed = 10f;
    Vector3 a;
    bool alive;
    public int dir;
    void Start()
    {
        /*
        a = this.gameObject.transform.position;
        Vector3 b = PlayerCtrl.Instance.transform.position;
        a = b - a;

        if (PlayerCtrl.Instance.alive)
        {
            alive = true;
            var heading = PlayerCtrl.Instance.transform.position - this.gameObject.transform.position;
            var distance = heading.magnitude;
            var direction = heading / distance;
            a = direction;
        }
        else{
            a = Vector3.down;
        }
        */
        setDir(dir);
         
    }
    
    // Update is called once per frame
    void Update()
    {
        
            tr.Translate(a * speed * Time.deltaTime);

    }
    void setDir(int dir)
    {
        /*
         1          2           3       
         4       캐릭터         6
         7          8           9
         */

        // 1 1:4 = ? : 1
        //1.4x = 1;
        //x = 1/1.4
        switch (dir)
        {
            case 1:
                a = (Vector3.up + Vector3.left)/0.707f;
                break;
            case 2:
                a = Vector3.up;
                break;
            case 3:
                a = (Vector3.up + Vector3.right)/0.707f;
                break;
            case 4:
                a = Vector3.left;
                break;
            case 5:
                if (PlayerCtrl.Instance.alive)
                {
                    alive = true;
                    var heading = PlayerCtrl.Instance.transform.position - this.gameObject.transform.position;
                    var distance = heading.magnitude;
                    var direction = heading / distance;
                    a = direction;
                }
                else
                {
                    a = Vector3.down;
                }
                break;
            case 6:
                a = Vector3.right;
                break;
            case 7:
                a = (Vector3.left + Vector3.down) / 0.707f;
                break;
            case 8:
                a = Vector3.down;
                break;
            case 9:
                a = (Vector3.down + Vector3.right) / 0.707f;
                break;
            default:
                a = Vector3.down;
                break;
        }
        
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if ((collision.gameObject.layer == 14))//벽 터치
        {
            Destroy(this.gameObject);
        }

    }
}
