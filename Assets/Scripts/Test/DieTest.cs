using UnityEngine;
using System.Collections;

public class DieTest : MonoBehaviour {

	public GameObject effect;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp(KeyCode.W)){
			Effect dieEffect = new Effect(transform, effect, 1);
		}
	}
}
