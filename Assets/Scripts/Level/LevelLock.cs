using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelLock : MonoBehaviour
{
    public int levelRequirement;
    private int currentLevel;
    private bool levelUnlocked;
    public void Start(){
        PlayerPrefs.SetInt("CurrentPlaying", 0);
        currentLevel = PlayerPrefs.GetInt("CompletedLevel");
        Debug.Log("" + currentLevel);
        levelUnlocked = currentLevel >= levelRequirement;
        GetComponent<Button>().interactable = levelUnlocked;
    }
}
