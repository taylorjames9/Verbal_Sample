 using UnityEngine;
 using System.Collections;
  
 public class Movement2DO : MonoBehaviour
  
 {
         void Update ()
         {
                 if (Input.GetKey(KeyCode.LeftArrow))
                 {
                         Vector3 position = this.transform.position;
                         position.x-=0.2f;
                         this.transform.position = position;
                 }
                 if (Input.GetKey(KeyCode.RightArrow))
                 {
                         Vector3 position = this.transform.position;
                         position.x+=0.2f;
                         this.transform.position = position;
                 }
                 if (Input.GetKey(KeyCode.UpArrow))
                 {
                         Vector3 position = this.transform.position;
                         position.z+=0.2f;
                         this.transform.position = position;
                 }
                 if (Input.GetKey(KeyCode.DownArrow))
                 {
                         Vector3 position = this.transform.position;
                         position.z-=0.2f;
                         this.transform.position = position;
                 }
 }
 }
