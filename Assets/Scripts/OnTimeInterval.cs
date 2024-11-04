using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class OnTimeInterval : MonoBehaviour
{
    // [Tooltip("The minimum range")]
    // public float minInterval = 0.0f;

    [Tooltip("The maximum range")]
    public float maxInterval = 1.0f;

    // Called once the wait is over
    public UnityEvent OnIntervalElapsed = new UnityEvent();

    private void Start()
    {
        StartCoroutine(IntervalRoutine());
    }

    private IEnumerator IntervalRoutine()
    {
        // float interval = Random.Range(minInterval, maxInterval);
        yield return new WaitForSeconds(maxInterval);
        PlayEvent();
        StartCoroutine(IntervalRoutine());
    }

    private void PlayEvent()
    {
        OnIntervalElapsed.Invoke();   

    }
}