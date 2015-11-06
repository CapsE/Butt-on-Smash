using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PipelineBehavior : MonoBehaviour {
    public float intervall;
    public GameObject[] buttons;
    private float time;
    public float spurbreite;
    public List<GameObject> activeButtons;

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
            activeButtons.Add(button);
            button.transform.parent = this.transform;
            button.transform.localPosition = new Vector3(spurbreite * buttonnr, 0, 0);
        }
	}

    void Update() {
        if (Input.GetKeyDown("joystick 1 button 0"))    //A
        {
            foreach(GameObject c in activeButtons){

            }
        }
        if (Input.GetKeyDown("joystick 1 button 1"))    //B
        {
            
        }
        if (Input.GetKeyDown("joystick 1 button 2"))    //X
        {
            
        }
        if (Input.GetKeyDown("joystick 1 button 3"))    //Y
        {
            
        }
        if (Input.GetKeyDown("joystick 2 button 0"))
        {
            Debug.Log("joy 2 but 0");
        }
    }
}
