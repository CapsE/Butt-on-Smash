using UnityEngine;
using System.Collections;

public class ColliderTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log("collision");
    }
    void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Trigger");
    }
}
