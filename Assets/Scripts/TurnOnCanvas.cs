using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class TurnOnCanvas : MonoBehaviour

{
    [SerializeField]
    GameObject canvas;


    [SerializeField]
    string textbox;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            canvas.SetActive(true);

            canvas.GetComponent<CanvasPosition>().placeCanvas();
            textbox = textbox.Replace("\\n", "\n");
            canvas.GetComponent<CanvasPosition>().assignText(textbox);

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
}
