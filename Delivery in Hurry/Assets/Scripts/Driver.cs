using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float moveSpeed = 20f, steerSpeed = 1f, slowSpeed= 15f, boostSpeed = 30f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Boost")
        {
            moveSpeed = boostSpeed;
            Destroy(other.gameObject, 0.01f);
        }
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        moveSpeed = slowSpeed;
        
    }

    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
}
