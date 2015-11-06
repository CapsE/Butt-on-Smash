using UnityEngine;
using System.Collections;

public class PipelineBehavior : MonoBehaviour {
    public float intervall;
    public GameObject[] buttons;
    private float time;
    public float spurbreite;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        time += Time.deltaTime;
        if (time >= intervall) {
            time = 0;
            int buttonnr = Random.Range(0, 4);
            GameObject button = Instantiate(buttons[buttonnr]) as GameObject;
            button.transform.parent = this.transform;
            button.transform.localPosition = new Vector3(spurbreite * buttonnr, 0, 0);
        }
	}
}
