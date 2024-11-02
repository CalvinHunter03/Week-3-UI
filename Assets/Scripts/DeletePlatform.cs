using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePlatform : MonoBehaviour
{

    public GameObject platform;
    private SpawnPlatform spawnPlatform;

    void Start()
    {
        if (platform != null)
        {
            spawnPlatform = platform.GetComponent<SpawnPlatform>();
        }
        else
        {
            Debug.LogError("Platform is not assigned in the Inspector.", this);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
<<<<<<< HEAD

            if (spawnPlatform == null)
            {
                Debug.LogError("spawnPlatform is null. Check if the component was added.");
                return;
            }
            spawnPlatform.triggered = false;
            platform.SetActive(false);
=======
            Destroy(platform);
>>>>>>> parent of b1b3b8a (can't fall and object pooling)
        }

    }
}
