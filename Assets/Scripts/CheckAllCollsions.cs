using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckAllCollsions : MonoBehaviour
{

    // Start is called before the first frame update
    void OnCollisionEnter(Collision other)
    {
        Debug.Log($"The object colliding with {this.gameObject.name} is {other.gameObject.name}");
    }
}
