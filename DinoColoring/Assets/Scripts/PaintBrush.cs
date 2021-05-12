using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintBrush : MonoBehaviour
{
    public static PaintBrush paintBrush = null;
    private Color activeColor = Color.white;
    private void Awake()
    {
        if (paintBrush == null)
        {
            paintBrush = this;
        }
        else if (paintBrush != this)
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }


    public void SetActiveColor(Color color)
    {
        activeColor = color;
    }

    public Color GetActiveColor()
    {
        return activeColor;
    }
}
