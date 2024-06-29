using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CanvasPosition : MonoBehaviour
{

    [SerializeField] private GameObject camera, PanelText;

    [SerializeField] private int distance;

    public Transform target;

    public void placeCanvas()
    {
        this.transform.position = camera.transform.position + camera.transform.forward * distance;
    }

    public void assignText(string text)
    {
        TMP_Text mytext = PanelText.GetComponent<TMP_Text>();
        mytext.text = text;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
    }
}
