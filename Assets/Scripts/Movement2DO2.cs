 using UnityEngine;
 using System.Collections;
  
 public class Movement2DO2 : MonoBehaviour
  
 {
         void Update ()
         {
                //  if (Input.GetKey(KeyCode.LeftArrow))
                //  {
				// 		transform.Translate(Vector3.left * Time.deltaTime *10);
                //  }
                //  if (Input.GetKey(KeyCode.RightArrow))
                //  {
				// 		transform.Translate(Vector3.right * Time.deltaTime *10);
                //  }
                 if (Input.GetKey(KeyCode.UpArrow))
                 {
					transform.Translate(Vector3.forward * Time.deltaTime *10);
                 }
                 if (Input.GetKey(KeyCode.DownArrow))
                 {
					transform.Translate(Vector3.back * Time.deltaTime *10);

                 }
 }
 }

