using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{
    public void back()
    {
        SceneManager.LoadScene("start");
    }
    public void asdf()
    {
        SceneManager.LoadScene("s2");
    }
    public void qwer()
    {
        Debug.Log("프로그램 종료");
        Application.Quit();
    }
    public void tyui()
    {
        SceneManager.LoadScene("stage1");
    }

    
}
