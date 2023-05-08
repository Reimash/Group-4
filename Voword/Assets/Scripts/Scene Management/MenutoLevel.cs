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

    public void LoadTutorialIsland()
    {
        SceneManager.LoadScene(16);
    }

    public void LoadLevelTwoFreeRoam()
    {
        SceneManager.LoadScene(19);
    }

    public void LoadLevelThreeFreeRoam()
    {
        SceneManager.LoadScene(34);
    }
}
