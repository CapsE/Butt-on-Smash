using UnityEngine;
using System.Collections;

public class SkullBehaviour : MonoBehaviour {

	public GameObject skullMagic;
	public float effectMultiply = 8;

	// Use this for initialization
	void Start () {
		GameController.SkullMoved += SkullMoved;
	}
	
	void SkullMoved(float value){
		skullMagic.GetComponent<ParticleBehaviour>().SetValue(Mathf.Abs(value) * effectMultiply);
	}
}
