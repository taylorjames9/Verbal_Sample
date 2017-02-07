using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Guide  {

    private static float targetAngleFromUserFacing;
    public static float TargetAngleFromUserFacing{get {
        return targetAngleFromUserFacing;
    } set {
        targetAngleFromUserFacing = value;
        Debug.Log("targetAngleFromUserFacing was updated to: "+targetAngleFromUserFacing);
    }}

    private static float distanceFromPlayer;
    public static float DistanceFromPlayer{get {
        return distanceFromPlayer;
    } set {
        distanceFromPlayer = value;
        Debug.Log("tdistance from player was updated to: "+distanceFromPlayer);
    }}


    public static float CalculateAdjacentLegLength(){
        //cos = adjacent/hypotenuse
        float adj = Mathf.Cos(TargetAngleFromUserFacing) * DistanceFromPlayer;
        Debug.Log("this is the adjacent side length = "+adj);
        return adj;

    }

    public static float CalculateOppositeLegLength(){
        //sin = opposite/hypotenuse;
        float opp = Mathf.Sin(TargetAngleFromUserFacing) * DistanceFromPlayer;
        Debug.Log("this is the opposite side length = "+opp);
        return opp;
    }

    public static string AR_DirectionsResponse(){
        string myResponse = "";

        return myResponse;
    }


}
