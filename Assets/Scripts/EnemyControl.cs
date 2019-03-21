using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyControl : MonoBehaviour {
    public GameObject player;
    public NavMeshAgent agent;
    public Animator anim;

	// Use this for initialization
	void Start () {
        agent = this.GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player");
        anim = transform.GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update () {
        agent.SetDestination(player.transform.position);
        float speed = agent.speed;
        anim.SetFloat("speed", speed);
    }
}
