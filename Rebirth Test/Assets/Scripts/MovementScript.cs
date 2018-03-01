using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour {

    public int currentSquare = 7;

    public bool isMoving = false;
    public bool wasSticking = false;

    public Vector3 targetPosition;

    public float moveTime = 1;
    public float jumpTime = 1;

    public GameObject core;

    void Start()
    {
        
    }

    void CleanUp()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update () {
        if(currentSquare == 0)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                iTween.StopByName("jump");
                Stick(0);
            }
            if (Input.GetKeyUp(KeyCode.LeftArrow) && wasSticking)
            {
                SpecialMove(6);
                wasSticking = false;
            }
        }
        if(currentSquare == 3)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                iTween.StopByName("jump");
                Stick(3);
            }
            if (Input.GetKeyUp(KeyCode.LeftArrow) && wasSticking)
            {
                SpecialMove(6);
                wasSticking = false;
            }
            if(!isMoving)
            {
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    Jump(0);
                }
            }
            
        }
        if (currentSquare == 6)
        {
            if(!isMoving)
            {
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    Move(7);
                }
                else if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    Jump(3);
                }
            }
        }
        else if(currentSquare == 7)
        {
            if(!isMoving)
            {
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    Move(6);
                }
                else if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    Move(8);
                }
                else if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    Jump(4);
                }
            }
        }
        else if(currentSquare == 8)
        {
            if(!isMoving)
            {
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    Move(7);
                }
                else if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    Jump(5);
                }
            }
        }
	}

    private void SpecialMove(int location)
    {
        if (location == 6)
        {
            targetPosition = new Vector3(-2, 0, 0);
        }
        iTween.MoveTo(core, iTween.Hash("name", "jump", "position", targetPosition, "time", jumpTime / 2, "easeType", iTween.EaseType.easeInQuad));
        iTween.MoveTo(gameObject, iTween.Hash("name", "movement", "position", targetPosition, "time", moveTime, "easeType", iTween.EaseType.easeOutCirc, "onstart", "SetIsMoving", "onstartparams", true, "oncomplete", "SetIsMoving", "oncompleteparams", false));
        

    }

    private void Move(int location)
    {
        if (location == 6)
        {
            targetPosition = new Vector3(-2, 0, 0);
        }
        if (location == 7)
        {
            targetPosition = new Vector3(0, 0, 0);
        }
        if(location == 8)
        {
            targetPosition = new Vector3(2, 0, 0);
        }
        iTween.MoveTo(gameObject, iTween.Hash("name", "movement", "position", targetPosition, "time", moveTime, "easeType", iTween.EaseType.easeOutCirc, "onstart", "SetIsMoving", "onstartparams", true, "oncomplete", "SetIsMoving", "oncompleteparams", false));
        
    }

    private void Jump(int location)
    {
        wasSticking = false;
        float lobHeight = 2.3f;
        if (location == 0)
        {
            targetPosition = new Vector3(-2, 0, 0);
            lobHeight = 4.2f;
        }
        if(location == 3)
        {
            targetPosition = new Vector3(-2, 0, 0);
        }
        if(location == 4)
        {
            targetPosition = new Vector3(0, 0, 0);
        }
        if (location == 5)
        {
            targetPosition = new Vector3(2, 0, 0);
        }

        iTween.MoveTo(core, iTween.Hash("name", "jump", "position", targetPosition+new Vector3(0, lobHeight, 0), "time", jumpTime / 2, "easeType", iTween.EaseType.easeOutCubic));
        iTween.MoveTo(core, iTween.Hash("name", "jump", "position", targetPosition, "time", jumpTime / 2, "delay", jumpTime / 2, "easeType", iTween.EaseType.easeInQuad));
        iTween.MoveTo(gameObject, iTween.Hash("name", "movement", "position", targetPosition, "time", jumpTime, "easeType", iTween.EaseType.linear, "onstart", "SetIsMoving", "onstartparams", true, "oncomplete", "SetIsMoving", "oncompleteparams", false));
    }

    private void Stick(int location)
    {
        if (location == 3 || location == 0)
        {
            targetPosition = new Vector3(-3, transform.position.y, 0);
        }
        iTween.MoveTo(gameObject, iTween.Hash("name", "movement", "position", targetPosition, "time", 0.5, "easeType", iTween.EaseType.easeOutExpo, "onstart", "SetIsMoving", "onstartparams", true, "oncomplete", "SetIsMoving", "oncompleteparams", false));
        wasSticking = true;
    }

    private void SetIsMoving(bool currentlyMoving)
    {
        isMoving = currentlyMoving;
        Debug.Log(transform.position);
        Debug.Log(transform.GetChild(0).transform.position);
    }
}
