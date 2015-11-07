using UnityEngine;
using System.Collections;

public class LightningStrikeBehaviour : MonoBehaviour {

	public GameObject lightningStrike;
	public GameObject smoke;
	public GameObject sound;
	public GameObject background;

	public float smokeHeight = 3.8f;

	// Use this for initialization
	void Start () {
		Effect e = new Effect (transform.position, lightningStrike, 0.5f);
		e = new Effect (transform.position + Vector3.down*smokeHeight, smoke, 5);
		e = new Effect (transform.position, sound, 3);
		e = new Effect (new Vector3(0,0,0), background, 0.5f);
	}
	
	// Update is called once per frame
	void Update () {
	}
}
