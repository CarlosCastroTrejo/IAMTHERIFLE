using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class SniperControl : MonoBehaviour {


    public GameObject Aparicion;
    GameObject enemy;
    GameObject[] SniperPoints;
    public string objeto;
    bool check;
    GameObject sniper;
    public Animator anim;


    void Spawn()
    {
      
        Vector3 pos = Aparicion.transform.position;
         sniper=Instantiate(enemy, pos, Quaternion.identity, this.transform);
        sniper.transform.GetComponent<EnemyControl>().enabled = false;
        sniper.transform.GetChild(0).GetComponent<EnemyIK>().enabled = false;
        sniper.transform.GetChild(0).GetChild(2).gameObject.SetActive(false);
        anim = sniper.transform.GetComponentInChildren<Animator>();
        anim.SetFloat("speed", sniper.GetComponent<NavMeshAgent>().speed);



        sniper.GetComponent<NavMeshAgent>().SetDestination(SniperPoints[Random.Range(0, SniperPoints.Length)].transform.position);
    }


    // Use this for initialization

    void Start()
    {
        enemy = Resources.Load(objeto) as GameObject;
       
        SniperPoints = GameObject.FindGameObjectsWithTag("SniperPoints");
        check = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.childCount == 0)
        {
           Spawn();
        }

        if (Vector3.Distance(sniper.transform.position,this.transform.position)<4)
        {
            sniper.transform.GetChild(0).GetComponent<EnemyIK>().enabled = true;
            sniper.transform.GetChild(0).GetChild(2).gameObject.SetActive(true);

        }
    }
}
