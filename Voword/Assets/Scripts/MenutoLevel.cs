using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenutoLevel : MonoBehaviour
{
    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadLevelOneFreeRoam()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadLevelTwo()
    {
        SceneManager.LoadScene(3);
    }

    public void LoadLevelThree()
    {
        SceneManager.LoadScene(4);
    }
}
