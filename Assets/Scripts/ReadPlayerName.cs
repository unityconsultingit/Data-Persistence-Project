using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI; // Required when Using UI elements.

public class ReadPlayerName : MonoBehaviour
{

    public GameObject TMP_InputField_Username;

    void Update()
    {
        GetUsername();
    }
  
    public void GetUsername() {
        string name = TMP_InputField_Username.GetComponent<TMP_InputField>().text;
        Debug.Log("Username: " + name);
        SaveClass.Instance.PlayerName=name;
    }

    

}
