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
    public bool grounded;
    public float groundCheckDistance;
    public float jumpForce = 5.0f;
    private float bufferCheckDistance = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
        
    }

    private void FixedUpdate(){
        rb.AddForce(movementDir.normalized * movementForce + drag);
    }

    private void Move(){
        movementDir = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        drag = new Vector3(-rb.velocity.x * dragForce, 0f, -rb.velocity.z * dragForce);
    }

    private void Jump(){
        groundCheckDistance = (GetComponent<CapsuleCollider>().height / 2) + bufferCheckDistance;

        if(Input.GetKeyDown(KeyCode.Space) && grounded){
            rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
        }

        RaycastHit hit;
        if(Physics.Raycast(transform.position, -transform.up, out hit, groundCheckDistance)){
            grounded = true;
        } else {
            grounded = false;
        }
    }

}
