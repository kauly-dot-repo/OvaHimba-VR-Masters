using UnityEngine;
using System.Collections.Generic;

public class DynamicCollisionTracker : MonoBehaviour
{
   private int machetteCollisionCount = 0;
    public Rigidbody rb;

    void Start()
    {
        // Get the Rigidbody component of the WoodInteractable object
        
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding object has the tag "Machette"
        Debug.Log("I'M HIT!!!!" + collision.gameObject.name);
        machetteCollisionCount++;
        if (machetteCollisionCount >= 3)
        {
            rb.isKinematic = true;
        }
    }
}
