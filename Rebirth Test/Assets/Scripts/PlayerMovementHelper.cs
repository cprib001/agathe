using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementHelper : MonoBehaviour {

    private int _currentSquare = 7;
    public int currentSquare
    {
        get
        {
            return _currentSquare;
        }
        set
        {
            _currentSquare = value;
            transform.parent.transform.parent.gameObject.GetComponent<PlayerMovement>().currentSquare = _currentSquare;
            TheWhiteboard.instance.currentSquare = _currentSquare;
        }
    }

    // Use this for initialization
    void Start()
    {
        currentSquare = 7;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
