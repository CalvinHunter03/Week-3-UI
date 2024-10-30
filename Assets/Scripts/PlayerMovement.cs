using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private Vector3 movementDir;
    [SerializeField] private float movementForce;
    [SerializeField] private Vector3 drag;
    [SerializeField] private float dragForce;
    [SerializeField] private Rigidbody rb;

    private int jumpCount;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //read values from keyboard
        movementDir = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        drag = new Vector3(-rb.velocity.x * dragForce, 0f, -rb.velocity.z * dragForce);
        
        
    }

    private void FixedUpdate(){
        rb.AddForce(movementDir.normalized * movementForce + drag);
    }

}
