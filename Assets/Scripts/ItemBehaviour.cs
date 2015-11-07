using UnityEngine;
using System.Collections;

public class ItemBehaviour : MonoBehaviour {
    public GameObject pipeline;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        int comb = pipeline.GetComponent<PipelineBehavior>().currentCombo;

        if (5 <= comb && comb >= 10)
        {

        }
	}
}
