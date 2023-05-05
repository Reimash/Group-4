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
<<<<<<< Updated upstream:Voword/Assets/Scripts/MenutoLevel.cs
        SceneManager.LoadScene(3);
    }

    public void LoadLevelThree()
    {
        SceneManager.LoadScene(4);
=======
        SceneManager.LoadScene(16);
    }

    public void LoadLevelTwoFreeRoam()
    {
        SceneManager.LoadScene(19);
    }

    public void LoadLevelThreeFreeRoam()
    {
        SceneManager.LoadScene(34);
>>>>>>> Stashed changes:Voword/Assets/Scripts/Scene Management/MenutoLevel.cs
    }
}
