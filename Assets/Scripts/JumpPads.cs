using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPads : MonoBehaviour
{
    PlayerMovement playerMovement;
    Rigidbody rb;
    [SerializeField] float jumpStrength;
    private void Start()
    {
        playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
        rb = GameObject.Find("Player").GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z);
            rb.AddForce(transform.up * jumpStrength, ForceMode.Impulse); playerMovement.Jump(jumpStrength);
        }
    }
}
