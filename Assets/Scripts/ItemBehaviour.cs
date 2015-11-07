using UnityEngine;
using System.Collections;

public class ItemBehaviour : MonoBehaviour {
    public GameObject pipeline;
    float speed = 30f;
    public bool floating;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
       /* int comb = pipeline.GetComponent<PipelineBehavior>().currentCombo;

        if (5 <= comb && comb >= 9)
        {
            GetComponent<SpriteRenderer>().sprite = Resources.Load("trank", typeof(Sprite)) as Sprite;
        }
        if (10 <= comb && comb >= 19)
        {
            GetComponent<SpriteRenderer>().sprite = Resources.Load("trank", typeof(Sprite)) as Sprite;
        }
        * */
        if (floating)
        {
            gameObject.transform.Rotate(0, 0, -1f);
        }
	}
}
