using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NoteHandler : MonoBehaviour
{
    public float beatTempo;
    public static bool hasStarted;
    
    public AudioSource auSource;
    public static AudioSource audioSource;


    void Start()
    {
        hasStarted = false;
        beatTempo = beatTempo/60f;
        audioSource = auSource;
    }

    void Update()
    {
        if(hasStarted)
        {
            if(MenuPanelOpener.openMenuPanel)
            {
                Time.timeScale = 0f;
                // transform.position -= new Vector3(0f, 0f, 0f);
                // Per tung tung tung dah 2,5 bar
            } 
            else 
            {
                if(!audioSource.isPlaying)
                {
                    PlayerPrefs.SetInt("CompletedLevel", PlayerPrefs.GetInt("CurrentPlaying"));
                    PlayerPrefs.SetInt("CurrentPlaying", 0);
                    SceneManager.LoadScene("LevelComplete");
                }
                Time.timeScale = 1f;
                transform.position -= new Vector3(0f, beatTempo * Time.deltaTime, 0f);
            }

            
        } 
    }
}
