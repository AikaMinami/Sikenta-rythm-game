using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public GameObject pointText;
    public static int totalPoint;
    public static int highScore;
    
    void Start() {
        highScore = PlayerPrefs.GetInt("highScore");
        totalPoint = 0;
    }
    void Update()
    {
        pointText.GetComponent<Text>().text = ""+totalPoint;
        PlayerPrefs.SetInt("score", totalPoint);

         if (totalPoint > highScore)
         {
            highScore = totalPoint;
            PlayerPrefs.SetInt ("highScore", highScore);
         }
 
    }
}
