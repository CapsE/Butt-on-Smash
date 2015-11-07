using UnityEngine;
using System.Collections;

public class ThunderBehaviour : MonoBehaviour {

	public AudioClip[] thunders;

	// Use this for initialization
	void Start () {
		AudioSource audio = gameObject.GetComponent<AudioSource> ();
		audio.clip = thunders [Random.Range (0, thunders.Length)];
		audio.Play ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
