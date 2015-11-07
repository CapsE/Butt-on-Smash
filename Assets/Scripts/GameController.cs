using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
    public GameObject Skull;
    public GameObject PipelineLeft;
    public GameObject PipelineRight;
    public float SkullSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
	
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
}
