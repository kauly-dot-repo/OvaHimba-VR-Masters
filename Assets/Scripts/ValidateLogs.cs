using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValidateLogs : MonoBehaviour
{
    public PlayAudio playAudio;
    public AudioSource wrongAudio;
    public AudioSource correctAudio;
    // public string specificTag;
    public List <string> specificTags = new List<string>();
    
    // Start is called before the first frame update


    
void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag !="Untagged") {
            other.gameObject.layer = 0;
            if(specificTags.Count != 0)
            {
                Debug.Log($"the object collided with was ===> {other.gameObject.tag}");
            
                if (specificTags.Contains(other.gameObject.tag))
                {
                    
                    Debug.Log($"the CORRECT object collided with was ===> {other.gameObject.tag}!!!!");
                    playAudio.PlayAudioSource(correctAudio);
                    // other.gameObject.GetComponent<Rigidbody>().isKinematic = true;
                    // this.gameObject.GetComponent<Collider>().isTrigger = false;
                    // other.gameObject.GetComponent<Collider>().enabled = false;
                    
                } else {

                    Debug.Log($"the WRONG object collided with was ===> {other.gameObject.tag} INSTEAD??????");
                    playAudio.PlayAudioSource(wrongAudio);
                    // other.gameObject.GetComponent<Rigidbody>().isKinematic = false;
                    // this.gameObject.GetComponent<Collider>().isTrigger = true;

                    // other.gameObject.GetComponent<BoxCollider>().enabled = true;
                }
            } 
        }
        

        // Debug.Log($"the object collided with was ===> {other.gameObject.tag}");
        
        //     if (other.gameObject.tag != specificTag)
        //     {
        //         Debug.Log($"the WRONG object collided with was ===> {other.gameObject.tag} INSTEAD OF {specificTag} has been added.");
        //         playAudio.PlayAudioSource(wrongAudio);
        //     } else {
        //         Debug.Log($"the CORRECT object collided with was ===> {other.gameObject.tag} same as {specificTag} has been added.");
        //         playAudio.PlayAudioSource(correctAudio);
        //     }
        
    }

    void OnTriggerExit(Collider other)
    {
        other.gameObject.layer = 3;
        // other.gameObject.GetComponent<Rigidbody>().isKinematic = false;
        // this.gameObject.GetComponent<Collider>().isTrigger = true;
        // other.gameObject.GetComponent<Collider>().enabled = true;
    }
}
