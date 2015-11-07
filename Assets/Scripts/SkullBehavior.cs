using UnityEngine;
using System.Collections;

public class SkullBehavior : MonoBehaviour {
    public string posi;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (posi == "left") {
            Debug.Log("Die Goetter verschonen Player2");
            GameObject.Find("PipelineLeft").GetComponent<PipelineBehavior>().running = false;
            GameObject.Find("PipelineRight").GetComponent<PipelineBehavior>().running = false;
            GameController cam = GameObject.Find("Main Camera").GetComponent<GameController>();
            cam.SkullMalus = 0;
            cam.finishScreen(2);

        }
        else if (posi == "right") {
            Debug.Log("Die Goetter verschonen Player1");
            GameObject.Find("PipelineLeft").GetComponent<PipelineBehavior>().running = false;
            GameObject.Find("PipelineRight").GetComponent<PipelineBehavior>().running = false;
            GameController cam = GameObject.Find("Main Camera").GetComponent<GameController>();
            cam.SkullMalus = 0;
            cam.finishScreen(1);
        }
    }
}
