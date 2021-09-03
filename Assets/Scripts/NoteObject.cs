using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    public bool canBePressed;
    private string state;
    public KeyCode keyToPress;
    public AudioSource audioSource;

    void Update() {
        if(Input.GetKeyDown(keyToPress))
        {
            if(canBePressed)
            {
                audioSource.Play();
                gameObject.SetActive(false);
                switch(state)
                {
                    case "perfect":
                        ScoringSystem.totalPoint+=50;
                        break;
                    case "almost":
                        ScoringSystem.totalPoint+=25;
                        break;
                }
                PointerHandler.state = state;
            }
        }    
    }

    private void OnTriggerEnter2D(Collider2D other) {
        
        if(other.tag == "PerfectPointer")
        {
            canBePressed = true;
            state = "perfect";
        } 
        else if (other.tag == "AlmostPointer")
        {
            canBePressed = true;
            state = "almost";
        }
        else if (other.tag == "MissPointer")
        {
            canBePressed = false;
            PointerHandler.state = "miss";
            ScoringSystem.totalPoint-=25;
        }
    }

}
