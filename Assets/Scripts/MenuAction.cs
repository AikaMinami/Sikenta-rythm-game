using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuAction : MonoBehaviour
{
    public void MENU_ACTION_GoToPage(string sceneName){
        SceneManager.LoadScene(sceneName);
    }
    public void RestartGame(string sceneName){
        SceneManager.LoadScene(sceneName);
        NoteHandler.hasStarted = false;
        ScoringSystem.totalPoint = 0;
        NoteHandler.audioSource.Stop();
    }

    public void doExitGame() {
     Application.Quit();
    }

    public void currentPlayingLevel(int idx)
    {
        PlayerPrefs.SetInt("CurrentPlaying", idx);
    }
}
