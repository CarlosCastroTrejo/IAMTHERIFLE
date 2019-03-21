using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ragdoll : MonoBehaviour {

    public GameObject ragdoll;
    public int Power;
    // Use this for initialization
    void Start () 
    {
        ragdoll = Resources.Load("EnemyRagdoll") as GameObject;
		
	}
	
	// Update is called once per frame
	void Update () 
    {

    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bala"))
        {
            GameObject muneco=Instantiate (ragdoll, transform.position,ragdoll.transform.rotation);
          muneco.transform.GetChild(0).GetChild(2).GetChild(0).GetComponent<Rigidbody>().AddForce(other.GetComponent<Rigidbody>().velocity*Power);
            Destroy(muneco, 3);
        }
    }


}
