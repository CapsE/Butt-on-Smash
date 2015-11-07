using UnityEngine;
using System.Collections;

public class ItemBehaviour : MonoBehaviour {
    float speed = 30f;
    public bool floating;
    public int level = 1;
    public bool righttoleft;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (floating && righttoleft)
        {
            gameObject.transform.Rotate(0, 0, -1f);
        }
        if (floating && !righttoleft)
        {
            gameObject.transform.Rotate(0, 0, 1f);
        }
        if (transform.position.y <= -5)
        {
            Destroy(gameObject);
        }
	}

   
}
