using UnityEngine;
using System.Collections;

public class SoundSpeedBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    GameController.SkullMoved += SkullMoved;
	}

    private void SkullMoved(float value){
        gameObject.GetComponent<AudioSource>().pitch = 1 + Mathf.Abs(value)/7;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
