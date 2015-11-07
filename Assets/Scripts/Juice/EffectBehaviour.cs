using UnityEngine;
using System.Collections;

public class EffectBehaviour : MonoBehaviour {
		
	public float delay = 1;
	
	private float time = -1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (time != -1 && Time.realtimeSinceStartup - time >= delay) {
			Destroy(gameObject);
		}
	}

	public void SetDelay(float delay){
		this.delay = delay;
		this.time = Time.realtimeSinceStartup;
	}
}
