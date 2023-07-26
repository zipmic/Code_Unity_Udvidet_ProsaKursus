using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Rigidbody RB;
    public float Speed;
    public float JumpForce;
    private Vector3 _movement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Vi får vores retning fra A/D eller venstre/højre fra inputsystemet
        _movement = new Vector3(Input.GetAxis("Horizontal"), 0, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            RB.AddForce(Vector3.up * JumpForce);
		}
    }

	private void FixedUpdate()
	{
		RB.AddForce(_movement * Speed * Time.fixedDeltaTime);
	}
}


