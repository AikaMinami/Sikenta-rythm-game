using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPanelOpener : MonoBehaviour
{
    public GameObject Panel;
    public GameObject PanelTutorial;
    public static bool openMenuPanel;
    public bool openTutorialPanel;
    private int btnOpener = 0;
    private int pnlOpener = 0;
    public void OpenPanel(){
        btnOpener++;
        if(btnOpener%2==0){
            openMenuPanel = false;
            NoteHandler.audioSource.UnPause();
        } else {
            openMenuPanel = true;
            NoteHandler.audioSource.Pause();
        }
        Panel.SetActive(openMenuPanel);
    }

    public void PanelHandler(){
        pnlOpener++;
        if(pnlOpener%2==0){
            openTutorialPanel = false;
        } else {
            openTutorialPanel = true;
        }
        PanelTutorial.SetActive(openTutorialPanel);
    }
}
