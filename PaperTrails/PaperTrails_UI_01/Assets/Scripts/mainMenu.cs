using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public AudioSource mainMenuAudio;

    public void Awake()
    {
        AudioSource[] allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
        foreach (AudioSource audioS in allAudioSources)
        {
            audioS.Stop();
        }
        mainMenuAudio.Play();
    }

    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Level_01");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
