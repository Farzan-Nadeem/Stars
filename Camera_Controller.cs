using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour {

    public GameObject player;

    private Vector3 offset;

   	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position;	
	}
	
	// Update is called once per frame
	void LateUpdate () {                        ///Runs after all items have been processed in update, so will 
                                                ///definetly run after the player object has ran
        transform.position = player.transform.position + offset;
	}
} 
