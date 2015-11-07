using UnityEngine;
using System.Collections;

public class PlayerBehaviour : MonoBehaviour
{
    public int player;
    public GameObject[] projectile;
    public float force;
    public int itemcount = 1;
    private float time;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       // if (player == 1)
        {
            time += Time.deltaTime;
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
                    if (itemcount >= 1)
                    {
                        
                        if (time >= 0.5)
                        {
                            time = 0;
                            GameObject wurfdings = Instantiate(projectile[0]) as GameObject;
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
                            
                            wurfdings.GetComponent<ItemBehaviour>().floating = true;
                            Debug.Log("joystick 1 Right Trigger");
                            itemcount--;
                        }
                        Debug.Log("PLAYER 1 Left Trigger");
                    }
                }
                if (Input.GetAxis("joystick "+ i +  " Right Trigger") == 1)    //RT
                {
                   
                }
                if (Input.GetAxis("joystick " + i + " Up") >= 1)    //RT
                {
                    //Debug.Log("PLAYER 1 Up");
                }


            }
        }

        // if (player == 1)
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
                    Debug.Log("PLAYER 2 Left Trigger");
                }
                if (Input.GetAxis("joystick " + i + " Right Trigger") == 1)    //RT
                {
                    Debug.Log("joystick 2 Right Trigger");
                }


            }
        }
    }
}
