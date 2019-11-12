using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnManager : MonoBehaviour
{
    public GameObject obj;
    public Transform respawnTr;
    public float respawnTime;
    void Start()
    {
        StartRespawn();
    }

    // Update is called once per frame
    IEnumerator RespawnEnemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            float range = (float)Screen.width / (float)Screen.height * Camera.main.orthographicSize;
            Instantiate(obj, respawnTr.position + new Vector3(Random.Range(-range, range), 0, 0), Quaternion.identity);
        }
    }

    public void StartRespawn()
    {
        StartCoroutine(RespawnEnemy());
    }
    public void StopRespawn()
    {
        StopCoroutine(RespawnEnemy());
    }
}
