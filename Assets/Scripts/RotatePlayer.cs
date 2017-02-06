using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlayer : MonoBehaviour {
	void Update () {
		if(Input.GetKey(KeyCode.LeftArrow)){
			Debug.Log("A Key is DOWN");
			transform.Rotate(0,-1,0);
		} else if (Input.GetKey(KeyCode.RightArrow)){
			transform.Rotate(0,1,0);
		}
	}
}
