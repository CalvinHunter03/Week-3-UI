using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatform : MonoBehaviour
{

    public Transform spawnPoint;
    public Transform appleSpawnPoint;
    public GameObject applePlatform;
    public GameObject platform;
    public GameObject platformCounterTrigger;
    public bool triggered = false;
    private int randomXPos;
    private int randomYPos;
    private int randomZPos;
    private int randomAppleXPos;
    private float chanceToApple;
    private float chanceForNegative;


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
                randomZPos = Random.Range(3, 5);
            }

            chanceToApple = Random.Range(0.0f, 1.0f);
            chanceForNegative = Random.Range(0.0f, 1.0f);

            if (chanceForNegative >= 0.5f)
            {
                randomAppleXPos *= -1;
            }

            Vector3 applePlatformPos = new Vector3(spawnPoint.position.x + randomAppleXPos, spawnPoint.position.y + randomYPos, spawnPoint.position.z + randomZPos);
            if (chanceToApple >= 0.75f)
            {
                Instantiate(applePlatform, applePlatformPos, Quaternion.identity);
            }

            Vector3 newPos = new Vector3(spawnPoint.position.x + randomXPos, spawnPoint.position.y + randomYPos, spawnPoint.position.z + randomZPos);
            //Instantiate(platform, newPos, Quaternion.identity);

            //Instantiate(platform, newPos, Quaternion.identity);

            GameObject newPlatform = ObjectPool.instance.GetPooledPlatform();
            if (newPlatform != null)
            {
                newPlatform.transform.position = newPos;
                newPlatform.SetActive(true);

            }

            /*
            if (platformCounterTrigger != null)
            {
                platformCounterTrigger.transform.position = new Vector3(platformCounterTrigger.transform.position.x, platformCounterTrigger.transform.position.y + 2, platformCounterTrigger.transform.position.z);
            }
            */
            triggered = true;
        }
    }

    private void OnDisable()
    {
        triggered = false;

    }
}
