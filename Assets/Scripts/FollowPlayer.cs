using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform playerPos;
    public float speed = 5.0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(this.transform.position, playerPos.position, speed * Time.deltaTime);

        float dist = Vector3.Distance(playerPos.position, this.transform.position);
        if (dist >= 20)
        {
            transform.position = new Vector3(playerPos.position.x, playerPos.position.y, playerPos.position.z - 5);
        }
    }
}
