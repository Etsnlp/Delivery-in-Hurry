using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
  void OnCollisionEnter2D(Collision2D other)
  {
    //Debug.Log("HIT");
    
  }

  void OnTriggerEnter2D(Collider2D other) 
  {
    if(other.tag == "Package")
    {
      Debug.Log("TRIGGER");
    } 
  }
}
