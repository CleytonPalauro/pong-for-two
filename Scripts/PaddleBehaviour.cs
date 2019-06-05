using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleBehaviour : MonoBehaviour
{
    public string inputAxis;

    public string wallTag;

    [Range(1f, 10f)]
    public float padSpeed = 5f;

    [Range(1f, 10f)]
    public float limits = 4.5f;

    void Start () { }
	
	void Update ()
    {
        transform.Translate(0f, Input.GetAxis(inputAxis) * padSpeed * Time.deltaTime, 0f);
        
        Vector3 padtransform = transform.position;
        
        padtransform.y = Mathf.Clamp(padtransform.y, (limits * -1), limits);

        transform.position = padtransform;
    }
}
