using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerConfiguration : MonoBehaviour
{
    public GameObject leftPad;
    public GameObject rightPad;

    public string wasd = "WASD";
    public string arrows = "Vertical";
    public string mouseY = "Mouse Y";
    public string scrollWheel = "Mouse ScrollWheel";
    public string gamepadOne = "WASD";
    public string gamepadTwo = "Vertical";
    public string gamepadSplit = "Split";

    void Start () { }

    void Update () { }
    
    public void ConfigOne()
    {
        leftPad.GetComponent<PaddleBehaviour>().inputAxis = wasd;
        rightPad.GetComponent<PaddleBehaviour>().inputAxis = arrows;
    }

    public void ConfigTwo()
    {
        leftPad.GetComponent<PaddleBehaviour>().inputAxis = arrows;
        rightPad.GetComponent<PaddleBehaviour>().inputAxis = mouseY;
    }

    public void ConfigThree()
    {
        leftPad.GetComponent<PaddleBehaviour>().inputAxis = arrows;
        rightPad.GetComponent<PaddleBehaviour>().inputAxis = scrollWheel;
    }

    public void ConfigFour()
    {
        leftPad.GetComponent<PaddleBehaviour>().inputAxis = gamepadOne;
        rightPad.GetComponent<PaddleBehaviour>().inputAxis = gamepadTwo;
    }

    public void ConfigFive()
    {
        leftPad.GetComponent<PaddleBehaviour>().inputAxis = gamepadOne;
        rightPad.GetComponent<PaddleBehaviour>().inputAxis = gamepadSplit;
    }
}