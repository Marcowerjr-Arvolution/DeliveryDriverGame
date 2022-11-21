using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{   
    [SerializeField] GameObject targetToFollow; 
    void LateUpdate()
    {   
        transform.position = targetToFollow.transform.position + new Vector3(0, 0, -10);
    }
}
