using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerPreferences : MonoBehaviour
{
    public string username;
    public GameObject inputField;
    public GameObject textDisplay;
    // public string gender;

    
    public void confirmPrefs()
    {
        username = inputField.GetComponent<Text>().text;
        textDisplay.GetComponent<Text>().text = "Apa kamu sudah yakin dengan nama " + username + "?";
    }

    public void savePrefs()
    {
        PlayerPrefs.SetString("username", username);
        // PlayerPrefs.SetString("gender", gender);
    }

    public void selectBoy()
    {
        // gender = "boy";
    }

    public void selectGirl()
    {
        // gender = "girl";
    }

    public void resetDataPlayer()
    {
        PlayerPrefs.DeleteAll();
    }


}
