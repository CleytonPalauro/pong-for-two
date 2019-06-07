using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUrl : MonoBehaviour
{
    public string address;

	void Start () { }
	
	void Update () { }

    public void OpenAddress()
    {
        Application.OpenURL(address);
    }

    public void OpenAddress(string weblink)
    {
        Application.OpenURL(weblink);
    }
}
