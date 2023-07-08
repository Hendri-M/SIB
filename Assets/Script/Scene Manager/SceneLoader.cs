using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader
{
    private static string progressLoad;

    public static string ProgressLoad { get => progressLoad; }

    public static void sceneLoad(string name)
    {
        SceneManager.LoadScene(name);
    }

    public static void sceneLoadProgress(string name)
    {
        progressLoad = name;
        SceneManager.LoadScene("LoadingScreen");
    }
}
