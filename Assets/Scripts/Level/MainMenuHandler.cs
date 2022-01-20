using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{
    
    void Start()
    {
        if(PlayerPrefs.GetInt("FirstTimeOpen") == 0)
        {
            SceneManager.LoadScene("PlayerPrefs");
        } 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
