using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    [SerializeField] GameObject carForFollow;
    void LateUpdate()
    {
        transform.position = carForFollow.transform.position + new Vector3(0, 0, -10);
        
    }
}
