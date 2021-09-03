using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerHandler : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite perfectPts;
    public Sprite goodPts;
    public Sprite missPts;
    public static string state;
    public KeyCode keyToPress;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(keyToPress))
        {
            switch(state)
                {
                    case "perfect":
                        StartCoroutine (ChangeKendhang (perfectPts) );
                        break;
                    case "almost":
                        StartCoroutine (ChangeKendhang (goodPts) );
                        break;
                    case "miss":
                        StartCoroutine (ChangeKendhang (missPts) );
                        break;
                }
        }
    }

    public IEnumerator ChangeKendhang (Sprite kendhangChange)
    {
        spriteRenderer.sprite = kendhangChange;
        yield return new WaitForSeconds (1.0f);
        spriteRenderer.sprite = null;
    }
    
}
