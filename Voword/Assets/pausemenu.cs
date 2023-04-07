using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] GameObject pausemenu;
    // Start is called before the first frame update
    public void Pause()
    {
        pausemenu.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Resume()
    {
        pausemenu.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Home(int sceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
    }
}
