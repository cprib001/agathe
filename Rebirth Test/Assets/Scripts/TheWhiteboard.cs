using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheWhiteboard : MonoBehaviour {

    public List<bool> canWallride = new List<bool>{ false, false, false, false, false, false, false, false, false, false, false, false };
    public int currentSquare = 7;


    public static TheWhiteboard instance = null;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
