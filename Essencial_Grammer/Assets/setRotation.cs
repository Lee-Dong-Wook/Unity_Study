using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setRotation : MonoBehaviour {

    //public Transform targetTransform;

    void Start () {
        /*
        Quaternion Look = Quaternion.LookRotation(new Vector3(0, 1, 0));
        transform.rotation = Look;    
        */

        /*
        Quaternion aRotation = Quaternion.Euler(new Vector3(30,0,0));
        Quaternion bRotation = Quaternion.Euler(new Vector3(60, 0, 0));

        Quaternion targetRotation = Quaternion.Lerp(aRotation,bRotation,0.5f);
        transform.rotation = targetRotation;
        */
        /*
        Quaternion targetRotation = Quaternion.Euler(45,0,0);
        transform.rotation = targetRotation;
        transform.Rotate(new Vector3(30,0,0));
        */
        /*
        Quaternion originalRotation = transform.rotation;

        Vector3 originalRotationInVector3 = originalRotation.eulerAngles;

        Debug.Log(originalRotationInVector3);

        Vector3 targetRoationVec = originalRotationInVector3 + new Vector3(30,0,0);

        Quaternion targetRotation = Quaternion.Euler(targetRoationVec);

        transform.rotation = targetRotation; 
        */
        /*
        Quaternion originalRotation = Quaternion.Euler(new Vector3(30,0,0));

        Quaternion plusRotation = Quaternion.Euler(new Vector3(45, 0, 0));

        Quaternion targetRotation = originalRotation * plusRotation;

        transform.rotation = targetRotation;
    */

        transform.Rotate(30,0,0);
        }
    
    private void Update()
    { 
        /*
        Vector3 direction = targetTransform.position - transform.position;
        Quaternion Look = Quaternion.LookRotation(direction);
        transform.rotation = Look;
        */
    }
}
