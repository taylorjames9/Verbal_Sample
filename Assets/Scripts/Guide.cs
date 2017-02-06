using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Guide  {

    public static float targetAngleFromUserFacing;

    public static float CalculateHypotenuseFromUser(){
        float dist = Vector3.Distance(Paddle.Instance.mySearchTarget.transform.position, Player.Instance.transform.position);
        Debug.Log("Distance to mysearchTarget: " + dist);
        return dist;
    }

    public static void CalculateAdjacentLegLength(){

    }

    public static void CalculateOppositeLegLength(){

    }


}
