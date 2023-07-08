using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void toGame(string name)
    {
        SceneLoader.sceneLoadProgress(name);
    }

    public void resumeGame()
    {
        //SceneManager.LoadScene(1);
        Debug.Log("Ini ke masuk Resume Game");
    }

    public void backMainMenu(string name)
    {
        SceneLoader.sceneLoadProgress(name);
    }
    public void quitGame()
    {
        Application.Quit();
    }

}
