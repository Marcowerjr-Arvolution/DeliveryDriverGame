using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] float destroyDelay = 0.5f;
    bool hasPackage = false;

    private void Start() {
        Debug.Log("Delivery started!");
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Package" && !hasPackage) 
        {
            hasPackage = true;
            Debug.Log("Package Picked Up!");
            Destroy(other.gameObject, destroyDelay);
        }
        if (other.tag == "Package" && hasPackage) 
        {
            Debug.Log("Already have a package!");
        }
        if (other.tag == "Customer")
        {
            if (hasPackage)
            {
                Debug.Log("Package Delivered!");
                hasPackage = false;
                Destroy(other.gameObject, destroyDelay);
            }
            else
            {
                Debug.Log("No Package!");
            }
        }
    }
}
