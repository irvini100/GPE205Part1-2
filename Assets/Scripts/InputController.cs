using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : Controller
{

    public enum ControlType { WASD, IJKL  };
    public ControlType controls;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (controls == ControlType.WASD)
        {
            if (Input.GetKey(KeyCode.W))
            {  //Move forward
                Pawn.mover.MoveForward();
            }
        }
        else
        {
            if (controls == ControlType.IJKL)
            {

            }
        }
	}
}
