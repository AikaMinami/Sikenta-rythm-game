using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    public bool canBePressed;
    private string state;
    public KeyCode keyToPress;
    public AudioSource audioSource;
    public AudioSource audioMissSource;
    public SpriteRenderer score;
    private SpriteRenderer spriteRenderer;
    public Sprite pointBt, pressedPts, perfectPts, goodPts, missPts;

    void Start() {
         spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Update() {
        if(Input.GetKeyDown(keyToPress))
        {
            if(canBePressed)
            {
                audioSource.Play();
                switch(state)
                {
                    case "perfect":
                        ScoringSystem.totalPoint+=100;
                        StartCoroutine (ChangePoint(perfectPts) );
                        break;
                    case "almost":
                        ScoringSystem.totalPoint+=50;
                        StartCoroutine (ChangePoint(goodPts) );
                        break;
                }
                gameObject.SetActive(false);
            }
        }    
    }

    private void OnTriggerEnter2D(Collider2D other) {
            if(other.tag == "PerfectPointer")
            {
                canBePressed = true;
                state = "perfect";
            } 
            if (other.tag == "AlmostPointer")
            {
                canBePressed = true;
                state = "almost";
            }
            if (other.tag == "MissPointer")
            {
                canBePressed = false;
                ScoringSystem.totalPoint-=25;
                StartCoroutine (ChangePoint(missPts) );
                gameObject.SetActive(false);
                audioMissSource.Play(); 
            }
    }


    public IEnumerator ChangePoint(Sprite pointPts)
    {
        score.sprite = pointPts;
        yield return new WaitForSeconds (1.0f);
        score.sprite = null;
    }

}
