using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointManager : MonoBehaviour
{
    public Text pointLeftText;
    public Text pointRightText;

    public static int pointLeft = 0;
    public static int pointRight = 0;

    void Start () { }

    void Update ()
    {
        UpdateScore();
    }

    public void UpdateScore()
    {
        pointLeftText.text = pointLeft.ToString();
        pointRightText.text = pointRight.ToString();
    }
}
