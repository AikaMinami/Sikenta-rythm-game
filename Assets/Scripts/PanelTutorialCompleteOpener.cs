using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelTutorialCompleteOpener : MonoBehaviour
{
    public GameObject tutorialPanel;
    private int btnOpener = 0;
    // Start is called before the first frame update
    // if tutorial completed for the first time, show panel
    void Start()
    {
        btnOpener++;
        if(PlayerPrefs.GetInt("FirstClearTutorial", 1) == 1)
        {
            tutorialPanel.SetActive(true);
            PlayerPrefs.SetInt("FirstClearTutorial", 0);
        }
    }


    public void CloseTutorialPanel(){
        if(btnOpener%2==0){
            tutorialPanel.SetActive(false);
        } else {
            tutorialPanel.SetActive(true);
        }
    }
}
