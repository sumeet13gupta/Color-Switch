using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        FindObjectOfType<AudioManager>().Play("click");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        FindObjectOfType<AudioManager>().Play("click");
        Application.Quit();
    }
    public void click()
    {
        FindObjectOfType<AudioManager>().Play("click");
    }
    public void About()
    {
        FindObjectOfType<AudioManager>().Play("click");
        SceneManager.LoadScene(5);

    }
}
