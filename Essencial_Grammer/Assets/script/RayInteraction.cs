using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayInteraction : MonoBehaviour {

    public LayerMask whatIsTarget; 

    private Camera playerCam;

    public float distance = 100f;

    private Transform moveTarget; //충돌한 변수를 넣어 시선에 따라 계속 움직이게 한다.

    private float targetDistance; 

	void Start () {
        playerCam = Camera.main;//현재활성화된 카메라를 가지고 온다.   
	}
	
	void Update () {

        //카메라가 보고있는 정중앙,화면에서 보고있는 곳이 게임세계상에서 어떤 위치인지를 저장 
        Vector3 rayOrigin = playerCam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0f));
        
        //광선을 쏠때 어느 방향으로 쏠지 정함, 카메라의 앞쪽 
        Vector3 rayDir = playerCam.transform.forward;

        //raycast는 다양한 변수와 형식이 존재한다. 
        Ray ray = new Ray(rayOrigin,rayDir);

        Debug.DrawRay(ray.origin, ray.direction*100f, Color.green); 

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit; 

            //rayOrigin 위치에서 rayDir 방향으로 distance만큼 광선을 쏘아 걸리는 물체가 있는지 검사 
            if (Physics.Raycast(ray, out hit, distance, whatIsTarget))         
            {
                GameObject hitTarget = hit.collider.gameObject;

                hitTarget.GetComponent<Renderer>().material.color = Color.red;

                moveTarget = hitTarget.transform;
                targetDistance = hit.distance;
         
            }
        }

        if(Input.GetMouseButtonUp(0))
        {
            if(moveTarget != null)
            {
                moveTarget.GetComponent<Renderer>().material.color = Color.white;
            }
            moveTarget = null;
        }

        if(moveTarget != null)
        {
            moveTarget.position = ray.origin + ray.direction * targetDistance;
        }

	}

    


}
