using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField]
    GameObject menu;

    [SerializeField]
    Button btn;

    bool isPaused = false;

    private void Start()
    {
        btn.onClick.AddListener(OnPause);
    }

    private void Update()
    {
        //isDed = death.isDed;
    }

    void OnPause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            menu.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            menu.SetActive(false);
            Time.timeScale = 1f;
        }
    }
    
    public void Unpause()
    {
        Debug.Log("Unpause");
    }

    public void Shop()
    {
        SceneManager.LoadScene(2);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    
}
