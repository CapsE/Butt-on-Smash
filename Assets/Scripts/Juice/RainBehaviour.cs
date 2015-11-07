using UnityEngine;
using System.Collections;

public class RainBehaviour : MonoBehaviour {
	
	public float intervall = 0.15f;
	public GameObject[] rain0;
	public GameObject[] rain1;

	public GameObject lightningEffect;
	public GameObject thunderEffect;
	public float lightningChanceLow = 1;
	public float lightningChanceHigh = 5;

	private float lightningChance;

	private float time = -1;
	private int currentArray = 0;
	private int current = 0;
	private GameObject[][] rain;

	// Use this for initialization
	void Start () {
		time = Time.realtimeSinceStartup;
		lightningChance = lightningChanceLow;
		rain = new GameObject[2][];
		rain [0] = rain0;
		rain [1] = rain1;
		GameController.SkullMoved += SkullMoved;
	}
	
	// Update is called once per frame
	void Update () {
		if (time != -1 && Time.realtimeSinceStartup - time >= intervall) {
			Switch();
			time = Time.realtimeSinceStartup;
		}
		if (Input.GetKeyDown (KeyCode.A)) {
			SkullMoved(0.7f);
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			SkullMoved(0.2f);
		}
	}

	private void SkullMoved(float value){
		value = Mathf.Abs (value);
		if (value >= 0.75f) {
			currentArray = 1;
			lightningChance = lightningChanceHigh;
			gameObject.GetComponent<AudioSource>().pitch = 1.5f;
			foreach(GameObject go in rain[0]){
				go.SetActive(false);
			}
		} else {
			currentArray = 0;
			lightningChance = lightningChanceLow;
			gameObject.GetComponent<AudioSource>().pitch = 1.0f;
			foreach(GameObject go in rain[1]){
				go.SetActive(false);
			}
		}
	}

	private void Switch(){
		current++;
		if (current >= rain[currentArray].Length) {
			current = 0;
		}
		for(int i = 0; i < rain[currentArray].Length; i++) {
			if(i == current){
				rain[currentArray][i].SetActive(true);
			}else{
				rain[currentArray][i].SetActive(false);
			}
		}
		if (Random.Range (0.0f, 100.0f) <= lightningChance) {
			Effect e = new Effect(new Vector3(1,-1.4f,0.5f), lightningEffect, 0.3f);
			Effect t = new Effect(transform.position, thunderEffect, 2.3f);
		}
	}
}
