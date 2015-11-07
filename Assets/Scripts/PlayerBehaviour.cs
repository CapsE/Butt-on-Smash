using UnityEngine;
using System.Collections;

public class PlayerBehaviour : MonoBehaviour
{
    public int player;
    public GameObject[] projectile;
    public float force;
    public GameObject deathEffect;
    
    //public int itemcount = 1;
    private float time1;
    private float time2;
    // Use this for initialization
    void Start()
    {

    }

    public void sterben() {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player == 1)
        {
            time1 += Time.deltaTime;
            time2 += Time.deltaTime;
            for(int i = 1; i<= 11; i=i+2){
                if (Input.GetKeyDown("joystick "+ i + " button 4"))    //LB
                {
                    Debug.Log("PLAYER 1 Left Bumper ");
                }
                if (Input.GetKeyDown("joystick "+ i + " button 5"))    //RB
                {
                    
                    Debug.Log("PLAYER 1 Right Bumper");
                }
                if (Input.GetAxis("joystick " + i + " Left Trigger") == 1)    //LT
                {
                    if (GameObject.Find("ShowItemLeft").GetComponent<ShowItemBehavior>().itemcount == 1)
                    {
                        
                        
                        if (time1 >= 0.5)
                        {
                            Debug.Log("WURF");
                            time1 = 0;
                            GameObject wurfdings = Instantiate(projectile[0]) as GameObject;
                            int level = GameObject.Find("ShowItemLeft").GetComponent<ShowItemBehavior>().currentitem;
                            if (level == 1) {
                                wurfdings.GetComponent<SpriteRenderer>().sprite = GameObject.Find("ShowItemLeft").GetComponent<ShowItemBehavior>().level1;
                            }
                            else if (level == 2)
                            {
                                wurfdings.GetComponent<SpriteRenderer>().sprite = GameObject.Find("ShowItemLeft").GetComponent<ShowItemBehavior>().level2;
                            }
                            else if (level == 3)
                            {
                                wurfdings.GetComponent<SpriteRenderer>().sprite = GameObject.Find("ShowItemLeft").GetComponent<ShowItemBehavior>().level3;
                            }
                            
                            float input = Input.GetAxis("joystick " + i + " Up");
                            if (input <= 0.3 && input >= -0.3)
                            {
                                wurfdings.transform.Rotate(0f, 0f, 32f);
                                wurfdings.GetComponent<Rigidbody2D>().AddForce(wurfdings.transform.right * force);
                            }
                            else if (input <= -0.3)
                            {
                                wurfdings.transform.Rotate(0f, 0f, 65f);
                                wurfdings.GetComponent<Rigidbody2D>().AddForce(wurfdings.transform.right * force * 1.15f);
                            }
                            else if (input >= 0.3)
                            {
                                wurfdings.transform.Rotate(0f, 0f, 10f);
                                wurfdings.GetComponent<Rigidbody2D>().AddForce(wurfdings.transform.right * force* 1.15f);
                            }
                            wurfdings.name = "player1wurf";
                            wurfdings.GetComponent<ItemBehaviour>().level = level;
                            wurfdings.GetComponent<ItemBehaviour>().floating = true;
                            wurfdings.GetComponent<ItemBehaviour>().righttoleft = true;
                            Debug.Log("joystick 1 Right Trigger");
                            GameObject.Find("ShowItemLeft").GetComponent<ShowItemBehavior>().currentitem = 0;
                            GameObject.Find("ShowItemLeft").GetComponent<ShowItemBehavior>().itemcount = 0;
                            Debug.Log("!gehts? " + GameObject.Find("ShowItemLeft").GetComponent<ShowItemBehavior>().itemcount);
                            Debug.Log("PLAYER 1 Left Trigger");
                        }
                        
                    }
                }
                if (Input.GetAxis("joystick "+ i +  " Right Trigger") == 1)    //RT
                {
                    gameObject.GetComponent<Animator>().Play("blocken");
                }
                if (Input.GetAxis("joystick " + i + " Up") >= 1)    //RT
                {
                    //Debug.Log("PLAYER 1 Up");
                }


            }
        }

         if (player == 2)
        {
            for (int i = 2; i <= 11; i = i + 2)
            {
                if (Input.GetKeyDown("joystick " + i + " button 4"))    //LB
                {
                    Debug.Log("PLAYER 2 Left Bumper");
                }
                if (Input.GetKeyDown("joystick " + i + " button 5"))    //RB
                {
                    Debug.Log("PLAYER 2 Right Bumper");
                }
                if (Input.GetAxis("joystick " + i + " Left Trigger") == 1)    //LT
                {
                    if (GameObject.Find("ShowItemRight").GetComponent<ShowItemBehavior>().itemcount == 1)
                    {
                        Debug.Log("PLAYER 2 Left Trigger");

                        //if (time2 >= 0.5)
                        {
                            Debug.Log("WURF");
                            time2 = 0;
                            GameObject wurfdings = Instantiate(projectile[0]) as GameObject;
                            wurfdings.name = "player2wurf";
                            //wurfdings.transform.Translate(-1,0,0);
                            int level = GameObject.Find("ShowItemRight").GetComponent<ShowItemBehavior>().currentitem;
                            if (level == 1)
                            {
                                wurfdings.GetComponent<SpriteRenderer>().sprite = GameObject.Find("ShowItemRight").GetComponent<ShowItemBehavior>().level1;
                            }
                            else if (level == 2)
                            {
                                wurfdings.GetComponent<SpriteRenderer>().sprite = GameObject.Find("ShowItemRight").GetComponent<ShowItemBehavior>().level2;
                            }
                            else if (level == 3)
                            {
                                wurfdings.GetComponent<SpriteRenderer>().sprite = GameObject.Find("ShowItemRight").GetComponent<ShowItemBehavior>().level3;
                            }
                            wurfdings.transform.localRotation = Quaternion.Euler(0, 180, 0);
                            float input = Input.GetAxis("joystick " + i + " Up");
                            if (input <= 0.3 && input >= -0.3)
                            {
                                wurfdings.transform.Rotate(0f, 0f, 32f);
                                wurfdings.GetComponent<Rigidbody2D>().AddForce(wurfdings.transform.right * force * 1);
                            }
                            else if (input <= -0.3)
                            {
                                wurfdings.transform.Rotate(0f, 0f, 66f);
                                wurfdings.GetComponent<Rigidbody2D>().AddForce(wurfdings.transform.right * force * 1.15f * 1);
                            }
                            else if (input >= 0.3)
                            {
                                wurfdings.transform.Rotate(0f, 0f, 10f);
                                wurfdings.GetComponent<Rigidbody2D>().AddForce(wurfdings.transform.right * force * 1.15f * 1);
                            }

                            wurfdings.GetComponent<ItemBehaviour>().floating = true;
                            wurfdings.GetComponent<ItemBehaviour>().righttoleft = false;
                            GameObject.Find("ShowItemRight").GetComponent<ShowItemBehavior>().currentitem = 0;
                            GameObject.Find("ShowItemRight").GetComponent<ShowItemBehavior>().itemcount = 0;
                            Debug.Log("!gehts? " + GameObject.Find("ShowItemRight").GetComponent<ShowItemBehavior>().itemcount);
                            Debug.Log("PLAYER 2 Left Trigger");
                        }

                    }
                }
                if (Input.GetAxis("joystick " + i + " Right Trigger") == 1)    //RT
                {
                    gameObject.GetComponent<Animator>().Play("blocken2");
                    Debug.Log("joystick 2 Right Trigger");

                    float input = Input.GetAxis("joystick " + i + " Up");
                    if (input <= 0.3 && input >= -0.3)
                    {
                            //NORMAL
                    }
                    else if (input <= -0.3)
                    {
                            //OBEN
                    }
                    else if (input >= 0.3)
                    {
                            //UNTEN
                    }
                }


            }
        }
    }
}
