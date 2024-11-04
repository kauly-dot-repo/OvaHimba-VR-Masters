using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListComponent : MonoBehaviour
{
    List <GameObject> listedGgameObjects;
    // Start is called before the first frame update
    void Start()
    {
        listedGgameObjects = new List <GameObject> ();
    }

    // public void Count()
    // {
    //     int count = listedGgameObjects.Length();
    //     return count;
    // }

}
