 using UnityEngine;
 using System.Collections;
  
 public class Player : MonoBehaviour
  
 {

    public static Player Instance{get; set;}

        void Update ()
        {
            if (Input.GetKey(KeyCode.UpArrow))
				      transform.Translate(Vector3.forward * Time.deltaTime *10);
            else if (Input.GetKey(KeyCode.DownArrow))
				      transform.Translate(Vector3.back * Time.deltaTime *10);


            if(Input.GetKey(KeyCode.LeftArrow)){
			        Debug.Log("A Key is DOWN");
			        transform.Rotate(0,-1,0);
		        } else if (Input.GetKey(KeyCode.RightArrow)){
			        transform.Rotate(0,1,0);}
        }
 }

