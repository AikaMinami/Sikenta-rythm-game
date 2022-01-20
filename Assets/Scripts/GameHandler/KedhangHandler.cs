using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KedhangHandler : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public KeyCode keyToPress;
    public Sprite kendhangNormal;
    public Sprite kendhangPressed;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(keyToPress)){
            spriteRenderer.sprite = kendhangPressed;
        }
        if(Input.GetKeyUp(keyToPress)){
            spriteRenderer.sprite = kendhangNormal;
        }
    }
}
