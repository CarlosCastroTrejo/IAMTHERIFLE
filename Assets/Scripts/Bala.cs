using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bala : MonoBehaviour {
    public string emitter = "";

    public void SetEmitter(string e) {
        emitter = e;
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("OnCollisionEnter en " + gameObject.name + " con " + collision.gameObject.name);
        if (other.gameObject.CompareTag("Player"))
        {
            if (!emitter.Equals("Player"))
            {
                Debug.Log("Game Over");
                SceneManager.LoadScene(0);
            }
        }
        else if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
        else
        {
            //SoundManager.instance.PlaySound("CRACK");
            Destroy(this.gameObject);
        }
    }
}
