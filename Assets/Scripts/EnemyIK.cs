using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyIK : MonoBehaviour {
    public Animator anim;
    public GameObject player;

    private void Start()
    {
        anim = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void OnAnimatorIK()
    {

        anim.SetLookAtWeight(1);
        anim.SetLookAtPosition(player.transform.position);
        anim.SetIKPositionWeight(AvatarIKGoal.RightHand, 1);
        anim.SetIKPosition(AvatarIKGoal.RightHand, player.transform.position);

    }
   
}
