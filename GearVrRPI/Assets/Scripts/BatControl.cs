using UnityEngine;
using System.Collections;

public class BatControl : MonoBehaviour {
    
    public float movementSpeed = 10f;

    CharacterController _controller;

    void Awake()
    {
        _controller = GetComponent<CharacterController>();
    }

	// Use this for initialization
	void Start () {
	    
	}

    void ProcessInput()
    {
        float movement = Input.GetAxis("Vertical");
        _controller.Move(transform.forward * movementSpeed * Time.deltaTime);
    }
	
	// Update is called once per frame
	void Update () {
        ProcessInput();
    }

    void FixedUpdate()
    {

    }
}
