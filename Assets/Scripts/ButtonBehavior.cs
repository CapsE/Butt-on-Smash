using UnityEngine;
using System.Collections;

public class ButtonBehavior : MonoBehaviour {
    public Sprite graphicstype;
    public string buchstabe;
    public string type;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.Translate(Vector3.down * transform.parent.GetComponent<PipelineBehavior>().speed);
        if (transform.position.y <= -4.7) {
            transform.parent.GetComponent<PipelineBehavior>().activeButtons.Remove(gameObject);
            if (transform.parent.GetComponent<PipelineBehavior>().player == 1)
            {
                GameObject.Find("Main Camera").GetComponent<GameController>().MoveSkullMalus(1);
            }
            else {
                GameObject.Find("Main Camera").GetComponent<GameController>().MoveSkullMalus(2);
            }
            Destroy(gameObject);
        }
	}
}
