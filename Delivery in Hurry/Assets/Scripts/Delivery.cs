using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
  bool hasPackage = false;
  [SerializeField] float destroyDelayTime;
  [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
  [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);

  SpriteRenderer spriteRenderer;

  void Start() 
  {
    spriteRenderer = GetComponent<SpriteRenderer>();
  }


  void OnTriggerEnter2D(Collider2D other) 
  {
    if(other.tag == "Package" && !hasPackage)
    {
      Debug.Log("Package Picked");
      hasPackage = true;
      spriteRenderer.color = hasPackageColor; 
      Destroy(other.gameObject, destroyDelayTime);
    } 

    if(other.tag == "Customer" && hasPackage)
    {
      Debug.Log("Package Delivered");
      hasPackage = false;
      spriteRenderer.color = noPackageColor;
    }
  }
}
