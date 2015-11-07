using UnityEngine;
using System.Collections;

public class ShakeBehaviour : MonoBehaviour {

	private float intervall = 0.1f;
	private float stopTime;
	private float time;
	private bool shaking;

	private Quaternion prevRotation;
	private Vector3 prevPosition;

	private float amount = 1;

	void Start(){
		prevPosition = transform.position;
		prevRotation = transform.rotation;
	}

	// Update is called once per frame
	void Update () {
		if (shaking && Time.realtimeSinceStartup - time >= intervall) {
			transform.Rotate(new Vector3(0,0, Random.Range(-amount,amount)));
			transform.position = prevPosition + new Vector3(Random.Range(-amount/10,amount/10), Random.Range(-amount/10,amount/10), prevPosition.z);
			time = Time.realtimeSinceStartup;
		}

		if (Time.realtimeSinceStartup >= stopTime) {
			shaking = false;
			transform.rotation = prevRotation;
			transform.position = prevPosition;
		}

		if(Input.GetKeyUp (KeyCode.S)){
			Shake (0.5f);
		}
	}

	public void Shake(float seconds, float amount = 1.0f){
        if (!shaking)
        {
            this.amount = amount;
            prevRotation = transform.rotation;
            prevPosition = transform.position;
            stopTime = Time.realtimeSinceStartup + seconds;
            shaking = true;
        }
        else
        {
            stopTime = Time.realtimeSinceStartup + seconds;
        }
        
	}
}
