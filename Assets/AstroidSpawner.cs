using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidSpawner : MonoBehaviour
{

    public GameObject Meteor;
    private float SpawnTime;
    private float STime;

    public float MinTime = 1.0f;
    public float MaxTime = 7.0f;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        STime += Time.deltaTime;

        if(STime >= SpawnTime)
        {
            SpawnMeteor();
            RandomSpawnTime();
        }
	}

    void SpawnMeteor ()
    {
        STime = 0;
        Instantiate(Meteor, transform.position, Meteor.transform.rotation);
    }

    void RandomSpawnTime ()
    {
        SpawnTime = Random.Range(MinTime, MaxTime);
    }
}
