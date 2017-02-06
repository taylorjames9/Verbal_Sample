using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Paddle : MonoBehaviour {
    public List<GameObject> allPossibleTargets;

    public GameObject mySearchTarget;
    public bool hitTarget; 
    public static Paddle Instance;
    public void OnEnabled(){
        RequestManager.OnRequestMade += ChooseTarget; 
    }

	public void Awake(){
        Instance = this;
    }

    public void ChooseTarget(string _loc){
        Debug.Log("We're inside of ChooseTarget Fucntion");
        switch(_loc){
            case "L":
                mySearchTarget = allPossibleTargets[0];
            break;
            case "E":
                mySearchTarget = allPossibleTargets[1];
            break;
            case "R":
                mySearchTarget = allPossibleTargets[2];
            break;
            case "B":
                mySearchTarget = allPossibleTargets[3];
            break;
            default: 
                Debug.Log("Command not recognized");
            break;

        }

    }

    public void OnTriggerEnter(Collider other){
        if(other.gameObject.Equals(mySearchTarget)){
            hitTarget = true; 
        }
        //TODO: record angle diff from user's perspective here

    }
    void OnDisable()
    {
        RequestManager.OnRequestMade -= ChooseTarget; 
    }
}
