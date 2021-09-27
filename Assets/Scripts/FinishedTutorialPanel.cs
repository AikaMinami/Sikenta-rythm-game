using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishedTutorialPanel : MonoBehaviour
{
    // Start is called before the first frame update
    public Image myImage;
    public GameObject dialogueText;
     
    public Sprite boySprite;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        dialogueText.GetComponent<Text>().text = "Kerja bagus " + PlayerPrefs.GetString("username") +"! Kita coba level lain yuk!";

        if(PlayerPrefs.GetString("Gender").Equals("boy")){
            myImage.sprite = boySprite;
        }
    }
 
}
