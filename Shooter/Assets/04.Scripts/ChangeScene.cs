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
    public void s2()
    {
        SceneManager.LoadScene("stage2");
    }
    public void s3()
    {
        SceneManager.LoadScene("stage3");
    }
    public void s4()
    {
        SceneManager.LoadScene("stage4");
    }
    public void s5()
    {
        SceneManager.LoadScene("stage5");
    }
    public void s6()
    {
        SceneManager.LoadScene("stage6");
    }
    public void s7()
    {
        SceneManager.LoadScene("stage7");
    }
    public void s8()
    {
        SceneManager.LoadScene("stage8");
    }
    public void s9()
    {
        SceneManager.LoadScene("stage9");
    }
    public void s10()
    {
        SceneManager.LoadScene("stage10");
    }


}
