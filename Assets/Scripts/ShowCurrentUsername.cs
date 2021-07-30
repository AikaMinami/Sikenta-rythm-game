using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowCurrentUsername : MonoBehaviour
{
    private string username;
    public GameObject textDisplay;
    // public string gender;

    
    private void Start() {
        username = PlayerPrefs.GetString("username");
        textDisplay.GetComponent<Text>().text = "" + username;
    }
}
