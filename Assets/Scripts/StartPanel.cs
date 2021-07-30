using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPanel : MonoBehaviour
{
    public GameObject Panel;
    private bool closePanel;
    public void ClosePanel(){
       
        closePanel = false;
        
        Panel.SetActive(closePanel);

        NoteHandler.hasStarted = true;
        NoteHandler.audioSource.Play();
    }
}
