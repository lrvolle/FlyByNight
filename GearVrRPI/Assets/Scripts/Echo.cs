using UnityEngine;
using System.Collections;

public class Echo : MonoBehaviour {

    public AudioClip sound;
    public GameObject hitLight;
    public float lightDistFromImpact = 5;

	// Use this for initialization
	void Awake () {
        Destroy(gameObject, 4f);
	}

    void OnCollisionEnter(Collision c)
    {
        //GetComponent<TrailRenderer>().enabled = true;
        Vector3 norm = c.contacts[0].normal * lightDistFromImpact;
        Vector3 pos = c.contacts[0].point;
        Debug.DrawRay(pos, norm);
        GameObject l = Instantiate(hitLight, pos + norm, Quaternion.LookRotation(-norm)) as GameObject;
        Destroy(l, 2);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
