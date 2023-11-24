using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugInteractable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void DebugInteraction(string text)
	{
		Debug.Log(text);
	}
}
