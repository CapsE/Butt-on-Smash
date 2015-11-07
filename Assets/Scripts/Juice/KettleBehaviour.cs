using UnityEngine;
using System.Collections;

public class KettleBehaviour : MonoBehaviour {

	public float bubbleFactor = 2;

	// Use this for initialization
	void Start () {
		GameController.SkullMoved += SkullMoved;
	}

	void SkullMoved(float value){
		gameObject.GetComponent<ParticleBehaviour> ().SetValue (value * bubbleFactor);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
