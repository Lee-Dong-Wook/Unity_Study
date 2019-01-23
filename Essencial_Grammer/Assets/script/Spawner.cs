using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject target;

    public Transform spawnPosition;

	void Start () {

       GameObject instance = Instantiate(target,spawnPosition.position,spawnPosition.rotation);

        instance.GetComponent<Rigidbody>().AddForce(0,1000,0);

        Debug.Log(instance.name);
    }
}
