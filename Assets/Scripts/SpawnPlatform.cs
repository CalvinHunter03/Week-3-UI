using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatform : MonoBehaviour
{

    public Transform spawnPoint;
    public Transform appleSpawnPoint;
    public GameObject applePlatform;
    public GameObject platform;
    private bool triggered = false;
    private int randomXPos;
    private int randomYPos;
    private int randomZPos;
    private float chanceToApple;


    private void OnTriggerEnter(Collider other)
    {
        if (!triggered && other.gameObject.tag == "Player")
        {
            randomXPos = Random.Range(-2, 3);
            randomYPos = Random.Range(-1, 2);
            randomZPos = Random.Range(3, 6);

            if (randomYPos == 1)
            {
                randomXPos = Random.Range(-1, 2);
                randomZPos = Random.Range(3, 6);
            }

            chanceToApple = Random.Range(0.0f, 1.0f);
            Vector3 applePlatformPos = new Vector3(appleSpawnPoint.position.x + Random.Range(-3, 4), appleSpawnPoint.position.y, appleSpawnPoint.position.z + Random.Range(1, 3));
            if (chanceToApple > 0.75f)
            {
                Instantiate(applePlatform, applePlatformPos, Quaternion.identity);
            }

            Vector3 newPos = new Vector3(spawnPoint.position.x + randomXPos, spawnPoint.position.y + randomYPos, spawnPoint.position.z + randomZPos);
            Instantiate(platform, newPos, Quaternion.identity);
            triggered = true;
        }
    }
}
