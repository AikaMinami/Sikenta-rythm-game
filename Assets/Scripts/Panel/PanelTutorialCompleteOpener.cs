using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PanelTutorialCompleteOpener : MonoBehaviour
{
    public GameObject tutorialPanel;
    public GameObject tutorialScdPanel;
    public GameObject textPanelComplete;
    // private int btnOpener = 0;
    private int completedLevel = 0;
    public Image myImage;
    public Sprite boyImage;
    public Sprite girlImage;
    private string spriteType;

    void Start()
    {
        if(PlayerPrefs.GetInt("FirstClearTutorial") == 1)
        {
            textPanelComplete.GetComponent<Text>().text = "Kerja bagus " + PlayerPrefs.GetString("username") + "! \nKita coba level lain yuk!";
            tutorialPanel.SetActive(true);
        }
    }


    public void CloseTutorialPanel(){
        tutorialScdPanel.SetActive(false);
        SetTutorialValue();
    }

    public void OpenNextPanel(){
        tutorialPanel.SetActive(false);
        ChangeImage();
        tutorialScdPanel.SetActive(true);
    }
    public void SetTutorialValue(){
        completedLevel= PlayerPrefs.GetInt("FirstClearTutorial") + 1;
        PlayerPrefs.SetInt("FirstClearTutorial", completedLevel);
    }

    public void ChangeImage (){
        if(PlayerPrefs.GetString("gender") == "boy"){
            myImage.sprite = boyImage;
        } else if(PlayerPrefs.GetString("gender") == "girl"){
            myImage.sprite = girlImage;
        }
    }
}


