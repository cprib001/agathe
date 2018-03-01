using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public int currentSquare = 7;

    public bool isMoving = false;
    //public bool wasSticking = false;
    public bool onLeftWall = false;
    public bool onRightWall = false;

    public Vector3 targetPosition;

    public float moveTime = 1;
    public float jumpTime = 1;

    public GameObject core;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (currentSquare == 0)
        {
            if (onLeftWall && !TheWhiteboard.instance.canWallride[0])
            {
                JumpDown(6);
                onLeftWall = false;
            }
            else if (onRightWall && !TheWhiteboard.instance.canWallride[1])
            {
                JumpDown(6);
                onRightWall = false;
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow) && onLeftWall && !TheWhiteboard.instance.canWallride[1])
            {
                Jump(7);
                onLeftWall = false;
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow) && TheWhiteboard.instance.canWallride[0])
            {
                iTween.StopByName("vertical");
                Wallride(0, "left");
                onRightWall = false;
            }
            else if (Input.GetKeyUp(KeyCode.LeftArrow) && onLeftWall)
            {
                JumpDown(6);
                onLeftWall = false;
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow) && TheWhiteboard.instance.canWallride[1])
            {
                iTween.StopByName("vertical");
                Wallride(0, "right");
                onLeftWall = false;
            }
            else if (Input.GetKeyUp(KeyCode.RightArrow) && onRightWall)
            {
                JumpDown(6);
                onRightWall = false;
            }
            else if (!isMoving)
            {
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    Jump(0);
                }
            }
        }
        else if (currentSquare == 1)
        {
            if (onLeftWall && !TheWhiteboard.instance.canWallride[1])
            {
                JumpDown(7);
                onLeftWall = false;
            }
            else if (onRightWall && !TheWhiteboard.instance.canWallride[2])
            {
                JumpDown(7);
                onRightWall = false;
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow) && onRightWall && !TheWhiteboard.instance.canWallride[1])
            {
                Jump(6);
                onRightWall = false;
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow) && onLeftWall && !TheWhiteboard.instance.canWallride[2])
            {
                Jump(8);
                onLeftWall = false;
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow) && TheWhiteboard.instance.canWallride[1])
            {
                iTween.StopByName("vertical");
                Wallride(1, "left");
                onRightWall = false;
            }
            else if (Input.GetKeyUp(KeyCode.LeftArrow) && onLeftWall)
            {
                JumpDown(7);
                onLeftWall = false;
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow) && TheWhiteboard.instance.canWallride[2])
            {
                iTween.StopByName("vertical");
                Wallride(1, "right");
                onLeftWall = false;
            }
            else if (Input.GetKeyUp(KeyCode.RightArrow) && onRightWall)
            {
                JumpDown(7);
                onRightWall = false;
            }
            else if (!isMoving)
            {
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    Jump(1);
                }
            }
        }
        else if (currentSquare == 2)
        {
            if (onLeftWall && !TheWhiteboard.instance.canWallride[2])
            {
                JumpDown(8);
                onLeftWall = false;
            }
            else if (onRightWall && !TheWhiteboard.instance.canWallride[3])
            {
                JumpDown(8);
                onRightWall = false;
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow) && onRightWall && !TheWhiteboard.instance.canWallride[2])
            {
                Jump(7);
                onRightWall = false;
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow) && TheWhiteboard.instance.canWallride[2])
            {
                iTween.StopByName("vertical");
                Wallride(2, "left");
                onRightWall = false;
            }
            else if (Input.GetKeyUp(KeyCode.LeftArrow) && onLeftWall)
            {
                JumpDown(8);
                onLeftWall = false;
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow) && TheWhiteboard.instance.canWallride[3])
            {
                iTween.StopByName("vertical");
                Wallride(2, "right");
                onLeftWall = false;
            }
            else if (Input.GetKeyUp(KeyCode.RightArrow) && onRightWall)
            {
                JumpDown(8);
                onRightWall = false;
            }
            else if (!isMoving)
            {
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    Jump(2);
                }
            }
        }
        else if (currentSquare == 3)
        {
            if (onLeftWall && !TheWhiteboard.instance.canWallride[4])
            {
                JumpDown(6);
                onLeftWall = false;
            }
            else if (onRightWall && !TheWhiteboard.instance.canWallride[5])
            {
                JumpDown(6);
                onRightWall = false;
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow) && onLeftWall && !TheWhiteboard.instance.canWallride[5])
            {
                Jump(7);
                onLeftWall = false;
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow) && TheWhiteboard.instance.canWallride[4])
            {
                iTween.StopByName("vertical");
                Wallride(3, "left");
                onRightWall = false;
            }
            else if (Input.GetKeyUp(KeyCode.LeftArrow) && onLeftWall)
            {
                JumpDown(6);
                onLeftWall = false;
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow) && TheWhiteboard.instance.canWallride[5])
            {
                iTween.StopByName("vertical");
                Wallride(3, "right");
                onLeftWall = false;
            }
            else if (Input.GetKeyUp(KeyCode.RightArrow) && onRightWall)
            {
                JumpDown(6);
                onRightWall = false;
            }
            else if (!isMoving)
            {
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    Jump(0);
                }
            }
        }
        else if (currentSquare == 4)
        {
            if (onLeftWall && !TheWhiteboard.instance.canWallride[5])
            {
                JumpDown(7);
                onLeftWall = false;
            }
            else if (onRightWall && !TheWhiteboard.instance.canWallride[6])
            {
                JumpDown(7);
                onRightWall = false;
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow) && onRightWall && !TheWhiteboard.instance.canWallride[5])
            {
                Jump(6);
                onRightWall = false;
            }
            else if(Input.GetKeyDown(KeyCode.RightArrow) && onLeftWall && !TheWhiteboard.instance.canWallride[6])
            {
                Jump(8);
                onLeftWall = false;
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow) && TheWhiteboard.instance.canWallride[5])
            {
                iTween.StopByName("vertical");
                Wallride(4, "left");
                onRightWall = false;
            }
            else if (Input.GetKeyUp(KeyCode.LeftArrow) && onLeftWall)
            {
                JumpDown(7);
                onLeftWall = false;
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow) && TheWhiteboard.instance.canWallride[6])
            {
                iTween.StopByName("vertical");
                Wallride(4, "right");
                onLeftWall = false;
            }
            else if (Input.GetKeyUp(KeyCode.RightArrow) && onRightWall)
            {
                JumpDown(7);
                onRightWall = false;
            }
            else if (!isMoving)
            {
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    Jump(1);
                }
            }
        }
        else if (currentSquare == 5)
        {
            if (onLeftWall && !TheWhiteboard.instance.canWallride[6])
            {
                JumpDown(8);
                onLeftWall = false;
            }
            else if (onRightWall && !TheWhiteboard.instance.canWallride[7])
            {
                JumpDown(8);
                onRightWall = false;
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow) && onRightWall && !TheWhiteboard.instance.canWallride[6])
            {
                Jump(7);
                onRightWall = false;
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow) && TheWhiteboard.instance.canWallride[6])
            {
                iTween.StopByName("vertical");
                Wallride(5, "left");
                onRightWall = false;
            }
            else if (Input.GetKeyUp(KeyCode.LeftArrow) && onLeftWall)
            {
                JumpDown(8);
                onLeftWall = false;
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow) && TheWhiteboard.instance.canWallride[7])
            {
                iTween.StopByName("vertical");
                Wallride(5, "right");
                onLeftWall = false;
            }
            else if (Input.GetKeyUp(KeyCode.RightArrow) && onRightWall)
            {
                JumpDown(8);
                onRightWall = false;
            }
            else if (!isMoving)
            {
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    Jump(2);
                }
            }
        }
        else if (currentSquare == 6)
        {
            if(onLeftWall && !TheWhiteboard.instance.canWallride[8])
            {
                JumpDown(6);
                onLeftWall = false;
            }
            else if(onRightWall && !TheWhiteboard.instance.canWallride[9])
            {
                JumpDown(6);
                onRightWall = false;
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow) && onLeftWall && !TheWhiteboard.instance.canWallride[9])
            {
                Jump(7);
                onLeftWall = false;
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow) && TheWhiteboard.instance.canWallride[8])
            {
                iTween.StopByName("vertical");
                Wallride(6, "left");
                onRightWall = false;
            }
            else if (Input.GetKeyUp(KeyCode.LeftArrow) && onLeftWall)
            {
                JumpDown(6);
                onLeftWall = false;
            }
            else if(Input.GetKeyDown(KeyCode.RightArrow) && TheWhiteboard.instance.canWallride[9])
            {
                iTween.StopByName("vertical");
                Wallride(6, "right");
                onLeftWall = false;
            }
            else if (Input.GetKeyUp(KeyCode.RightArrow) && onRightWall)
            {
                JumpDown(6);
                onRightWall = false;
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                Move(7);
            }
            else if (!isMoving)
            {
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    Jump(3);
                }
            }
        }
        else if (currentSquare == 7)
        {
            if (onLeftWall && !TheWhiteboard.instance.canWallride[9])
            {
                JumpDown(7);
                onLeftWall = false;
            }
            else if(onRightWall && !TheWhiteboard.instance.canWallride[10])
            {
                JumpDown(7);
                onRightWall = false;
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow) && onRightWall && !TheWhiteboard.instance.canWallride[9])
            {
                Jump(6);
                onRightWall = false;
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow) && onLeftWall && !TheWhiteboard.instance.canWallride[10])
            {
                Jump(8);
                onLeftWall = false;
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow) && TheWhiteboard.instance.canWallride[9])
            {
                iTween.StopByName("vertical");
                Wallride(7, "left");
                onRightWall = false;
            }
            else if (Input.GetKeyUp(KeyCode.LeftArrow) && onLeftWall)
            {
                JumpDown(7);
                onLeftWall = false;
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow) && TheWhiteboard.instance.canWallride[10])
            {
                iTween.StopByName("vertical");
                Wallride(7, "right");
                onLeftWall = false;
            }
            else if (Input.GetKeyUp(KeyCode.RightArrow) && onRightWall)
            {
                JumpDown(7);
                onRightWall = false;
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Move(6);
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                Move(8);
            }
            else if (!isMoving)
            {
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    Jump(4);
                }
            }
        }
        else if (currentSquare == 8)
        {
            if (onLeftWall && !TheWhiteboard.instance.canWallride[10])
            {
                JumpDown(8);
                onLeftWall = false;
            }
            else if (onRightWall && !TheWhiteboard.instance.canWallride[11])
            {
                JumpDown(8);
                onRightWall = false;
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow) && onRightWall && !TheWhiteboard.instance.canWallride[10])
            {
                Jump(7);
                onRightWall = false;
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow) && TheWhiteboard.instance.canWallride[10])
            {
                iTween.StopByName("vertical");
                Wallride(8, "left");
                onRightWall = false;
            }
            else if (Input.GetKeyUp(KeyCode.LeftArrow) && onLeftWall)
            {
                JumpDown(8);
                onLeftWall = false;
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow) && TheWhiteboard.instance.canWallride[11])
            {
                iTween.StopByName("vertical");
                Wallride(8, "right");
                onLeftWall = false;
            }
            else if (Input.GetKeyUp(KeyCode.RightArrow) && onRightWall)
            {
                JumpDown(8);
                onRightWall = false;
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Move(7);
            }
            else if (!isMoving)
            {
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    Jump(5);
                }
            }
        }
    }

    private void Move(int location)
    {
        isMoving = false;
        if (location == 6)
        {
            targetPosition = new Vector3(-2, 0, 0);
        }
        else if (location == 7)
        {
            targetPosition = new Vector3(0, 0, 0);
        }
        else if (location == 8)
        {
            targetPosition = new Vector3(2, 0, 0);
        }
        iTween.MoveTo(gameObject, iTween.Hash("name", "horizontal", "position", targetPosition, "time", moveTime, "easeType", iTween.EaseType.easeOutCirc));

    }

    private void Jump(int location)
    {
        onLeftWall = false;
        onRightWall = false;

        if (location == 0 || location == 1 || location == 2 || location == 3 || location == 4 || location == 5)
        {
            float jumpHeight = 2.3f;
            if (location == 0)
            {
                targetPosition = new Vector3(-2, 0, 0);
                jumpHeight = 4.2f;
            }
            if (location == 1)
            {
                targetPosition = new Vector3(0, 0, 0);
                jumpHeight = 4.2f;
            }
            if (location == 2)
            {
                targetPosition = new Vector3(2, 0, 0);
                jumpHeight = 4.2f;
            }
            else if (location == 3)
            {
                targetPosition = new Vector3(-2, 0, 0);
            }
            else if (location == 4)
            {
                targetPosition = new Vector3(0, 0, 0);
            }
            else if (location == 5)
            {
                targetPosition = new Vector3(2, 0, 0);
            }

            iTween.MoveBy(core, iTween.Hash("name", "vertical", "y", jumpHeight - transform.GetChild(0).transform.position.y, "time", jumpTime / 2, "easeType", iTween.EaseType.easeOutQuad));
            iTween.MoveBy(core, iTween.Hash("name", "vertical", "y", -jumpHeight, "time", jumpTime / 2, "delay", jumpTime / 2, "easeType", iTween.EaseType.easeInCubic));
            iTween.MoveTo(gameObject, iTween.Hash("name", "horizontal", "position", targetPosition, "time", jumpTime, "easeType", iTween.EaseType.linear, "onstart", "SetIsMoving", "onstartparams", true, "oncomplete", "SetIsMoving", "oncompleteparams", false));
        }

        else if(location == 6 || location == 7 || location == 8)
        {
            float jumpHeight = .5f;
            if (location == 6)
            {
                targetPosition = new Vector3(-2, 0, 0);
            }
            else if (location == 7)
            {
                targetPosition = new Vector3(0, 0, 0);
            }
            else if (location == 8)
            {
                targetPosition = new Vector3(2, 0, 0);
            }

            iTween.MoveBy(core, iTween.Hash("name", "vertical", "y", jumpHeight, "time", jumpTime / 2, "easeType", iTween.EaseType.easeOutQuad));
            iTween.MoveBy(core, iTween.Hash("name", "vertical", "y", -(jumpHeight + transform.GetChild(0).transform.position.y), "time", jumpTime / 2, "delay", jumpTime / 2, "easeType", iTween.EaseType.easeInCubic));
            iTween.MoveTo(gameObject, iTween.Hash("name", "horizontal", "position", targetPosition, "time", jumpTime, "easeType", iTween.EaseType.linear, "onstart", "SetIsMoving", "onstartparams", true, "oncomplete", "SetIsMoving", "oncompleteparams", false));
        }
        

        
    }

    private void Wallride(int location, string direction)
    {
        if (direction == "left")
        {
            onLeftWall = true;
            if ((location == 0 || location == 3 || location == 6))
            {
                targetPosition = new Vector3(-2.5f, 0, 0);
            }
            else if((location == 1 || location == 4 || location == 7))
            {
                targetPosition = new Vector3(-0.5f, 0, 0);
            }
            else if ((location == 2 || location == 5 || location == 8))
            {
                targetPosition = new Vector3(1.5f, 0, 0);
            }
        }
        else if (direction == "right")
        {
            onRightWall = true;
            if ((location == 0 || location == 3 || location == 6))
            {
                targetPosition = new Vector3(-1.5f, 0, 0);
            }
            else if ((location == 1 || location == 4 || location == 7))
            {
                targetPosition = new Vector3(0.5f, 0, 0);
            }
            else if ((location == 2 || location == 5 || location == 8))
            {
                targetPosition = new Vector3(2.5f, 0, 0);
            }
        }
        
        iTween.MoveTo(gameObject, iTween.Hash("name", "horizontal", "position", targetPosition, "time", 0.5, "easeType", iTween.EaseType.easeOutExpo, "onstart", "SetIsMoving", "onstartparams", true, "oncomplete", "SetIsMoving", "oncompleteparams", false));
    }

    private void JumpDown(int location)
    {
        if (location == 6)
        {
            targetPosition = new Vector3(-2, 0, 0);
        }
        if (location == 7)
        {
            targetPosition = new Vector3(0, 0, 0);
        }
        if (location == 8)
        {
            targetPosition = new Vector3(2, 0, 0);
        }
        iTween.MoveBy(core, iTween.Hash("name", "vertical", "y", -transform.GetChild(0).transform.position.y, "time", jumpTime, "easeType", iTween.EaseType.easeOutQuad));
        iTween.MoveTo(gameObject, iTween.Hash("name", "horizontal", "position", targetPosition, "time", moveTime, "easeType", iTween.EaseType.linear, "onstart", "SetIsMoving", "onstartparams", true, "oncomplete", "SetIsMoving", "oncompleteparams", false));


    }


    private void SetIsMoving(bool currentlyMoving)
    {
        isMoving = currentlyMoving;
    }
}
