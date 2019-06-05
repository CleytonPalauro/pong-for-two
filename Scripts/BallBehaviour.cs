using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    [Range(1f,10f)]
    public float ballSpeed = 5f;

    [Range(0f, 1f)]
    public float speedUp = 0f;

    private float xDirection;
    private float yDirection;

    void Start ()
    {
        xDirection = Random.Range(0, 2) == 0 ? -1 : 1;
        yDirection = Random.Range(0, 2) == 0 ? -1 : 1;

        GetComponent<Rigidbody>().velocity = new Vector3(ballSpeed * xDirection, ballSpeed * yDirection, 0f);
    }

    void Update () { }
}
