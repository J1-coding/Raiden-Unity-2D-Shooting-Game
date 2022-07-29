using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    public AudioSource audiosource;

    // Start is called before the first frame update
    public void OnGameStartBtnClick()
    {
        SceneManager.LoadScene(1);
    }

    public void OnGameLoadBtnClick()
    {
        SceneManager.LoadScene(1);
    }

    public void OnGameSettingsBtnClick()
    {
        SceneManager.LoadScene(1);
    }

    public void OnGameTryAgainBtnClick()
    {
        SceneManager.LoadScene(0);
    }

    public void playThisSound()
    {
        audiosource.Play();
    }

}
