using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintBrush : MonoBehaviour
{
    private Color[] colorOptions = new Color[4];
    private Color activeColor;
    private Camera gameCamera;


    // Start is called before the first frame update
    void Start()
    {
        activeColor = Color.white;
        gameCamera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeColor()
    {
        if (true)
        {
            SpriteRenderer chosenPaint = GetComponent<SpriteRenderer>();
            Color chosenColor = chosenPaint.color;
            activeColor = chosenColor;
        }
    }
}
