using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObs : MonoBehaviour
{
    [SerializeField] private PlayerControl pc;
    [SerializeField] private GameObject obsprefab;
    [SerializeField] private Transform[] spawnPoints;

    private float timer = 3f;
    // Start is called before the first frame update
    void Start()
    {
        timer = Random.Range(3, 8);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * pc.movespeed);

        if(timer <= 0)
        {
            Instantiate(obsprefab, spawnPoints[Random.Range(0, spawnPoints.Length)].position, Quaternion.identity);
            timer = Random.Range(3, 8);
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }
}
