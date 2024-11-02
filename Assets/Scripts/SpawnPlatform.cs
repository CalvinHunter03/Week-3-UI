using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatform : MonoBehaviour
{

    public Transform spawnPoint;
    public Transform appleSpawnPoint;
    public GameObject applePlatform;
    public GameObject platform;
    public bool triggered = false;
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
<<<<<<< HEAD
            chanceForNegative = Random.Range(0.0f, 1.0f);
            if (chanceForNegative >= 0.5f)
            {
                randomAppleXPos *= -1;
            }
            Vector3 applePlatformPos = new Vector3(spawnPoint.position.x + randomAppleXPos, spawnPoint.position.y, spawnPoint.position.z + randomZPos);
<<<<<<< HEAD
            if (chanceToApple >= 0.75f)
=======
            Vector3 applePlatformPos = new Vector3(appleSpawnPoint.position.x + Random.Range(-3, 4), appleSpawnPoint.position.y, appleSpawnPoint.position.z + Random.Range(1, 3));
            if (chanceToApple > 0.75f)
>>>>>>> parent of 5ff6c62 (fixed apple platform kinda, i like the way it works)
=======
            if (chanceToApple > 0.75f)
>>>>>>> parent of b1b3b8a (can't fall and object pooling)
            {
                Instantiate(applePlatform, applePlatformPos, Quaternion.identity);
            }

            Vector3 newPos = new Vector3(spawnPoint.position.x + randomXPos, spawnPoint.position.y + randomYPos, spawnPoint.position.z + randomZPos);
<<<<<<< HEAD
            //Instantiate(platform, newPos, Quaternion.identity);
            GameObject thePlatform = ObjectPool.instance.GetPlatformObject();
            if (thePlatform != null)
            {
                thePlatform.transform.position = newPos;
                thePlatform.SetActive(true);
            }
=======
            Instantiate(platform, newPos, Quaternion.identity);
>>>>>>> parent of b1b3b8a (can't fall and object pooling)
            triggered = true;
        }
    }
}
