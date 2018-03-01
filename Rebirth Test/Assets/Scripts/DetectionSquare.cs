using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionSquare: MonoBehaviour {

    public int number;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay(Collider other)
    {
        if(other.name == "PlayerHitbox")
        {
            other.gameObject.GetComponent<PlayerMovementHelper>().currentSquare = number;
        }
        
    }
    //void OnTriggerEnter(Collider other)
    //{
    //    if(other.name == "PlayerHitbox")
    //    {
    //        other.gameObject.GetComponent<PlayerMovementHelper>().currentSquare = number;
    //    }
        
    //}
}
