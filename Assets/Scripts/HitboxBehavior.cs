using UnityEngine;
using System.Collections;

public class HitboxBehavior : MonoBehaviour {
    public int position;
    public int topf; //0 ist links, 1 ist rechts

    public GameObject dropEffect;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        GameController gc = GameObject.Find("Main Camera").GetComponent<GameController>();
        if (topf == 0)
        {
            if (coll.gameObject.name == "player2wurf")
            {
                Debug.Log("Kollision an Topf Links " + position + " mit level " + coll.gameObject.GetComponent<ItemBehaviour>().level);
                Debug.Log(coll.gameObject.name);
                //GameObject.Find("Main Camera").GetComponent<GameController>().MoveSkull(player);
                
                if (!GameObject.Find("Player").GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("blocken")) {
                    if (coll.gameObject.GetComponent<ItemBehaviour>().level == 1) {
                        gc.MoveSkull(2);
                        gc.MoveSkull(2);
                        gc.MoveSkull(2);
                        gc.MoveSkull(2);
                        gc.MoveSkull(2);
                        Effect e = new Effect(transform.position, dropEffect, 4);
                    }
                }
                Destroy(coll.gameObject); //TODO effekt?   
            }
        }
        else {
            if (coll.gameObject.name == "player1wurf")
            {
                Debug.Log("Kollision an Topf Rechts " + position + " mit level " + coll.gameObject.GetComponent<ItemBehaviour>().level);
                Debug.Log(coll.gameObject.name);
                
                if (!GameObject.Find("Player (1)").GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("blocken2"))
                {
                    if (coll.gameObject.GetComponent<ItemBehaviour>().level == 1)
                    {
                        gc.MoveSkull(1);
                        gc.MoveSkull(1);
                        gc.MoveSkull(1);
                        gc.MoveSkull(1);
                        gc.MoveSkull(1);
                        Effect e = new Effect(transform.position, dropEffect, 4);
                    }
                }
               
                Destroy(coll.gameObject); //TODO effekt?
            }
        }
    }
}
