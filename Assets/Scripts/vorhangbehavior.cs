using UnityEngine;
using System.Collections;

public class vorhangbehavior : MonoBehaviour {
    public GameObject links1;
    public GameObject links2;
    public GameObject rechts1;
    public GameObject rechts2;
    private bool startPressed = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        for (int i = 1; i <= 11; i++)
        {
            if (Input.GetKeyDown("joystick " + i + " button 7"))
            {
                startPressed = true;
            }
            if (startPressed) {
                links1.transform.Translate(Vector3.left * 0.01f);
                links2.transform.Translate(Vector3.left * 0.01f);
                rechts1.transform.Translate(Vector3.right * 0.01f);
                rechts2.transform.Translate(Vector3.right * 0.01f);
                if (rechts2.transform.position.x >= 15) {
                    Application.LoadLevel("scene");
                }
            }
        }
	
	}
}
