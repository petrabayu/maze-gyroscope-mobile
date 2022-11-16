using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoadManager : MonoBehaviour
{
    //Load
    public static void Load(string sceneName)
    {
        SceneLoader.Load(sceneName);
    }



    //progress Load
    public static void ProgressLoad(string sceneName)
    {
        SceneLoader.ProgressLoad(sceneName);
    }



    //reload level
    public static void ReloadLevel()
    {
        SceneLoader.ReloadLevel();
    }

    //load next level

    public static void LoadNextLevel()
    {
        SceneLoader.LoadNextLevel();
    }
}
