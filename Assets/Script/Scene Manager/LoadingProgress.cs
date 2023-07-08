using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingProgress : MonoBehaviour
{
    [SerializeField] Image  imageLoader;

    private void Start() {
        StartCoroutine(LoadingScreen());
    }

    IEnumerator LoadingScreen()
    {
        imageLoader.fillAmount = 0;
        yield return new WaitForSeconds(3);
        var asyncLoad = SceneManager.LoadSceneAsync(SceneLoader.ProgressLoad);

        while (asyncLoad.isDone == false)
        {
            imageLoader.fillAmount = asyncLoad.progress;
            yield return null;
        }
    }
}
