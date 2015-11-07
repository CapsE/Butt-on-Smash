using UnityEngine;
using System.Collections;
using System;

public class GameController : MonoBehaviour {
    public GameObject Skull;
    public GameObject PipelineLeft;
    public GameObject PipelineRight;
    public float SkullSpeed;
    public float SkullMalus;
    public float speedInc;
    public float intervallInc;
    public GameObject endText;
    
    public GameObject comboText1;
    public GameObject number11;
    public GameObject number12;
    public GameObject number13;
    private float time;

    public GameObject comboText2;
    public GameObject number21;
    public GameObject number22;
    public GameObject number23;
    public GameObject newgametext;
    public GameObject player1;
    public GameObject player2;

    private bool end = false;
    private bool drehbool = false;

	public delegate void SkullMovedEventHandler(float value);
	public static event SkullMovedEventHandler SkullMoved;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        PipelineLeft.GetComponent<PipelineBehavior>().speed = Math.Abs(Skull.transform.position.x)*speedInc + 0.12f;
        PipelineLeft.GetComponent<PipelineBehavior>().intervall = 0.5f - Math.Abs(Skull.transform.position.x) * intervallInc;
        PipelineRight.GetComponent<PipelineBehavior>().speed = Math.Abs(Skull.transform.position.x) * speedInc + 0.12f;
        PipelineRight.GetComponent<PipelineBehavior>().intervall = 0.5f - Math.Abs(Skull.transform.position.x) * intervallInc;


        if (end)
        {
            time += Time.deltaTime;
            if (time >= 0.5)
            {
                //Debug.Log(Input.GetJoystickNames().Length);

                time = 0;
                if (drehbool)
                {
                    number11.transform.Rotate(new Vector3(0, 0, 1) * 10);
                    number12.transform.Rotate(new Vector3(0, 0, 1) * 10);
                    number13.transform.Rotate(new Vector3(0, 0, 1) * 10);

                    number21.transform.Rotate(new Vector3(0, 0, 1) * 10);
                    number22.transform.Rotate(new Vector3(0, 0, 1) * 10);
                    number23.transform.Rotate(new Vector3(0, 0, 1) * 10);
                    drehbool = false;
                }
                else {
                    number11.transform.Rotate(new Vector3(0, 0, 1) * -10);
                    number12.transform.Rotate(new Vector3(0, 0, 1) * -10);
                    number13.transform.Rotate(new Vector3(0, 0, 1) * -10);

                    number21.transform.Rotate(new Vector3(0, 0, 1) * -10);
                    number22.transform.Rotate(new Vector3(0, 0, 1) * -10);
                    number23.transform.Rotate(new Vector3(0, 0, 1) * -10);
                    drehbool = true;
                }

            }
            for (int i = 1; i <= 11; i++)
            {
                if (Input.GetKeyDown("joystick " + i +" button 7"))
                {
                    Application.LoadLevel(0);
                }
            }
        }
	}

    public void MoveSkull(int player) {
        if (player == 1) {
            Skull.transform.Translate(Vector3.right * SkullSpeed);
        }
        if (player == 2)
        {
            Skull.transform.Translate(Vector3.left * SkullSpeed);
        }
		if(SkullMoved != null)
			SkullMoved (Skull.transform.position.x);
    }
    public void MoveSkullMalus(int player)
    {
        if (player == 2)
        {
            Skull.transform.Translate(Vector3.right * SkullMalus);
        }
        if (player == 1)
        {
            Skull.transform.Translate(Vector3.left * SkullMalus);
        }
        if(SkullMoved != null)
			SkullMoved (Skull.transform.position.x);
    }

    public void finishScreen(int Player) {
        end = true;
        if (Player == 1)
        {
            player2.GetComponent<Animation>().CrossFade("Sterben");
            endText.GetComponent<TextMesh>().text = "spieler i wird verschont";
               
        }
        else
        {
            player1.GetComponent<Animation>().CrossFade("Sterben");
            endText.GetComponent<TextMesh>().text = "spieler ii wird verschont";
            
        }
        newgametext.GetComponent<TextMesh>().text = "start zum neustart"; 
        comboText2.GetComponent<TextMesh>().text = "max combo";
        number21.GetComponent<TextMesh>().text = "" + PipelineRight.GetComponent<PipelineBehavior>().maxCombo.ToString()[0];
        if (PipelineRight.GetComponent<PipelineBehavior>().maxCombo.ToString().Length >= 2)
            number22.GetComponent<TextMesh>().text = "" + PipelineRight.GetComponent<PipelineBehavior>().maxCombo.ToString()[1];
        if (PipelineRight.GetComponent<PipelineBehavior>().maxCombo.ToString().Length >= 3)
            number23.GetComponent<TextMesh>().text = "" + PipelineRight.GetComponent<PipelineBehavior>().maxCombo.ToString()[2];

        comboText1.GetComponent<TextMesh>().text = "max combo";
        number11.GetComponent<TextMesh>().text = "" + PipelineLeft.GetComponent<PipelineBehavior>().maxCombo.ToString()[0];
        if (PipelineLeft.GetComponent<PipelineBehavior>().maxCombo.ToString().Length >= 2)
            number12.GetComponent<TextMesh>().text = "" + PipelineLeft.GetComponent<PipelineBehavior>().maxCombo.ToString()[1];
        if (PipelineLeft.GetComponent<PipelineBehavior>().maxCombo.ToString().Length >= 3)
            number13.GetComponent<TextMesh>().text = "" + PipelineLeft.GetComponent<PipelineBehavior>().maxCombo.ToString()[2];
    }
}
