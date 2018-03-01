using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionWallride : MonoBehaviour {

    public int number;

    public int counter = 0;

    public bool isWallride = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(counter > 0)
        {
            isWallride = true;
            TheWhiteboard.instance.canWallride[number] = true;
        }
        else
        {
            isWallride = false;
            TheWhiteboard.instance.canWallride[number] = false;
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Wallride")
        {
            counter++;
        }

    }

    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Wallride")
        {
            counter--;
        }
    }
}
