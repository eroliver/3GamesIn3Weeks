using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintBrush : MonoBehaviour
{
    private Color[] colorOptions = new Color[4];
    private Color activeColor;
    [SerializeField]
    private Camera gameCamera;  


    // Start is called before the first frame update
    void Start()
    {
        activeColor = Color.green;
        //gameCamera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetPaintableArea();
        }
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

    public void GetPaintableArea()
    {
        Ray ray = gameCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        Transform objectClicked = null;
        Color clickedObjectColor = Color.white;
        if (Physics.Raycast(ray, out hit))
        {
            objectClicked = hit.transform;
            clickedObjectColor = objectClicked.gameObject.GetComponent<SpriteRenderer>().color;
            Debug.Log("click");
            if (objectClicked.tag == "paintable")
            {
                clickedObjectColor = activeColor;
            }
        }
        

    }
}
