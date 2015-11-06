using UnityEngine;
using System.Collections;

public class FrameBehaviour : MonoBehaviour {


	public ParticleSystem emitter;
	private int min = 0;
	private int max = 30;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.A) && emitter.emissionRate > 0) {
			emitter.emissionRate -= 2;
		}
		if (Input.GetKeyUp (KeyCode.D) && emitter.emissionRate < 30) {
			emitter.emissionRate += 2;
		}
	}

	public void Increase(){
		if (emitter.emissionRate < max) {
			emitter.emissionRate += 2;
		}
	}

	public void Decrease(){
		if (emitter.emissionRate > min) {
			emitter.emissionRate -= 2;
		}
	}

	public void Set(int value){
		value = Mathf.Max (max, value);
		value = Mathf.Min(min, value);
		emitter.emissionRate = value;
	}
}
