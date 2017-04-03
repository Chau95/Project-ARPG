/*
Joe Duong
03/26/17
This is the camera control program. 
It is used to make the camera follows the player.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    GameObject player;

	// Use this for initialization
	void Start () {
        //Reference to the controlled player
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void LateUpdate () {
        //Locking the camera to the player character.
        transform.position = player.transform.position;
	}
}
