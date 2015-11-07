using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PipelineBehavior : MonoBehaviour {
    public float intervall;
    public GameObject[] buttons;
    private float time;
    public float spurbreite;
    public List<GameObject> activeButtons;
    public float maxArea = -3.83f;
    public float minArea = -4.324f;
    public GameObject ButtonArea;
    public int player;
    public float speed;
    public bool running = true;

    public int maxCombo;
    public int currentCombo;
    private int hits;
    private int misses;

    public GameObject effect;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (running)
        {
            time += Time.deltaTime;
            if (time >= intervall)
            {
                //Debug.Log(Input.GetJoystickNames().Length);

                time = 0;
                int buttonnr = Random.Range(0, 4);
                GameObject button = Instantiate(buttons[buttonnr]) as GameObject;
                activeButtons.Add(button);
                button.transform.parent = this.transform;
                button.transform.localPosition = new Vector3(spurbreite * buttonnr, 0, 0);
            }
        }
        else
        {
            foreach (GameObject go in activeButtons)
            {
                activeButtons.Remove(go);
                Destroy(go);
            }
        }
	}

    void Update() {
        bool hit = false;
        if(player == 1){
            for (int i = 1; i <= 11; i = i + 2)
            {

                if (Input.GetKeyDown("joystick " + i +" button 0"))    //A
                {

                    Debug.Log("player 1 but 0");
                    foreach (GameObject c in activeButtons)
                    {
                        if (c.GetComponent<ButtonBehavior>().type == "A")
                        {
                            if (c.GetComponent<BoxCollider2D>().IsTouching(ButtonArea.GetComponent<BoxCollider2D>()))
                            {
                                GameObject.Find("Main Camera").GetComponent<GameController>().MoveSkull(player);
                                Effect a = new Effect(c.transform, effect, 0.5f);
                                activeButtons.Remove(c);
                                Destroy(c);
                                hit = true;
                                hits++;
                                currentCombo++;
                                if (currentCombo > maxCombo)
                                {
                                    maxCombo = currentCombo;
                                }
                                break;
                            }
                        }
                    }
                    if (!hit)
                    {
                        misses++;
                        currentCombo = 0;
                        GameObject.Find("Main Camera").GetComponent<GameController>().MoveSkullMalus(player);
                    }
                }

                if (Input.GetKeyDown("joystick " + i + " button 1"))    //B
                {
                    Debug.Log("player 1 but 1");
                    foreach (GameObject c in activeButtons)
                    {
                        if (c.GetComponent<ButtonBehavior>().type == "B")
                        {
                            if (c.GetComponent<BoxCollider2D>().IsTouching(ButtonArea.GetComponent<BoxCollider2D>()))
                            {
                                GameObject.Find("Main Camera").GetComponent<GameController>().MoveSkull(player);
                                Effect a = new Effect(c.transform, effect, 0.5f);
                                activeButtons.Remove(c);
                                Destroy(c);
                                hit = true;
                                hits++;
                                currentCombo++;
                                if (currentCombo > maxCombo)
                                {
                                    maxCombo = currentCombo;
                                }
                                break;
                            }
                        }
                    }
                    if (!hit)
                    {
                        misses++;
                        currentCombo = 0;
                        GameObject.Find("Main Camera").GetComponent<GameController>().MoveSkullMalus(player);
                    }
                }
                if (Input.GetKeyDown("joystick " + i + " button 2"))    //X
                {
                    Debug.Log("player 1 but 2");
                    foreach (GameObject c in activeButtons)
                    {
                        if (c.GetComponent<ButtonBehavior>().type == "X")
                        {
                            if (c.GetComponent<BoxCollider2D>().IsTouching(ButtonArea.GetComponent<BoxCollider2D>()))
                            {
                                GameObject.Find("Main Camera").GetComponent<GameController>().MoveSkull(player);
                                Effect a = new Effect(c.transform, effect, 0.5f);
                                activeButtons.Remove(c);
                                Destroy(c);
                                hit = true;
                                hits++;
                                currentCombo++;
                                if (currentCombo > maxCombo)
                                {
                                    maxCombo = currentCombo;
                                }
                                break;
                            }
                        }
                    }
                    if (!hit)
                    {
                        misses++;
                        currentCombo = 0;
                        GameObject.Find("Main Camera").GetComponent<GameController>().MoveSkullMalus(player);
                    }
                }
                if (Input.GetKeyDown("joystick " + i + " button 3"))    //Y
                {
                    Debug.Log("palyer 1 but 3");
                    foreach (GameObject c in activeButtons)
                    {
                        if (c.GetComponent<ButtonBehavior>().type == "Y")
                        {
                            if (c.GetComponent<BoxCollider2D>().IsTouching(ButtonArea.GetComponent<BoxCollider2D>()))
                            {
                                GameObject.Find("Main Camera").GetComponent<GameController>().MoveSkull(player);
                                Effect a = new Effect(c.transform, effect, 0.5f);
                                activeButtons.Remove(c);
                                Destroy(c);
                                hit = true;
                                hits++;
                                currentCombo++;
                                if (currentCombo > maxCombo)
                                {
                                    maxCombo = currentCombo;
                                }
                                break;
                            }
                        }
                    }
                    if (!hit)
                    {
                        misses++;
                        currentCombo = 0;
                        GameObject.Find("Main Camera").GetComponent<GameController>().MoveSkullMalus(player);
                    }
                }

            }
        }
        else if (player == 2)
        {
            for (int i = 2; i <= 11; i = i + 2)
            {
                if (Input.GetKeyDown("joystick " + i + " button 0"))    //A
                {
                    Debug.Log("Player 2 but 0");
                    foreach (GameObject c in activeButtons)
                    {
                        if (c.GetComponent<ButtonBehavior>().type == "A")
                        {
                            if (c.GetComponent<BoxCollider2D>().IsTouching(ButtonArea.GetComponent<BoxCollider2D>()))
                            {
                                GameObject.Find("Main Camera").GetComponent<GameController>().MoveSkull(player);
                                Effect a = new Effect(c.transform, effect, 0.5f);
                                activeButtons.Remove(c);
                                Destroy(c);
                                hit = true;
                                hits++;
                                currentCombo++;
                                if (currentCombo > maxCombo)
                                {
                                    maxCombo = currentCombo;
                                }
                                break;
                            }
                        }
                    }
                    if (!hit)
                    {
                        misses++;
                        currentCombo = 0;
                        GameObject.Find("Main Camera").GetComponent<GameController>().MoveSkullMalus(player);
                    }
                }
                if (Input.GetKeyDown("joystick " + i + " button 1"))    //B
                {
                    Debug.Log("player 2 but 1");
                    foreach (GameObject c in activeButtons)
                    {
                        if (c.GetComponent<ButtonBehavior>().type == "B")
                        {
                            if (c.GetComponent<BoxCollider2D>().IsTouching(ButtonArea.GetComponent<BoxCollider2D>()))
                            {
                                GameObject.Find("Main Camera").GetComponent<GameController>().MoveSkull(player);
                                Effect a = new Effect(c.transform, effect, 0.5f);
                                activeButtons.Remove(c);
                                Destroy(c);
                                hit = true;
                                hits++;
                                currentCombo++;
                                if (currentCombo > maxCombo)
                                {
                                    maxCombo = currentCombo;
                                }
                                break;
                            }
                        }
                    }
                    if (!hit)
                    {
                        misses++;
                        currentCombo = 0;
                        GameObject.Find("Main Camera").GetComponent<GameController>().MoveSkullMalus(player);
                    }
                }
                if (Input.GetKeyDown("joystick " + i + " button 2"))    //X
                {
                    Debug.Log("player 2 but 2");
                    foreach (GameObject c in activeButtons)
                    {
                        if (c.GetComponent<ButtonBehavior>().type == "X")
                        {
                            if (c.GetComponent<BoxCollider2D>().IsTouching(ButtonArea.GetComponent<BoxCollider2D>()))
                            {
                                GameObject.Find("Main Camera").GetComponent<GameController>().MoveSkull(player);
                                Effect a = new Effect(c.transform, effect, 0.5f);
                                activeButtons.Remove(c);
                                Destroy(c);
                                hit = true;
                                hits++;
                                currentCombo++;
                                if (currentCombo > maxCombo)
                                {
                                    maxCombo = currentCombo;
                                }
                                break;
                            }
                        }
                    }
                    if (!hit)
                    {
                        misses++;
                        currentCombo = 0;
                        GameObject.Find("Main Camera").GetComponent<GameController>().MoveSkullMalus(player);
                    }
                }
                if (Input.GetKeyDown("joystick " + i + " button 3"))    //Y
                {
                    Debug.Log("player 2 but 3");
                    foreach (GameObject c in activeButtons)
                    {
                        if (c.GetComponent<ButtonBehavior>().type == "Y")
                        {
                            if (c.GetComponent<BoxCollider2D>().IsTouching(ButtonArea.GetComponent<BoxCollider2D>()))
                            {
                                GameObject.Find("Main Camera").GetComponent<GameController>().MoveSkull(player);
                                Effect a = new Effect(c.transform, effect, 0.5f);
                                activeButtons.Remove(c);
                                Destroy(c);
                                hit = true;
                                hits++;
                                currentCombo++;
                                if (currentCombo > maxCombo)
                                {
                                    maxCombo = currentCombo;
                                }
                                break;
                            }
                        }
                    }
                    if (!hit)
                    {
                        misses++;
                        currentCombo = 0;
                        GameObject.Find("Main Camera").GetComponent<GameController>().MoveSkullMalus(player);
                    }
                }
            }
        }
    }
}
