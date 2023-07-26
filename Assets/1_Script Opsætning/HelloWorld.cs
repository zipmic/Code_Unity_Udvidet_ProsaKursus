using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello world....  i start");
    }

    // Update is called once per frame
    void Update()
    {
		Debug.Log("Hello world....  i Update");
	}

	private void FixedUpdate()
	{
		// Bliver kaldt ved hver fixed frame (60 gange i sekundet)
	}

	private void LateUpdate()
	{
		// Kaldes hver frame som Update, men kommer efter alt i Update er lavet
	}
}
