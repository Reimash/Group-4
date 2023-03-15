using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour
{

    public void LoadLevelOneScene()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadMainMenuScene()
    {
        SceneManager.LoadScene(0);
    }

}
