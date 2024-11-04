using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    private Animator mAnimator;
    public GameObject woman;
    public GameObject place;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        mAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (mAnimator != null)
        {
            mAnimator.SetTrigger("TrWalk");

            woman.transform.position = Vector3.Lerp(
                woman.transform.position, 
                place.transform.position, 
                speed * Time.deltaTime
            );

            if (Vector3.Distance(woman.transform.position, place.transform.position) < 0.01f) // Adjust the threshold as needed
            {
                mAnimator.ResetTrigger("TrWalk");  // Stop the animation trigger
            }
            else
            {
                mAnimator.SetTrigger("TrWalk");  // Continue walking
            }
            
        } 


        
        
    }


    
}
