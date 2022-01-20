using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowCurrentUsername : MonoBehaviour
{
    private string username;
    private string gender;
    public GameObject textDisplay;
    // public GameObject buttonBoy;
    // public GameObject buttonGirl;

    
    private void Start() {
        username = PlayerPrefs.GetString("username");
        textDisplay.GetComponent<Text>().text = "" + username;
    }
}
