using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehavour : MonoBehaviour {
    void Autodes ()
    {
        Destroy(this.gameObject);
    }
	// Use this for initialization
	void Start () {
        Invoke("Autodes", 1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
