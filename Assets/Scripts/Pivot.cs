using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pivot : MonoBehaviour {

	public static Pivot Instance {get; set;}

	void Awake(){
		Instance = this;

	}
	public IEnumerator Scan(string locationLetter){
		//transform.RotateAround(this.transform.position, Vector3.up, Time.deltaTime);
		while(!Paddle.Instance.hitTarget){
			transform.Rotate(0, 1.1f, 0);
		}
		//Util.CalculateAngleFromUser();
		//Util.CalculateAdjacentLegLength();
		//Util.CalculateOppositeLegLength();
		yield return null;

    }


}
