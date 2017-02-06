using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pivot : MonoBehaviour {

	public static Pivot Instance {get; set;}
	bool sweep;

	float myAngleFromUserFacing;

	void Awake(){
		Instance = this;

	}
	public IEnumerator Scan(string locationLetter){
		//transform.RotateAround(this.transform.position, Vector3.up, Time.deltaTime);
		//int num = 0;
		sweep = true;
		while(!Paddle.Instance.hitTarget /*|| num<1000*/){
			yield return null;
		}
		//Util.CalculateAngleFromUser();
		Guide.targetAngleFromUserFacing = transform.rotation.y;
		Guide.CalculateHypotenuseFromUser();
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

}
