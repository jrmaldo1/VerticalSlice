using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Rigidbody rb;

    public bool isGrounded = false;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * 7, ForceMode.Impulse);
            isGrounded = false;
        }
    }
    private void OnCollisionEnter(Collision theCollision)
    {
        if (theCollision.gameObject.tag == "_isGrounded")
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
}
}
