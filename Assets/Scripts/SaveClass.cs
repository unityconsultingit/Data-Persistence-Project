using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveClass : MonoBehaviour
{

    //design pattern Singleton

    public static SaveClass Instance;

    public string PlayerName; // new variable declared

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

}


