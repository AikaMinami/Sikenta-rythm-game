using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{
    
    void Start()
    {
        if(PlayerPrefs.GetInt("FirstTimeOpen", 1) == 1)
        {
            SceneManager.LoadScene("PlayerPrefs");
            PlayerPrefs.SetInt("FirstTimeOpen", 0);
        } else if(PlayerPrefs.GetInt("FirstClearTutorial", 1) == 1)
        {
            SceneManager.LoadScene("PlayerPrefs");
            PlayerPrefs.SetInt("FirstClearTutorial", 0);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
