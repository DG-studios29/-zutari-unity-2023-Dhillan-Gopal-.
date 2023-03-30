using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeSpeed : MonoBehaviour
{
    public Slider speedSlider;
    public Movement moveCubeScript;
    public TextMeshProUGUI dispalySpeed;

    void Start()
    {
        //method will be called whenever the value of the slider changes.
        speedSlider.onValueChanged.AddListener(delegate { OnslidervalueChange(); });
        
    }

    public void OnslidervalueChange()
    {
        // change cude speed
        moveCubeScript.Cubespeed = speedSlider.value;
    }

    
    private void Update()
    {
        // show speed in text
        dispalySpeed.text = "Speed at: " + speedSlider.value.ToString("0");
    }
}


