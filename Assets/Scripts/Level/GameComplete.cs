using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameComplete : MonoBehaviour
{

    public GameObject scoreText;
    public GameObject highScoreText;
    void Start()
    {
        scoreText.GetComponent<Text>().text = "" + PlayerPrefs.GetInt("score");
        highScoreText.GetComponent<Text>().text = "" + PlayerPrefs.GetInt("highScore");
    }
}
