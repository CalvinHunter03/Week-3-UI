using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectSpawner : MonoBehaviour
{

    public Transform plane;
    public GameObject thingToSpawn;
    private bool done = false;

    void Update()
    {
        if (!done)
        {
            for (int i = 0; i < 10; i++)
            {
                Vector3 randomSpawnPosition = new Vector3(Random.Range(-9, 10), .25f, Random.Range(-5, 10));

                //Instantiate(thingToSpawn, randomSpawnPosition, Quaternion.identity);
                GameObject apple = ObjectPool.instance.GetPooledObject();
                if (apple != null)
                {
                    apple.transform.position = randomSpawnPosition;
                    apple.SetActive(true);
                }
            }
            done = true;
        }

    }
}
