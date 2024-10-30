using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectSpawner : MonoBehaviour
{

    public Transform plane;
    public GameObject thingToSpawn;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-9, 10), .25f, Random.Range(-9, 10));
            
            //Instantiate(thingToSpawn, randomSpawnPosition, Quaternion.identity);
            GameObject apple = ObjectPool.instance.GetPooledObject();
            if(apple != null){
                apple.transform.position = randomSpawnPosition;
                apple.SetActive(true);
            }
        }
    }
}
