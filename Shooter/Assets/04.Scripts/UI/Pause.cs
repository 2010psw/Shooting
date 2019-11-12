using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    private bool pauseNow;
    private void Start()
    {
        pauseNow = false;
    }


    public void pause()
    {
        Time.timeScale = 0;
    }
    public void resume()
    {
        Time.timeScale = 1;
    }
}
