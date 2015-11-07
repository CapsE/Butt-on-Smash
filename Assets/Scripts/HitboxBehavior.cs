using UnityEngine;
using System.Collections;

public class HitboxBehavior : MonoBehaviour {
    public int position;
    public int topf; //0 ist links, 1 ist rechts


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (topf == 0)
        {
            if (coll.gameObject.name == "player2wurf")
            {
                Debug.Log("Kollision an Topf Links " + position + " mit level " + coll.gameObject.GetComponent<ItemBehaviour>().level);
                Debug.Log(coll.gameObject.name);
                //GameObject.Find("Main Camera").GetComponent<GameController>().MoveSkull(player);
                Destroy(coll.gameObject); //TODO effekt?
            }
        }
        else {
            if (coll.gameObject.name == "player1wurf")
            {
                Debug.Log("Kollision an Topf Rechts " + position + " mit level " + coll.gameObject.GetComponent<ItemBehaviour>().level);
                Debug.Log(coll.gameObject.name);
                Destroy(coll.gameObject); //TODO effekt?
            }
        }
    }
}
