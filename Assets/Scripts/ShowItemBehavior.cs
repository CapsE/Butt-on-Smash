using UnityEngine;
using System.Collections;

public class ShowItemBehavior : MonoBehaviour {
    public GameObject pipeline;
    public int currentitem = 0; //Value represents current Level of Players Item, 0 means no Item
    public int itemcount = 0;
    public Sprite level0;
    public Sprite level1;
    public Sprite level2;
    public Sprite level3;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        int comb = pipeline.GetComponent<PipelineBehavior>().currentCombo;
        if(currentitem == 0){
            GetComponent<SpriteRenderer>().sprite = level0;
        }

        if (5 <= comb && comb <= 9 && currentitem < 1)
        {
            itemcount = 1;
            currentitem++;
            Debug.Log("Item Level Up 1");
            currentitem = 1;
            GetComponent<SpriteRenderer>().sprite = level1;
        }
        if (10 <= comb && comb <= 19 && currentitem < 2)
        {
            Debug.Log("Item Level Up 2");
            currentitem = 2;
            GetComponent<SpriteRenderer>().sprite = level2;
        }
        if (20 <= comb && comb <= 25 && currentitem < 3)
        {
            Debug.Log("Item Level Up 3");
            currentitem = 3;
            GetComponent<SpriteRenderer>().sprite = level3;
        }
        
	}
}
