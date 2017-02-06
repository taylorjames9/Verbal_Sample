using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RequestManager : MonoBehaviour {

    public delegate void RequestAction(string place_name);
    public static event RequestAction OnRequestMade;

	void Update(){
        if(Input.GetKeyUp(KeyCode.L)){
            Debug.Log("L Key pressed");
            StartCoroutine(Pivot.Instance.Scan("L"));
            //Paddle should update its hitTarget depending on which location is sought
            //OnRequestMade("Lobby");
            Paddle.Instance.ChooseTarget("L");
        }
        if(Input.GetKeyUp(KeyCode.E)){
            Debug.Log("E Key pressed");
            StartCoroutine(Pivot.Instance.Scan("E"));
            Paddle.Instance.ChooseTarget("E");
        }
        if(Input.GetKeyUp(KeyCode.R)){
            Debug.Log("R Key pressed");
            StartCoroutine(Pivot.Instance.Scan("R"));
            Paddle.Instance.ChooseTarget("R");
        }
        if(Input.GetKeyUp(KeyCode.B)){
            Debug.Log("B Key pressed");
            StartCoroutine(Pivot.Instance.Scan("B"));
            Paddle.Instance.ChooseTarget("B");
        }
	}



}
