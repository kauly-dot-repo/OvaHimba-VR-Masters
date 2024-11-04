using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction;

public class BranchPlacementManager : MonoBehaviour
{
    List <GameObject> snapzones;

    // [Serialized]
    private SnapInteractable snapInteractable;



    // Start is called before the first frame update
    void Start()
    {
        // snapzones = new List <GameObject>(GameObject.Find("SnapInteractable"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
