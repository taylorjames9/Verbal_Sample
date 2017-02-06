 using UnityEngine;
 using System.Collections;
  
 public class Movement : MonoBehaviour
  
 {
        void Update ()
        {
            if (Input.GetKey(KeyCode.UpArrow))
				transform.Translate(Vector3.forward * Time.deltaTime *10);
            else if (Input.GetKey(KeyCode.DownArrow))
				transform.Translate(Vector3.back * Time.deltaTime *10);
        }
 }

