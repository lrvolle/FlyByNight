using UnityEngine;
using System.Collections;

public class BatControl : MonoBehaviour {
    
    public float movementSpeed = 10f;

    void Awake()
    {

    }

	// Use this for initialization
	void Start () {
	    
	}

    void ProcessInput()
    {
        float movement = Input.GetAxis("Vertical");
        transform.position += transform.forward * movement * movementSpeed * Time.deltaTime;
    }
	
	// Update is called once per frame
	void Update () {
        ProcessInput();
    }

    void FixedUpdate()
    {

    }
}
