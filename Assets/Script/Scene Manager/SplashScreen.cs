using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SplashScreen : MonoBehaviour
{
    [SerializeField] Image loadingProgress;

    void Start()
    {
        StartCoroutine(splashLoading());
    }

    IEnumerator splashLoading()
    {
        loadingProgress.fillAmount = 0;
        yield return new WaitForSeconds(3);

        var async = SceneManager.LoadSceneAsync("MainMenu");

        while (async.isDone == false)
        {
            loadingProgress.fillAmount = async.progress;
            yield return null;
        }
    }

}
