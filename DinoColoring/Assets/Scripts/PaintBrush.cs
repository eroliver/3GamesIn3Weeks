using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintBrush : MonoBehaviour
{
    public static PaintBrush paintBrush = null;
    private Color activeColor = Color.white;
    private SpriteRenderer brush = null;
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
        brush = gameObject.transform.Find("PaintRoller").Find("Brush").GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }


    public void SetActiveColor(Color color)
    {
        activeColor = color;
        brush.color = color;
    }

    public Color GetActiveColor()
    {
        return activeColor;
    }
}
