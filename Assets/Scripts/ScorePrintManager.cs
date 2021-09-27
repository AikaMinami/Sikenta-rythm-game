// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class ScorePrintManager : MonoBehaviour
// {
//     public SpriteRenderer takPts;
//     public SpriteRenderer tungPts;
//     public SpriteRenderer dahPts;
    
//     public Sprite perfectPts;
//     public Sprite goodPts;
//     public Sprite missPts;


//     private void OnTriggerEnter2D(Collider2D other) {

//         switch (other.tag){
//             case "Tak":
//                 Debug.Log("Tak");
//                 StartCoroutine (ChangePoint(takPts, NoteObject.pressedPts) );
//                 break;
//             case "Tung":
//                 Debug.Log("TUng");
//                 StartCoroutine (ChangePoint(tungPts, NoteObject.pressedPts) );
//                 break;
//             case "Dah":
//                 Debug.Log("Dah");
//                 StartCoroutine (ChangePoint(dahPts, NoteObject.pressedPts) );
//                 break;
//         }
//     }


//     public IEnumerator ChangePoint(SpriteRenderer pressed, Sprite pointPts)
//     {
//         pressed.sprite = pointPts;
//         yield return new WaitForSeconds (1.0f);
//         pressed.sprite = null;
//     }

// }