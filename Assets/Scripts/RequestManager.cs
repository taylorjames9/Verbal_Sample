using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RequestManager : MonoBehaviour {

    public delegate void RequestAction(string place_name);
    public static event RequestAction OnRequestMade;

	void Update(){
        if(Input.GetKeyUp(KeyCode.L)){
            Debug.Log("L Key pressed");
            //Start Paddle Rotation
            StartCoroutine(Pivot.Instance.Scan("L"));
            //Paddle should update its hitTarget depending on which location is sought
            //OnRequestMade("Lobby");
            Paddle.Instance.ChooseTarget("L");
        }
	}



}
