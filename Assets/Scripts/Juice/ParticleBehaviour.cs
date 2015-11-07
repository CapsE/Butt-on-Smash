using UnityEngine;
using System.Collections;

public class ParticleBehaviour : MonoBehaviour {

	public float min = 0;
	public float max = 30;

	private ParticleSystem emitter;


	// Use this for initialization
	void Start () {
		emitter = gameObject.GetComponent<ParticleSystem> ();
	}
	
	public void Increase(){
		if (emitter.emissionRate < max) {
			emitter.emissionRate += 2.0f;
		}
	}
	
	public void Decrease(){
		if (emitter.emissionRate > min) {
			emitter.emissionRate -= 2.0f;
		}
	}
	
	public void SetValue(float value){
		value = Mathf.Min (max, value);
		value = Mathf.Max(min, value);
		Debug.Log ("Setting Particle to " + value);
		emitter.emissionRate = value;
	}
}
