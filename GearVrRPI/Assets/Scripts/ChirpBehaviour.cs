using UnityEngine;
using System.Collections;

public class ChirpBehaviour : MonoBehaviour {
    //initialize vars
    public Rigidbody chirp;
    public float force = 20f;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetButtonDown("AButton"))
        {
            Rigidbody newChirp = Instantiate(chirp, 
                transform.position, transform.rotation) as Rigidbody;

            newChirp.AddForce(newChirp.transform.forward * force);
        }
	}
}
