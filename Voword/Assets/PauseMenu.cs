using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pausemenu;
     public void Pause()
    {
        pausemenu.SetActive(true);
        Time.timeScale = 0f;
    }
    public void resume()
    {
        pausemenu.SetActive(false);
        Time.timeScale = 1f;
    }
    public void home(int sceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
    }

}
