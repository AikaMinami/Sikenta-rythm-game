using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefConfirm : MonoBehaviour
{
    public GameObject Panel;
    public bool openMenuPanel;
    private int btnOpener = 0;
    public void OpenPanel(){
        btnOpener++;
        if(btnOpener%2==0){
            openMenuPanel = false;
        } else {
            openMenuPanel = true;
        }
        Panel.SetActive(openMenuPanel);
    }
}
