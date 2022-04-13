using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{

    [SerializeField] private GameObject pauseMenuUI;
    [SerializeField] private bool isPaused = false;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }

        if (isPaused)
        {
            ActivateMenu();
        }
        else
        {
            DeactivateMenu();
        }

    }

    void ActivateMenu()
    {
        Time.timeScale = 0; //Spiel während des Pausemenüs pausieren
        AudioListener.pause = true;
        pauseMenuUI.SetActive(true);
    }

   public void DeactivateMenu()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
        pauseMenuUI.SetActive(false);
        isPaused = false;
    }

    public void GeheInsHauptmenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LevelNeustarten()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        DeactivateMenu();
    }
}
