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
    public int Player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        time += Time.deltaTime;
        if (time >= intervall) {
            time = 0;
            int buttonnr = Random.Range(0, 4);
            GameObject button = Instantiate(buttons[buttonnr]) as GameObject;
            activeButtons.Add(button);
            button.transform.parent = this.transform;
            button.transform.localPosition = new Vector3(spurbreite * buttonnr, 0, 0);
        }
	}

    void Update() {
        if(Player == 1){
        if (Input.GetKeyDown("joystick 1 button 0"))    //A
        {
            Debug.Log("joy 1 but 0");
            foreach(GameObject c in activeButtons){
                if (c.GetComponent<ButtonBehavior>().type == "A") {
                    if (c.GetComponent<BoxCollider2D>().IsTouching(ButtonArea.GetComponent<BoxCollider2D>()))
                    {
                        activeButtons.Remove(c);
                        Destroy(c);
                        break;
                }
            }
        }
        }
        if (Input.GetKeyDown("joystick 1 button 1"))    //B
        {
            Debug.Log("joy 1 but 1");
            foreach (GameObject c in activeButtons)
            {
                if (c.GetComponent<ButtonBehavior>().type == "B")
                {
                    if (c.GetComponent<BoxCollider2D>().IsTouching(ButtonArea.GetComponent<BoxCollider2D>()))
                    {
                        activeButtons.Remove(c);
                        Destroy(c);
                        break;
                    }
                }
            }
        }
        if (Input.GetKeyDown("joystick 1 button 2"))    //X
        {
            Debug.Log("joy 1 but 2");
            foreach (GameObject c in activeButtons)
            {
                if (c.GetComponent<ButtonBehavior>().type == "X")
                {
                    if (c.GetComponent<BoxCollider2D>().IsTouching(ButtonArea.GetComponent<BoxCollider2D>()))
                    {
                        activeButtons.Remove(c);
                        Destroy(c);
                        break;
                    }
                }
            }
        }
        if (Input.GetKeyDown("joystick 1 button 3"))    //Y
        {
            Debug.Log("joy 1 but 3");
            foreach (GameObject c in activeButtons)
            {
                if (c.GetComponent<ButtonBehavior>().type == "Y")
                {
                    if (c.GetComponent<BoxCollider2D>().IsTouching(ButtonArea.GetComponent<BoxCollider2D>()))
                    {
                        activeButtons.Remove(c);
                        Destroy(c);
                        break;
                    }
                }
            }
        }
        }
        else if (Player == 2)
        {
            if (Input.GetKeyDown("joystick 2 button 0"))    //A
            {
                Debug.Log("joy 2 but 0");
                foreach (GameObject c in activeButtons)
                {
                    if (c.GetComponent<ButtonBehavior>().type == "A")
                    {
                        if (c.GetComponent<BoxCollider2D>().IsTouching(ButtonArea.GetComponent<BoxCollider2D>()))
                        {
                            activeButtons.Remove(c);
                            Destroy(c);
                            break;
                        }
                    }
                }
            }
            if (Input.GetKeyDown("joystick 2 button 1"))    //B
            {
                Debug.Log("joy 2 but 1");
                foreach (GameObject c in activeButtons)
                {
                    if (c.GetComponent<ButtonBehavior>().type == "B")
                    {
                        if (c.GetComponent<BoxCollider2D>().IsTouching(ButtonArea.GetComponent<BoxCollider2D>()))
                        {
                            activeButtons.Remove(c);
                            Destroy(c);
                            break;
                        }
                    }
                }
            }
            if (Input.GetKeyDown("joystick 2 button 2"))    //X
            {
                Debug.Log("joy 2 but 2");
                foreach (GameObject c in activeButtons)
                {
                    if (c.GetComponent<ButtonBehavior>().type == "X")
                    {
                        if (c.GetComponent<BoxCollider2D>().IsTouching(ButtonArea.GetComponent<BoxCollider2D>()))
                        {
                            activeButtons.Remove(c);
                            Destroy(c);
                            break;
                        }
                    }
                }
            }
            if (Input.GetKeyDown("joystick 2 button 3"))    //Y
            {
                Debug.Log("joy 2 but 3");
                foreach (GameObject c in activeButtons)
                {
                    if (c.GetComponent<ButtonBehavior>().type == "Y")
                    {
                        if (c.GetComponent<BoxCollider2D>().IsTouching(ButtonArea.GetComponent<BoxCollider2D>()))
                        {
                            activeButtons.Remove(c);
                            Destroy(c);
                            break;
                        }
                    }
                }
            }
        }
    }
}
