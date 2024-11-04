using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Oculus.Interaction.HandGrab;


public class TreeChopping : MonoBehaviour
{
    // [SerializeField]
    // private int minHits = 2; // Minimum number of hits needed (inclusive)

    // [SerializeField]
    // private int maxHits = 5; // Maximum number of hits needed (inclusive)

    // [SerializeField]
    // private int requiredHits; // Number of hits needed to turn kinematic (adjust as needed)

    // private int hitCount = 0;
    // public List<GameObject> treesChopped;
    public List<GameObject> treesInScene;
    public int collisionCounter;

    public SceneTransitionManager sceneTransition;

    public string targetScene;

    private Coroutine checkingCoroutine;
    private void Start()
    {
        // Randomize requiredHits on Start
        // requiredHits = Random.Range(minHits, maxHits + 1);
        // requiredHits = 4;
        //Get the objects to check
        treesInScene = new List<GameObject>(GameObject.FindGameObjectsWithTag("woodInteractable"));
        // check if objects are kinematic
        checkingCoroutine = StartCoroutine(CheckTreesChoppedRoutine());
    }

    

    private IEnumerator CheckTreesChoppedRoutine()
    {
        while (true) // This loop will continue until we break out of it
        {
            bool allKinematic = true; // Assume all are kinematic initially

            // Loop through the list of objects
            foreach (GameObject tree in treesInScene)
            {
                // Get the Rigidbody component
                Rigidbody rb = tree.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    // If any Rigidbody is not kinematic, set the flag to false
                    if (!rb.isKinematic)
                    {
                        allKinematic = false;
                        break; // Exit the loop early if one is found
                    }
                }
                else
                {
                    // Optionally handle the case where the object does not have a Rigidbody
                    Debug.LogWarning($"{tree.name} does not have a Rigidbody component.");
                    allKinematic = false; // You can decide how to handle this case
                    break;
                }
            }

            // Call GoToNextSceneAsync if all are kinematic
            if (allKinematic)
            {
                sceneTransition.GoToNextSceneAsync(targetScene);
                yield break; // Exit the coroutine
            }
            else
            {
                Debug.Log("Not all objects are kinematic. Staying in the current scene.");
            }

            // Wait for a short period before checking again
            yield return new WaitForSeconds(0.5f); // Adjust the wait time as necessary
        }
    }
   
}
