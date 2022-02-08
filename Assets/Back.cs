using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour
{
    public void BackButton()
    {
        FindObjectOfType<AudioManager>().Play("click");
        SceneManager.LoadScene(0);
    }
}
