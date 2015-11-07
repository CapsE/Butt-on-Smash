using UnityEngine;
using System.Collections;

public class KesselBehavior : MonoBehaviour {

    public GameObject eye1;
    public GameObject eye2;
    public GameObject eye3;
    public float time = 0;
    public float intervall;
    private int cnt = 0;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        if (time >= intervall)
        {
            //Debug.Log(Input.GetJoystickNames().Length);

            time = 0;
            if (cnt == 0)
            {
                cnt++;
                eye1.transform.position = new Vector3(eye1.transform.position.x - 0.025f, eye1.transform.position.y , eye1.transform.position.z);
                eye2.transform.position = new Vector3(eye2.transform.position.x + 0.04f, eye2.transform.position.y, eye2.transform.position.z);
                eye3.transform.position = new Vector3(eye3.transform.position.x + 0.06f, eye3.transform.position.y, eye3.transform.position.z);
            }
            else {
                cnt--;
                eye1.transform.position = new Vector3(eye1.transform.position.x + 0.025f, eye1.transform.position.y , eye1.transform.position.z);
                eye2.transform.position = new Vector3(eye2.transform.position.x - 0.04f, eye2.transform.position.y, eye2.transform.position.z);
                eye3.transform.position = new Vector3(eye3.transform.position.x - 0.06f, eye3.transform.position.y, eye3.transform.position.z);
            }
        }
    }
}
