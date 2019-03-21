using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {
    public GameObject bala;
    public AudioSource shootSound;

	// Use this for initialization
	void Start () {
        shootSound = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * 10);
        
        if (Input.GetMouseButtonDown(0)) {
            shootSound.Play();
            RaycastHit hit;
            Vector3 dir;
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit))
            {
                Debug.DrawLine(hit.point, transform.position);
                dir = hit.point - transform.position;                
            }
            else {
                dir = Camera.main.transform.forward;
            }
            GameObject b = Instantiate(bala, transform.position, transform.rotation) as GameObject;
            b.GetComponent<Rigidbody>().velocity = dir.normalized * 8;
            b.GetComponent<Bala>().SetEmitter("Player");
        }
	}
}
