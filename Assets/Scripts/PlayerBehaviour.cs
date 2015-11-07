using UnityEngine;
using System.Collections;

public class PlayerBehaviour : MonoBehaviour
{
    public int player;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       // if (player == 1)
        {
            for(int i = 1; i<= 11; i=i+2){
                if (Input.GetKeyDown("joystick "+ i + " button 4"))    //LB
                {
                    Debug.Log("PLAYER 1 Left Bumper");
                }
                if (Input.GetKeyDown("joystick "+ i + " button 5"))    //RB
                {
                    Debug.Log("PLAYER 1 Right Bumper");
                }
                if (Input.GetAxis("joystick " + i +" Left Trigger") ==1)    //LT
                {
                    Debug.Log("PLAYER 1 Left Bumper");
                }
                if (Input.GetAxis("joystick "+ i +  " Right Trigger") == 1)    //RT
                {
                    Debug.Log("joystick 1 Right Trigger");
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
                    Debug.Log("PLAYER 2 Left Bumper");
                }
                if (Input.GetAxis("joystick " + i + " Right Trigger") == 1)    //RT
                {
                    Debug.Log("joystick 2 Right Trigger");
                }


            }
        }
    }
}
