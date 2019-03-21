using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooter : MonoBehaviour {
    public GameObject bala;

    void Shoot() {
      
        GameObject b = Instantiate(bala, transform.position, transform.rotation) as GameObject;
        b.GetComponent<Rigidbody>().velocity = transform.forward * 8;
    }

	// Use this for initialization
	void Start () {

        InvokeRepeating("Shoot", 0.5f, 2);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
