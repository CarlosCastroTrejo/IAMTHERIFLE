using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teletransport : MonoBehaviour {

    public Transform teletrasportTo;
    public char Tecla;

    private void OnTriggerStay(Collider col)
    {
      
        if (Input.GetKeyDown("x"))
        {
           
            col.transform.position = teletrasportTo.position;
        }
    }

    // Use this for initialization
    void Start () 
    {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
