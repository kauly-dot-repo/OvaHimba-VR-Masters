using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Oculus.Interaction.Samples;

public class SceneTransitionManager : MonoBehaviour
{
    public OVRScreenFade fadeScreen;
    public SceneLoader sceneLoader;
    
    public void GoToNextSceneAsync(string targetScene)
    {
        StartCoroutine(GoToNextSceneAsyncRoutine(targetScene));
    }

    IEnumerator GoToNextSceneAsyncRoutine(string targetScene)
    {
        fadeScreen.FadeOut();
        yield return new WaitForSeconds(3);

        sceneLoader.Load(targetScene);
    }

    public void ExitGame()
    {
        StartCoroutine(ExitGameRoutine());
    }

    IEnumerator ExitGameRoutine()
    {
        fadeScreen.FadeOut();
        yield return new WaitForSeconds(3);

        Application.Quit();
    }

}
