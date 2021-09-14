using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankData : MonoBehaviour {

    public TankMover mover;
    public TankShooter shooter;
    //Variables for our tanks in game
    public float speed;
    public float turnSpeed;

	// Use this for initialization
	void Start () {
        //Load the mover
        mover = this.gameObject.GetComponent<TankMover>();
        //Load the shooter.
        shooter = this.gameObject.GetComponent<TankShooter>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
