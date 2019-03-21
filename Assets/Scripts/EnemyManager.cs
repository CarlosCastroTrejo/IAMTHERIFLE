using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
     GameObject[] arr;
     GameObject enemy;
    Queue<int> pila;
    bool[] visit;
    int alt;
    public string objeto;
    void GeneraPatron()
    {
        int x;
        int N = arr.Length;
        while (pila.Count < N)
        {
            x = Random.Range(0, N);
            if (x != visit.Length)
            {
                if (visit[x] == false)
                {
                    visit[x] = true;
                    pila.Enqueue(x);
                }
            }
        }
    }
    void Resetear()
    {
        for (int i = 0; i < visit.Length; i++)
            visit[i] = false;
        while (pila.Count > 0)
            pila.Dequeue();
    }
    void SpawnNext()
    {
        Vector3 pos = arr[pila.Peek()].transform.position;
        pos.y += alt;
        Instantiate(enemy, pos, Quaternion.identity, GameObject.Find("EnemyManager").transform);
        Debug.Log(pila.Dequeue());
    }
    void RandSpawn()
    {
        if (pila.Count > 0)
        {
            int x;
            x = Random.Range(0, 101);
            Debug.Log(x);
            if (x < 50)
            {
                SpawnNext();
            }
        }
        else
        {
            alt += 2;
            Resetear();
            GeneraPatron();
        }
    }
    // Use this for initialization

    void Start()
    {
        alt = 0;
        enemy = Resources.Load(objeto) as GameObject;
        arr = GameObject.FindGameObjectsWithTag("Respawn");
        visit = new bool[arr.Length];
        pila = new Queue<int>();
        Resetear();
        GeneraPatron();
        InvokeRepeating("RandSpawn", 1, 1.50f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
