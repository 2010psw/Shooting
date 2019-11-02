using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class GameManager : MonoBehaviour
{
    
    public static GameManager Instance
    {//싱글톤
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();
                if (Instance == null)
                {
                    var instanceContainer = new GameObject("GameManager");
                    instance = instanceContainer.AddComponent<GameManager>();
                }
            }
            return instance;
        }
    }
    private static GameManager instance;

    void revivePlayer()
    {
            
    }

}
