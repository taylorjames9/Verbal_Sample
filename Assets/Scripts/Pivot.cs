using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pivot : MonoBehaviour {

	public static Pivot Instance {get; set;}
	bool sweep;

	float myAngleFromUserFacing;

	void Awake(){
		Instance = this;
		Guide.TargetAngleFromUserFacing = transform.rotation.eulerAngles.y;
		Debug.Log("facing angle from start = "+Guide.TargetAngleFromUserFacing);

	}
	public IEnumerator Scan(string locationLetter){
		//transform.RotateAround(this.transform.position, Vector3.up, Time.deltaTime);
		//int num = 0;
		sweep = true;
		while(!Paddle.Instance.hitTarget){
			yield return null;
		}
		Guide.TargetAngleFromUserFacing = transform.rotation.eulerAngles.y;
		Guide.DistanceFromPlayer = CalculateHypotenuseFromUser();
		Guide.CalculateAdjacentLegLength();
		Guide.CalculateOppositeLegLength();
		Debug.Log("we've come to far...");
		//num =0;
		yield return null;

    }

	public void Update(){
		if(sweep && !Paddle.Instance.hitTarget){
			StartCoroutine(Sweep());
		}

	}
	IEnumerator Sweep(){
		transform.Rotate(0,1,0);
		if(Paddle.Instance.hitTarget)
			sweep = false;
		yield return null;
	}

	public float CalculateHypotenuseFromUser(){
		Debug.Log("paddle search target is: "+Paddle.Instance.mySearchTarget.name);
        float dist = Vector3.Distance(Paddle.Instance.mySearchTarget.transform.position, Player.Instance.transform.position);
        //Guide.TargetAngleFromUserFacing = dist;
		Debug.Log("Distance to mysearchTarget: " + dist);
        return dist;
    }

}
