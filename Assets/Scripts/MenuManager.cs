using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject menuGameObject;
    public bool isMenuOpen;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            /*
             if (isMenuOpen = true)
             {
                isMenuOpen = false
             }
             else
            {
                isMenuOpen = True
            } 
            */
            
            OpenCloseMenu();
        }
    }

    public void OpenCloseMenu()
    {
        isMenuOpen = !isMenuOpen;

        menuGameObject.SetActive(isMenuOpen);
        
        if (isMenuOpen == true)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
        
    }

    public void ReloadScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        Time.timeScale = 1;
        SceneManager.LoadScene(scene.name);
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    
    

}
