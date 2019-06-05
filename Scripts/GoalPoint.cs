using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalPoint : MonoBehaviour
{
    public string ballTag;

    public enum Side
    {
        leftgoal,
        rightgoal
    }

    public Side goalside;

    void Start () { }
    
    void Update () { }

    private void OnCollisionEnter(Collision myCollision)
    {
        if (myCollision.gameObject.CompareTag(ballTag))
        {
            if(goalside == Side.leftgoal)
            {
                PointManager.pointRight++;
            }
            else
            {
                PointManager.pointLeft++;
            }

            myCollision.gameObject.transform.position = new Vector3(0f, 0f, 0f);
        }
    }
}
