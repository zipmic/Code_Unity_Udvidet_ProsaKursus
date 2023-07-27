using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateGameObject : MonoBehaviour
{
    public GameObject PrefabToSpawn;
    public float SpawnEvery;

    private float counter;

	private void Start()
	{
        counter = SpawnEvery;
	}

	// Update is called once per frame
	void Update()
    {
        counter -= Time.deltaTime;
        if (counter <= 0)
        {
            GameObject Spawn = Instantiate(PrefabToSpawn) as GameObject;
            Spawn.transform.position = transform.position;
            counter = SpawnEvery;
        }
    }
}


