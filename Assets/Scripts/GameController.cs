using UnityEngine;
using System.Collections;
using System;

public class GameController : MonoBehaviour {
    public GameObject Skull;
    public GameObject PipelineLeft;
    public GameObject PipelineRight;
    public float SkullSpeed;
    public float SkullMalus;
    public float speedInc;
    public float intervallInc;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        PipelineLeft.GetComponent<PipelineBehavior>().speed = Math.Abs(Skull.transform.position.x)*speedInc + 0.12f;
        PipelineLeft.GetComponent<PipelineBehavior>().intervall = 0.5f - Math.Abs(Skull.transform.position.x) * intervallInc;
        PipelineRight.GetComponent<PipelineBehavior>().speed = Math.Abs(Skull.transform.position.x) * speedInc + 0.12f;
        PipelineRight.GetComponent<PipelineBehavior>().intervall = 0.5f - Math.Abs(Skull.transform.position.x) * intervallInc;

	}

    public void MoveSkull(int player) {
        if (player == 1) {
            Skull.transform.Translate(Vector3.right * SkullSpeed);
        }
        if (player == 2)
        {
            Skull.transform.Translate(Vector3.left * SkullSpeed);
        }
    }
    public void MoveSkullMalus(int player)
    {
        if (player == 2)
        {
            Skull.transform.Translate(Vector3.right * SkullMalus);
        }
        if (player == 1)
        {
            Skull.transform.Translate(Vector3.left * SkullMalus);
        }
    }
}
