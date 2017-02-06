using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlayer : MonoBehaviour {
	void Update () {
		Debug.Log("Rotating Player");
		if(Input.GetKey(KeyCode.A)){
			Debug.Log("A Key is DOWN");
			transform.Rotate(0,-1,0);
		} else if (Input.GetKey(KeyCode.D)){
			transform.Rotate(0,1,0);
		}
	}
}
